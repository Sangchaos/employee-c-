using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CONGTY
{
    public partial class frmEmployee : Form
    {
        List<Employee> employees = new List<Employee>
        {
            new Boss("1", "Dinh Van Sang", new Date(1980, 5, 10), new Date(2005, 6, 15), 5000),
            new Commissionworker("2", "Dang Ngoc Gay", new Date(1975, 11, 20), new Date(2000, 1, 5), 7000),

            new Houlyworker("3", "Chau Kim Tat", new Date(1990, 8, 22), new Date(2010, 3, 20), 1000),
            new Houlyworker("4", "Thai Quang Huy", new Date(1992, 7, 14), new Date(2015, 2, 28), 800 ),
            new Houlyworker("5", "Mai Hong Tin", new Date(1988, 3, 12), new Date(2013, 10, 19), 400),

            new Commissionworker("6", "Nguyen Quoc Khanh", new Date(1985, 1, 15), new Date(2012, 5, 10), 3000),
            new Commissionworker("7", "Le An Thai", new Date(1987, 6, 30), new Date(2011, 7, 23), 3200),
            new Commissionworker("8", "Qunag Le", new Date(1991, 9, 5), new Date(2018, 12, 17), 2800),

            new Houlyworker("9", "Bui Hai Duong", new Date(1983, 4, 25), new Date(2008, 9, 30), 5500),
            new Houlyworker("10", "Viet Hieu", new Date(1993, 2, 16), new Date(2019, 11, 4), 2000)
        };
        public frmEmployee()
        {
            InitializeComponent();
        }


        private void btnCalculation_Click(object sender, EventArgs e)
        {   
            string  id = txtId.Text;
            Boolean check = false;
            foreach (var employee in employees)
            {
                if (id == employee.Id)
                {
                    richtbShow.Text = employee.ToString();
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                MessageBox.Show("Khong tim thay nhan vien", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Clear();
                txtId.Focus();
            }
        }

        private void btngoshop_Click(object sender, EventArgs e)
        {
            frmShop frmShop = new frmShop();
            frmShop.Show();
            this.Hide();
     
        }

        private void btnaddEmp_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            bool check = false;

            foreach (var employee in employees)
            {
                if (id.Equals(employee.Id))
                {
                    MessageBox.Show("Nhân viên đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtId.Clear();
                    txtId.Focus();
                    check = true;
                    break;
                }
            }

            if (check)
            {
                return; // Exit if the employee ID already exists
            }

            string name = txtName.Text;
            int birthYear = int.Parse(txtyear.Text);
            int birthMonth = int.Parse(txtmonth.Text);
            int birthDay = int.Parse(txtDay.Text);
            Date birth = new Date(birthYear, birthMonth, birthDay);

            int hireYear = int.Parse(txtHireYear.Text);
            int hireMonth = int.Parse(txtHireMonth.Text);
            int hireDay = int.Parse(txtHireDay.Text);
            Date hire = new Date(hireYear, hireMonth, hireDay);

            double wage = double.Parse(txtWage.Text);
            double rate = double.Parse(txtRate.Text); // Changed to double

            if (rate == 1)
            {
                Boss boss = new Boss(id, name, birth, hire, wage);
                employees.Add(boss);
                MessageBox.Show("Thêm nhân viên thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rate == 0.8)
            {
                Commissionworker commissionWorker = new Commissionworker(id, name, birth, hire, wage);
                employees.Add(commissionWorker);
                MessageBox.Show("Thêm nhân viên thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rate == 0.5)
            {
                Houlyworker hourlyWorker = new Houlyworker(id, name, birth, hire, wage);
                employees.Add(hourlyWorker);
                MessageBox.Show("Thêm nhân viên thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Chức vụ không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRate.Clear();
                txtRate.Focus();
            }
        }

        private void frmEmployee_FormClosing(object sender, FormClosingEventArgs e)
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
    }

}
