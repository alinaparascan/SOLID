namespace MagazinChitare
{
    partial class fSearch
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
            this.lConstructor = new System.Windows.Forms.Label();
            this.lModel = new System.Windows.Forms.Label();
            this.llemnFata = new System.Windows.Forms.Label();
            this.lLemnSpate = new System.Windows.Forms.Label();
            this.lTip = new System.Windows.Forms.Label();
            this.lTitlu = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.rtbRezultat = new System.Windows.Forms.RichTextBox();
            this.bCauta = new System.Windows.Forms.Button();
            this.biesire = new System.Windows.Forms.Button();
            this.cbTipChitara = new System.Windows.Forms.ComboBox();
            this.cbLemnSpate = new System.Windows.Forms.ComboBox();
            this.cbConstructor = new System.Windows.Forms.ComboBox();
            this.cbLemnFata = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lConstructor
            // 
            this.lConstructor.AutoSize = true;
            this.lConstructor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lConstructor.Location = new System.Drawing.Point(348, 69);
            this.lConstructor.Name = "lConstructor";
            this.lConstructor.Size = new System.Drawing.Size(89, 17);
            this.lConstructor.TabIndex = 0;
            this.lConstructor.Text = "Constructor :";
            // 
            // lModel
            // 
            this.lModel.AutoSize = true;
            this.lModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lModel.Location = new System.Drawing.Point(12, 99);
            this.lModel.Name = "lModel";
            this.lModel.Size = new System.Drawing.Size(130, 17);
            this.lModel.TabIndex = 1;
            this.lModel.Text = "Model(poate fi gol):";
            // 
            // llemnFata
            // 
            this.llemnFata.AutoSize = true;
            this.llemnFata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.llemnFata.Location = new System.Drawing.Point(348, 100);
            this.llemnFata.Name = "llemnFata";
            this.llemnFata.Size = new System.Drawing.Size(79, 17);
            this.llemnFata.TabIndex = 2;
            this.llemnFata.Text = "Lemn fata :";
            // 
            // lLemnSpate
            // 
            this.lLemnSpate.AutoSize = true;
            this.lLemnSpate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lLemnSpate.Location = new System.Drawing.Point(12, 132);
            this.lLemnSpate.Name = "lLemnSpate";
            this.lLemnSpate.Size = new System.Drawing.Size(90, 17);
            this.lLemnSpate.TabIndex = 3;
            this.lLemnSpate.Text = "Lemn spate :";
            // 
            // lTip
            // 
            this.lTip.AutoSize = true;
            this.lTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lTip.Location = new System.Drawing.Point(12, 66);
            this.lTip.Name = "lTip";
            this.lTip.Size = new System.Drawing.Size(83, 17);
            this.lTip.TabIndex = 4;
            this.lTip.Text = "Tip chitara :";
            // 
            // lTitlu
            // 
            this.lTitlu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTitlu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lTitlu.Location = new System.Drawing.Point(0, 0);
            this.lTitlu.Name = "lTitlu";
            this.lTitlu.Size = new System.Drawing.Size(664, 54);
            this.lTitlu.TabIndex = 5;
            this.lTitlu.Text = "Cautare chitara";
            this.lTitlu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(148, 98);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(189, 22);
            this.tbModel.TabIndex = 2;
            this.tbModel.Tag = "Poate fi lasat gol";
            // 
            // rtbRezultat
            // 
            this.rtbRezultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbRezultat.ForeColor = System.Drawing.Color.Maroon;
            this.rtbRezultat.Location = new System.Drawing.Point(12, 172);
            this.rtbRezultat.Name = "rtbRezultat";
            this.rtbRezultat.ReadOnly = true;
            this.rtbRezultat.Size = new System.Drawing.Size(639, 169);
            this.rtbRezultat.TabIndex = 11;
            this.rtbRezultat.Text = "";
            // 
            // bCauta
            // 
            this.bCauta.Location = new System.Drawing.Point(351, 123);
            this.bCauta.Name = "bCauta";
            this.bCauta.Size = new System.Drawing.Size(147, 33);
            this.bCauta.TabIndex = 6;
            this.bCauta.Text = "Cauta";
            this.bCauta.UseVisualStyleBackColor = true;
            this.bCauta.Click += new System.EventHandler(this.bCauta_Click);
            // 
            // biesire
            // 
            this.biesire.Location = new System.Drawing.Point(504, 122);
            this.biesire.Name = "biesire";
            this.biesire.Size = new System.Drawing.Size(147, 33);
            this.biesire.TabIndex = 7;
            this.biesire.Text = "Iesire";
            this.biesire.UseVisualStyleBackColor = true;
            this.biesire.Click += new System.EventHandler(this.biesire_Click);
            // 
            // cbTipChitara
            // 
            this.cbTipChitara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipChitara.FormattingEnabled = true;
            this.cbTipChitara.Location = new System.Drawing.Point(148, 66);
            this.cbTipChitara.Name = "cbTipChitara";
            this.cbTipChitara.Size = new System.Drawing.Size(189, 24);
            this.cbTipChitara.TabIndex = 0;
            // 
            // cbLemnSpate
            // 
            this.cbLemnSpate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLemnSpate.FormattingEnabled = true;
            this.cbLemnSpate.Location = new System.Drawing.Point(148, 128);
            this.cbLemnSpate.Name = "cbLemnSpate";
            this.cbLemnSpate.Size = new System.Drawing.Size(189, 24);
            this.cbLemnSpate.TabIndex = 3;
            // 
            // cbConstructor
            // 
            this.cbConstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConstructor.FormattingEnabled = true;
            this.cbConstructor.Location = new System.Drawing.Point(443, 66);
            this.cbConstructor.Name = "cbConstructor";
            this.cbConstructor.Size = new System.Drawing.Size(208, 24);
            this.cbConstructor.TabIndex = 4;
            // 
            // cbLemnFata
            // 
            this.cbLemnFata.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLemnFata.FormattingEnabled = true;
            this.cbLemnFata.Location = new System.Drawing.Point(443, 96);
            this.cbLemnFata.Name = "cbLemnFata";
            this.cbLemnFata.Size = new System.Drawing.Size(208, 24);
            this.cbLemnFata.TabIndex = 5;
            // 
            // fSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 353);
            this.Controls.Add(this.cbLemnFata);
            this.Controls.Add(this.cbConstructor);
            this.Controls.Add(this.cbLemnSpate);
            this.Controls.Add(this.cbTipChitara);
            this.Controls.Add(this.biesire);
            this.Controls.Add(this.bCauta);
            this.Controls.Add(this.rtbRezultat);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.lTitlu);
            this.Controls.Add(this.lTip);
            this.Controls.Add(this.lLemnSpate);
            this.Controls.Add(this.llemnFata);
            this.Controls.Add(this.lModel);
            this.Controls.Add(this.lConstructor);
            this.Name = "fSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cautam chitare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lConstructor;
        private System.Windows.Forms.Label lModel;
        private System.Windows.Forms.Label llemnFata;
        private System.Windows.Forms.Label lLemnSpate;
        private System.Windows.Forms.Label lTip;
        private System.Windows.Forms.Label lTitlu;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.RichTextBox rtbRezultat;
        private System.Windows.Forms.Button bCauta;
        private System.Windows.Forms.Button biesire;
        private System.Windows.Forms.ComboBox cbTipChitara;
        private System.Windows.Forms.ComboBox cbLemnSpate;
        private System.Windows.Forms.ComboBox cbConstructor;
        private System.Windows.Forms.ComboBox cbLemnFata;
    }
}