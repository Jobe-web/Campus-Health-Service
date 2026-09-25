namespace Receptionist
{
    partial class CheckPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckPatient));
            btnCheck = new Button();
            label1 = new Label();
            txtCheck = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.Blue;
            btnCheck.Image = Campus_Health_Service.Properties.Resources.check;
            btnCheck.ImageAlign = ContentAlignment.MiddleLeft;
            btnCheck.Location = new Point(144, 217);
            btnCheck.Margin = new Padding(3, 4, 3, 4);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(110, 43);
            btnCheck.TabIndex = 0;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 115);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 1;
            label1.Text = "Student/Staff Number :";
            // 
            // txtCheck
            // 
            txtCheck.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCheck.Location = new Point(57, 163);
            txtCheck.Margin = new Padding(3, 4, 3, 4);
            txtCheck.Name = "txtCheck";
            txtCheck.Size = new Size(319, 27);
            txtCheck.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(134, 40);
            label2.Name = "label2";
            label2.Size = new Size(165, 29);
            label2.TabIndex = 3;
            label2.Text = "New OR Regular";
            // 
            // CheckPatient
            // 
            AcceptButton = btnCheck;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 316);
            Controls.Add(label2);
            Controls.Add(txtCheck);
            Controls.Add(label1);
            Controls.Add(btnCheck);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "CheckPatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckPatient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCheck;
        private Label label1;
        private TextBox txtCheck;
        private Label label2;
    }
}