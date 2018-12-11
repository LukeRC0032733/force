namespace force
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbx1 = new System.Windows.Forms.TextBox();
            this.txtbx2 = new System.Windows.Forms.TextBox();
            this.calculate1 = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::force.Properties.Resources.angle2;
            this.pictureBox1.Location = new System.Drawing.Point(185, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 374);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtbx1
            // 
            this.txtbx1.Location = new System.Drawing.Point(309, 321);
            this.txtbx1.Name = "txtbx1";
            this.txtbx1.Size = new System.Drawing.Size(51, 20);
            this.txtbx1.TabIndex = 1;
            // 
            // txtbx2
            // 
            this.txtbx2.Location = new System.Drawing.Point(270, 450);
            this.txtbx2.Name = "txtbx2";
            this.txtbx2.Size = new System.Drawing.Size(51, 20);
            this.txtbx2.TabIndex = 2;
            // 
            // calculate1
            // 
            this.calculate1.Location = new System.Drawing.Point(545, 504);
            this.calculate1.Name = "calculate1";
            this.calculate1.Size = new System.Drawing.Size(75, 23);
            this.calculate1.TabIndex = 3;
            this.calculate1.Text = "calculate";
            this.calculate1.UseVisualStyleBackColor = true;
            this.calculate1.Click += new System.EventHandler(this.calculate1_Click);
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(321, 389);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(0, 13);
            this.answer.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 662);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.calculate1);
            this.Controls.Add(this.txtbx2);
            this.Controls.Add(this.txtbx1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbx1;
        private System.Windows.Forms.TextBox txtbx2;
        private System.Windows.Forms.Button calculate1;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

