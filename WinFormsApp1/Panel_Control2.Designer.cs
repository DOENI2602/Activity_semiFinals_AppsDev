namespace WinFormsApp1
{
    partial class Panel_Control2
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
            label2 = new Label();
            label3 = new Label();
            input1_text = new TextBox();
            input2_text = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.GhostWhite;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 4;
            label1.Text = "Panel Two: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.GhostWhite;
            label2.Location = new Point(22, 113);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 5;
            label2.Text = "Input One:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.GhostWhite;
            label3.Location = new Point(22, 211);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 6;
            label3.Text = "Input One:";
            // 
            // input1_text
            // 
            input1_text.Location = new Point(22, 151);
            input1_text.Name = "input1_text";
            input1_text.Size = new Size(187, 23);
            input1_text.TabIndex = 8;
            // 
            // input2_text
            // 
            input2_text.Location = new Point(22, 243);
            input2_text.Name = "input2_text";
            input2_text.Size = new Size(187, 23);
            input2_text.TabIndex = 9;
            // 
            // Panel_Control2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.delb7tq_587727f4_44cd_44af_9b5d_df2003c50a85;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(input2_text);
            Controls.Add(input1_text);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Panel_Control2";
            Size = new Size(449, 427);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox input1_text;
        private TextBox input2_text;
    }
}
