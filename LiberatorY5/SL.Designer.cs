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
            this.label1 = new System.Windows.Forms.Label();
            this.ReadThis = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
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
            this.button2.Text = "Change This";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(388, 170);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubisoft Sans", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(363, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 51);
            this.label1.TabIndex = 17;
            this.label1.Text = "Notes:\r\nSituation Only Contains \"Recruit\" Terrorist, it has some operators,\r\nbut " +
    "we dont use them";
            // 
            // ReadThis
            // 
            this.ReadThis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReadThis.ForeColor = System.Drawing.Color.White;
            this.ReadThis.Location = new System.Drawing.Point(388, 139);
            this.ReadThis.Name = "ReadThis";
            this.ReadThis.Size = new System.Drawing.Size(110, 25);
            this.ReadThis.TabIndex = 18;
            this.ReadThis.Text = "Read This";
            this.ReadThis.UseVisualStyleBackColor = true;
            this.ReadThis.Click += new System.EventHandler(this.ReadThis_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(586, 108);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(283, 175);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // SL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(897, 576);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ReadThis);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReadThis;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}