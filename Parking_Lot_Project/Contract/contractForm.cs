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
    public partial class contractForm : Form
    {
        private int price;
        private DateTime rental;
        public contractForm()
        {
            InitializeComponent();
        }
        private void OpenFormPanel(Form childForm, Panel page)
        {
            //if (curentEmpForm != null)
            //{
            //    curentEmpForm.Close();
            //}
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            page.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        private void textBox_idCus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_idCus.Text != "")
                {
                    
                    DataTable table = Customer.Instance.getCusByID(textBox_idCus.Text);
                    inforCustomerForm frm = new inforCustomerForm();
                    frm.textBox_id.Text = table.Rows[0][0].ToString();
                    frm.textBox_fname.Text = table.Rows[0][1].ToString();
                    frm.textBox_lname.Text = table.Rows[0][2].ToString();
                    frm.dateTimePicker_bdate.Value = (DateTime)table.Rows[0][3];
                    frm.textBox_phone.Text = table.Rows[0][4].ToString();
                    frm.Male.Checked = true;
                    if (table.Rows[0][5].ToString() == "Female")
                        frm.Female.Checked = true;
                    frm.textBox_country.Text = table.Rows[0][6].ToString();
                    frm.textBox_addr.Text = table.Rows[0][7].ToString();
                    frm.textBox_mail.Text = table.Rows[0][8].ToString();
                    byte[] data = (byte[])table.Rows[0][9];
                    MemoryStream stream = new MemoryStream(data);
                    frm.pictureBox_img.Image = Image.FromStream(stream);
                    OpenFormPanel(frm, panel_Customer);
                }
            }
        }



        private void loadData(string id)
        {
            textBox_idCus.Text = "";
            textBox_idCus.Text = id;
        }

        private void button_listCus_Click(object sender, EventArgs e)
        {
            customerListForm frm = new customerListForm();
            frm.label_dark.Text = "d";
            frm.sendTheData = new customerListForm.sendData(loadData);
            frm.ShowDialog();
        }
        private void loadDataTrans(string id)
        {
            textBox_trans.Text = "";
            textBox_trans.Text = id;
        }

        private void button_trans_Click(object sender, EventArgs e)
        {
            if (comboBox_trans.SelectedIndex == 0)
            {
                bikeListForm frm = new bikeListForm();
                frm.label_dark.Text = "d";
                frm.sendTheData = new bikeListForm.sendData(loadDataTrans);
                frm.ShowDialog();
            }
            else if (comboBox_trans.SelectedIndex == 1)
            {
                motorListForm frm = new motorListForm();
                frm.label_dark.Text = "d";
                frm.sendTheData = new motorListForm.sendData(loadDataTrans);
                frm.ShowDialog();
            }
            else
            {
                carListForm frm = new carListForm();
                frm.label_dark.Text = "d";
                frm.sendTheData = new carListForm.sendData(loadDataTrans);
                frm.ShowDialog();
            }
        }

        private void convertImg(DataTable table, int column, PictureBox pic)
        {
            byte[] data = (byte[])table.Rows[0][column];
            MemoryStream stream = new MemoryStream(data);
            pic.Image = Image.FromStream(stream);
        }

        private void textBox_trans_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox_trans.Text != "")
            {
                //string search;
                //if (textBox_idCus.Text[0] >= '0' && textBox_idCus.Text[0] <= '9')
                //    search = "Customer" + textBox_idCus.Text[0];
                //else
                //search = textBox_idCus.Text;
                DataTable table = Transport.Instancet.getTrans(textBox_trans.Text, comboBox_trans.Text);
                
                if (comboBox_trans.SelectedIndex == 0)
                {
                    inforBikeForm frm = new inforBikeForm();
                    frm.label_status.Text = "Tình trạng: Xe đã ra bãi";
                    frm.textBox_id.Text = table.Rows[0][0].ToString();
                    convertImg(table, 1, frm.pictureBox_user);
                    convertImg(table, 2, frm.pictureBox_bike);
                    frm.comboBox_typeCustomer.Text = table.Rows[0][3].ToString();
                    frm.dateTimePicker_timeStart.Value = (DateTime)table.Rows[0][4];
                    frm.dateTimePicker_rental.Value = (DateTime)table.Rows[0][5];
                    if (table.Rows[0][6].ToString() != "")
                    {
                        frm.dateTimePicker_timeEnd.Value = (DateTime)table.Rows[0][6];

                    }
                    else
                        frm.dateTimePicker_timeEnd.Visible = false;
                    frm.textBox_price.Text = table.Rows[0][7].ToString();
                    if (frm.textBox_price.Text == "0")
                        frm.label_status.Text = "Tình trạng: Xe đang gửi";
                    OpenFormPanel(frm, panel_trans);

                }
                else if (comboBox_trans.SelectedIndex == 1)
                {
                    inforMotorForm frm = new inforMotorForm();
                    frm.label_status.Text = "Tình trạng: Xe đã ra bãi";
                    frm.textBox_id.Text = table.Rows[0][0].ToString();
                    convertImg(table, 1, frm.pictureBox_user);
                    convertImg(table, 2, frm.pictureBox_motor);
                    frm.textBox_plate.Text = table.Rows[0][3].ToString();
                    frm.comboBox_typeCustomer.Text = table.Rows[0][4].ToString();
                    frm.dateTimePicker_timeStart.Value = (DateTime)table.Rows[0][5];
                    frm.dateTimePicker_rental.Value = (DateTime)table.Rows[0][6];
                    if (table.Rows[0][7].ToString() != "")
                    {
                        frm.dateTimePicker_timeEnd.Value = (DateTime)table.Rows[0][7];

                    }
                    else
                        frm.dateTimePicker_timeEnd.Visible = false;
                    frm.textBox_price.Text = table.Rows[0][8].ToString();
                    if (frm.textBox_price.Text == "0")
                        frm.label_status.Text = "Tình trạng: Xe đang gửi";
                    OpenFormPanel(frm, panel_trans);
                }
                else
                {
                    inforCarForm frm = new inforCarForm();
                    frm.label_status.Text = "Tình trạng: Xe đã ra bãi";
                    frm.textBox_id.Text = table.Rows[0][0].ToString();
                    convertImg(table, 1, frm.pictureBox_user) ;
                    convertImg(table, 2, frm.pictureBox_motor);
                    frm.textBox_plate.Text = table.Rows[0][3].ToString();
                    frm.comboBox_typeCustomer.Text = table.Rows[0][4].ToString();
                    frm.dateTimePicker_timeStart.Value = (DateTime)table.Rows[0][5];
                    frm.dateTimePicker_rental.Value = (DateTime)table.Rows[0][6];
                    if (table.Rows[0][7].ToString() != "")
                    {
                        frm.dateTimePicker_timeEnd.Value = (DateTime)table.Rows[0][7];

                    }
                    else
                        frm.dateTimePicker_timeEnd.Visible = false;
                    frm.textBox_price.Text = table.Rows[0][8].ToString();
                    if (frm.textBox_price.Text == "0")
                        frm.label_status.Text = "Tình trạng: Xe đang gửi";
                    OpenFormPanel(frm, panel_trans);
                }
                
            }
        }
        private void formatRental ()
        {
            foreach (DataGridViewRow row in dataGridView_rentalList.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
            dataGridView_rentalList.RowTemplate.Height = 80;
            dataGridView_rentalList.Columns[0].HeaderCell.Value = "ID";
            dataGridView_rentalList.Columns[1].HeaderCell.Value = "Mã Khách Hàng";
            dataGridView_rentalList.Columns[2].HeaderCell.Value = "Mã Xe";
            dataGridView_rentalList.Columns[3].HeaderCell.Value = "Khách Hàng";
            dataGridView_rentalList.Columns[4].HeaderCell.Value = "Thời Gian Thuê";
            dataGridView_rentalList.Columns[5].HeaderCell.Value = "Ngày Hết Hạn";
            dataGridView_rentalList.Columns[6].HeaderCell.Value = "Thời Gian Trả Xe";
            dataGridView_rentalList.Columns[7].HeaderCell.Value = "Trị Giá Hợp Đồng";
            dataGridView_rentalList.Columns[8].HeaderCell.Value = "Đã Trả";
            dataGridView_rentalList.Columns[9].HeaderCell.Value = "Số Dư";

            dataGridView_rentalList.Columns[0].Width = 120;
            dataGridView_rentalList.Columns[1].Width = 120;
            dataGridView_rentalList.Columns[4].Width = 120;
            dataGridView_rentalList.Columns[5].Width = 120;
            dataGridView_rentalList.AllowUserToAddRows = false;
        }
        private void calPrice(DateTime time)
        {
            //if (comboBox_trans.SelectedIndex == 0)
        }

        
        private void materialButton_add_Click(object sender, EventArgs e)
        {
            string id = Contract.Instance.makeID();
            string cus = textBox_idCus.Text;
            string trans = textBox_trans.Text;
            string type = "car consignment";
            DateTime start = DateTime.Now;
            
            if (Contract.Instance.insertContract(id, cus, trans, type, start, rental, price) == true )
            {
                MessageBox.Show("Thêm hợp đồng thành công");
            }

            
        }

        private void button_up_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_trans.Image = Image.FromFile((opf.FileName));
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string id = Contract.Instance.makeIdRent();
            MemoryStream stream = new MemoryStream();
            pictureBox_trans.Image.Save(stream, pictureBox_trans.Image.RawFormat);

            if (Contract.Instance.insertRent(id,stream)== true)
            {
                MessageBox.Show("Thêm Xe Thành Công");
                pictureBox_trans.Image = null;
                dataGridView_rent.DataSource = Contract.Instance.getAllRent();
            }
        }
        private void formatImage(DataGridView dgv, int numberColumn)
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dgv.Columns[numberColumn];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
        private void format()
        {
            foreach (DataGridViewRow row in dataGridView_rent.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
            dataGridView_rent.RowTemplate.Height = 80;
            dataGridView_rent.Columns[0].HeaderCell.Value = "ID";
            dataGridView_rent.Columns[1].HeaderCell.Value = "Hình Xe";
            formatImage(dataGridView_rent, 1);
            dataGridView_rent.AllowUserToAddRows = false;
        }

        private void contractForm_Load(object sender, EventArgs e)
        {
            dataGridView_rentalList.DataSource = Contract.Instance.getAllContract();
            formatRental();
            panel_rent.Visible = false;
            dataGridView_rent.DataSource = Contract.Instance.getAllRent();
            format();
            comboBox_trans.SelectedIndex = 2;
        }

        private void dataGridView_rent_DoubleClick(object sender, EventArgs e)
        {
            panel_rent.Visible = true;
            textBox_rent.Text = dataGridView_rent.CurrentRow.Cells[0].Value.ToString();
            byte[] data = (byte[])dataGridView_rent.CurrentRow.Cells[1].Value;
            MemoryStream stream = new MemoryStream(data);
            pictureBox_rent.Image = Image.FromStream(stream);
        }
        private void loadIDCustomer(string id)
        {
            textBox_customer.Text = "";
            textBox_customer.Text = id;
        }
        private void button_Customer_Click(object sender, EventArgs e)
        {
            customerListForm frm = new customerListForm();
            frm.label_dark.Text = "d";
            frm.sendTheData = new customerListForm.sendData(loadIDCustomer);
            frm.ShowDialog();
        }

        private void textBox_customer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_customer.Text != "")
                {
                    
                    DataTable table = Customer.Instance.getCusByID(textBox_customer.Text);
                    inforCustomerForm frm = new inforCustomerForm();
                    frm.textBox_id.Text = table.Rows[0][0].ToString();
                    frm.textBox_fname.Text = table.Rows[0][1].ToString();
                    frm.textBox_lname.Text = table.Rows[0][2].ToString();
                    frm.dateTimePicker_bdate.Value = (DateTime)table.Rows[0][3];
                    frm.textBox_phone.Text = table.Rows[0][4].ToString();
                    frm.Male.Checked = true;
                    if (table.Rows[0][5].ToString() == "Female")
                        frm.Female.Checked = true;
                    frm.textBox_country.Text = table.Rows[0][6].ToString();
                    frm.textBox_addr.Text = table.Rows[0][7].ToString();
                    frm.textBox_mail.Text = table.Rows[0][8].ToString();
                    byte[] data = (byte[])table.Rows[0][9];
                    MemoryStream stream = new MemoryStream(data);
                    frm.pictureBox_img.Image = Image.FromStream(stream);
                    OpenFormPanel(frm, panel_inforCustomer);
                }
            }
        }

        private void getPrice (ComboBox cbx, NumericUpDown nu,  Label lb)
        {
            DateTime start = DateTime.Now;
            //DateTime rental;
            if (cbx.SelectedIndex == 0)
            {
                rental = start.AddDays((int)nu.Value);
                TimeSpan time = rental - start;
                price = Calculate.Instance.priceCar(time.Days, 0, 2);
                lb.Text = "Giá: " + price.ToString();
            }
            if (cbx.SelectedIndex == 1)
            {
                rental = start.AddMonths((int)nu.Value);
                
                price = Calculate.Instance.priceCar(rental.Month - start.Month, 0, 3);
                lb.Text = "Giá: " + price.ToString();
            }
            if (cbx.SelectedIndex == 2)
            {
                rental = start.AddYears((int)nu.Value);
                price = Calculate.Instance.priceCar(rental.Year - start.Year, 0, 4);
                lb.Text = "Giá: " + price.ToString();
            }
        }

        private void comboBox_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            getPrice(comboBox_select, numericUpDown_get ,label_price);
        }

        private void materialButton_rent_Click(object sender, EventArgs e)
        {
            string id = Contract.Instance.makeID();
            string id_Cus = textBox_customer.Text;
            string id_trans = textBox_rent.Text;
            string type = "Thuê Xe";
            DateTime start = DateTime.Now;
            getPrice(comboBox_trans, numericUpDown_get, label_price);
            if (Contract.Instance.insertContract(id, id_Cus, id_trans, type, start, rental, price) == true)
            {
                MessageBox.Show("Thêm hợp đồng thành công");
            }
        }

        private void numericUpDown_get_ValueChanged(object sender, EventArgs e)
        {
            getPrice(comboBox_select, numericUpDown_get, label_price);
        }

        private void comboBox_typeCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            getPrice(comboBox_typeCustomer, numericUpDown_add, label_money);
        }

        private void numericUpDown_add_ValueChanged(object sender, EventArgs e)
        {
            getPrice(comboBox_typeCustomer, numericUpDown_add, label_money);
        }

        private void label_contract_Click(object sender, EventArgs e)
        {
            contractForm_Load(null, null);
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
                    headerRange.Text = "Danh Sách Hợp Đồng";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //Write text


                



                //save the file
                oDoc.SaveAs2(filename);
            }
        }

        private void materialButton_print_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (.docx)|.docx";

            sfd.FileName = "export.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_Word(dataGridView_rentalList, sfd.FileName);
            }
        }
    }
}
