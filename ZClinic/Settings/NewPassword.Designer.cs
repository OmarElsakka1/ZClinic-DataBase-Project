
namespace ZClinic
{
    partial class NewPassword
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
            this.EnterPasstextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasstextBox = new System.Windows.Forms.TextBox();
            this.Donebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // EnterPasstextBox
            // 
            this.EnterPasstextBox.Location = new System.Drawing.Point(137, 54);
            this.EnterPasstextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EnterPasstextBox.Name = "EnterPasstextBox";
            this.EnterPasstextBox.Size = new System.Drawing.Size(215, 20);
            this.EnterPasstextBox.TabIndex = 0;
            // 
            // ConfirmPasstextBox
            // 
            this.ConfirmPasstextBox.Location = new System.Drawing.Point(137, 128);
            this.ConfirmPasstextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfirmPasstextBox.Name = "ConfirmPasstextBox";
            this.ConfirmPasstextBox.Size = new System.Drawing.Size(215, 20);
            this.ConfirmPasstextBox.TabIndex = 1;
            // 
            // Donebutton
            // 
            this.Donebutton.Location = new System.Drawing.Point(165, 194);
            this.Donebutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Donebutton.Name = "Donebutton";
            this.Donebutton.Size = new System.Drawing.Size(154, 32);
            this.Donebutton.TabIndex = 2;
            this.Donebutton.Text = "Done!";
            this.Donebutton.UseVisualStyleBackColor = true;
            this.Donebutton.Click += new System.EventHandler(this.Donebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter new Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm your new Password:";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(261, 37);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(14, 16);
            this.bunifuCustomLabel12.TabIndex = 66;
            this.bunifuCustomLabel12.Text = "*";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(294, 107);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(14, 16);
            this.bunifuCustomLabel1.TabIndex = 67;
            this.bunifuCustomLabel1.Text = "*";
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Donebutton);
            this.Controls.Add(this.ConfirmPasstextBox);
            this.Controls.Add(this.EnterPasstextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewPassword";
            this.Text = "NewPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnterPasstextBox;
        private System.Windows.Forms.TextBox ConfirmPasstextBox;
        private System.Windows.Forms.Button Donebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}