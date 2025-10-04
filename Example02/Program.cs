using System;
using System.Windows.Forms;

namespace Example02
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var calcForm = new CalculatorForm();
            calcForm.Show();

            var simpleForm = new SimpleCalculatorForm();
            simpleForm.Show();

            var advForm = new AdvancedCalculatorForm();
            Application.Run(advForm); // Form này giữ app chạy
        }
    }
}
