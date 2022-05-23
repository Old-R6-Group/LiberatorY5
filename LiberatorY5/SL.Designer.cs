namespace LiberatorY5
{
    partial class SL
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
            this.BundleDataViewer = new System.Windows.Forms.TreeView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BundleDataViewer
            // 
            this.BundleDataViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.BundleDataViewer.ForeColor = System.Drawing.Color.White;
            this.BundleDataViewer.Location = new System.Drawing.Point(12, 94);
            this.BundleDataViewer.Name = "BundleDataViewer";
            this.BundleDataViewer.ShowLines = false;
            this.BundleDataViewer.Size = new System.Drawing.Size(345, 470);
            this.BundleDataViewer.TabIndex = 11;
            this.BundleDataViewer.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.BundleDataViewer_NodeMouseDoubleClick);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(388, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 25);
            this.button2.TabIndex = 14;
            this.button2.Text = "Send to Siege";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(388, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "Send to Siege";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Ubisoft Sans", 10F);
            this.labelData.ForeColor = System.Drawing.Color.White;
            this.labelData.Location = new System.Drawing.Point(114, 74);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(84, 17);
            this.labelData.TabIndex = 16;
            this.labelData.Text = "Game Datas";
            // 
            // SL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(897, 576);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BundleDataViewer);
            this.Font = new System.Drawing.Font("Ubisoft Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaximizeBox = false;
            this.Name = "SL";
            this.ShowIcon = false;
            this.Text = "Shadow Legacy Inventory Editor";
            this.Load += new System.EventHandler(this.SL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView BundleDataViewer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelData;
    }
}