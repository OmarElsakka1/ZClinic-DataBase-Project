namespace ZClinic
{
    partial class DrugsEntry
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrugsEntry));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Donebutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.FullStockTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.AvailableTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.DrugNameTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Tock = new System.Windows.Forms.PictureBox();
            this.Tick = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Donebutton
            // 
            this.Donebutton.BackColor = System.Drawing.Color.White;
            this.Donebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Donebutton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Donebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.Donebutton.Location = new System.Drawing.Point(318, 244);
            this.Donebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Donebutton.Name = "Donebutton";
            this.Donebutton.Size = new System.Drawing.Size(104, 34);
            this.Donebutton.TabIndex = 26;
            this.Donebutton.Text = "Done!";
            this.Donebutton.UseVisualStyleBackColor = false;
            this.Donebutton.Click += new System.EventHandler(this.Donebutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(203, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Description:";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.DescriptionTextBox.BorderColorFocused = System.Drawing.SystemColors.Window;
            this.DescriptionTextBox.BorderColorIdle = System.Drawing.SystemColors.Window;
            this.DescriptionTextBox.BorderColorMouseHover = System.Drawing.Color.WhiteSmoke;
            this.DescriptionTextBox.BorderThickness = 3;
            this.DescriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DescriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DescriptionTextBox.isPassword = false;
            this.DescriptionTextBox.Location = new System.Drawing.Point(165, 192);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(165, 29);
            this.DescriptionTextBox.TabIndex = 24;
            this.DescriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Should stock full with: ";
            // 
            // FullStockTextBox
            // 
            this.FullStockTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.FullStockTextBox.BorderColorFocused = System.Drawing.SystemColors.Window;
            this.FullStockTextBox.BorderColorIdle = System.Drawing.SystemColors.Window;
            this.FullStockTextBox.BorderColorMouseHover = System.Drawing.Color.WhiteSmoke;
            this.FullStockTextBox.BorderThickness = 3;
            this.FullStockTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FullStockTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FullStockTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FullStockTextBox.isPassword = false;
            this.FullStockTextBox.Location = new System.Drawing.Point(257, 123);
            this.FullStockTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FullStockTextBox.Name = "FullStockTextBox";
            this.FullStockTextBox.Size = new System.Drawing.Size(165, 29);
            this.FullStockTextBox.TabIndex = 20;
            this.FullStockTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Available:";
            // 
            // AvailableTextBox
            // 
            this.AvailableTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.AvailableTextBox.BorderColorFocused = System.Drawing.SystemColors.Window;
            this.AvailableTextBox.BorderColorIdle = System.Drawing.SystemColors.Window;
            this.AvailableTextBox.BorderColorMouseHover = System.Drawing.Color.WhiteSmoke;
            this.AvailableTextBox.BorderThickness = 3;
            this.AvailableTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AvailableTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.AvailableTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AvailableTextBox.isPassword = false;
            this.AvailableTextBox.Location = new System.Drawing.Point(59, 123);
            this.AvailableTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AvailableTextBox.Name = "AvailableTextBox";
            this.AvailableTextBox.Size = new System.Drawing.Size(165, 29);
            this.AvailableTextBox.TabIndex = 18;
            this.AvailableTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Price: ";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.PriceTextBox.BorderColorFocused = System.Drawing.SystemColors.Window;
            this.PriceTextBox.BorderColorIdle = System.Drawing.SystemColors.Window;
            this.PriceTextBox.BorderColorMouseHover = System.Drawing.Color.WhiteSmoke;
            this.PriceTextBox.BorderThickness = 3;
            this.PriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PriceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PriceTextBox.isPassword = false;
            this.PriceTextBox.Location = new System.Drawing.Point(257, 56);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(165, 29);
            this.PriceTextBox.TabIndex = 16;
            this.PriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "DrugName: ";
            // 
            // DrugNameTextBox
            // 
            this.DrugNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.DrugNameTextBox.BorderColorFocused = System.Drawing.SystemColors.Window;
            this.DrugNameTextBox.BorderColorIdle = System.Drawing.SystemColors.Window;
            this.DrugNameTextBox.BorderColorMouseHover = System.Drawing.Color.WhiteSmoke;
            this.DrugNameTextBox.BorderThickness = 3;
            this.DrugNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DrugNameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DrugNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.DrugNameTextBox.isPassword = false;
            this.DrugNameTextBox.Location = new System.Drawing.Point(59, 54);
            this.DrugNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DrugNameTextBox.Name = "DrugNameTextBox";
            this.DrugNameTextBox.Size = new System.Drawing.Size(165, 29);
            this.DrugNameTextBox.TabIndex = 14;
            this.DrugNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.ImageActive")));
            this.bunifuImageButton3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuImageButton3.Location = new System.Drawing.Point(449, 0);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(32, 23);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 27;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Tock
            // 
            this.Tock.Image = global::ZClinic.Properties.Resources.x_rred;
            this.Tock.Location = new System.Drawing.Point(212, 244);
            this.Tock.Name = "Tock";
            this.Tock.Size = new System.Drawing.Size(28, 31);
            this.Tock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tock.TabIndex = 70;
            this.Tock.TabStop = false;
            // 
            // Tick
            // 
            this.Tick.Image = global::ZClinic.Properties.Resources.checkmark_48px;
            this.Tick.Location = new System.Drawing.Point(212, 244);
            this.Tick.Name = "Tick";
            this.Tick.Size = new System.Drawing.Size(28, 31);
            this.Tick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tick.TabIndex = 69;
            this.Tick.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.button1.Location = new System.Drawing.Point(11, 241);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 37);
            this.button1.TabIndex = 68;
            this.button1.Text = "Upload Image";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuImageButton1.Image = global::ZClinic.Properties.Resources.image_48px;
            this.bunifuImageButton1.ImageActive = global::ZClinic.Properties.Resources.image_48px;
            this.bunifuImageButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuImageButton1.Location = new System.Drawing.Point(19, 248);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(32, 23);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 71;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DrugsEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZClinic.Properties.Resources.drugsentry1;
            this.ClientSize = new System.Drawing.Size(483, 317);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.Tock);
            this.Controls.Add(this.Tick);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.Donebutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FullStockTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AvailableTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrugNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DrugsEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DrugsEntry_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button Donebutton;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox DescriptionTextBox;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox FullStockTextBox;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox AvailableTextBox;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox PriceTextBox;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox DrugNameTextBox;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox Tock;
        private System.Windows.Forms.PictureBox Tick;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
