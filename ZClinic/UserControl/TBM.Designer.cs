
namespace ZClinic
{
    partial class TBM
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
            this.components = new System.ComponentModel.Container();
            this.bunifuMetroTextbox7 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuMetroTextbox7
            // 
            this.bunifuMetroTextbox7.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox7.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox7.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox7.BorderThickness = 3;
            this.bunifuMetroTextbox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox7.isPassword = false;
            this.bunifuMetroTextbox7.Location = new System.Drawing.Point(2, 4);
            this.bunifuMetroTextbox7.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox7.Name = "bunifuMetroTextbox7";
            this.bunifuMetroTextbox7.Size = new System.Drawing.Size(370, 37);
            this.bunifuMetroTextbox7.TabIndex = 64;
            this.bunifuMetroTextbox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMetroTextbox7.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox7_OnValueChanged);
            this.bunifuMetroTextbox7.Load += new System.EventHandler(this.bunifuMetroTextbox7_Load);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuImageButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuImageButton5.Image = global::ZClinic.Properties.Resources.minus_48px;
            this.bunifuImageButton5.ImageActive = global::ZClinic.Properties.Resources.minus_48px;
            this.bunifuImageButton5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuImageButton5.Location = new System.Drawing.Point(375, 8);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(38, 29);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 71;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 10;
            this.bunifuImageButton5.Click += new System.EventHandler(this.bunifuImageButton5_Click);
            // 
            // TBM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuImageButton5);
            this.Controls.Add(this.bunifuMetroTextbox7);
            this.Name = "TBM";
            this.Size = new System.Drawing.Size(416, 45);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
    }
}
