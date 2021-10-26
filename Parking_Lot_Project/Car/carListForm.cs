using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Parking_Lot_Project
{
    public partial class carListForm : Form
    {
        public delegate void sendData(string id);
        public sendData sendTheData;
        public carListForm()
        {
            InitializeComponent();
        }
        private void formatParked()
        {
            dataGridView_parked.Columns[0].HeaderCell.Value = "Số Phiếu";
            dataGridView_parked.Columns[1].HeaderCell.Value = "Hình Trước Xe";
            dataGridView_parked.Columns[2].HeaderCell.Value = "Hình Sau Xe";
            dataGridView_parked.Columns[3].HeaderCell.Value = "Số Xe";
            dataGridView_parked.Columns[4].HeaderCell.Value = "Kiểu Khách";
            dataGridView_parked.Columns[5].HeaderCell.Value = "Thời Gian Gửi";
            dataGridView_parked.Columns[6].HeaderCell.Value = "Thời Hạn Gửi";
            dataGridView_parked.Columns[7].HeaderCell.Value = "Thời Gian Trả";
            dataGridView_parked.Columns[8].HeaderCell.Value = "Tiền Gửi Xe";
            ChangeImage.Instance.formatImage(dataGridView_parked, 1);
            ChangeImage.Instance.formatImage(dataGridView_parked, 2);
            dataGridView_parked.Columns[0].Width = 80;
            dataGridView_parked.Columns[1].Width = 150;
            dataGridView_parked.Columns[3].Width = 150;
            dataGridView_parked.Columns[4].Width = 250;
            dataGridView_parked.Columns[5].Width = 250;
            dataGridView_parked.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss";
            dataGridView_parked.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss";
            dataGridView_parked.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss";
            dataGridView_parked.RowTemplate.Height = 80;
            foreach (DataGridViewRow row in dataGridView_parked.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
            for (int i = 0; i < dataGridView_parked.Rows.Count; ++i)
            {
                if (i % 2 != 0)
                {
                    dataGridView_parked.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dataGridView_parked.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }
            dataGridView_parked.AllowUserToAddRows = false;
        }
        private void formatMotor()
        {
            

            dataGridView_car.Columns[0].HeaderCell.Value = "Số Phiếu";
            dataGridView_car.Columns[1].HeaderCell.Value = "Hình Trước Xe";
            dataGridView_car.Columns[2].HeaderCell.Value = "Hình Sau Xe";
            dataGridView_car.Columns[3].HeaderCell.Value = "Số Xe";
            dataGridView_car.Columns[4].HeaderCell.Value = "Kiểu Khách";
            dataGridView_car.Columns[5].HeaderCell.Value = "Thời Gian Gửi";
            ChangeImage.Instance.formatImage(dataGridView_car, 1);
            ChangeImage.Instance.formatImage(dataGridView_car, 2);
            dataGridView_car.Columns[0].Width = 80;
            dataGridView_car.Columns[1].Width = 150;
            dataGridView_car.Columns[3].Width = 150;
            dataGridView_car.Columns[4].Width = 250;
            dataGridView_car.Columns[5].Width = 250;
            dataGridView_car.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss";
            dataGridView_car.RowTemplate.Height = 80;
            foreach (DataGridViewRow row in dataGridView_car.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
            for (int i = 0; i < dataGridView_car.Rows.Count; ++i)
            {
                if (i % 2 != 0)
                {
                    dataGridView_car.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dataGridView_car.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }
            dataGridView_car.AllowUserToAddRows = false;
        }
        private void carListForm_Load(object sender, EventArgs e)
        {
            label_dark.Visible = false;
            dataGridView_car.DataSource = Car.Instance.getAllCar();
            formatMotor(); 
            dataGridView_parked.DataSource = Car.Instance.getAllParked();
            formatParked();
        }



        private void label_logo_Click(object sender, EventArgs e)
        {
            carListForm_Load(null, null);
        }

        private void label_listCar_Click(object sender, EventArgs e)
        {
            carListForm_Load(null, null);
        }
        private void convertImg(PictureBox pic, int column, DataGridView dgv)
        {
            byte[] data = (byte[])dgv.CurrentRow.Cells[column].Value;
            MemoryStream stream = new MemoryStream(data);
            pic.Image = Image.FromStream(stream);
        }
        private void dataGridView_car_DoubleClick(object sender, EventArgs e)
        {
            if (label_dark.Text == "d")
            {
                if (sendTheData != null)
                {
                    sendTheData(dataGridView_car.CurrentRow.Cells[0].Value.ToString());
                    this.Close();
                    return;
                }
            }
            textBox_id.Text = dataGridView_car.CurrentRow.Cells[0].Value.ToString();
            convertImg(pictureBox_front, 1, dataGridView_car);
            convertImg(pictureBox_back, 2, dataGridView_car);
            textBox_plate.Text = dataGridView_car.CurrentRow.Cells[3].Value.ToString();
            comboBox_typeCustomer.Text = dataGridView_car.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker_timeStart.Value = (DateTime)dataGridView_car.CurrentRow.Cells[5].Value;
        }

        private void dataGridView_parked_DoubleClick(object sender, EventArgs e)
        {
            
            inforCarForm frm = new inforCarForm();
            frm.label_status.Text = "Tình trạng: Xe đã ra bãi";
            frm.textBox_id.Text = dataGridView_parked.CurrentRow.Cells[0].Value.ToString();
            convertImg(frm.pictureBox_user, 1, dataGridView_parked);
            convertImg(frm.pictureBox_motor, 2, dataGridView_parked);
            frm.textBox_plate.Text = dataGridView_parked.CurrentRow.Cells[3].Value.ToString();
            frm.comboBox_typeCustomer.Text = dataGridView_parked.CurrentRow.Cells[4].Value.ToString();
            frm.dateTimePicker_timeStart.Value = (DateTime)dataGridView_parked.CurrentRow.Cells[5].Value;
            frm.dateTimePicker_rental.Value = (DateTime)dataGridView_parked.CurrentRow.Cells[6].Value;
            if (dataGridView_parked.CurrentRow.Cells[7].Value.ToString() != "")
            {
                frm.dateTimePicker_timeEnd.Value = (DateTime)dataGridView_parked.CurrentRow.Cells[7].Value;

            }
            else
                frm.dateTimePicker_timeEnd.Visible = false;
            frm.textBox_price.Text = dataGridView_parked.CurrentRow.Cells[8].Value.ToString();
            if (frm.textBox_price.Text == "0")
                frm.label_status.Text = "Tình trạng: Xe đang gửi";
            frm.Show();
        }

        private void dateTimePicker_searchParked_ValueChanged(object sender, EventArgs e)
        {
            if (radioButton_timeStart.Checked == true)
            {
                dataGridView_parked.DataSource = Bike.Instance.getParkedByDate(dateTimePicker_searchParked.Value);
            }
            else if (radioButton_rental.Checked == true)
            {
                dataGridView_parked.DataSource = Bike.Instance.getParkedByRental(dateTimePicker_searchParked.Value);
            }
            else
                dataGridView_parked.DataSource = Bike.Instance.getParkedByTimeEnd(dateTimePicker_searchParked.Value);
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
                        //if (c == 3)
                        //{
                        //    string Bdate = DataArray[r, c].ToString();
                        //    string dateNonTime = "";
                        //    for (int i = 0; ; ++i)
                        //    {
                        //        if (Bdate[i] == ' ')
                        //            break;
                        //        dateNonTime += Bdate[i];
                        //    }
                        //    oTemp += dateNonTime + "\t";
                        //}
                        //else
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
                    headerRange.Text = "Danh Sách Xe Hơi";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //Write text


                for (r = 0; r < RowCount; ++r)
                {
                    byte[] imgbyte = (byte[])dataGridView_parked.Rows[r].Cells[1].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(System.Drawing.Image.FromStream(ms), new Size(70, 70)));
                    Clipboard.SetDataObject(finalPic);
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 2).Range.Paste();
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 2).Range.InsertParagraph();
                }

                for (r = 0; r < RowCount; ++r)
                {
                    byte[] imgbyte = (byte[])dataGridView_parked.Rows[r].Cells[2].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(System.Drawing.Image.FromStream(ms), new Size(70, 70)));
                    Clipboard.SetDataObject(finalPic);
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 3).Range.Paste();
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 3).Range.InsertParagraph();
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

                Export_Data_To_Word(dataGridView_parked, sfd.FileName);
            }
        }
    }
}
