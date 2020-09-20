using System;
using Gtk;

namespace Calc
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow win = new MainWindow();
            Entry firstnum = new Entry();
            Entry secnum = new Entry();
            Button calculate = new Button();
            ComboBoxText combotext = new ComboBoxText();
            Label summary = new Label();
            Grid maingrid = new Grid();
            string[] adds = {"+", "x", "-", "÷" };
            combotext.AppendText(adds[0]);
            combotext.AppendText(adds[1]);
            combotext.AppendText(adds[2]);
            combotext.AppendText(adds[3]);
            calculate.Label = "Calculate!";
            maingrid.Attach(firstnum, 0, 0, 1, 1);
            maingrid.AttachNextTo(combotext, firstnum, PositionType.Bottom, 1, 1);
            maingrid.AttachNextTo(secnum, combotext, PositionType.Bottom, 1, 1);
            maingrid.AttachNextTo(calculate, secnum, PositionType.Bottom, 1, 1);
            maingrid.AttachNextTo(summary, calculate, PositionType.Bottom, 1, 1);
            calculate.Clicked += Calculate_Clicked;
            void Calculate_Clicked(object sender, EventArgs e)
            {
                if (combotext.ActiveText == "+")
                {
                    int sumadd = int.Parse(firstnum.Text) + int.Parse(secnum.Text);
                    summary.Text = sumadd.ToString();
                }
                if (combotext.ActiveText == "x")
                {
                    int summultiply = int.Parse(firstnum.Text) * int.Parse(secnum.Text);
                    summary.Text = summultiply.ToString();
                }
                if (combotext.ActiveText == "-")
                {
                    int sumsubstract = int.Parse(firstnum.Text) - int.Parse(secnum.Text);
                    summary.Text = sumsubstract.ToString();
                }
                if (combotext.ActiveText == "÷")
                {
                    int sumsubstract = int.Parse(firstnum.Text) / int.Parse(secnum.Text);
                    summary.Text = sumsubstract.ToString();
                }
            }
            win.Add(maingrid);
            win.ShowAll();
            Application.Run();
        }


    }
}
