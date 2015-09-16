namespace TennisScore
{
    partial class ConfigurarPartido
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtUno = new System.Windows.Forms.RadioButton();
            this.rbtTres = new System.Windows.Forms.RadioButton();
            this.rbtCinco = new System.Windows.Forms.RadioButton();
            this.txtNombreJugadorUno = new System.Windows.Forms.TextBox();
            this.txtNombreJugadorDos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.gbxGenero = new System.Windows.Forms.GroupBox();
            this.txtNacionalidadJugadorDos = new System.Windows.Forms.TextBox();
            this.txtNacionalidadJugadorUno = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtServicioJugadorDos = new System.Windows.Forms.RadioButton();
            this.rbtServicioJugadorUno = new System.Windows.Forms.RadioButton();
            this.gbxGenero.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genero";
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(35, 18);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 1;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            this.rbtMasculino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(35, 46);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtFemenino.TabIndex = 2;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            this.rbtFemenino.CheckedChanged += new System.EventHandler(this.rbtFemenino_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número de sets:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre jugador uno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nacionalidad Jugador Uno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre jugador dos:";
            // 
            // rbtUno
            // 
            this.rbtUno.AutoSize = true;
            this.rbtUno.Location = new System.Drawing.Point(209, 106);
            this.rbtUno.Name = "rbtUno";
            this.rbtUno.Size = new System.Drawing.Size(31, 17);
            this.rbtUno.TabIndex = 7;
            this.rbtUno.Text = "1";
            this.rbtUno.UseVisualStyleBackColor = true;
            // 
            // rbtTres
            // 
            this.rbtTres.AutoSize = true;
            this.rbtTres.Location = new System.Drawing.Point(275, 106);
            this.rbtTres.Name = "rbtTres";
            this.rbtTres.Size = new System.Drawing.Size(31, 17);
            this.rbtTres.TabIndex = 8;
            this.rbtTres.Text = "3";
            this.rbtTres.UseVisualStyleBackColor = true;
            this.rbtTres.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtCinco
            // 
            this.rbtCinco.AutoSize = true;
            this.rbtCinco.Location = new System.Drawing.Point(333, 106);
            this.rbtCinco.Name = "rbtCinco";
            this.rbtCinco.Size = new System.Drawing.Size(31, 17);
            this.rbtCinco.TabIndex = 9;
            this.rbtCinco.Text = "5";
            this.rbtCinco.UseVisualStyleBackColor = true;
            // 
            // txtNombreJugadorUno
            // 
            this.txtNombreJugadorUno.Location = new System.Drawing.Point(298, 164);
            this.txtNombreJugadorUno.Name = "txtNombreJugadorUno";
            this.txtNombreJugadorUno.Size = new System.Drawing.Size(247, 20);
            this.txtNombreJugadorUno.TabIndex = 10;
            // 
            // txtNombreJugadorDos
            // 
            this.txtNombreJugadorDos.Location = new System.Drawing.Point(302, 236);
            this.txtNombreJugadorDos.Name = "txtNombreJugadorDos";
            this.txtNombreJugadorDos.Size = new System.Drawing.Size(243, 20);
            this.txtNombreJugadorDos.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nacionalidad jugador dos:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(253, 365);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(148, 36);
            this.btnRegistrar.TabIndex = 17;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // gbxGenero
            // 
            this.gbxGenero.Controls.Add(this.rbtMasculino);
            this.gbxGenero.Controls.Add(this.rbtFemenino);
            this.gbxGenero.Location = new System.Drawing.Point(106, 12);
            this.gbxGenero.Name = "gbxGenero";
            this.gbxGenero.Size = new System.Drawing.Size(200, 69);
            this.gbxGenero.TabIndex = 18;
            this.gbxGenero.TabStop = false;
            this.gbxGenero.Enter += new System.EventHandler(this.gbxGenero_Enter);
            // 
            // txtNacionalidadJugadorDos
            // 
            this.txtNacionalidadJugadorDos.Location = new System.Drawing.Point(302, 279);
            this.txtNacionalidadJugadorDos.Name = "txtNacionalidadJugadorDos";
            this.txtNacionalidadJugadorDos.Size = new System.Drawing.Size(243, 20);
            this.txtNacionalidadJugadorDos.TabIndex = 19;
            // 
            // txtNacionalidadJugadorUno
            // 
            this.txtNacionalidadJugadorUno.Location = new System.Drawing.Point(298, 197);
            this.txtNacionalidadJugadorUno.Name = "txtNacionalidadJugadorUno";
            this.txtNacionalidadJugadorUno.Size = new System.Drawing.Size(243, 20);
            this.txtNacionalidadJugadorUno.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtServicioJugadorDos);
            this.groupBox1.Controls.Add(this.rbtServicioJugadorUno);
            this.groupBox1.Location = new System.Drawing.Point(575, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 135);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // rbtServicioJugadorDos
            // 
            this.rbtServicioJugadorDos.AutoSize = true;
            this.rbtServicioJugadorDos.Location = new System.Drawing.Point(7, 88);
            this.rbtServicioJugadorDos.Name = "rbtServicioJugadorDos";
            this.rbtServicioJugadorDos.Size = new System.Drawing.Size(93, 17);
            this.rbtServicioJugadorDos.TabIndex = 1;
            this.rbtServicioJugadorDos.TabStop = true;
            this.rbtServicioJugadorDos.Text = "Primer servicio";
            this.rbtServicioJugadorDos.UseVisualStyleBackColor = true;
            // 
            // rbtServicioJugadorUno
            // 
            this.rbtServicioJugadorUno.AutoSize = true;
            this.rbtServicioJugadorUno.Location = new System.Drawing.Point(7, 27);
            this.rbtServicioJugadorUno.Name = "rbtServicioJugadorUno";
            this.rbtServicioJugadorUno.Size = new System.Drawing.Size(93, 17);
            this.rbtServicioJugadorUno.TabIndex = 0;
            this.rbtServicioJugadorUno.TabStop = true;
            this.rbtServicioJugadorUno.Text = "Primer servicio";
            this.rbtServicioJugadorUno.UseVisualStyleBackColor = true;
            // 
            // ConfigurarPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 460);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNacionalidadJugadorUno);
            this.Controls.Add(this.txtNacionalidadJugadorDos);
            this.Controls.Add(this.gbxGenero);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombreJugadorDos);
            this.Controls.Add(this.txtNombreJugadorUno);
            this.Controls.Add(this.rbtCinco);
            this.Controls.Add(this.rbtTres);
            this.Controls.Add(this.rbtUno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConfigurarPartido";
            this.Text = "Configurar Partido";
            this.gbxGenero.ResumeLayout(false);
            this.gbxGenero.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtUno;
        private System.Windows.Forms.RadioButton rbtTres;
        private System.Windows.Forms.RadioButton rbtCinco;
        private System.Windows.Forms.TextBox txtNombreJugadorUno;
        private System.Windows.Forms.TextBox txtNombreJugadorDos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox gbxGenero;
        private System.Windows.Forms.TextBox txtNacionalidadJugadorDos;
        private System.Windows.Forms.TextBox txtNacionalidadJugadorUno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtServicioJugadorDos;
        private System.Windows.Forms.RadioButton rbtServicioJugadorUno;
    }
}

