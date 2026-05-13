using System;
using System.Windows.Forms;
using ATOTIFY.Arayuz;

namespace ATOTIFY
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Uygulama Giriş Ekranı ile başlar
            Application.Run(new GirisEkrani());
        }
    }
}
