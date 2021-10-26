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
using Emgu.CV;
using Emgu.CV.Structure;

namespace Parking_Lot_Project
{
    public partial class entranceForm : Form
    {
        List<Image<Bgr, Byte>> PlateImagesList = new List<Image<Bgr, byte>>();
        List<string> PlateTextList = new List<string>();
        List<Rectangle> listRect = new List<Rectangle>();
        PictureBox[] box = new PictureBox[12];

        //public TesseractProcessor full_tesseract = null;
        //public TesseractProcessor ch_tesseract = null;
        //public TesseractProcessor num_tesseract = null;
        private string m_path = Application.StartupPath + @"\data\";
        private List<string> lstimages = new List<string>();
        private const string m_lang = "eng";
        public entranceForm()
        {
            InitializeComponent();
        }
        public static Dictionary<string, string> plate = new Dictionary<string, string>();




        private void button_getPic1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                if (label_darrk.Text != "NOT BIKE")
                {
                    detectPlate();
                }
                pictureBox_getPic1.Image = Image.FromFile((opf.FileName));
                if (button_addTransport.Text[8] != 'đ')
                {
                    #region detect
                    string rev = "";
                    string key = "";
                    string vir = "";
                    for (int i = opf.FileName.Length - 1; ; --i)
                    {
                        if (opf.FileName[i] == '\\')
                            break;
                        if (opf.FileName[i] == '.')
                            continue;
                        rev += opf.FileName[i];
                    }

                    for (int i = rev.Length - 1; i >= 0; --i)
                        vir += rev[i];
                    for (int i = 0; i < vir.Length; ++i)
                    {
                        if (vir[i] == 'j')
                            break;
                        key += vir[i];
                    }
                    #endregion

                    if (button_addTransport.Text[8] == 'm')
                    {
                        textBox_plateNumber.Text = Motor.Instance.getPlate(int.Parse(key));
                        
                    }   
                    if (button_addTransport.Text[8] == 'h')
                    {
                        try
                        {
                            textBox_plateNumber.Text = Car.Instance.detectCar(int.Parse(key));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                
                
            }
        }

        private void button_getPic2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                
                pictureBox_getPic2.Image = Image.FromFile((opf.FileName));
                
            }
        }

        private void entranceForm_Load(object sender, EventArgs e)
        {
            label_darrk.Visible = false;
            label_darrk.Text = "NOT BIKE";
            comboBox_typeCustomer.SelectedIndex = 0;
        }

        public void ProcessImage(string urlImage)
        {
            PlateImagesList.Clear();
            PlateTextList.Clear();
            Bitmap img = new Bitmap(urlImage);
        }
        private void detectPlate ()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image (*.bmp; *.jpg; *.jpeg; *.png) |*.bmp; *.jpg; *.jpeg; *.png|All files (*.*)|*.*||";
            dlg.InitialDirectory = Application.StartupPath + "\\ImageTest";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            string startupPath = dlg.FileName;

            ProcessImage(startupPath);
            if (PlateImagesList.Count != 0)
            {
                
                string zz = "";

                // lọc và sắp xếp số
                List<Bitmap> bmp = new List<Bitmap>();
                List<int> erode = new List<int>();
                List<Rectangle> up = new List<Rectangle>();
                List<Rectangle> dow = new List<Rectangle>();
                int up_y = 0, dow_y = 0;
                bool flag_up = false;

                int di = 0;

                if (listRect == null) return;

                for (int i = 0; i < listRect.Count; i++)
                {
                    int cou = 0;
                    
                    string temp = "";
                    while (temp.Length > 3)
                    {
                                       
                        cou++;
                        if (cou > 10)
                        {
                            listRect.RemoveAt(i);
                            i--;
                            di = 0;
                            break;
                        }
                        di = cou;
                    }
                }

                for (int i = 0; i < listRect.Count; i++)
                {
                    for (int j = i; j < listRect.Count; j++)
                    {
                        if (listRect[i].Y > listRect[j].Y + 100)
                        {
                            flag_up = true;
                            up_y = listRect[j].Y;
                            dow_y = listRect[i].Y;
                            break;
                        }
                        else if (listRect[j].Y > listRect[i].Y + 100)
                        {
                            flag_up = true;
                            up_y = listRect[i].Y;
                            dow_y = listRect[j].Y;
                            break;
                        }
                        if (flag_up == true) break;
                    }
                }

                for (int i = 0; i < listRect.Count; i++)
                {
                    if (listRect[i].Y < up_y + 50 && listRect[i].Y > up_y - 50)
                    {
                        up.Add(listRect[i]);
                    }
                    else if (listRect[i].Y < dow_y + 50 && listRect[i].Y > dow_y - 50)
                    {
                        dow.Add(listRect[i]);
                    }
                }

                if (flag_up == false) dow = listRect;

                for (int i = 0; i < up.Count; i++)
                {
                    for (int j = i; j < up.Count; j++)
                    {
                        if (up[i].X > up[j].X)
                        {
                            Rectangle w = up[i];
                            up[i] = up[j];
                            up[j] = w;
                        }
                    }
                }
                for (int i = 0; i < dow.Count; i++)
                {
                    for (int j = i; j < dow.Count; j++)
                    {
                        if (dow[i].X > dow[j].X)
                        {
                            Rectangle w = dow[i];
                            dow[i] = dow[j];
                            dow[j] = w;
                        }
                    }
                }

                int x = 0;
                int c_x = 0;

                for (int i = 0; i < up.Count; i++)
                {
                    string temp = "";
                    

                    zz += temp;
                    box[i].Location = new Point(x + i * 50, 0);
                    box[i].Size = new Size(50, 100);
                    box[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    //panel1.Controls.Add(box[i]);
                    c_x++;
                }
                zz += "\r";
                for (int i = 0; i < dow.Count; i++)
                {
                    //string temp = clsBSoft.Ocr(ch, false, full_tesseract, num_tesseract, ch_tesseract, true); // nhan dien so
                    string temp = "";
                    zz += temp;
                    box[i + c_x].Location = new Point(x + i * 50, 100);
                    box[i + c_x].Size = new Size(50, 100);
                    box[i + c_x].SizeMode = PictureBoxSizeMode.StretchImage;
                    //panel1.Controls.Add(box[i + c_x]);
                }
                //textBox1.Text = zz;

            }

        }
        private void button_addTransport_Click(object sender, EventArgs e)
        {
            //string[] type_customer = { "PASSENGER CUSTOMERS","RENT BY DAY", "RENT BY WEEK", "RENT BY MONTH", "RENT BY YEAR" };
            if (button_addTransport.Text[8] == 'đ')
            {
                string id;
                id = Bike.Instance.makeID("BIKE");
                
                MemoryStream pic_trans = new MemoryStream();
                MemoryStream pic_user = new MemoryStream();
                pictureBox_getPic1.Image.Save(pic_trans, pictureBox_getPic1.Image.RawFormat);
                pictureBox_getPic2.Image.Save(pic_user, pictureBox_getPic2.Image.RawFormat);          
                string type = comboBox_typeCustomer.Text;
                DateTime rental = Transport.Instancet.getRental(comboBox_typeCustomer, numericUpDown_add);
                


                if (Bike.Instance.insertBike(id, pic_user, pic_trans, type) == true && Bike.Instance.insertParked(id, pic_user, pic_trans, type, rental) == true)
                {
                    pictureBox_getPic1.Image = null;
                    pictureBox_getPic2.Image = null;
                    int du = Transport.Instancet.getCapacity("Bike") - Bike.Instance.getAllBike().Rows.Count;
                    if (du == 0)
                        MessageBox.Show("Đã hết chỗ để xe đạp");
                    label_count.Text = "Số Chỗ Dư Hiện Tại: " + du.ToString();
                }
                else
                {                
                    MessageBox.Show("Vui lòng thử lại");
                }
            }  
            else if (button_addTransport.Text[8] == 'm')
            {
                string id =Motor.Instance.makeID("Motor");
                MemoryStream pic_user = new MemoryStream();
                MemoryStream pic_plate = new MemoryStream();
                pictureBox_getPic2.Image.Save(pic_user, pictureBox_getPic2.Image.RawFormat);
                pictureBox_getPic1.Image.Save(pic_plate, pictureBox_getPic1.Image.RawFormat);
                string plate = textBox_plateNumber.Text;
                DateTime rental =Transport.Instancet.getRental(comboBox_typeCustomer, numericUpDown_add);
                string type = comboBox_typeCustomer.Text;
                if (Motor.Instance.insertMotor(id,pic_user, pic_plate, plate,type) == true && Motor.Instance.insertMotorParked(id,pic_user, pic_plate,plate, type,rental) == true)
                {
                    pictureBox_getPic1.Image = null;
                    pictureBox_getPic2.Image = null;
                    int du = Transport.Instancet.getCapacity("Motor") - Motor.Instance.getAllMotor().Rows.Count;
                    if (du == 0)
                        MessageBox.Show("Đã hết chỗ để xe máy");
                    label_count.Text = "Số Chỗ Dư Hiện Tại: " + du.ToString();
                    textBox_plateNumber.Text = "";
                }
                else
                {
                    MessageBox.Show("Vui lòng thử lại");
                }
            }   
            else if (button_addTransport.Text[8] == 'h')
            {
                string id = Car.Instance.makeID("CAR");
                MemoryStream pic_plate = new MemoryStream();
                pictureBox_getPic1.Image.Save(pic_plate, pictureBox_getPic1.Image.RawFormat);
                MemoryStream pic_brand = new MemoryStream();
                pictureBox_getPic2.Image.Save(pic_brand, pictureBox_getPic2.Image.RawFormat);
                string plate = textBox_plateNumber.Text;
                DateTime rental = Transport.Instancet.getRental(comboBox_typeCustomer, numericUpDown_add);
                string type = comboBox_typeCustomer.Text;

                if (Car.Instance.insertCar(id, pic_brand, pic_plate, plate, type) == true && Car.Instance.insertCarParked(id, pic_brand, pic_plate, plate, type, rental) == true)
                {
                    pictureBox_getPic1.Image = null;
                    pictureBox_getPic2.Image = null;
                    int du = Transport.Instancet.getCapacity("Car") - Car.Instance.getAllCar().Rows.Count;
                    if (du == 0)
                        MessageBox.Show("Đã hết chỗ để xe hơi");
                    label_count.Text = "Số Chỗ Dư Hiện Tại: " + du.ToString();
                    textBox_plateNumber.Text = "";
                }
                else
                {
                    MessageBox.Show("Vui lòng thử lại");
                }

            }    
        }
    }
}
