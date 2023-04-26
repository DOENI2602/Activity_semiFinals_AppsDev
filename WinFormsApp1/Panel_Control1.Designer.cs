namespace WinFormsApp1
{
    partial class Panel_Control1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            inputOne_text = new TextBox();
            inputTwo_text = new TextBox();
            Submit_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepPink;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 3;
            label1.Text = "Panel One: ";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Fuchsia;
            label3.Location = new Point(17, 85);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 5;
            label3.Text = " Input One: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Fuchsia;
            label2.Location = new Point(17, 166);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 6;
            label2.Text = " Input Two: ";
            // 
            // inputOne_text
            // 
            inputOne_text.Location = new Point(17, 122);
            inputOne_text.Name = "inputOne_text";
            inputOne_text.Size = new Size(187, 23);
            inputOne_text.TabIndex = 7;
            // 
            // inputTwo_text
            // 
            inputTwo_text.Location = new Point(17, 199);
            inputTwo_text.Name = "inputTwo_text";
            inputTwo_text.Size = new Size(187, 23);
            inputTwo_text.TabIndex = 8;
            // 
            // Submit_button
            // 
            Submit_button.BackColor = SystemColors.ButtonShadow;
            Submit_button.Location = new Point(17, 273);
            Submit_button.Name = "Submit_button";
            Submit_button.Size = new Size(100, 49);
            Submit_button.TabIndex = 9;
            Submit_button.Text = "Submit";
            Submit_button.UseVisualStyleBackColor = false;
            Submit_button.Click += Submit_button_Click;
            // 
            // Panel_Control1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._3387284_jotaro_asb_r;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(Submit_button);
            Controls.Add(inputTwo_text);
            Controls.Add(inputOne_text);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Panel_Control1";
            Size = new Size(500, 411);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox inputOne_text;
        private TextBox inputTwo_text;
        private Button Submit_button;
    }
}
