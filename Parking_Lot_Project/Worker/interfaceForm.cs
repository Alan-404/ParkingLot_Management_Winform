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
    public partial class interfaceForm : Form
    {
        Worker worker = new Worker();
        public interfaceForm()
        {
            InitializeComponent();
            
        }

        private void interfaceForm_Load(object sender, EventArgs e)
        {
                      
        }

        private void button_parkingArea_Click(object sender, EventArgs e)
        {
            settingPriceParkForm frm = new settingPriceParkForm();
            frm.ShowDialog();
            
        }

        private void button_manage_Click(object sender, EventArgs e)
        {
            interfaceWorkerForm frm = new interfaceWorkerForm();
            frm.Show();
        }

        private void button_fixer_Click(object sender, EventArgs e)
        {
            settingPriceFixForm frm = new settingPriceFixForm();
            frm.Show();
            
        }

        private void button_washer_Click(object sender, EventArgs e)
        {
            settingWashForm frm = new settingWashForm();
            frm.Show();
            
        }

    }
}
