namespace EIS
{
    partial class Form1
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
            this.NavigationBar = new Z80NavBarControl.Z80_Navigation();
            this.z80_Navigation1 = new Z80NavBarControl.Z80_Navigation();
            this.SuspendLayout();
            // 
            // NavigationBar
            // 
            this.NavigationBar.AutoVerticalScrollBar = false;
            this.NavigationBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavigationBar.Location = new System.Drawing.Point(0, 0);
            this.NavigationBar.Name = "NavigationBar";
            this.NavigationBar.ShowItemsBorder = false;
            this.NavigationBar.Size = new System.Drawing.Size(169, 445);
            this.NavigationBar.TabIndex = 0;
            // 
            // z80_Navigation1
            // 
            this.z80_Navigation1.AutoVerticalScrollBar = false;
            this.z80_Navigation1.Dock = System.Windows.Forms.DockStyle.Right;
            this.z80_Navigation1.Location = new System.Drawing.Point(592, 0);
            this.z80_Navigation1.Name = "z80_Navigation1";
            this.z80_Navigation1.ShowItemsBorder = false;
            this.z80_Navigation1.Size = new System.Drawing.Size(169, 445);
            this.z80_Navigation1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 445);
            this.Controls.Add(this.z80_Navigation1);
            this.Controls.Add(this.NavigationBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Z80NavBarControl.Z80_Navigation NavigationBar;
        private Z80NavBarControl.Z80_Navigation z80_Navigation1;
    }
}

