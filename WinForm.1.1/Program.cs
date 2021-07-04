using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Створити консольний додаток.
            //   Програма задає питання щодо розмірів, кольору форми, розмірів  кнопки і зображує відповідну форму з кнопкою на формі.

             Show_My_Form();
        }
        private static void Show_My_Form()
        {
            Console.WriteLine("Write height of form");
            int h_form = int.Parse(Console.ReadLine());

            Console.WriteLine("Write width of form");
            int w_form = int.Parse(Console.ReadLine());

            Console.WriteLine("Write color of form");
            String col_form = Console.ReadLine();

            Console.WriteLine("Write height of button");
            int h_button = int.Parse(Console.ReadLine());

            Console.WriteLine("Write width of button");
            int w_button = int.Parse(Console.ReadLine());

            var form = new Form();
            form.BackColor = Color.FromName(col_form);
            form.Height = h_form;
            form.Width = w_form;

            var button = new Button();
            button.Height = h_button;
            button.Width = w_button;
            button.Location = new Point(form.Height / 2, form.Width / 2);
            form.Controls.Add(button);
            form.ShowDialog();
        }
    }
}
