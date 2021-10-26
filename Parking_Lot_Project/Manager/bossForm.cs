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
using MaterialSkin.Controls;
using AForge.Video;
using AForge.Video.DirectShow;
using FontAwesome.Sharp;
using MaterialSkin;

namespace Parking_Lot_Project
{
    public partial class bossForm : MaterialForm
    {
        #region Data
        Admin ad = new Admin();

        #endregion
        #region Camera
        #endregion

        public delegate void sendData(string id);
        public sendData sendTheData;
        public bossForm()
        {
            InitializeComponent();
            
        }
        private void OpenForm(Form childForm, TabPage page)
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

        private void bossForm_Load(object sender, EventArgs e)
        {
            //loadDataEmp();
            //cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //foreach (FilterInfo camera in cameras)
            //    comboBox_cameras.Items.Add(camera.Name);
            //comboBox_cameras.SelectedIndex = 1;
            //comboBox_manager.Enabled = false;
            mainForm frm = new mainForm();
            frm.label_darkID.Text = "Boss";
            frm.iconButton_exit.Visible = false;
            interfaceWorkerForm frmEmp = new interfaceWorkerForm();
            frm.label_darkID.Text = "B";
            OpenForm(frmEmp, tabPage_emp);
            OpenForm(new parkingAreaForm(), tabPage_transport);
            OpenFormPanel(new calenderForm(), panel_calender) ;
            OpenFormPanel(new interfaceForm(), panel_work);
            OpenForm(new customerListForm(), tabPage_customer);
            OpenForm(new contractForm(), tabPage_contract);
            OpenForm(new addSpecForm(), tabPage_addSpec);
        }
        #region Format
        
        #endregion

        

        private void iconButton_setting_Click(object sender, EventArgs e)
        {
            settingBossForm frm = new settingBossForm();
            frm.ShowDialog();
        }

        private void metroTile_emp_Click(object sender, EventArgs e)
        {
            materialTabControl_boss.SelectedTab = tabPage_emp;          
        }

        private void metroTile_addAccount_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.ShowDialog();
        }

        private void metroTile_setting_Click(object sender, EventArgs e)
        {
            settingBossForm frm = new settingBossForm();
            frm.ShowDialog();
        }

        private void metroTile_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroTile_parking_Click(object sender, EventArgs e)
        {
            materialTabControl_boss.SelectedTab = tabPage_transport;
        }

        private void metroTile_security_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_work_Enter(object sender, EventArgs e)
        {
            //addManagerForm frm = new addManagerForm();
            //frm.Show();
        }

        private void metroTile_bike_Click(object sender, EventArgs e)
        {
            bikeListForm frm = new bikeListForm();
            frm.Show();
        }

        private void metroTile_addCus_Click(object sender, EventArgs e)
        {
            addCustomerForm frm = new addCustomerForm();
            frm.Show();
        }

        private void metroTile_listCus_Click(object sender, EventArgs e)
        {
            materialTabControl_boss.SelectedTab = tabPage_customer;
        }

        private void materialButton_settingSpec_Click(object sender, EventArgs e)
        {
            specSettingForm frm = new specSettingForm();
            frm.Show();
        }

        private void metroTile_rent_Click(object sender, EventArgs e)
        {
            materialTabControl_boss.SelectedIndex = 6;
            OpenForm(new contractForm(), tabPage_contract);
        }

        private void metroTile_sendRent_Click(object sender, EventArgs e)
        {
            materialTabControl_boss.SelectedIndex = 6;
            contractForm frm = new contractForm();
            frm.tabControl_rent.SelectedIndex = 1;
            OpenForm(frm, tabPage_contract);
        }

        private void metroTile_listContract_Click(object sender, EventArgs e)
        {
            materialTabControl_boss.SelectedIndex = 6;
            contractForm frm = new contractForm();
            frm.tabControl_rent.SelectedIndex = 2;
            OpenForm(frm, tabPage_contract);
        }

        private void tabPage_Dashboard_Click(object sender, EventArgs e)
        {
            materialTabControl_boss.SelectedTab = tabPage_interface;
        }

        private void comboBox_service_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_service.SelectedIndex == 0)
            {
                OpenFormPanel(new interfaceFixForm(), panel_service);
            }
            else
            {
                OpenFormPanel(new interfaceWasherForm(), panel_service);
            }
        }

        private void metroTile_serviceFix_Click(object sender, EventArgs e)
        {
            materialTabControl_boss.SelectedTab = tabPage_service;
            comboBox_service.SelectedIndex = 0;
        }

        private void metroTile_washService_Click(object sender, EventArgs e)
        {
            materialTabControl_boss.SelectedTab = tabPage_service;
            comboBox_service.SelectedIndex = 1;
        }



        private void metroTile_spec_Click(object sender, EventArgs e)
        {
            materialTabControl_boss.SelectedTab = tabPage_addSpec;
        }

        private void metroTile_shiftSe_Click(object sender, EventArgs e)
        {
            OpenForm(new shiftForm(), tabPage_shift);
            materialTabControl_boss.SelectedTab = tabPage_shift;
        }

        private void metroTile_shiftFix_Click(object sender, EventArgs e)
        {
            
            OpenForm(new shiftFixForm(), tabPage_shift);
            materialTabControl_boss.SelectedTab = tabPage_shift;
        }

        private void metroTile_shiftWash_Click(object sender, EventArgs e)
        {
            
            OpenForm(new shiftWashForm(), tabPage_shift);
            materialTabControl_boss.SelectedTab = tabPage_shift;
        }

        private void iconButton_home_Click(object sender, EventArgs e)
        {
            materialTabControl_boss.SelectedTab = tabPage_interface;
        }

        private void metroTile_se_Click(object sender, EventArgs e)
        {
            addManagerForm frm = new addManagerForm();
            frm.Show();
        }

        private void metroTile_car_Click(object sender, EventArgs e)
        {
            carListForm frm = new carListForm();
            frm.Show();
        }

        private void metroTile_moto_Click(object sender, EventArgs e)
        {
            motorListForm frm = new motorListForm();
            frm.Show();
        }

        private void metroTile_fix_Click(object sender, EventArgs e)
        {
            removeManagerForm frm = new removeManagerForm();
            frm.Show();
        }

        private void metroTile_price_Click(object sender, EventArgs e)
        {
            materialTabControl_boss.SelectedTab = tabPage_work;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            bossForm_Load(null, null);
        }
    }
}
