namespace U1_1Dibujos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CboxLinea = new CheckBox();
            CboxCuadrado = new CheckBox();
            CboxRectangulo = new CheckBox();
            CboxOvalo = new CheckBox();
            CboxOvaloRelleno = new CheckBox();
            CboxRandom = new CheckBox();
            btnDibujar = new Button();
            btnDelete = new Button();
            pictureBox1 = new PictureBox();
            colorDialog1 = new ColorDialog();
            btnColor = new Button();
            txtR = new TextBox();
            txtG = new TextBox();
            txtB = new TextBox();
            btnColorRGB = new Button();
            lblR = new Label();
            lblG = new Label();
            lblB = new Label();
            pictureCuadro = new PictureBox();
            lblresultado = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureCuadro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // CboxLinea
            // 
            CboxLinea.AutoSize = true;
            CboxLinea.Location = new Point(14, 7);
            CboxLinea.Margin = new Padding(3, 4, 3, 4);
            CboxLinea.Name = "CboxLinea";
            CboxLinea.Size = new Size(66, 24);
            CboxLinea.TabIndex = 0;
            CboxLinea.Text = "Linea";
            CboxLinea.UseVisualStyleBackColor = true;
            // 
            // CboxCuadrado
            // 
            CboxCuadrado.AutoSize = true;
            CboxCuadrado.Location = new Point(14, 40);
            CboxCuadrado.Margin = new Padding(3, 4, 3, 4);
            CboxCuadrado.Name = "CboxCuadrado";
            CboxCuadrado.Size = new Size(96, 24);
            CboxCuadrado.TabIndex = 1;
            CboxCuadrado.Text = "Cuadrado";
            CboxCuadrado.UseVisualStyleBackColor = true;
            // 
            // CboxRectangulo
            // 
            CboxRectangulo.AutoSize = true;
            CboxRectangulo.Location = new Point(14, 73);
            CboxRectangulo.Margin = new Padding(3, 4, 3, 4);
            CboxRectangulo.Name = "CboxRectangulo";
            CboxRectangulo.Size = new Size(106, 24);
            CboxRectangulo.TabIndex = 2;
            CboxRectangulo.Text = "Rectangulo";
            CboxRectangulo.UseVisualStyleBackColor = true;
            // 
            // CboxOvalo
            // 
            CboxOvalo.AutoSize = true;
            CboxOvalo.Location = new Point(14, 107);
            CboxOvalo.Margin = new Padding(3, 4, 3, 4);
            CboxOvalo.Name = "CboxOvalo";
            CboxOvalo.Size = new Size(70, 24);
            CboxOvalo.TabIndex = 3;
            CboxOvalo.Text = "Ovalo";
            CboxOvalo.UseVisualStyleBackColor = true;
            // 
            // CboxOvaloRelleno
            // 
            CboxOvaloRelleno.AutoSize = true;
            CboxOvaloRelleno.Location = new Point(14, 140);
            CboxOvaloRelleno.Margin = new Padding(3, 4, 3, 4);
            CboxOvaloRelleno.Name = "CboxOvaloRelleno";
            CboxOvaloRelleno.Size = new Size(124, 24);
            CboxOvaloRelleno.TabIndex = 4;
            CboxOvaloRelleno.Text = "Ovalo Relleno";
            CboxOvaloRelleno.UseVisualStyleBackColor = true;
            // 
            // CboxRandom
            // 
            CboxRandom.AutoSize = true;
            CboxRandom.Location = new Point(14, 173);
            CboxRandom.Margin = new Padding(3, 4, 3, 4);
            CboxRandom.Name = "CboxRandom";
            CboxRandom.Size = new Size(87, 24);
            CboxRandom.TabIndex = 5;
            CboxRandom.Text = "Random";
            CboxRandom.UseVisualStyleBackColor = true;
            // 
            // btnDibujar
            // 
            btnDibujar.Location = new Point(14, 207);
            btnDibujar.Margin = new Padding(3, 4, 3, 4);
            btnDibujar.Name = "btnDibujar";
            btnDibujar.Size = new Size(89, 37);
            btnDibujar.TabIndex = 6;
            btnDibujar.Text = "Dibujar";
            btnDibujar.UseVisualStyleBackColor = true;
            btnDibujar.Click += btnDibujar_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(133, 207);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 37);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Borrar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(262, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(603, 425);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseDown += pictureBox1_MouseDown_1;
            pictureBox1.MouseMove += pictureBox1_MouseMove_1;
            pictureBox1.MouseUp += pictureBox1_MouseUp_1;
            pictureBox1.Resize += pictureBox1_Resize;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(106, 351);
            btnColor.Margin = new Padding(3, 4, 3, 4);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(126, 36);
            btnColor.TabIndex = 9;
            btnColor.Text = "Seleccionar Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click_1;
            // 
            // txtR
            // 
            txtR.Location = new Point(133, 16);
            txtR.Margin = new Padding(3, 4, 3, 4);
            txtR.Name = "txtR";
            txtR.Size = new Size(76, 27);
            txtR.TabIndex = 10;
            txtR.Text = "0";
            txtR.TextAlign = HorizontalAlignment.Right;
            // 
            // txtG
            // 
            txtG.Location = new Point(133, 57);
            txtG.Margin = new Padding(3, 4, 3, 4);
            txtG.Name = "txtG";
            txtG.Size = new Size(76, 27);
            txtG.TabIndex = 11;
            txtG.Text = "0";
            txtG.TextAlign = HorizontalAlignment.Right;
            // 
            // txtB
            // 
            txtB.Location = new Point(133, 96);
            txtB.Margin = new Padding(3, 4, 3, 4);
            txtB.Name = "txtB";
            txtB.Size = new Size(76, 27);
            txtB.TabIndex = 12;
            txtB.Text = "0";
            txtB.TextAlign = HorizontalAlignment.Right;
            // 
            // btnColorRGB
            // 
            btnColorRGB.Location = new Point(129, 135);
            btnColorRGB.Margin = new Padding(3, 4, 3, 4);
            btnColorRGB.Name = "btnColorRGB";
            btnColorRGB.Size = new Size(104, 31);
            btnColorRGB.TabIndex = 13;
            btnColorRGB.Text = "Aplicar Color";
            btnColorRGB.UseVisualStyleBackColor = true;
            btnColorRGB.Click += btnColorRGB_Click;
            // 
            // lblR
            // 
            lblR.AutoSize = true;
            lblR.Location = new Point(216, 20);
            lblR.Name = "lblR";
            lblR.Size = new Size(18, 20);
            lblR.TabIndex = 14;
            lblR.Text = "R";
            // 
            // lblG
            // 
            lblG.AutoSize = true;
            lblG.Location = new Point(216, 63);
            lblG.Name = "lblG";
            lblG.Size = new Size(19, 20);
            lblG.TabIndex = 15;
            lblG.Text = "G";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(217, 107);
            lblB.Name = "lblB";
            lblB.Size = new Size(18, 20);
            lblB.TabIndex = 16;
            lblB.Text = "B";
            // 
            // pictureCuadro
            // 
            pictureCuadro.BackColor = Color.Black;
            pictureCuadro.Location = new Point(106, 293);
            pictureCuadro.Margin = new Padding(3, 4, 3, 4);
            pictureCuadro.Name = "pictureCuadro";
            pictureCuadro.Size = new Size(126, 48);
            pictureCuadro.TabIndex = 17;
            pictureCuadro.TabStop = false;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(14, 307);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(98, 20);
            lblresultado.TabIndex = 18;
            lblresultado.Text = "Color Actual: ";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(422, 491);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(151, 153);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            pictureBox2.MouseDown += pictureBox2_MouseDown;
            pictureBox2.MouseMove += pictureBox2_MouseMove;
            pictureBox2.MouseUp += pictureBox2_MouseUp;
            pictureBox2.Resize += pictureBox2_Resize;
            // 
            // button1
            // 
            button1.Location = new Point(239, 493);
            button1.Name = "button1";
            button1.Size = new Size(177, 29);
            button1.TabIndex = 22;
            button1.Text = "Guardar Imagen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(250, 458);
            button2.Name = "button2";
            button2.Size = new Size(157, 29);
            button2.TabIndex = 23;
            button2.Text = "Agregar Imagen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(298, 535);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 24;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 688);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(lblresultado);
            Controls.Add(pictureCuadro);
            Controls.Add(lblB);
            Controls.Add(lblG);
            Controls.Add(lblR);
            Controls.Add(btnColorRGB);
            Controls.Add(txtB);
            Controls.Add(txtG);
            Controls.Add(txtR);
            Controls.Add(btnColor);
            Controls.Add(pictureBox1);
            Controls.Add(btnDelete);
            Controls.Add(btnDibujar);
            Controls.Add(CboxRandom);
            Controls.Add(CboxOvaloRelleno);
            Controls.Add(CboxOvalo);
            Controls.Add(CboxRectangulo);
            Controls.Add(CboxCuadrado);
            Controls.Add(CboxLinea);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureCuadro).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox CboxLinea;
        private CheckBox CboxCuadrado;
        private CheckBox CboxRectangulo;
        private CheckBox CboxOvalo;
        private CheckBox CboxOvaloRelleno;
        private CheckBox CboxRandom;
        private Button btnDibujar;
        private Button btnDelete;
        private PictureBox pictureBox1;
        private ColorDialog colorDialog1;
        private Button btnColor;
        private TextBox txtR;
        private TextBox txtG;
        private TextBox txtB;
        private Button btnColorRGB;
        private Label lblR;
        private Label lblG;
        private Label lblB;
        private PictureBox pictureCuadro;
        private Label lblresultado;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}