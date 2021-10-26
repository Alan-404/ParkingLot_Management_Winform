using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_Lot_Project
{
    class ChangeImage
    {
        public static volatile ChangeImage instance;
        private static object key = new object();
        public static ChangeImage Instance
        {
            get
            {
                if (instance == null)
                {
                    lock(key)
                    {
                        instance = new ChangeImage();
                    }
                }
                return instance;
            }
        }

        public void formatImage(DataGridView dgv, int numberColumn)
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dgv.Columns[numberColumn];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
    }
}
