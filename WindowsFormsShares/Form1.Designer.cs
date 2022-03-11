
namespace WindowsFormsShares
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPerimeter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTriangleSquare = new System.Windows.Forms.TextBox();
            this.textBoxCircleSquare = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSquareArea = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxRectangleSquare = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxRhombusSquare = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonRhombus = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(500, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Площади геометрических фигур";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Площадь Треугольника";
            // 
            // textBoxPerimeter
            // 
            this.textBoxPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPerimeter.Location = new System.Drawing.Point(205, 565);
            this.textBoxPerimeter.Name = "textBoxPerimeter";
            this.textBoxPerimeter.Size = new System.Drawing.Size(100, 26);
            this.textBoxPerimeter.TabIndex = 2;
            this.textBoxPerimeter.Text = "10,23";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(111, 567);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Периметр ";
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.Location = new System.Drawing.Point(20, 94);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(257, 41);
            this.buttonTriangle.TabIndex = 4;
            this.buttonTriangle.Text = "Вычислить площадь треугольника";
            this.buttonTriangle.UseVisualStyleBackColor = true;
            this.buttonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Площадь";
            // 
            // textBoxTriangleSquare
            // 
            this.textBoxTriangleSquare.Location = new System.Drawing.Point(96, 149);
            this.textBoxTriangleSquare.Name = "textBoxTriangleSquare";
            this.textBoxTriangleSquare.Size = new System.Drawing.Size(181, 20);
            this.textBoxTriangleSquare.TabIndex = 6;
            // 
            // textBoxCircleSquare
            // 
            this.textBoxCircleSquare.Location = new System.Drawing.Point(469, 149);
            this.textBoxCircleSquare.Name = "textBoxCircleSquare";
            this.textBoxCircleSquare.Size = new System.Drawing.Size(181, 20);
            this.textBoxCircleSquare.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(388, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Площадь";
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(393, 94);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(257, 41);
            this.buttonCircle.TabIndex = 10;
            this.buttonCircle.Text = "Вычислить площадь круга\r\n";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(388, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Площадь Круга\r\n";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxSquareArea
            // 
            this.textBoxSquareArea.Location = new System.Drawing.Point(814, 149);
            this.textBoxSquareArea.Name = "textBoxSquareArea";
            this.textBoxSquareArea.Size = new System.Drawing.Size(181, 20);
            this.textBoxSquareArea.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(733, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Площадь";
            // 
            // buttonSquare
            // 
            this.buttonSquare.Location = new System.Drawing.Point(738, 94);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(257, 41);
            this.buttonSquare.TabIndex = 16;
            this.buttonSquare.Text = "Вычислить площадь квадрата\r\n";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(735, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 36);
            this.label10.TabIndex = 13;
            this.label10.Text = "Площадь Квадрата\r\n\r\n";
            // 
            // textBoxRectangleSquare
            // 
            this.textBoxRectangleSquare.Location = new System.Drawing.Point(96, 319);
            this.textBoxRectangleSquare.Name = "textBoxRectangleSquare";
            this.textBoxRectangleSquare.Size = new System.Drawing.Size(181, 20);
            this.textBoxRectangleSquare.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(15, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "Площадь";
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Location = new System.Drawing.Point(20, 264);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(257, 41);
            this.buttonRectangle.TabIndex = 22;
            this.buttonRectangle.Text = "Вычислить площадь  прямоугольника\r\n";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(17, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(236, 54);
            this.label13.TabIndex = 19;
            this.label13.Text = "Площадь Прямоугольника ,у которого\r\n одна сторона в 2 раза больше другого\r\n\r\n";
            // 
            // textBoxRhombusSquare
            // 
            this.textBoxRhombusSquare.Location = new System.Drawing.Point(467, 319);
            this.textBoxRhombusSquare.Name = "textBoxRhombusSquare";
            this.textBoxRhombusSquare.Size = new System.Drawing.Size(181, 20);
            this.textBoxRhombusSquare.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(386, 319);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 18);
            this.label14.TabIndex = 29;
            this.label14.Text = "Площадь";
            // 
            // buttonRhombus
            // 
            this.buttonRhombus.Location = new System.Drawing.Point(391, 264);
            this.buttonRhombus.Name = "buttonRhombus";
            this.buttonRhombus.Size = new System.Drawing.Size(257, 41);
            this.buttonRhombus.TabIndex = 28;
            this.buttonRhombus.Text = "Вычислить площадь ромба\r\n";
            this.buttonRhombus.UseVisualStyleBackColor = true;
            this.buttonRhombus.Click += new System.EventHandler(this.buttonRhombus_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(390, 207);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(235, 54);
            this.label16.TabIndex = 25;
            this.label16.Text = "Площадь Ромба который состоит \r\nиз 2-х равносторонних треугольников\r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 691);
            this.Controls.Add(this.textBoxRhombusSquare);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.buttonRhombus);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxRectangleSquare);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonRectangle);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxSquareArea);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxCircleSquare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCircle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTriangleSquare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonTriangle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPerimeter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TextChanged += new System.EventHandler(this.Form1_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPerimeter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTriangleSquare;
        private System.Windows.Forms.TextBox textBoxCircleSquare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSquareArea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxRectangleSquare;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxRhombusSquare;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonRhombus;
        private System.Windows.Forms.Label label16;
    }
}

