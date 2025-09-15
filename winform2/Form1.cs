using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void b1_Click(object sender, EventArgs e)
        {
            string hoten = txthoten.Text;
            string gioitinh = rb1.Checked ? "Nam" : rb2.Checked ? "Nữ" : "Chưa chọn";
            string ngaysinh = dtp1.Value.ToString("dd/MM/yyyy hh:mm:ss tt", new System.Globalization.CultureInfo("en-US"));
            List<string> soThich = new List<string>();
            if (ck1.Checked) soThich.Add(ck1.Text);
            if (ck2.Checked) soThich.Add(ck2.Text);
            if (ck3.Checked) soThich.Add(ck3.Text);
            string message = $"Họ tên: {hoten}, Giới tính: {gioitinh}, Ngày sinh: {ngaysinh}, Sở thích: {string.Join(", ", soThich)}";
            MessageBox.Show(message, "Thông tin người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
