using System;
using System.Windows.Forms;

namespace Example12
{
    public partial class FormResult : Form
    {
        public StudentInfo StudentInfo { get; set; }
        public int TotalQuestions { get; set; }
        public int CorrectAnswers { get; set; }
        public double Score { get; set; }

        public FormResult()
        {
            InitializeComponent();
            btnThoat.Click += (s, e) => Application.Exit();
            btnLamLai.Click += (s, e) => {
                Form1 frmMain = new Form1();
                frmMain.Show();
                this.Close();
            };
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            DisplayResult();
        }

        private void DisplayResult()
        {
            if (StudentInfo != null)
            {
                txtResult.Text = $"Thong tin thi sinh\r\n\r\n" +
                               $"Ma: {StudentInfo.Ma}\r\n" +
                               $"Ten: {StudentInfo.Ten}\r\n" +
                               $"Ngay sinh: {StudentInfo.NgaySinh:dd/MM/yyyy}\r\n" +
                               $"Noi sinh: {StudentInfo.NoiSinh}\r\n" +
                               $"Gioi tinh: {StudentInfo.GioiTinh}\r\n" +
                               $"Dia chi: {StudentInfo.DiaChi}\r\n\r\n" +
                               $"Ket qua thi\r\n\r\n" +
                               $"Tong so cau hoi: {TotalQuestions}\r\n" +
                               $"Tong so cau tra loi: {TotalQuestions}\r\n" +
                               $"Tong so cau tra loi dung: {CorrectAnswers}\r\n" +
                               $"Tong so diem dat duoc: {Score:F1}";
            }
        }
    }
}