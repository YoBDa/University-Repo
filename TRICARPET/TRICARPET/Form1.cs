using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRICARPET
{
    public partial class Form1 : Form
    {
        private const int MaxLevelT = 6;
        private const int MaxLevelC = 6;
        private int CurrentLevelT = 0;
        private int CurrentLevelC = 0;
        private int width;
        private int height;

        private Bitmap fractal;
        private Graphics graph;
        public Form1()
        {
            InitializeComponent();
            Size resolution = Screen.PrimaryScreen.Bounds.Size;
            this.Height = resolution.Height - 100;
            this.Width = this.Height;
            FractalBox.Width = this.Width - 100;
            FractalBox.Height = FractalBox.Width;
            width = FractalBox.Width;
            height = FractalBox.Height;
        }


        private void DrawTriangle(int level, PointF top, PointF left, PointF right)
        {
            if (level == 0)
            {
                PointF[] points = new PointF[3]
                {
                    top, right, left
                };
                graph.FillPolygon(Brushes.Red, points);
            }
            else
            {
                var leftMid = MidPoint(top, left);
                var rightMid = MidPoint(top, right);
                var topMid = MidPoint(left, right);
                DrawTriangle(level - 1, top, leftMid, rightMid);
                DrawTriangle(level - 1, leftMid, left, topMid);
                DrawTriangle(level - 1, rightMid, topMid, right);
            }
        }

        private PointF MidPoint(PointF p1, PointF p2)
        {
            return new PointF((p1.X + p2.X) / 2f, (p1.Y + p2.Y) / 2f);
        }

        private void DrawCarpet(int level, RectangleF carpet)
        {
            if (level == 0)
            {
                graph.FillRectangle(Brushes.Blue, carpet);
            }
            else
            {
                var width = carpet.Width / 3f;
                var height = carpet.Height / 3f;
                var x1 = carpet.Left;
                var x2 = x1 + width;
                var x3 = x1 + 2f * width;
                var y1 = carpet.Top;
                var y2 = y1 + height;
                var y3 = y1 + 2f * height;

                DrawCarpet(level - 1, new RectangleF(x1, y1, width, height)); // left 1(top)
                DrawCarpet(level - 1, new RectangleF(x2, y1, width, height)); // middle 1
                DrawCarpet(level - 1, new RectangleF(x3, y1, width, height)); // right 1
                DrawCarpet(level - 1, new RectangleF(x1, y2, width, height)); // left 2
                DrawCarpet(level - 1, new RectangleF(x3, y2, width, height)); // right 2
                DrawCarpet(level - 1, new RectangleF(x1, y3, width, height)); // left 3
                DrawCarpet(level - 1, new RectangleF(x2, y3, width, height)); // middle 3
                DrawCarpet(level - 1, new RectangleF(x3, y3, width, height)); // right 3
            }
        }

        private void NextCarpet_Click(object sender, EventArgs e)
        {
            if (CurrentLevelC > MaxLevelC) CurrentLevelC = 0;
            fractal = new Bitmap(width, height);
            graph = Graphics.FromImage(fractal);
            RectangleF carpet = new RectangleF(0, 0, width, height);
            DrawCarpet(CurrentLevelC, carpet);
            FractalBox.BackgroundImage = fractal;
            CurrentLevelC++;
        }

        private void NextTriangle_Click(object sender, EventArgs e)
        {
            if (CurrentLevelT > MaxLevelT) CurrentLevelT = 0;
            fractal = new Bitmap(width, height);
            graph = Graphics.FromImage(fractal);
            //peaks
            PointF topPoint = new PointF(width / 2f, 0);
            PointF leftPoint = new PointF(0, height);
            PointF rightPoint = new PointF(width, height);
            DrawTriangle(CurrentLevelT, topPoint, leftPoint, rightPoint);
            FractalBox.BackgroundImage = fractal;
            CurrentLevelT++;
        }
    }
}

