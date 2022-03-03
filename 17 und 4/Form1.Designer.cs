namespace _17_und_4
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_wkarte = new System.Windows.Forms.Button();
            this.lbl_sieger = new System.Windows.Forms.Label();
            this.lbl_spieler = new System.Windows.Forms.Label();
            this.lbl_dealer = new System.Windows.Forms.Label();
            this.btn_ende = new System.Windows.Forms.Button();
            this.tb_risk = new System.Windows.Forms.TrackBar();
            this.lbl_risk = new System.Windows.Forms.Label();
            this.lbl_risk2 = new System.Windows.Forms.Label();
            this.btn_show = new System.Windows.Forms.Button();
            this.lbl_dealerende = new System.Windows.Forms.Label();
            this.lbl_spielereinzelkarten = new System.Windows.Forms.Label();
            this.lbl_dealereinzelkarten = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tb_risk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_wkarte
            // 
            this.btn_wkarte.BackgroundImage = global::_17_und_4.Properties.Resources.Button;
            this.btn_wkarte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_wkarte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_wkarte.Location = new System.Drawing.Point(550, 9);
            this.btn_wkarte.Name = "btn_wkarte";
            this.btn_wkarte.Size = new System.Drawing.Size(104, 167);
            this.btn_wkarte.TabIndex = 0;
            this.btn_wkarte.Text = "Karte ziehen";
            this.btn_wkarte.UseVisualStyleBackColor = true;
            this.btn_wkarte.Click += new System.EventHandler(this.btn_wkarte_Click);
            // 
            // lbl_sieger
            // 
            this.lbl_sieger.AutoSize = true;
            this.lbl_sieger.Location = new System.Drawing.Point(12, 9);
            this.lbl_sieger.Name = "lbl_sieger";
            this.lbl_sieger.Size = new System.Drawing.Size(0, 25);
            this.lbl_sieger.TabIndex = 5;
            // 
            // lbl_spieler
            // 
            this.lbl_spieler.AutoSize = true;
            this.lbl_spieler.BackColor = System.Drawing.Color.Transparent;
            this.lbl_spieler.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_spieler.Location = new System.Drawing.Point(97, 199);
            this.lbl_spieler.Name = "lbl_spieler";
            this.lbl_spieler.Size = new System.Drawing.Size(106, 25);
            this.lbl_spieler.TabIndex = 6;
            this.lbl_spieler.Text = "Spieler: 00";
            // 
            // lbl_dealer
            // 
            this.lbl_dealer.AutoSize = true;
            this.lbl_dealer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dealer.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_dealer.Location = new System.Drawing.Point(322, 199);
            this.lbl_dealer.Name = "lbl_dealer";
            this.lbl_dealer.Size = new System.Drawing.Size(102, 25);
            this.lbl_dealer.TabIndex = 7;
            this.lbl_dealer.Text = "Dealer: 00";
            this.lbl_dealer.Visible = false;
            // 
            // btn_ende
            // 
            this.btn_ende.BackgroundImage = global::_17_und_4.Properties.Resources.Button;
            this.btn_ende.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ende.Location = new System.Drawing.Point(550, 358);
            this.btn_ende.Name = "btn_ende";
            this.btn_ende.Size = new System.Drawing.Size(104, 39);
            this.btn_ende.TabIndex = 8;
            this.btn_ende.Text = "Ende";
            this.btn_ende.UseVisualStyleBackColor = true;
            this.btn_ende.Click += new System.EventHandler(this.btn_ende_Click);
            // 
            // tb_risk
            // 
            this.tb_risk.BackColor = System.Drawing.Color.Black;
            this.tb_risk.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.tb_risk.Location = new System.Drawing.Point(3, 57);
            this.tb_risk.Maximum = 21;
            this.tb_risk.Minimum = 1;
            this.tb_risk.Name = "tb_risk";
            this.tb_risk.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tb_risk.Size = new System.Drawing.Size(56, 340);
            this.tb_risk.TabIndex = 9;
            this.tb_risk.Value = 16;
            this.tb_risk.Scroll += new System.EventHandler(this.tb_risk_Scroll);
            // 
            // lbl_risk
            // 
            this.lbl_risk.AutoSize = true;
            this.lbl_risk.BackColor = System.Drawing.Color.Black;
            this.lbl_risk.Font = new System.Drawing.Font("Miriam Mono CLM", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_risk.ForeColor = System.Drawing.Color.White;
            this.lbl_risk.Location = new System.Drawing.Point(-2, 3);
            this.lbl_risk.Name = "lbl_risk";
            this.lbl_risk.Size = new System.Drawing.Size(125, 30);
            this.lbl_risk.TabIndex = 10;
            this.lbl_risk.Text = "Risiko:";
            this.lbl_risk.Click += new System.EventHandler(this.lbl_risk_Click);
            // 
            // lbl_risk2
            // 
            this.lbl_risk2.AutoSize = true;
            this.lbl_risk2.BackColor = System.Drawing.Color.Black;
            this.lbl_risk2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_risk2.ForeColor = System.Drawing.Color.White;
            this.lbl_risk2.Location = new System.Drawing.Point(-1, 30);
            this.lbl_risk2.Name = "lbl_risk2";
            this.lbl_risk2.Size = new System.Drawing.Size(52, 20);
            this.lbl_risk2.TabIndex = 11;
            this.lbl_risk2.Text = "(1-21)";
            this.lbl_risk2.Click += new System.EventHandler(this.lbl_risk2_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackgroundImage = global::_17_und_4.Properties.Resources.Button;
            this.btn_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_show.Location = new System.Drawing.Point(550, 185);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(104, 167);
            this.btn_show.TabIndex = 12;
            this.btn_show.Text = "Show cards";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // lbl_dealerende
            // 
            this.lbl_dealerende.AutoSize = true;
            this.lbl_dealerende.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dealerende.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dealerende.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_dealerende.Location = new System.Drawing.Point(75, 140);
            this.lbl_dealerende.Name = "lbl_dealerende";
            this.lbl_dealerende.Size = new System.Drawing.Size(469, 36);
            this.lbl_dealerende.TabIndex = 13;
            this.lbl_dealerende.Text = "Dealer möchte nichtmehr ziehen";
            this.lbl_dealerende.Visible = false;
            // 
            // lbl_spielereinzelkarten
            // 
            this.lbl_spielereinzelkarten.AutoSize = true;
            this.lbl_spielereinzelkarten.BackColor = System.Drawing.Color.Transparent;
            this.lbl_spielereinzelkarten.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_spielereinzelkarten.Location = new System.Drawing.Point(98, 264);
            this.lbl_spielereinzelkarten.Name = "lbl_spielereinzelkarten";
            this.lbl_spielereinzelkarten.Size = new System.Drawing.Size(76, 25);
            this.lbl_spielereinzelkarten.TabIndex = 14;
            this.lbl_spielereinzelkarten.Text = "Karten:";
            // 
            // lbl_dealereinzelkarten
            // 
            this.lbl_dealereinzelkarten.AutoSize = true;
            this.lbl_dealereinzelkarten.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dealereinzelkarten.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_dealereinzelkarten.Location = new System.Drawing.Point(330, 264);
            this.lbl_dealereinzelkarten.Name = "lbl_dealereinzelkarten";
            this.lbl_dealereinzelkarten.Size = new System.Drawing.Size(76, 25);
            this.lbl_dealereinzelkarten.TabIndex = 15;
            this.lbl_dealereinzelkarten.Text = "Karten:";
            this.lbl_dealereinzelkarten.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::_17_und_4.Properties.Resources.points;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 63);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::_17_und_4.Properties.Resources.border;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 354);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImage = global::_17_und_4.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(660, 404);
            this.Controls.Add(this.lbl_dealereinzelkarten);
            this.Controls.Add(this.lbl_spielereinzelkarten);
            this.Controls.Add(this.lbl_dealerende);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.lbl_risk2);
            this.Controls.Add(this.lbl_risk);
            this.Controls.Add(this.btn_ende);
            this.Controls.Add(this.lbl_dealer);
            this.Controls.Add(this.lbl_spieler);
            this.Controls.Add(this.lbl_sieger);
            this.Controls.Add(this.btn_wkarte);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_risk);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "17 und 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_risk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_wkarte;
        private System.Windows.Forms.Label lbl_sieger;
        private System.Windows.Forms.Label lbl_spieler;
        private System.Windows.Forms.Label lbl_dealer;
        private System.Windows.Forms.Button btn_ende;
        private System.Windows.Forms.TrackBar tb_risk;
        private System.Windows.Forms.Label lbl_risk;
        private System.Windows.Forms.Label lbl_risk2;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Label lbl_dealerende;
        private System.Windows.Forms.Label lbl_spielereinzelkarten;
        private System.Windows.Forms.Label lbl_dealereinzelkarten;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

