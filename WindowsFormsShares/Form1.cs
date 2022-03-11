using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryShapes;

namespace WindowsFormsShares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            double perimeter = double.Parse(textBoxPerimeter.Text);
            double square = ClassShapes.TriangleSquare(perimeter);
            textBoxTriangleSquare.Text = square.ToString();
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            double perimeter = double.Parse(textBoxPerimeter.Text);
            double square = ClassShapes.CircleSquare(perimeter);
            textBoxCircleSquare.Text = square.ToString();
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            double perimeter = double.Parse(textBoxPerimeter.Text);
            double square = ClassShapes.SquareArea(perimeter);
            textBoxSquareArea.Text = square.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            double perimeter = double.Parse(textBoxPerimeter.Text);
            double square = ClassShapes.RectangleSquare(perimeter);
            textBoxRectangleSquare.Text = square.ToString();
        }

        private void buttonRhombus_Click(object sender, EventArgs e)
        {
            double perimeter = double.Parse(textBoxPerimeter.Text);
            double square = ClassShapes.RhombusSquare(perimeter);
            textBoxRhombusSquare.Text = square.ToString();
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
