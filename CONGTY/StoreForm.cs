using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONGTY
{
    public partial class StoreForm : Form
    {
        public StoreForm()
        {
            InitializeComponent();
        }

        private void StoreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true; 
            } 
            else
            {
                Application.Exit();
            }
            
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            frmShop frmShop = new frmShop();
            frmShop.Show();
            this.Hide();
        }

        private void btnaddDevice_Click(object sender, EventArgs e)
        {
            try
            {
                
                string nameDevice = txtName.Text;
                string producer = txtProducer.Text;
                string color = txtColor.Text;
                float price;
                if (!float.TryParse(txtPrice.Text, out price))
                {
                    MessageBox.Show("Giá không hợp lệ, vui lòng nhập lại.");
                    return;
                }

                int day, month, year;
                if (!int.TryParse(txtday.Text, out day) ||
                    !int.TryParse(txtmonth.Text, out month) ||
                    !int.TryParse(txtyear.Text, out year))
                {
                    MessageBox.Show("Ngày sản xuất không hợp lệ, vui lòng nhập lại.");
                    return;
                }


                Date yob = new Date(year, month, day);
                

                MessageBox.Show("Thiết bị đã được thêm thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
    }
}
