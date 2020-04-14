using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;



namespace Komponent
{
    public class UI : UserControl
    {
     
        public void DrawTwoDigitSegmentNumber(Graphics gx, Color clr, int number, int x, int y, int thickness, int width)
        {
            DrawSegments(gx, clr, number / 10, x, y, thickness, width);
            DrawSegments(gx, clr, number % 10, x + width + 10, y, thickness, width);

        }

        

        static void DrawHorizondalSegment(Graphics gx, Color clr, int x, int y, int l, int w)
        {
            gx.FillPolygon(new SolidBrush(clr), new Point[] {
                new Point(x, y), new Point(x + l, y-l), new Point(x+w-l, y - l),
                new Point(x +w, y),new Point(x+w-l,y+l) ,new Point(x+l,y+l)
            });
        }

        static void DrawVerticalSegment(Graphics gx, Color clr, int x, int y, int l, int w)
        {
            gx.FillPolygon(new SolidBrush(clr), new Point[] {
                new Point(x, y), new Point(x + l, y+l), new Point(x+l, y +w - l),
                new Point(x , y+w),new Point(x-l,y+w-l) ,new Point(x-l,y+l)
            });
        }

        public static void DrawSegments(Graphics gx, Color clr, int n, int x, int y, int l, int w)
        {

            byte[][] segment = new byte[10][];
            segment[0] = new byte[] { 1, 1, 1, 1, 1, 1, 0 }; 
            segment[1] = new byte[] { 1, 1, 0, 0, 0, 0, 0 }; 
            segment[2] = new byte[] { 0, 1, 1, 1, 0, 1, 1 };
            segment[3] = new byte[] { 0, 0, 1, 1, 1, 1, 1 }; 
            segment[4] = new byte[] { 1, 0, 0, 1, 1, 0, 1 }; 
            segment[5] = new byte[] { 1, 0, 1, 0, 1, 1, 1 }; 
            segment[6] = new byte[] { 1, 1, 1, 0, 1, 1, 1 }; 
            segment[7] = new byte[] { 0, 0, 1, 1, 1, 0, 0 }; 
            segment[8] = new byte[] { 1, 1, 1, 1, 1, 1, 1 }; 
            segment[9] = new byte[] { 1, 0, 1, 1, 1, 0, 1 }; 

            if (segment[n][0] == 1)
                DrawVerticalSegment(gx, clr, x + 2, y + 4, l, w);            
            if (segment[n][1] == 1)
                DrawVerticalSegment(gx, clr, x + 2, y + 8 + w, l, w);        
            if (segment[n][2] == 1)
                DrawHorizondalSegment(gx, clr, x + 2, y + 2, l, w);          
            if (segment[n][3] == 1)
                DrawVerticalSegment(gx, clr, x + 2 + w, y + 4, l, w);       
            if (segment[n][4] == 1)
                DrawVerticalSegment(gx, clr, x + 2 + w, y + 8 + w, l, w);    
            if (segment[n][5] == 1)
                DrawHorizondalSegment(gx, clr, x + 2, y + 10 + 2 * w, l, w); 
            if (segment[n][6] == 1)
                DrawHorizondalSegment(gx, clr, x + 2, y + 6 + w, l, w);      


        }


        private int val;
        public int getValue(int val)
        {
            return val;
        }

       
        public void setValue(int value) 
        {
            this.val = value;
            
            
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            setValue(val);
            base.OnPaint(e);
            DrawTwoDigitSegmentNumber(e.Graphics, Color.Blue, val, 10, 10, 3, 25);
           
        }
    }
}
