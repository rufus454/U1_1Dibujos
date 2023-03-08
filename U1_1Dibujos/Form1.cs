using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace U1_1Dibujos
{
    public partial class Form1 : Form
    {
        int size = 100;
        int size2 = 50;
        Control draggedPiece = null;
        bool resizing = false;
        private Point startDraggingPoint;
        private Size startSize;
        Rectangle rectProposedSize = Rectangle.Empty;
        int resizingMargin = 5;

        Pen Lapiz = new Pen(Color.Black);
        Brush brocha = new SolidBrush(Color.Blue);

        private bool drawing = false;
        private Point lastPoint;
        private Pen currentPen = new Pen(Color.Black, 5);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            size = (int)(pictureBox1.Width * .25);
            size2 = (int)(pictureBox2.Width * .5);
        }

        /**
         * *********************** Métodos para el resize ***********************
         */
        void mouseDown(object sender, MouseEventArgs e)
        {
            draggedPiece = sender as Control;

            if ((e.X <= resizingMargin) || (e.X >= draggedPiece.Width - resizingMargin) ||
                (e.Y <= resizingMargin) || (e.Y >= draggedPiece.Height - resizingMargin))
            {
                resizing = true;
                this.Cursor = Cursors.SizeNWSE;

                this.startSize = new Size(e.X, e.Y);
                Point pt = this.PointToScreen(draggedPiece.Location);
                rectProposedSize = new Rectangle(pt, startSize);
                ControlPaint.DrawReversibleFrame(rectProposedSize, this.ForeColor, FrameStyle.Dashed);
            }
            else
            {
                resizing = false;
                this.Cursor = Cursors.SizeAll;
            }

            this.startDraggingPoint = e.Location;
        }

        void mouseMove(object sender, MouseEventArgs e)
        {
            //if (draggedPiece != null)
            //{
            //  if (resizing)
            //{
            //  if (rectProposedSize.Width > 0 && rectProposedSize.Height > 0)
            //    ControlPaint.DrawReversibleFrame(rectProposedSize, this.ForeColor, FrameStyle.Dashed);
            //rectProposedSize.Width = e.X - this.startDraggingPoint.X + this.startSize.Width;
            // rectProposedSize.Height = e.Y - this.startDraggingPoint.Y + this.startSize.Height;
            // if (rectProposedSize.Width > 0 && rectProposedSize.Height > 0)
            //      ControlPaint.DrawReversibleFrame(rectProposedSize, this.ForeColor, FrameStyle.Dashed);
            //}
            //else
            //{
            //   Point pt;
            //  if (draggedPiece == sender)
            //     pt = new Point(e.X, e.Y);
            //else
            //   pt = draggedPiece.PointToClient((sender as Control).PointToScreen(new Point(e.X, e.Y)));

            //draggedPiece.Left += pt.X - this.startDraggingPoint.X;
            //draggedPiece.Top += pt.Y - this.startDraggingPoint.Y;
            //}
            //}
        }

        void mouseUp(object sender, MouseEventArgs e)
        {
            if (resizing)
            {
                try
                {
                    if (rectProposedSize.Width > 0 && rectProposedSize.Height > 0)
                    {
                        ControlPaint.DrawReversibleFrame(rectProposedSize, this.ForeColor, FrameStyle.Dashed);
                    }
                    if (rectProposedSize.Width > 10 && rectProposedSize.Height > 10)
                    {
                        if (this.draggedPiece != null) this.draggedPiece.Size = rectProposedSize.Size;
                    }
                    else
                    {
                        this.draggedPiece.Size = new Size((int)Math.Max(10, rectProposedSize.Width), Math.Max(10, rectProposedSize.Height));
                    }
                }
                catch (Exception ex)
                {
                    return;
                }
            }

            this.draggedPiece = null;
            this.startDraggingPoint = Point.Empty;
            this.Cursor = Cursors.Default;
        }

        /**
         * *********************** Fin métodos para el resize ***********************
         */


        /**
         * *********************** Métodos de dibujado ***********************
         */

        void drawPictureBox(PictureBox pictureBox)
        {
            if (pictureBox == pictureBox2)
            {
                size2 = (int)(pictureBox.Width * .5);
            }
            else
            {
                size = (int)(pictureBox.Width * .25);
            }


            if (pictureBox.Image != null)
            {
                clearPictureBox(pictureBox);
            }

            Graphics papel = pictureBox.CreateGraphics();
            papel.Clear(pictureBox.BackColor);

            //DIBUJAR
            if (CboxLinea.Checked)
            {
                if (pictureBox == pictureBox2)
                {
                    papel.DrawRectangle(Lapiz, pictureBox.Width / 2, pictureBox.Height / 2 - size2 / 2, 1, size2);
                }
                else
                {
                    papel.DrawRectangle(Lapiz, (int)(pictureBox.Width * .1), (int)(pictureBox.Height * .20), 1, size);
                }

            }
            if (CboxRectangulo.Checked)
            {
                if (pictureBox == pictureBox2)
                {
                    papel.DrawRectangle(Lapiz, pictureBox.Width / 2 - size2 / 2, pictureBox.Height / 2 - size2 / 4, size2, size2 / 2);
                }
                else
                {
                    papel.DrawRectangle(Lapiz, (int)(pictureBox.Width * .025), (int)(pictureBox.Height * .009), size, size / 2);
                }
            }
            if (CboxCuadrado.Checked)
            {
                if (pictureBox == pictureBox2)
                {
                    papel.DrawRectangle(Lapiz, pictureBox.Width / 2 - size2 / 2, pictureBox.Height / 2 - size2 / 2, size2, size2);
                }
                else
                {
                    papel.DrawRectangle(Lapiz, (int)(pictureBox.Width * .15), (int)(pictureBox.Height * .25), size, size);
                }
            }
            if (CboxOvalo.Checked)
            {
                if (pictureBox == pictureBox2)
                {
                    papel.DrawEllipse(Lapiz, pictureBox.Width / 2 - (size2 / 2) - (size2 / 4), pictureBox.Height / 2 - size2 / 2, (size2 / 2) + size2, size2);
                }
                else
                {

                    Rectangle rect = new Rectangle((int)(pictureBox.Width * .20), (int)(pictureBox.Height * .35), (size / 2) + size, size);
                    papel.DrawEllipse(Lapiz, rect);
                }
            }
            if (CboxOvaloRelleno.Checked)
            {
                if (pictureBox == pictureBox2)
                {
                    papel.FillEllipse(brocha, pictureBox.Width / 2 - (size2 / 2) - (size2 / 4), pictureBox.Height / 2 - size2 / 2, (size2 / 2) + size2, size2);
                }
                else
                {
                    Rectangle rect = new Rectangle((int)(pictureBox.Width * .30), (int)(pictureBox.Height * .15), (size / 2) + size, size);
                    papel.FillEllipse(brocha, rect);
                }
            }
            if (pictureBox == pictureBox1)
            {
                if (CboxRandom.Checked && CboxLinea.Checked)
                {
                    Random rnd = new Random();
                    int x = rnd.Next(pictureBox1.Width - 100);
                    int y = rnd.Next(pictureBox1.Height - 100);
                    int ancho = rnd.Next(1, 1);
                    int alto = rnd.Next(50, 101);
                    Rectangle rect = new Rectangle(x, y, ancho, alto);
                    papel.DrawRectangle(Lapiz, rect);
                }
                if (CboxRandom.Checked && CboxRectangulo.Checked)
                {
                    Random rnd = new Random();
                    int x = rnd.Next(pictureBox1.Width - 100);
                    int y = rnd.Next(pictureBox1.Height - 100);
                    int ancho = rnd.Next(80, 80);
                    int alto = rnd.Next(50, 50);
                    Rectangle rect = new Rectangle(x, y, ancho, alto);
                    papel.DrawRectangle(Lapiz, rect);
                }
                if (CboxRandom.Checked && CboxCuadrado.Checked)
                {
                    Random rnd = new Random();
                    int x = rnd.Next(pictureBox1.Width - 100);
                    int y = rnd.Next(pictureBox1.Height - 100);
                    int ancho = rnd.Next(50, 50);
                    int alto = rnd.Next(50, 50);
                    Rectangle rect = new Rectangle(x, y, ancho, alto);
                    papel.DrawRectangle(Lapiz, rect);
                }
                if (CboxOvalo.Checked && CboxRandom.Checked)
                {
                    Random rnd = new Random();
                    int x = rnd.Next(pictureBox1.Width - 100);
                    int y = rnd.Next(pictureBox1.Height - 100);
                    int ancho = rnd.Next(50, 101);
                    int alto = rnd.Next(50, 101);
                    Rectangle rect = new Rectangle(x, y, ancho, alto);
                    papel.DrawEllipse(Lapiz, rect);
                }
                if (CboxOvaloRelleno.Checked && CboxRandom.Checked)
                {
                    Random rnd = new Random();
                    int x = rnd.Next(pictureBox1.Width - 100);
                    int y = rnd.Next(pictureBox1.Height - 100);
                    int ancho = rnd.Next(50, 101);
                    int alto = rnd.Next(50, 101);
                    Rectangle rect = new Rectangle(x, y, ancho, alto);
                    papel.FillEllipse(brocha, rect);
                }
            }
        }

        /**
         * *********************** Fin métodos de dibujado ***********************
         */

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialogoColor = new ColorDialog();
            if (dialogoColor.ShowDialog() == DialogResult.OK)
            {
                Lapiz.Color = dialogoColor.Color;
                pictureCuadro.BackColor = dialogoColor.Color;
            }
        }

        private void txtR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }


        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                currentPen.Color = colorDialog.Color;
            }
        }

        private void buttonEraser_Click(object sender, EventArgs e)
        {
            currentPen.Color = pictureBox1.BackColor;
        }

        void clearPictureBox(PictureBox pictureBox)
        {
            using (Graphics g = Graphics.FromImage(pictureBox.Image))
            {
                g.Clear(pictureBox.BackColor);
            }
            pictureBox.Invalidate();
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearPictureBox(pictureBox1);
            clearPictureBox(pictureBox2);
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {

            drawPictureBox(pictureBox1);
            drawPictureBox(pictureBox2);

        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            /** Descomentar esta parte si se quiere usar el picturebox como lienzo para dibujar */
            drawing = true;
            lastPoint = e.Location;

            mouseDown(sender, e);
        }

        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
            /** Descomentar esta parte si se quiere usar el picturebox como lienzo para dibujar */
            drawing = false;

            mouseUp(sender, e);
        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            /** Descomentar esta parte si se quiere usar el picturebox como lienzo para dibujar */
            if (drawing)
            {
                if (pictureBox1.Image == null)
                {
                    Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.Image = bmp;
                }
                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    g.DrawLine(currentPen, lastPoint, e.Location);
                    lastPoint = e.Location;
                }
                pictureBox1.Invalidate();

                txtR.Text = 0.ToString();
                txtG.Text = 0.ToString();
                txtB.Text = 0.ToString();
            }

            mouseMove(sender, e);
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            drawPictureBox(pictureBox1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown(sender, e);
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUp(sender, e);
        }

        private void pictureBox2_Resize(object sender, EventArgs e)
        {
            drawPictureBox(pictureBox2);
        }

        private void btnColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog dialogoColor = new ColorDialog();
            if (dialogoColor.ShowDialog() == DialogResult.OK)
            {
                Lapiz.Color = dialogoColor.Color;
                pictureCuadro.BackColor = dialogoColor.Color;

            }
        }

        private void btnColorRGB_Click(object sender, EventArgs e)
        {
            int r = 0, g = 0, b = 0;
            if (int.TryParse(txtR.Text, out r) && int.TryParse(txtG.Text, out g) && int.TryParse(txtB.Text, out b))
            {
                if (r >= 0 && r <= 255 && g >= 0 && g <= 255 && b >= 0 && b <= 255)
                {
                    Lapiz.Color = Color.FromArgb(r, g, b);
                    txtB.BackColor = Color.FromArgb(0, 0, b);
                    txtG.BackColor = Color.FromArgb(0, g, 0);
                    txtR.BackColor = Color.FromArgb(r, 0, 0);
                    pictureCuadro.BackColor = Color.FromArgb(r, g, b);
                    if (r == 0 || g == 0 || b == 0)
                    {
                        if (r == 0 && g != 0 && b != 0) txtR.ForeColor = Color.FromArgb(255, 255, 255);

                        if (r != 0 && g == 0 && b != 0) txtG.ForeColor = Color.FromArgb(255, 255, 255);

                        if (r != 0 && g != 0 && b == 0) txtB.ForeColor = Color.FromArgb(255, 255, 255);

                        txtB.ForeColor = Color.FromArgb(255, 255, 255);
                        txtG.ForeColor = Color.FromArgb(255, 255, 255);
                        txtR.ForeColor = Color.FromArgb(255, 255, 255);
                    }
                    else
                    {
                        txtB.ForeColor = Color.FromArgb(255, 255, 255);
                        txtG.ForeColor = Color.FromArgb(255, 255, 255);
                        txtR.ForeColor = Color.FromArgb(255, 255, 255);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese valores R, G y B válidos (entre 0 y 255).");
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos para R, G y B.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Guarda la imagen actual en el disco
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Carga la imagen seleccionada en el control PictureBox
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            drawPictureBox(pictureBox1);
            drawPictureBox(pictureBox2);



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}