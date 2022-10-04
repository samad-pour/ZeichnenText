namespace ZeichnenText
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
            this.BtnAnzeige = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LstSchriftart = new System.Windows.Forms.ListBox();
            this.NumSchriftgroesse = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LstFarbe = new System.Windows.Forms.ListBox();
            this.BtnLoeschen = new System.Windows.Forms.Button();
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumSchriftgroesse)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAnzeige
            // 
            this.BtnAnzeige.Location = new System.Drawing.Point(244, 12);
            this.BtnAnzeige.Name = "BtnAnzeige";
            this.BtnAnzeige.Size = new System.Drawing.Size(75, 23);
            this.BtnAnzeige.TabIndex = 0;
            this.BtnAnzeige.Text = "Anzeigen";
            this.BtnAnzeige.UseVisualStyleBackColor = true;
            this.BtnAnzeige.Click += new System.EventHandler(this.BtnAnzeige_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Schriftart";
            // 
            // LstSchriftart
            // 
            this.LstSchriftart.FormattingEnabled = true;
            this.LstSchriftart.ItemHeight = 15;
            this.LstSchriftart.Items.AddRange(new object[] {
            "Arial",
            "Courier New",
            "Symbol"});
            this.LstSchriftart.Location = new System.Drawing.Point(244, 56);
            this.LstSchriftart.Name = "LstSchriftart";
            this.LstSchriftart.Size = new System.Drawing.Size(75, 64);
            this.LstSchriftart.TabIndex = 2;
            this.LstSchriftart.SelectedIndexChanged += new System.EventHandler(this.LstSchriftart_SelectedIndexChanged);
            // 
            // NumSchriftgroesse
            // 
            this.NumSchriftgroesse.Location = new System.Drawing.Point(244, 141);
            this.NumSchriftgroesse.Name = "NumSchriftgroesse";
            this.NumSchriftgroesse.Size = new System.Drawing.Size(75, 23);
            this.NumSchriftgroesse.TabIndex = 3;
            this.NumSchriftgroesse.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.NumSchriftgroesse.ValueChanged += new System.EventHandler(this.NumSchriftgroesse_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Schriftgrösse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Farbe:";
            // 
            // LstFarbe
            // 
            this.LstFarbe.FormattingEnabled = true;
            this.LstFarbe.ItemHeight = 15;
            this.LstFarbe.Items.AddRange(new object[] {
            "Rot",
            "Grün",
            "Blau"});
            this.LstFarbe.Location = new System.Drawing.Point(244, 185);
            this.LstFarbe.Name = "LstFarbe";
            this.LstFarbe.Size = new System.Drawing.Size(75, 64);
            this.LstFarbe.TabIndex = 2;
            this.LstFarbe.SelectedIndexChanged += new System.EventHandler(this.LstFarbe_SelectedIndexChanged);
            // 
            // BtnLoeschen
            // 
            this.BtnLoeschen.Location = new System.Drawing.Point(244, 255);
            this.BtnLoeschen.Name = "BtnLoeschen";
            this.BtnLoeschen.Size = new System.Drawing.Size(75, 23);
            this.BtnLoeschen.TabIndex = 0;
            this.BtnLoeschen.Text = "Löschen";
            this.BtnLoeschen.UseVisualStyleBackColor = true;
            this.BtnLoeschen.Click += new System.EventHandler(this.BtnLoeschen_Click);
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(12, 255);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(203, 23);
            this.TxtEingabe.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 285);
            this.Controls.Add(this.TxtEingabe);
            this.Controls.Add(this.NumSchriftgroesse);
            this.Controls.Add(this.LstFarbe);
            this.Controls.Add(this.LstSchriftart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLoeschen);
            this.Controls.Add(this.BtnAnzeige);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumSchriftgroesse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnAnzeige;
        private Label label1;
        private ListBox LstSchriftart;
        private NumericUpDown NumSchriftgroesse;
        private Label label2;
        private Label label3;
        private ListBox LstFarbe;
        private Button BtnLoeschen;
        private TextBox TxtEingabe;
    }
}