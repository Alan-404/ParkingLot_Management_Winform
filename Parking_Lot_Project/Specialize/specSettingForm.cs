using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_Lot_Project
{
    public partial class specSettingForm : Form
    {
        public specSettingForm()
        {
            InitializeComponent();
        }

        private void specSettingForm_Load(object sender, EventArgs e)
        {
            comboBox_work.DataSource = Work.Instance.getAllWork();
            comboBox_work.DisplayMember = "NAME_WORK";
            comboBox_work.ValueMember = "ID";
        }

        private void comboBox_work_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_spec.DataSource = Specialize.Instance.getSpecByWord(comboBox_work.SelectedValue.ToString());
            comboBox_spec.DisplayMember = "NAME_SPEC";
            comboBox_spec.ValueMember = "ID";
        }

        private void materialButton_add_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text != "")
            {
                string id = Specialize.Instance.makeID();
                string name = textBox_name.Text;
                string work = comboBox_work.SelectedValue.ToString();
                if (Specialize.Instance.insertSpec(id,name,work) == true)
                {
                    MessageBox.Show("Thêm Chuyên Môn Thành Công");
                }
            }
            else
            {
                MessageBox.Show("Chưa Nhập Tên Chuyên Môn");
            }
                
            
        }

        private void materialButton_edit_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text != "")
            {
                string name = textBox_name.Text;
                if (Specialize.Instance.editSpec(comboBox_spec.SelectedValue.ToString(), name) == true)
                {
                    MessageBox.Show("Sửa Chuyên Môn Thành Công");
                }
            }
            else
            {
                MessageBox.Show("Chưa Nhập Tên Chuyên Môn");
            } 
                
        }

        private void materialButton_remove_Click(object sender, EventArgs e)
        {
            string id = comboBox_spec.SelectedValue.ToString();
            if (Specialize.Instance.removeSpec(id) == true)
            {
                MessageBox.Show("Xóa Chuyên Môn Thành Công");
            }
        }
    }
}
