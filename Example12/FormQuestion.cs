using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Example12
{
    public partial class FormQuestion : Form
    {
        public StudentInfo StudentInfo { get; set; }
        private List<Question> questions;
        private int currentQuestion = 0;
        private int[] userAnswers;
        private Timer timer;
        private int timeLeft = 600; // 10 phut

        public FormQuestion()
        {
            InitializeComponent();
            InitializeQuestions();
            userAnswers = new int[questions.Count];
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            DisplayQuestion();
            btnNext.Click += BtnNext_Click;
            btnPrev.Click += BtnPrev_Click;
            btnFinish.Click += BtnFinish_Click;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            int minutes = timeLeft / 60;
            int seconds = timeLeft % 60;
            lblTime.Text = $"Thoi gian con lai: {minutes:00}:{seconds:00}";
            
            if (timeLeft <= 0)
            {
                timer.Stop();
                FinishExam();
            }
        }

        private void InitializeQuestions()
        {
            questions = new List<Question>
            {
                new Question("Thu do cua Viet Nam la gi?", new string[] { "Ha Noi", "TP. Ho Chi Minh", "Da Nang", "Hue" }, 0),
                new Question("1 + 1 = ?", new string[] { "1", "2", "3", "4" }, 1),
                new Question("Mau cua la cay thuong la?", new string[] { "Do", "Xanh", "Vang", "Tim" }, 1),
                new Question("Viet Nam co bao nhieu tinh thanh?", new string[] { "62", "63", "64", "65" }, 1),
                new Question("Bien nao o phia Dong Viet Nam?", new string[] { "Bien Dong", "Bien Tay", "Bien Nam", "Bien Bac" }, 0),
                new Question("2 x 3 = ?", new string[] { "5", "6", "7", "8" }, 1),
                new Question("Dong vat nao sau day la loai chim?", new string[] { "Ca", "Cho", "Ga", "Meo" }, 2),
                new Question("Ngay Quoc khanh Viet Nam la ngay nao?", new string[] { "2/9", "30/4", "1/5", "19/5" }, 0),
                new Question("10 : 2 = ?", new string[] { "3", "4", "5", "6" }, 2),
                new Question("Mat troi moc o huong nao?", new string[] { "Tay", "Dong", "Nam", "Bac" }, 1),
                new Question("Nuoc co cong thuc hoa hoc la?", new string[] { "H2O", "CO2", "O2", "H2SO4" }, 0),
                new Question("1 nam co bao nhieu thang?", new string[] { "10", "11", "12", "13" }, 2),
                new Question("Song dai nhat Viet Nam la?", new string[] { "Song Hong", "Song Me Kong", "Song Dong Nai", "Song Ca" }, 1),
                new Question("5 + 3 = ?", new string[] { "7", "8", "9", "10" }, 1),
                new Question("Con vat nao sau day song o nuoc?", new string[] { "Cho", "Meo", "Ca", "Ga" }, 2),
                new Question("Qua nao co mau do?", new string[] { "Chuoi", "Tao", "Cam", "Nho" }, 1),
                new Question("Ha Noi thuoc mien nao cua Viet Nam?", new string[] { "Mien Bac", "Mien Trung", "Mien Nam", "Mien Tay" }, 0),
                new Question("9 - 4 = ?", new string[] { "4", "5", "6", "7" }, 1),
                new Question("Loai hoa nao duoc goi la quoc hoa Viet Nam?", new string[] { "Hoa hong", "Hoa sen", "Hoa dao", "Hoa mai" }, 1),
                new Question("Trong mot tuan co bao nhieu ngay?", new string[] { "5", "6", "7", "8" }, 2)
            };
        }

        private void DisplayQuestion()
        {
            if (currentQuestion >= 0 && currentQuestion < questions.Count)
            {
                var q = questions[currentQuestion];
                lblQuestionNumber.Text = $"Cau {currentQuestion + 1}";
                lblQuestion.Text = q.Text;
                rdo1.Text = q.Options[0];
                rdo2.Text = q.Options[1];
                rdo3.Text = q.Options[2];
                rdo4.Text = q.Options[3];
                
                // Hien thi dap an da chon
                ClearSelection();
                if (userAnswers[currentQuestion] > 0)
                {
                    switch (userAnswers[currentQuestion] - 1)
                    {
                        case 0: rdo1.Checked = true; break;
                        case 1: rdo2.Checked = true; break;
                        case 2: rdo3.Checked = true; break;
                        case 3: rdo4.Checked = true; break;
                    }
                }
                
                btnPrev.Enabled = currentQuestion > 0;
                btnNext.Enabled = currentQuestion < questions.Count - 1;
            }
        }

        private void ClearSelection()
        {
            rdo1.Checked = false;
            rdo2.Checked = false;
            rdo3.Checked = false;
            rdo4.Checked = false;
        }

        private void SaveAnswer()
        {
            if (rdo1.Checked) userAnswers[currentQuestion] = 1;
            else if (rdo2.Checked) userAnswers[currentQuestion] = 2;
            else if (rdo3.Checked) userAnswers[currentQuestion] = 3;
            else if (rdo4.Checked) userAnswers[currentQuestion] = 4;
            else userAnswers[currentQuestion] = 0;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            SaveAnswer();
            if (currentQuestion < questions.Count - 1)
            {
                currentQuestion++;
                DisplayQuestion();
            }
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            SaveAnswer();
            if (currentQuestion > 0)
            {
                currentQuestion--;
                DisplayQuestion();
            }
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            SaveAnswer();
            FinishExam();
        }

        private void FinishExam()
        {
            timer.Stop();
            
            // Tinh diem
            int correctAnswers = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                if (userAnswers[i] == questions[i].CorrectAnswer + 1)
                    correctAnswers++;
            }
            
            double score = (double)correctAnswers / questions.Count * 10;
            
            // Chuyen sang form ket qua
            FormResult frmResult = new FormResult();
            frmResult.StudentInfo = this.StudentInfo;
            frmResult.TotalQuestions = questions.Count;
            frmResult.CorrectAnswers = correctAnswers;
            frmResult.Score = score;
            frmResult.Show();
            this.Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (StudentInfo != null)
            {
                lblMa.Text = $"Ma: {StudentInfo.Ma}";
                lblTen.Text = $"Ten: {StudentInfo.Ten}";
                lblNgaySinh.Text = $"Ngay sinh: {StudentInfo.NgaySinh:dd/MM/yyyy}";
            }
        }
    }

    public class Question
    {
        public string Text { get; set; }
        public string[] Options { get; set; }
        public int CorrectAnswer { get; set; }

        public Question(string text, string[] options, int correctAnswer)
        {
            Text = text;
            Options = options;
            CorrectAnswer = correctAnswer;
        }
    }
}