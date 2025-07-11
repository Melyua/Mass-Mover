using System;
using System.Windows.Forms;

namespace FileMoverApp  // <--- это пространство имён должно совпадать
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());  // <--- здесь должно быть правильное имя формы
        }
    }
}
