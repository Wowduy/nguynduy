using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace formdangkyatikhoan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text;
            string email = textBox2.Text;

            // Biến để kiểm tra nếu cả email và mật khẩu đều hợp lệ
            bool isPasswordValid = true;
            bool isEmailValid = true;

            // Kiểm tra mật khẩu
            string passwordPattern = @"^(?=.*[!@#$%^&*(),.?""{}|<>])[A-Za-z\d!@#$%^&*(),.?""{}|<>]{8,}$";
            if (!Regex.IsMatch(password, passwordPattern))
            {
                MessageBox.Show("Mật khẩu không hợp lệ. Yêu cầu tối thiểu 8 ký tự và phải bao gồm ít nhất 1 ký tự đặc biệt.", "Lỗi mật khẩu");
                isPasswordValid = false; // Đánh dấu mật khẩu không hợp lệ
            }

            // Kiểm tra email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Email yêu cầu nhập đúng định dạng.", "Lỗi email");
                isEmailValid = false; // Đánh dấu email không hợp lệ
            }

            // Nếu cả email và mật khẩu đều hợp lệ, hiển thị thông báo thành công
            if (isPasswordValid && isEmailValid)
            {
                MessageBox.Show("Đăng ký thành công!", "Thành công");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
