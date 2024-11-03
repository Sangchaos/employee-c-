using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace CONGTY
{
    public partial class frmShop : Form
    {
        public frmShop()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            // Thêm các mục vào ComboBox theo từng loại thiết bị
            cbiphone.Items.AddRange(new string[] { "iphone14", "iphone15", "iphone16" });
            cbsamsung.Items.AddRange(new string[] { "samsungS22", "samsungS23", "samsungS24" });
            cblg.Items.AddRange(new string[] { "lgG8ThinQ", "lgV50ThinQ" });

            // Gán sự kiện khi chọn thay đổi trong ComboBox
            cbiphone.SelectedIndexChanged += cbiphone_SelectedIndexChanged;
            cbsamsung.SelectedIndexChanged += cbsamsung_SelectedIndexChanged;
            cblg.SelectedIndexChanged += cblg_SelectedIndexChanged;
        }

        private List<Devices> deviceList = new List<Devices>
        {
            new Iphone("iphone14", new Date(2022, 9, 16), "Tím", "Apple", 780f),
            new Iphone("iphone15", new Date(2023, 9, 22), "Xám", "Apple", 799f),
            new Iphone("iphone16", new Date(2024, 9, 20), "Trắng", "Apple", 829f),
            new Samsung("samsungS22", new Date(2022, 2, 25), "Nâu Đỏ ", "Samsung", 750f),
            new Samsung("samsungS23", new Date(2023, 2, 17), "Hồng Trắng", "Samsung", 790f),
            new Samsung("samsungS24", new Date(2024, 2, 9), "Đen Xám", "Samsung", 849f),
            new LG("lgG8ThinQ", new Date(2022, 2, 9), "Đen", "LG", 720f),
            new LG("lgV50ThinQ", new Date(2022, 6, 27), "Đen", "LG", 770f)
        };
        public void AddDevice(Devices device)
        {
            deviceList.Add(device);
        }


        public List<Devices> GetDeviceList()
        {
            return deviceList;
        }
        private void btnoplist_Click(object sender, EventArgs e)
        {
            string type = txtType.Text;

            if (string.IsNullOrWhiteSpace(type))
            {
                MessageBox.Show("Vui lòng nhập tên interface.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> matchedDevices = new List<string>();
            foreach (var device in deviceList)
            {
                bool hasInterface = device.GetType().GetInterfaces()
                                          .Any(i => i.Name.Equals(type, StringComparison.OrdinalIgnoreCase));

                if (hasInterface)
                {
                    matchedDevices.Add(device.NameDivice);
                }
            }

            if (matchedDevices.Any())
            {
                string devices = string.Join("\n", matchedDevices);
                MessageBox.Show(devices, $"Danh sách thiết bị có {type}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy thiết bị phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbiphone_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem != null)
            {
                string extension = ".jpg"; // Đặt phần mở rộng của ảnh
                Bitmap bm = new Bitmap(Application.StartupPath + "\\Resources\\" + cb.SelectedItem.ToString() + extension);
                pictureBox.Image = bm;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                // Gọi phương thức để thiết lập giá của thiết bị
                SetPriceForDevice(cb.SelectedItem.ToString());
            }
        }

        private void cbsamsung_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem != null)
            {
                string extension = ".jpg";
                Bitmap bm = new Bitmap(Application.StartupPath + "\\Resources\\" + cb.SelectedItem.ToString() + extension);
                pictureBox.Image = bm;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                SetPriceForDevice(cb.SelectedItem.ToString());
            }
        }

        private void cblg_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem != null)
            {
                string extension = ".jpg";
                Bitmap bm = new Bitmap(Application.StartupPath + "\\Resources\\" + cb.SelectedItem.ToString() + extension);
                pictureBox.Image = bm;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                SetPriceForDevice(cb.SelectedItem.ToString());
            }
        }

        private void SetPriceForDevice(string deviceName)
        {
            foreach (var device in deviceList)
            {
                if (device.NameDivice == deviceName)
                {
                    btnBuy.Text = device.Price.ToString() + "$";
                    lblInfo.Text = device.ToString();
                    break;
                }
            }
        }


        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            // Loại bỏ ký hiệu `$` và chuyển đổi giá trị sang float
            string priceText = btnBuy.Text.Replace("$", "").Trim();
            if (!float.TryParse(priceText, out float price))
            {
                MessageBox.Show("Giá trị không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var device in deviceList)
            {
                if (price == device.Price)
                {
                    string filePath = @"S:\WINFORM\congty\buy.txt";
                    using (StreamWriter sw = new StreamWriter(filePath, true))
                    {
                        sw.WriteLine($"Mua hàng vào lúc: {DateTime.Now}");
                        sw.WriteLine(device.ToString() + "\n");
                    }

                    MessageBox.Show("Mua hàng thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show("Không tìm thấy thiết bị có giá trị này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRedu_Click(object sender, EventArgs e)
        {
            frmEmployee form = new frmEmployee();
            form.Show();
            this.Hide();
        }

        private void btnGoStore_Click(object sender, EventArgs e)
        {
            StoreForm form = new StoreForm();
            form.Show();
            this.Hide();
        }

        private void frmShop_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Ngăn việc đóng form
            }
            else
            {
                Application.Exit();
            }
        }
    }

}
