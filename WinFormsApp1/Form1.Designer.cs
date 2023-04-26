namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button_panel2 = new Button();
            button_panel1 = new Button();
            panel2 = new Panel();
            input_textBox2 = new TextBox();
            input_textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel_Control11 = new Panel_Control1();
            panel_Control21 = new Panel_Control2();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button_panel2);
            panel1.Controls.Add(button_panel1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 452);
            panel1.TabIndex = 0;
            // 
            // button_panel2
            // 
            button_panel2.Location = new Point(46, 237);
            button_panel2.Name = "button_panel2";
            button_panel2.Size = new Size(103, 53);
            button_panel2.TabIndex = 1;
            button_panel2.Text = "Panel 2";
            button_panel2.UseVisualStyleBackColor = true;
            button_panel2.Click += button_panel2_Click;
            // 
            // button_panel1
            // 
            button_panel1.Location = new Point(46, 122);
            button_panel1.Name = "button_panel1";
            button_panel1.Size = new Size(103, 53);
            button_panel1.TabIndex = 0;
            button_panel1.Text = "Panel 1";
            button_panel1.UseVisualStyleBackColor = true;
            button_panel1.Click += button_panel1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(input_textBox2);
            panel2.Controls.Add(input_textBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(605, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(203, 452);
            panel2.TabIndex = 1;
            // 
            // input_textBox2
            // 
            input_textBox2.Location = new Point(21, 253);
            input_textBox2.Name = "input_textBox2";
            input_textBox2.Size = new Size(148, 23);
            input_textBox2.TabIndex = 7;
            // 
            // input_textBox1
            // 
            input_textBox1.Location = new Point(21, 152);
            input_textBox1.Name = "input_textBox1";
            input_textBox1.Size = new Size(148, 23);
            input_textBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Fuchsia;
            label4.Location = new Point(21, 214);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 5;
            label4.Text = " Input Two: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Fuchsia;
            label3.Location = new Point(21, 122);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = " Input One: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LavenderBlush;
            label2.Location = new Point(21, 46);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 3;
            label2.Text = "Data:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(221, 9);
            label1.Name = "label1";
            label1.Size = new Size(295, 30);
            label1.TabIndex = 2;
            label1.Text = "User Control Panel Application";
            label1.Click += label1_Click;
            // 
            // panel_Control11
            // 
            panel_Control11.BackgroundImage = (Image)resources.GetObject("panel_Control11.BackgroundImage");
            panel_Control11.BackgroundImageLayout = ImageLayout.Stretch;
            panel_Control11.Location = new Point(197, 41);
            panel_Control11.Name = "panel_Control11";
            panel_Control11.Size = new Size(412, 411);
            panel_Control11.TabIndex = 8;
            // 
            // panel_Control21
            // 
            panel_Control21.BackgroundImage = (Image)resources.GetObject("panel_Control21.BackgroundImage");
            panel_Control21.BackgroundImageLayout = ImageLayout.Stretch;
            panel_Control21.Location = new Point(197, 41);
            panel_Control21.Name = "panel_Control21";
            panel_Control21.Size = new Size(412, 427);
            panel_Control21.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.JoJo_s_Bizarre_Adventure_Stardust_Crusaders_TV_Series_790867590_large;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_Control21);
            Controls.Add(panel_Control11);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button_panel2;
        private Button button_panel1;
        private Panel panel2;
        private Label label1;
        private TextBox input_textBox2;
        private TextBox input_textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel_Control1 panel_Control11;
        private Panel_Control2 panel_Control21;
    }
}