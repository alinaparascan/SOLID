namespace DogDoor
{
    partial class fDoggyBusiness
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
            this.bDoStuff = new System.Windows.Forms.Button();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bDoStuff
            // 
            this.bDoStuff.Location = new System.Drawing.Point(13, 12);
            this.bDoStuff.Name = "bDoStuff";
            this.bDoStuff.Size = new System.Drawing.Size(119, 35);
            this.bDoStuff.TabIndex = 0;
            this.bDoStuff.Text = "Do stuff";
            this.bDoStuff.UseVisualStyleBackColor = true;
            this.bDoStuff.Click += new System.EventHandler(this.bDoStuff_Click);
            // 
            // rtbResult
            // 
            this.rtbResult.Enabled = false;
            this.rtbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbResult.Location = new System.Drawing.Point(13, 53);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(451, 288);
            this.rtbResult.TabIndex = 1;
            this.rtbResult.Text = "";
            // 
            // fDoggyBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(476, 366);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.bDoStuff);
            this.Name = "fDoggyBusiness";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoggyBusiness";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bDoStuff;
        private System.Windows.Forms.RichTextBox rtbResult;
    }
}

