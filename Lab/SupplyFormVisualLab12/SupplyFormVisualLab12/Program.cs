using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplyFormVisualLab12
{
    internal static class Program
    {
        public static SupplyForm f1; // переменная, которая будет содержать ссылку на форму Form1
        public static AddItemForm f2; // переменная, которая будет содержать ссылку на форму Form2
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SupplyForm());
        }


        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            // Обработка и отображение исключения
            MessageBox.Show($"Произошла ошибка: {e.Exception.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
