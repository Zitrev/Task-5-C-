using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_5_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Draw();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Draw();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Draw();
        }

        public void Draw()
        {
            Bitmap tree = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph_tree = Graphics.FromImage(tree);
          
            Pen pen_brown = new Pen(Color.Brown, 10);
            SolidBrush solid_green = new SolidBrush(Color.Green);
           
            graph_tree.DrawRectangle(pen_brown,95, 160, 10, 10);

           
            Point topPoint = new Point(100, 30);
            Point topPoint1 = new Point(100, 70);
            Point topPoint2 = new Point (100, 110) ;
            int size = 50;

            
            DrawFilledTriangle(graph_tree, solid_green, topPoint, size);
            DrawFilledTriangle(graph_tree, solid_green, topPoint1, size);
            DrawFilledTriangle(graph_tree, solid_green, topPoint2, size);
            
            pictureBox1.Image = tree;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DrawFilledTriangle(Graphics g, Brush brush, Point topPoint, int size)
        {
            
            Point leftPoint = new Point(topPoint.X - size / 2, topPoint.Y + size);
            Point rightPoint = new Point(topPoint.X + size / 2, topPoint.Y + size);

           
            Point[] trianglePoints = { topPoint, leftPoint, rightPoint };

            
            g.FillPolygon(brush, trianglePoints);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Малюнок за варіантом, Варіант 7, ялинка \n © Совєтніков Олександр, 2024,ІПЗ 21к1", "About", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }
    }
}
