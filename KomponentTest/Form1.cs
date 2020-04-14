using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KomponentTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int result;
        public int getNumber()
        {
            String numer = Input.Text;
            result = Int32.Parse(numer);
            return result;
        }

        private void segment1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            try { 
            getNumber();
                if (result >= 0 && result < 100)
                {

                    ui1.setValue(result);

                    Refresh();
                }
                else
                {
                    Console.Out.WriteLine("Liczba spoza zakresu");
                }
            }
            catch(FormatException f)
            {

            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (result != 0)
            {
               // ui1.DrawTwoDigitSegmentNumber(e.Graphics, Color.Blue, result, 10, 10, 3, 25);
            }
            //ui1.DrawTwoDigitSegmentNumber(e.Graphics, Color.Green, DateTime.Now.Minute, 100, 10, 3, 25);
           // ui1.DrawTwoDigitSegmentNumber(e.Graphics, Color.Orange, DateTime.Now.Second, 190, 10, 3, 25);
        }

        private void ui1_Load(object sender, EventArgs e)
        {

        }
    }
}
