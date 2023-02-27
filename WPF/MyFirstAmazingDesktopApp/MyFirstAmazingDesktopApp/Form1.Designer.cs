namespace MyFirstAmazingDesktopApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.btn_mbox = new System.Windows.Forms.Button();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Fuchsia;
            this.button1.Location = new System.Drawing.Point(530, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click Me";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl.Location = new System.Drawing.Point(137, 53);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(68, 30);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "label1";
            this.lbl.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            this.lbl.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            // 
            // btn_mbox
            // 
            this.btn_mbox.AutoSize = true;
            this.btn_mbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_mbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mbox.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_mbox.ForeColor = System.Drawing.Color.Fuchsia;
            this.btn_mbox.Location = new System.Drawing.Point(530, 147);
            this.btn_mbox.Name = "btn_mbox";
            this.btn_mbox.Size = new System.Drawing.Size(147, 33);
            this.btn_mbox.TabIndex = 0;
            this.btn_mbox.Text = "Message Box";
            this.btn_mbox.UseVisualStyleBackColor = false;
            this.btn_mbox.Click += new System.EventHandler(this.btn_mbox_Click);
            // 
            // txtbox_name
            // 
            this.txtbox_name.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbox_name.Location = new System.Drawing.Point(49, 144);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(219, 36);
            this.txtbox_name.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btn_mbox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label lbl;
        private Button btn_mbox;
        private TextBox txtbox_name;
    }
}