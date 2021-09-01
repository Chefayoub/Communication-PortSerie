
namespace AA_PortSerie
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bventi = new System.Windows.Forms.Button();
            this.bventiof = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bSend = new System.Windows.Forms.Button();
            this.tbOut = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bBuzzerON = new System.Windows.Forms.Button();
            this.bBuzzerOFF = new System.Windows.Forms.Button();
            this.lLedRouge = new System.Windows.Forms.Label();
            this.bLedRougeON = new System.Windows.Forms.Button();
            this.bLedRougeOFF = new System.Windows.Forms.Button();
            this.lLEDJaune = new System.Windows.Forms.Label();
            this.bLedJauneON = new System.Windows.Forms.Button();
            this.bLedJauneOFF = new System.Windows.Forms.Button();
            this.lLedVerte = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bLedVerteON = new System.Windows.Forms.Button();
            this.bLedVerteOFF = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLireDonnees = new System.Windows.Forms.Button();
            this.rtbAffichageText = new System.Windows.Forms.RichTextBox();
            this.lcom = new System.Windows.Forms.Label();
            this.Temperature = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCom = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(175, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 543);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.bventi);
            this.panel5.Controls.Add(this.bventiof);
            this.panel5.Location = new System.Drawing.Point(20, 388);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(320, 100);
            this.panel5.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(63, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Controle buzzer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Buzzer";
            // 
            // bventi
            // 
            this.bventi.Location = new System.Drawing.Point(130, 62);
            this.bventi.Name = "bventi";
            this.bventi.Size = new System.Drawing.Size(75, 23);
            this.bventi.TabIndex = 16;
            this.bventi.Text = "ON";
            this.bventi.UseVisualStyleBackColor = true;
            // 
            // bventiof
            // 
            this.bventiof.Location = new System.Drawing.Point(211, 62);
            this.bventiof.Name = "bventiof";
            this.bventiof.Size = new System.Drawing.Size(77, 23);
            this.bventiof.TabIndex = 17;
            this.bventiof.Text = "OFF";
            this.bventiof.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.bSend);
            this.panel4.Controls.Add(this.tbOut);
            this.panel4.Location = new System.Drawing.Point(384, 314);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(343, 149);
            this.panel4.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(51, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Envoyer des données";
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(130, 109);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(75, 23);
            this.bSend.TabIndex = 14;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // tbOut
            // 
            this.tbOut.Location = new System.Drawing.Point(114, 72);
            this.tbOut.MaxLength = 4;
            this.tbOut.Name = "tbOut";
            this.tbOut.Size = new System.Drawing.Size(100, 22);
            this.tbOut.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.bBuzzerON);
            this.panel3.Controls.Add(this.bBuzzerOFF);
            this.panel3.Controls.Add(this.lLedRouge);
            this.panel3.Controls.Add(this.bLedRougeON);
            this.panel3.Controls.Add(this.bLedRougeOFF);
            this.panel3.Controls.Add(this.lLEDJaune);
            this.panel3.Controls.Add(this.bLedJauneON);
            this.panel3.Controls.Add(this.bLedJauneOFF);
            this.panel3.Controls.Add(this.lLedVerte);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.bLedVerteON);
            this.panel3.Controls.Add(this.bLedVerteOFF);
            this.panel3.Location = new System.Drawing.Point(384, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 240);
            this.panel3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Buzzer";
            // 
            // bBuzzerON
            // 
            this.bBuzzerON.Location = new System.Drawing.Point(130, 197);
            this.bBuzzerON.Name = "bBuzzerON";
            this.bBuzzerON.Size = new System.Drawing.Size(75, 23);
            this.bBuzzerON.TabIndex = 13;
            this.bBuzzerON.Text = "ON";
            this.bBuzzerON.UseVisualStyleBackColor = true;
            this.bBuzzerON.Click += new System.EventHandler(this.bBuzzerON_Click);
            // 
            // bBuzzerOFF
            // 
            this.bBuzzerOFF.Location = new System.Drawing.Point(211, 197);
            this.bBuzzerOFF.Name = "bBuzzerOFF";
            this.bBuzzerOFF.Size = new System.Drawing.Size(77, 23);
            this.bBuzzerOFF.TabIndex = 14;
            this.bBuzzerOFF.Text = "OFF";
            this.bBuzzerOFF.UseVisualStyleBackColor = true;
            this.bBuzzerOFF.Click += new System.EventHandler(this.bBuzzerOFF_Click);
            // 
            // lLedRouge
            // 
            this.lLedRouge.AutoSize = true;
            this.lLedRouge.Location = new System.Drawing.Point(26, 165);
            this.lLedRouge.Name = "lLedRouge";
            this.lLedRouge.Size = new System.Drawing.Size(78, 17);
            this.lLedRouge.TabIndex = 12;
            this.lLedRouge.Text = "Led Rouge";
            // 
            // bLedRougeON
            // 
            this.bLedRougeON.Location = new System.Drawing.Point(130, 159);
            this.bLedRougeON.Name = "bLedRougeON";
            this.bLedRougeON.Size = new System.Drawing.Size(75, 23);
            this.bLedRougeON.TabIndex = 10;
            this.bLedRougeON.Text = "ON";
            this.bLedRougeON.UseVisualStyleBackColor = true;
            this.bLedRougeON.Click += new System.EventHandler(this.bLedRougeON_Click);
            // 
            // bLedRougeOFF
            // 
            this.bLedRougeOFF.Location = new System.Drawing.Point(211, 159);
            this.bLedRougeOFF.Name = "bLedRougeOFF";
            this.bLedRougeOFF.Size = new System.Drawing.Size(77, 23);
            this.bLedRougeOFF.TabIndex = 11;
            this.bLedRougeOFF.Text = "OFF";
            this.bLedRougeOFF.UseVisualStyleBackColor = true;
            this.bLedRougeOFF.Click += new System.EventHandler(this.bLedRougeOFF_Click);
            // 
            // lLEDJaune
            // 
            this.lLEDJaune.AutoSize = true;
            this.lLEDJaune.Location = new System.Drawing.Point(26, 127);
            this.lLEDJaune.Name = "lLEDJaune";
            this.lLEDJaune.Size = new System.Drawing.Size(75, 17);
            this.lLEDJaune.TabIndex = 9;
            this.lLEDJaune.Text = "Led Jaune";
            // 
            // bLedJauneON
            // 
            this.bLedJauneON.Location = new System.Drawing.Point(130, 121);
            this.bLedJauneON.Name = "bLedJauneON";
            this.bLedJauneON.Size = new System.Drawing.Size(75, 23);
            this.bLedJauneON.TabIndex = 7;
            this.bLedJauneON.Text = "ON";
            this.bLedJauneON.UseVisualStyleBackColor = true;
            this.bLedJauneON.Click += new System.EventHandler(this.bLedJauneON_Click);
            // 
            // bLedJauneOFF
            // 
            this.bLedJauneOFF.Location = new System.Drawing.Point(211, 121);
            this.bLedJauneOFF.Name = "bLedJauneOFF";
            this.bLedJauneOFF.Size = new System.Drawing.Size(77, 23);
            this.bLedJauneOFF.TabIndex = 8;
            this.bLedJauneOFF.Text = "OFF";
            this.bLedJauneOFF.UseVisualStyleBackColor = true;
            this.bLedJauneOFF.Click += new System.EventHandler(this.bLedJauneOFF_Click);
            // 
            // lLedVerte
            // 
            this.lLedVerte.AutoSize = true;
            this.lLedVerte.Location = new System.Drawing.Point(26, 87);
            this.lLedVerte.Name = "lLedVerte";
            this.lLedVerte.Size = new System.Drawing.Size(70, 17);
            this.lLedVerte.TabIndex = 6;
            this.lLedVerte.Text = "Led Verte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(68, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Controle des leds";
            // 
            // bLedVerteON
            // 
            this.bLedVerteON.Location = new System.Drawing.Point(130, 81);
            this.bLedVerteON.Name = "bLedVerteON";
            this.bLedVerteON.Size = new System.Drawing.Size(75, 23);
            this.bLedVerteON.TabIndex = 0;
            this.bLedVerteON.Text = "ON";
            this.bLedVerteON.UseVisualStyleBackColor = true;
            this.bLedVerteON.Click += new System.EventHandler(this.bLedVerteON_Click);
            // 
            // bLedVerteOFF
            // 
            this.bLedVerteOFF.Location = new System.Drawing.Point(211, 81);
            this.bLedVerteOFF.Name = "bLedVerteOFF";
            this.bLedVerteOFF.Size = new System.Drawing.Size(77, 23);
            this.bLedVerteOFF.TabIndex = 1;
            this.bLedVerteOFF.Text = "OFF";
            this.bLedVerteOFF.UseVisualStyleBackColor = true;
            this.bLedVerteOFF.Click += new System.EventHandler(this.bLedVerteOFF_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnLireDonnees);
            this.panel2.Controls.Add(this.rtbAffichageText);
            this.panel2.Controls.Add(this.lcom);
            this.panel2.Controls.Add(this.Temperature);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbCom);
            this.panel2.Location = new System.Drawing.Point(20, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 290);
            this.panel2.TabIndex = 4;
            // 
            // btnLireDonnees
            // 
            this.btnLireDonnees.Location = new System.Drawing.Point(99, 237);
            this.btnLireDonnees.Name = "btnLireDonnees";
            this.btnLireDonnees.Size = new System.Drawing.Size(88, 34);
            this.btnLireDonnees.TabIndex = 13;
            this.btnLireDonnees.Text = "Afficher";
            this.btnLireDonnees.UseVisualStyleBackColor = true;
            this.btnLireDonnees.Click += new System.EventHandler(this.btnLireDonnees_Click);
            // 
            // rtbAffichageText
            // 
            this.rtbAffichageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAffichageText.Location = new System.Drawing.Point(105, 161);
            this.rtbAffichageText.Name = "rtbAffichageText";
            this.rtbAffichageText.Size = new System.Drawing.Size(85, 40);
            this.rtbAffichageText.TabIndex = 18;
            this.rtbAffichageText.Text = "";
            // 
            // lcom
            // 
            this.lcom.AutoSize = true;
            this.lcom.BackColor = System.Drawing.Color.Teal;
            this.lcom.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcom.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lcom.Location = new System.Drawing.Point(50, 87);
            this.lcom.Name = "lcom";
            this.lcom.Size = new System.Drawing.Size(49, 22);
            this.lcom.TabIndex = 8;
            this.lcom.Text = "COM";
            // 
            // Temperature
            // 
            this.Temperature.AutoSize = true;
            this.Temperature.Location = new System.Drawing.Point(112, 141);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(66, 17);
            this.Temperature.TabIndex = 6;
            this.Temperature.Text = "Text LCD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ouverture du port COM";
            // 
            // cbCom
            // 
            this.cbCom.FormattingEnabled = true;
            this.cbCom.Location = new System.Drawing.Point(115, 87);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(121, 24);
            this.cbCom.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(938, 567);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbCom;
        private System.Windows.Forms.Label Temperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lLedVerte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bLedVerteON;
        private System.Windows.Forms.Button bLedVerteOFF;
        private System.Windows.Forms.Label lLedRouge;
        private System.Windows.Forms.Button bLedRougeON;
        private System.Windows.Forms.Button bLedRougeOFF;
        private System.Windows.Forms.Label lLEDJaune;
        private System.Windows.Forms.Button bLedJauneON;
        private System.Windows.Forms.Button bLedJauneOFF;
        private System.Windows.Forms.Label lcom;
        private System.Windows.Forms.Button btnLireDonnees;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.TextBox tbOut;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox rtbAffichageText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bBuzzerON;
        private System.Windows.Forms.Button bBuzzerOFF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bventi;
        private System.Windows.Forms.Button bventiof;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
    }
}

