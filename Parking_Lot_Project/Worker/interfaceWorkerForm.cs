using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using Word = Microsoft.Office.Interop.Word;

namespace Parking_Lot_Project
{
    public partial class interfaceWorkerForm : Form
    {
        #region Data
        Admin ad = new Admin();
        Worker worker = new Worker();
        private Form currentForm;
        public delegate void sendData(string id);
        public sendData sendToData;
        #endregion

        #region Camera
        FilterInfoCollection cameras;
        VideoCaptureDevice cam;
        #endregion
        private void openForm(Form childForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            tabPage_manageWorker.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        public interfaceWorkerForm()
        {
            InitializeComponent();
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo camera in cameras)
            {
                comboBox_cameras.Items.Add(camera.Name);
                comboBox_tabPageManage_listCam.Items.Add(camera.Name);
            }
            comboBox_cameras.SelectedIndex = 0;
            comboBox_tabPageManage_listCam.SelectedIndex = 0;
        }

        private void interfaceWorkerForm_Load(object sender, EventArgs e)
        {
            label_dark.Visible = false;
            textBox_tabPageManage_id.ReadOnly = true;
            
            outputComboBox();
            fillChart();
        }

        private void outputComboBox() 
        {
            try
            {
                DataTable table = worker.getListWork();
                DataRow row = table.NewRow();
                row[0] = "0";
                row[1] = "All";
                table.Rows.InsertAt(row, 0);
                metroComboBox_chooseEmp.DataSource = table;
                metroComboBox_chooseEmp.ValueMember = "ID";
                metroComboBox_chooseEmp.DisplayMember = "NAME_WORK";

                metroComboBox_chooseEmp.SelectedIndex = 0;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }          
        }

        #region Process Camera in tabpage addWorker
        public void openCam ()
        {
            if (cam != null && cam.IsRunning)
                cam.Stop();
            else
            {
                cam = new VideoCaptureDevice(cameras[comboBox_cameras.SelectedIndex].MonikerString);
                cam.NewFrame += Cam_NewFrame;
                cam.Start();
            }
        }

        public void closeCam ()
        {
            if (cam != null && cam.IsRunning)
                cam.Stop();
            pictureBox_image.Image = null;
        }
        private void button_openCam_Click(object sender, EventArgs e)
        {
            openCam();
        }
        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            pictureBox_image.Image = bmp;
        }
        private void button_stopCam_Click(object sender, EventArgs e)
        {
            closeCam();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (cam != null && cam.IsRunning)
                cam.Stop();
        }
        private void button_takePhoto_Click(object sender, EventArgs e)
        {
            cam.Stop();
            //MemoryStream pic = new MemoryStream();
            //pictureBox_image.Image.Save(pic, pictureBox_image.Image.RawFormat);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = textBox_Lname.Text + " Image";
            sfd.DefaultExt = ".jpg";
            sfd.Filter = "Image (.jpg)|*.jpg";
            sfd.InitialDirectory = @"D:\Đồ Án Winform\Parking_Lot_Project\Parking_Lot_Project\Resources\Admin_Image";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
               pictureBox_image.Image.Save(sfd.FileName);
            }

            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_image.Image = Image.FromFile((opf.FileName));
            }

        }
        #endregion
        #region Format
        public void format_dataGridView()
        {
            
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView_listWorker.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView_listWorker.Columns[0].HeaderCell.Value = "Mã Nhân Viên";
            dataGridView_listWorker.Columns[1].HeaderCell.Value = "Họ";
            dataGridView_listWorker.Columns[2].HeaderCell.Value = "Tên";
            dataGridView_listWorker.Columns[3].HeaderCell.Value = "CMND";
            dataGridView_listWorker.Columns[4].HeaderCell.Value = "Ngày Sinh";
            dataGridView_listWorker.Columns[5].HeaderCell.Value = "Số Điện Thoại";
            dataGridView_listWorker.Columns[6].HeaderCell.Value = "Địa chỉ";
            dataGridView_listWorker.Columns[7].HeaderCell.Value = "Giới tính";
            dataGridView_listWorker.Columns[8].HeaderCell.Value = "Hình ảnh";

            dataGridView_listWorker.Columns[0].Width = 80;
            dataGridView_listWorker.Columns[1].Width = 100;
            dataGridView_listWorker.Columns[2].Width = 100;
            dataGridView_listWorker.Columns[3].Width = 150;
            dataGridView_listWorker.Columns[4].Width = 150;
            dataGridView_listWorker.Columns[6].Width = 150;
            dataGridView_listWorker.Columns[7].Width = 100;
            dataGridView_listWorker.Columns[5].Width = 130;
            //dataGridView_listWorker.Columns[8].Width = 130;
            

            foreach (DataGridViewRow row in dataGridView_listWorker.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
            dataGridView_listWorker.RowTemplate.Height = 50;
            picCol = (DataGridViewImageColumn)dataGridView_listWorker.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            

            dataGridView_listWorker.AllowUserToAddRows = false;
        }
        
        #endregion
        private void loadDataEmp()
        {
            //worker.getAllEmp(dataGridView_listWorker, "");
            dataGridView_listWorker.DataSource = Worker.Instance.getAllEmp();
            format_dataGridView();
        }
        public void downPic ()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = textBox_fName.Text + " Image";
            sfd.DefaultExt = ".jpg";
            sfd.Filter = "Image (.jpg)|*.jpg";
            sfd.InitialDirectory = @"\Image_Worker\";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_image.Image.Save(sfd.FileName);
            }

            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_image.Image = Image.FromFile((opf.FileName));
            }
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            string fname = textBox_fName.Text;
            string lname = textBox_Lname.Text;
            string cmnd = textBox_CMND.Text;
            string bdate = dateTimePicker_Bdate.Value.ToString();
            string phone = textBox_phone.Text;
            string gender = "Male";
            string addr = richTextBox_addr.Text;
            if (radioButton_female.Checked)
                gender = "Female";

            MemoryStream pic = new MemoryStream();
            pictureBox_image.Image.Save(pic, pictureBox_image.Image.RawFormat);
            string id = worker.makeID();
            if (worker.insert_worker(id, fname, lname, cmnd, bdate,phone, addr, gender, pic))
            {
                MessageBox.Show("Thêm thợ thành công\n Mã thợ là: " + id, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //if (ad.insertAdmin(fname + " " + lname, id, "1", work, pic) == false)
                //{
                //    MessageBox.Show("Có lỗi khi tạo tài khoản");
                //}
                tabControl_interfaceWorker.SelectedTab = tabPage_listWorker;
                textBox_fName.Text = "";
                textBox_tabPageManage_bdate.Text = "";
                textBox_CMND.Text = "";
                richTextBox_addr.Text = "";
                textBox_phone.Text = "";
                textBox_Lname.Text = "";
                if (radioButton_male.Checked)
                    radioButton_male.Checked = false;
                else
                    radioButton_female.Checked = false;
                pictureBox_image.Image = null;
                loadDataEmp();
                tabControl_interfaceWorker.SelectedTab = tabPage_listWorker;
                //fillChart();
            }
            else
            {
                MessageBox.Show("Thêm thợ thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_downImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_image.Image = Image.FromFile((opf.FileName));
            }
        }
        private void button_manageWorker_add_Click(object sender, EventArgs e)
        {
            string fName = "";
            string lName = "";
            string fullName = textBox_tabPageManage_fullName.Text;
            int count = fullName.Length - 1;

            while (count >= 0)
            {
                if (fullName[count] == ' ')
                    break;
                --count;
            }

            for (int i = 0; i < count; ++i)
                fName += fullName[i];

            for (int i = count + 1; i < fullName.Length; ++i)
                lName += fullName[i];
            string id = textBox_tabPageManage_id.Text;
            string cmnd = textBox_tabPageManage_cmnd.Text;
            string bdate = textBox_tabPageManage_bdate.Text;
            string addr = richTextBox_tabPageManage_addr.Text;
            string gender = "Female";
            string phone = textBox_showPhone.Text;
            if (radioButton_tabpageManage_male.Checked)
                gender = "Male";
            MemoryStream pic = new MemoryStream();
            pictureBox__tabPageManage_image.Image.Save(pic, pictureBox__tabPageManage_image.Image.RawFormat);
            if (worker.insert_worker(id, fName, lName, cmnd, bdate, addr,phone, gender, pic))
            {
                MessageBox.Show("Thêm thợ thành công");
                loadDataEmp();
                textBox_tabPageManage_bdate.Text = "";
                textBox_tabPageManage_cmnd.Text = "";
                textBox_tabPageManage_fullName.Text = "";
                textBox_tabPageManage_id.Text = "";
                pictureBox__tabPageManage_image.Image = null;
                richTextBox_tabPageManage_addr.Text = "";
                if (radioButton_tabpageManage_female.Checked)
                    radioButton_tabpageManage_female.Checked = false;
                else
                    radioButton_tabpageManage_male.Checked = false;
                tabControl_interfaceWorker.SelectedTab = tabPage_listWorker;
                //if (ad.insertAdmin(fullName, id, "1", work, pic) == false)
                //{
                //    MessageBox.Show("Có lỗi khi tạo tài khoản");
                //}
            }
            else
            {
                MessageBox.Show("Thêm thợ thất bại");
            }
        }

        private void buttonmanageWorker_edit_Click(object sender, EventArgs e)
        {
            string fName = "";
            string lName = "";
            string fullName = textBox_tabPageManage_fullName.Text;
            int count = fullName.Length -1;

            while (count >=0)
            {
                if (fullName[count] == ' ')
                    break;
                --count;
            }

            for (int i = 0; i < count; ++i)
                fName += fullName[i];

            for (int i = count + 1; i < fullName.Length; ++i)
                lName += fullName[i];
            string id = textBox_tabPageManage_id.Text;
            string cmnd = textBox_tabPageManage_cmnd.Text;
            string bdate = textBox_tabPageManage_bdate.Text;
            string addr = richTextBox_tabPageManage_addr.Text;
            string gender = "Female";
            if (radioButton_tabpageManage_male.Checked)
                gender = "Male";
            MemoryStream pic = new MemoryStream();
            pictureBox__tabPageManage_image.Image.Save(pic, pictureBox__tabPageManage_image.Image.RawFormat);
            if (worker.editWorker(id,fName,lName,cmnd,bdate,addr,gender, pic))
            {
                MessageBox.Show("Sửa thông tin thành công");
                loadDataEmp();
                textBox_tabPageManage_bdate.Text = "";
                textBox_tabPageManage_cmnd.Text = "";
                textBox_tabPageManage_fullName.Text = "";
                textBox_tabPageManage_id.Text = "";
                pictureBox__tabPageManage_image.Image = null;
                richTextBox_tabPageManage_addr.Text = "";
                if (radioButton_tabpageManage_female.Checked)
                    radioButton_tabpageManage_female.Checked = false;
                else
                    radioButton_tabpageManage_male.Checked = false;
                tabControl_interfaceWorker.SelectedTab = tabPage_listWorker;
                
            }
            else
            {
                MessageBox.Show("Chỉnh sửa thất bại");
            }
        }

        //tagpage manage worker
        private void dataGridView_listWorker_DoubleClick(object sender, EventArgs e)
        {
            if (label_dark.Text == "l")
            {
                if (sendToData != null)
                    sendToData(dataGridView_listWorker.CurrentRow.Cells[0].Value.ToString());
                this.Close();
                return;
            }
            if (label_dark.Text == "s")
            {
                if (sendToData != null)
                    sendToData(dataGridView_listWorker.CurrentRow.Cells[0].Value.ToString());
                this.Close();
                return;
            }
            textBox_tabPageManage_id.Text = dataGridView_listWorker.CurrentRow.Cells[0].Value.ToString();
            textBox_tabPageManage_fullName.Text = dataGridView_listWorker.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView_listWorker.CurrentRow.Cells[2].Value.ToString();
            textBox_tabPageManage_cmnd.Text = dataGridView_listWorker.CurrentRow.Cells[3].Value.ToString();
            string bDate = dataGridView_listWorker.CurrentRow.Cells[4].Value.ToString();
            string dateNonTime = "";
            for (int i = 0; ; ++i)
            {
                if (bDate[i] == ' ')
                    break;
                dateNonTime += bDate[i];
            }
            textBox_showPhone.Text = dataGridView_listWorker.CurrentRow.Cells[5].Value.ToString();
            textBox_tabPageManage_bdate.Text = dateNonTime;
            richTextBox_tabPageManage_addr.Text = dataGridView_listWorker.CurrentRow.Cells[6].Value.ToString();
            if (dataGridView_listWorker.CurrentRow.Cells[7].Value.ToString() == "Nam")
                radioButton_tabpageManage_male.Checked = true;
            else
                radioButton_tabpageManage_female.Checked = true;
            byte[] pic = (byte[])dataGridView_listWorker.CurrentRow.Cells[8].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBox__tabPageManage_image.Image = Image.FromStream(picture);
            tabControl_interfaceWorker.SelectedTab = tabPage_manageWorker;
            //informationForm frm = new informationForm();
            //frm.textBox_ID.Text = dataGridView_listWorker.CurrentRow.Cells[0].Value.ToString();
            //openForm(frm);

        }

        //take photo in tabpage manage Worker
        private void button_manageWorker_delete_Click(object sender, EventArgs e)
        {
            string id = textBox_tabPageManage_id.Text;
            if (worker.deleteWorker(id))
            {
                MessageBox.Show("Xóa nhân viên thành công");
                textBox_tabPageManage_id.Text = "";
                textBox_tabPageManage_bdate.Text = "";
                textBox_tabPageManage_cmnd.Text = "";
                textBox_tabPageManage_fullName.Text = "";
                richTextBox_tabPageManage_addr.Text = "";
                pictureBox__tabPageManage_image.Image = null;
                if (radioButton_tabpageManage_male.Checked == true)
                    radioButton_tabpageManage_male.Checked = false;
                else
                    radioButton_tabpageManage_female.Checked = false;
                loadDataEmp();
                if (ad.deleteAdmin(id) == false)
                {
                    MessageBox.Show("Có lỗi khi xóa nhân viên, thử lại");
                }
                tabControl_interfaceWorker.SelectedTab = tabPage_listWorker;
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại");
            }
            
        }
        #region Process Camera in tabpage manageWorker
        private void button_tabPageManage_openCam_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
                cam.Stop();
            else
            {
                cam = new VideoCaptureDevice(cameras[comboBox_tabPageManage_listCam.SelectedIndex].MonikerString);
                cam.NewFrame += Cam_NewFrame_manageWoker; ;
                cam.Start();
            }
        }

        private void Cam_NewFrame_manageWoker(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            pictureBox__tabPageManage_image.Image = bmp;
        }

        private void button_tabPageManage_takePhoto_Click(object sender, EventArgs e)
        {
            cam.Stop();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = textBox_fName.Text + " Image";
            sfd.DefaultExt = ".jpg";
            sfd.Filter = "Image (.jpg)|*.jpg";
            sfd.InitialDirectory = @"\Worker_Image\";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox__tabPageManage_image.Image.Save(sfd.FileName);
            }

            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox__tabPageManage_image.Image = Image.FromFile((opf.FileName));
            }
        }

        private void button_tabPageManage_stopCam_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
                cam.Stop();
            pictureBox__tabPageManage_image.Image = null;
        }
        #endregion

        private void comboBox_tabPageManage_Work_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id;
            ////string work;
            //if (comboBox_tabPageManage_Work.SelectedIndex == 0)
            //    work = "Fixer";
            //else if (comboBox_tabPageManage_Work.SelectedIndex == 1)
            //    work = "Washer";
            //else
            //    work = "Sercurity";

            id = worker.makeID();

            textBox_tabPageManage_id.Text = id;
           
        }

        private void button_tabpageUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox__tabPageManage_image.Image = Image.FromFile((opf.FileName));
            }
        }

        private void metroComboBox_chooseEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox_chooseEmp.SelectedIndex == 0)
            {
                dataGridView_listWorker.DataSource = Worker.Instance.getAllEmp();
            }
                
            else
            {
                dataGridView_listWorker.DataSource = Worker.Instance.getAllEmpWork(metroComboBox_chooseEmp.SelectedValue.ToString());
            }
            format_dataGridView();
        }

        private void fillChart ()
        {
            double security = Worker.Instance.getAllEmpWork("1").Rows.Count;
            double fixer = Worker.Instance.getAllEmpWork("2").Rows.Count;
            double washer = Worker.Instance.getAllEmpWork("3").Rows.Count;
            double all = Worker.Instance.getAllEmp().Rows.Count;
            double free = all - security - fixer - washer;
            double percentSe = security * 100 / all;
            double percentFix = fixer * 100 / all;
            double percentWa = washer * 100 / all;
            double percentFree = free * 100 / all;

            if (percentSe != 0)
                chart_emp.Series["EMP"].Points.AddXY("Bảo Vệ\n" + percentSe.ToString("0.00") + "%", security / all);
            if (percentFix != 0)
                chart_emp.Series["EMP"].Points.AddXY("Thợ Sửa Xe\n" + percentFix.ToString("0.00") + "%", fixer / all);
            if (percentWa != 0)
                chart_emp.Series["EMP"].Points.AddXY("Thợ Rửa Xe\n" + percentWa.ToString("0.00") + "%", washer / all);
            if (percentFree != 0)
                chart_emp.Series["EMP"].Points.AddXY("Ban Quản Lý\n" + percentFree.ToString("0.00") + "%", free / all);
        }

        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {



            if (DGV.Rows.Count != 0)
            {

                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];



                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop




                //page orintation
                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;

                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; ++r)
                {
                    for (int c = 0; c <= ColumnCount - 1; ++c)
                    {
                        if (c == 4)
                        {
                            string Bdate = DataArray[r, c].ToString();
                            string dateNonTime = "";
                            for (int i = 0; ; ++i)
                            {
                                if (Bdate[i] == ' ')
                                    break;
                                dateNonTime += Bdate[i];
                            }
                            oTemp += dateNonTime + "\t";
                        }
                        else
                            oTemp = oTemp + DataArray[r, c] + "\t";
                    }

                }





                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "Danh Sách Nhân Viên";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //Write text


                for (r = 0; r < RowCount; ++r)
                {
                    byte[] imgbyte = (byte[])dataGridView_listWorker.Rows[r].Cells[8].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(System.Drawing.Image.FromStream(ms), new Size(70, 70)));
                    Clipboard.SetDataObject(finalPic);
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 9).Range.Paste();
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 9).Range.InsertParagraph();
                }



                //save the file
                oDoc.SaveAs2(filename);
            }
        }

        private void button_printListWorker_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (.docx)|.docx";

            sfd.FileName = "export.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_Word(dataGridView_listWorker, sfd.FileName);
            }
        }
    }
}
