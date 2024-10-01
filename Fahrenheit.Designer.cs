namespace calc
{
    partial class Fahrenheit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fahrenheit));
            InputTemp = new TextBox();
            BotaoInput = new Button();
            OutputTemp = new TextBox();
            labelOutput = new Label();
            labelInput = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // InputTemp
            // 
            InputTemp.Location = new Point(12, 36);
            InputTemp.Multiline = true;
            InputTemp.Name = "InputTemp";
            InputTemp.Size = new Size(367, 34);
            InputTemp.TabIndex = 0;
            // 
            // BotaoInput
            // 
            BotaoInput.Location = new Point(12, 76);
            BotaoInput.Name = "BotaoInput";
            BotaoInput.Size = new Size(135, 34);
            BotaoInput.TabIndex = 1;
            BotaoInput.Text = "Converter";
            BotaoInput.UseVisualStyleBackColor = true;
            BotaoInput.Click += BotaoInput_Click;
            // 
            // OutputTemp
            // 
            OutputTemp.Location = new Point(12, 217);
            OutputTemp.Multiline = true;
            OutputTemp.Name = "OutputTemp";
            OutputTemp.ReadOnly = true;
            OutputTemp.Size = new Size(785, 105);
            OutputTemp.TabIndex = 2;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(12, 194);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(187, 20);
            labelOutput.TabIndex = 3;
            labelOutput.Text = "temperatura em fahrenheit";
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(12, 13);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(218, 20);
            labelInput.TabIndex = 4;
            labelInput.Text = "Forneça o valor da temperatura";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(503, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(244, 76);
            button1.Name = "button1";
            button1.Size = new Size(135, 34);
            button1.TabIndex = 6;
            button1.Text = "Limpar Tudo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Fahrenheit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 334);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(labelInput);
            Controls.Add(labelOutput);
            Controls.Add(OutputTemp);
            Controls.Add(BotaoInput);
            Controls.Add(InputTemp);
            Name = "Fahrenheit";
            Text = "Fahrenheit";
            Load += Fahrenheit_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputTemp;
        private Button BotaoInput;
        private TextBox OutputTemp;
        private Label labelOutput;
        private Label labelInput;
        private PictureBox pictureBox1;
        private Button button1;
    }
}