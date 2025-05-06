/*
Program: Paint_Project
Purpose: To make a painting application
Authors: Mirza Selimovic, Zach Lacoste, Baba Cisse, Mahmood Ali
Date: 2/16/2025
*/
namespace Paint_Project
{
    public partial class Paint : Form
    {
        public Paint()
        {
            InitializeComponent();
            this.Width = 10000;
            this.Height = 10000;
            bmMap = new Bitmap(pic.Width, pic.Height); //creating a bitmap based off the picture box height and width
            g = Graphics.FromImage(bmMap);
            pic.Image = bmMap; //to show the pixels from bitmap to the the picture box image
            myPen = new Pen(selectedColor, 4);

        }
        private Bitmap bmMap; //to create a canvas for bits of pixels to be stored and saved in memory
        private Graphics g;
        private Color selectedColor = Color.Black; // Default color
        private Pen myPen; //pen
        private Point startPoint, endPoint; //To know the starting and end points when drawing
        private bool painting; //boolean variable to know if 
        private int index;
        int x, y, shapeX, shapeY, currentX, currentY;


        private void Clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Refresh();

        }
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            painting = true;
            endPoint = e.Location;

            currentX = e.X; //set currentX to the current X position of the mouse when pressed down
            currentY = e.Y; //set currentY to the current Y position of the mouse when pressed down
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (painting)
            {
                if (index == 1)
                {
                    startPoint = e.Location;
                    g.DrawLine(myPen, startPoint, endPoint);
                    endPoint = startPoint;

                }
            }
            x = e.X; //get location of mouse
            y = e.Y; //get location of mouse
            shapeX = e.X - currentX; //Get the absolute value of the shapes width
            shapeY = e.Y - currentY; //Get absolute value of the shapes height
            pic.Refresh();
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            painting = false;

            shapeX = x - currentX; //get the abs value of the shape width from the difference of the mouse location
            shapeY = x - currentY; //get the abs value of the shape height from the difference of the mouse location
            if (index == 2)
            {
                g.DrawEllipse(myPen, currentX, currentY, shapeX, shapeY);
            }
            if (index == 3)
            {
                g.DrawRectangle(myPen, currentX, currentY, shapeX, shapeY);
            }
            else if (index == 4)
            {
                g.DrawLine(myPen, currentX, currentY, x, y);
            }
            pic.Refresh();
        }

        private void shapeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (shapeComboBox.SelectedItem.ToString())
            {
                case "Pencil":
                    index = 1;
                    break;
                case "Ellipse":
                    index = 2;
                    break;
                case "Rectangle":
                    index = 3;
                    break;
                case "Line":
                    index = 4;
                    break;
            }
        }

        private void colorComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (colorComboBox.SelectedItem.ToString())
            {
                case "Red":
                    selectedColor = Color.Red;
                    break;
                case "Yellow":
                    selectedColor = Color.Yellow;
                    break;
                case "Green":
                    selectedColor = Color.Green;
                    break;
                case "Blue":
                    selectedColor = Color.Blue;
                    break;
                case "White":
                    selectedColor = Color.White;
                    break;
                case "Black":
                    selectedColor = Color.Black;
                    break;
            }
            myPen.Color = selectedColor;
        }

        private void sizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sizeComboBox.SelectedItem.ToString())
            {
                case "1":
                    myPen.Width = 1;
                    break;
                case "2":
                    myPen.Width = 2;
                    break;
                case "3":
                    myPen.Width = 3;
                    break;
                case "4":
                    myPen.Width = 4;
                    break;
                case "5":
                    myPen.Width = 5;
                    break;
                case "6":
                    myPen.Width = 6;
                    break;
                case "7":
                    myPen.Width = 7;
                    break;
                case "8":
                    myPen.Width = 8;
                    break;
                case "9":
                    myPen.Width = 9;
                    break;
                case "10":
                    myPen.Width = 10;
                    break;
                case "11":
                    myPen.Width = 11;
                    break;
                case "12":
                    myPen.Width = 12;
                    break;
                case "13":
                    myPen.Width = 13;
                    break;
                case "14":
                    myPen.Width = 14;
                    break;
                case "15":
                    myPen.Width = 15;
                    break;
                case "16":
                    myPen.Width = 16;
                    break;
                case "17":
                    myPen.Width = 17;
                    break;
                case "18":
                    myPen.Width = 18;
                    break;
                case "19":
                    myPen.Width = 19;
                    break;
                case "20":
                    myPen.Width = 20;
                    break;
            }

        }
    }
}
