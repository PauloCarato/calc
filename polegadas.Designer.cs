namespace calc
{
    partial class polegadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(polegadas));
            InputCM = new TextBox();
            OutputPolegada = new TextBox();
            label1 = new Label();
            label2 = new Label();
            confirma22 = new Button();
            limpa = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // InputCM
            // 
            InputCM.Location = new Point(59, 42);
            InputCM.Multiline = true;
            InputCM.Name = "InputCM";
            InputCM.Size = new Size(263, 36);
            InputCM.TabIndex = 0;
            // 
            // OutputPolegada
            // 
            OutputPolegada.Location = new Point(59, 272);
            OutputPolegada.Multiline = true;
            OutputPolegada.Name = "OutputPolegada";
            OutputPolegada.Size = new Size(700, 152);
            OutputPolegada.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 19);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 2;
            label1.Text = "Insira o valor em CM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 249);
            label2.Name = "label2";
            label2.Size = new Size(199, 20);
            label2.TabIndex = 3;
            label2.Text = "Valor inserido em polegadas";
            // 
            // confirma22
            // 
            confirma22.Location = new Point(59, 84);
            confirma22.Name = "confirma22";
            confirma22.Size = new Size(94, 29);
            confirma22.TabIndex = 4;
            confirma22.Text = "confirmar";
            confirma22.UseVisualStyleBackColor = true;
            confirma22.Click += confirma22_Click;
            // 
            // limpa
            // 
            limpa.Location = new Point(59, 119);
            limpa.Name = "limpa";
            limpa.Size = new Size(94, 29);
            limpa.TabIndex = 5;
            limpa.Text = "limpar";
            limpa.UseVisualStyleBackColor = true;
            limpa.Click += limpa_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(498, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // polegadas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(limpa);
            Controls.Add(confirma22);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OutputPolegada);
            Controls.Add(InputCM);
            Name = "polegadas";
            Text = "polegadas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputCM;
        private TextBox OutputPolegada;
        private Label label1;
        private Label label2;
        private Button confirma22;
        private Button limpa;
        private PictureBox pictureBox1;
    }
}