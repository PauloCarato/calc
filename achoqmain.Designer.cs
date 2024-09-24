namespace calc
{
    partial class achoqmain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(achoqmain));
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            pictureBox1 = new PictureBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            imageList1 = new ImageList(components);
            somabutton = new Button();
            subtraçãoButton = new Button();
            IgualButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(291, 195);
            button1.Name = "button1";
            button1.Size = new Size(62, 47);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(71, 28);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(682, 121);
            textBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(359, 195);
            button2.Name = "button2";
            button2.Size = new Size(62, 47);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(427, 195);
            button3.Name = "button3";
            button3.Size = new Size(62, 47);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(359, 267);
            button4.Name = "button4";
            button4.Size = new Size(62, 47);
            button4.TabIndex = 4;
            button4.Text = "5";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(291, 267);
            button5.Name = "button5";
            button5.Size = new Size(62, 47);
            button5.TabIndex = 5;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(427, 267);
            button6.Name = "button6";
            button6.Size = new Size(62, 47);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(315, 335);
            button7.Name = "button7";
            button7.Size = new Size(62, 47);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 195);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // somabutton
            // 
            somabutton.Location = new Point(519, 195);
            somabutton.Name = "somabutton";
            somabutton.Size = new Size(62, 47);
            somabutton.TabIndex = 9;
            somabutton.Text = "+";
            somabutton.UseVisualStyleBackColor = true;
            somabutton.Click += somabutton_Click;
            // 
            // subtraçãoButton
            // 
            subtraçãoButton.Location = new Point(519, 267);
            subtraçãoButton.Name = "subtraçãoButton";
            subtraçãoButton.Size = new Size(62, 47);
            subtraçãoButton.TabIndex = 10;
            subtraçãoButton.Text = "-";
            subtraçãoButton.UseVisualStyleBackColor = true;
            subtraçãoButton.Click += subtraçãoButton_Click;
            // 
            // IgualButton
            // 
            IgualButton.Location = new Point(519, 335);
            IgualButton.Name = "IgualButton";
            IgualButton.Size = new Size(62, 47);
            IgualButton.TabIndex = 11;
            IgualButton.Text = "=";
            IgualButton.UseVisualStyleBackColor = true;
            IgualButton.Click += IgualButton_Click;
            // 
            // achoqmain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IgualButton);
            Controls.Add(subtraçãoButton);
            Controls.Add(somabutton);
            Controls.Add(pictureBox1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "achoqmain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "vv";
            Load += achoqmain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private PictureBox pictureBox1;
        private FileSystemWatcher fileSystemWatcher1;
        private ImageList imageList1;
        private Button IgualButton;
        private Button subtraçãoButton;
        private Button somabutton;
    }
}