﻿namespace PROYECTO_CLASE.View
{
    partial class Registro_Perfil_Catedratico
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
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnEdicion = new System.Windows.Forms.Button();
            this.CBSede = new System.Windows.Forms.ComboBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtIdentidad = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.txtIdCate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdSede = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGuardarEdicion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnGuardar.BackgroundImage = global::PROYECTO_CLASE.Properties.Resources.guardar_el_archivo1;
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(637, 266);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(61, 52);
            this.BtnGuardar.TabIndex = 83;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnEdicion
            // 
            this.BtnEdicion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEdicion.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnEdicion.BackgroundImage = global::PROYECTO_CLASE.Properties.Resources.editar;
            this.BtnEdicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdicion.Location = new System.Drawing.Point(637, 181);
            this.BtnEdicion.Name = "BtnEdicion";
            this.BtnEdicion.Size = new System.Drawing.Size(61, 52);
            this.BtnEdicion.TabIndex = 82;
            this.BtnEdicion.UseVisualStyleBackColor = false;
            this.BtnEdicion.Click += new System.EventHandler(this.BtnEdicion_Click);
            // 
            // CBSede
            // 
            this.CBSede.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBSede.FormattingEnabled = true;
            this.CBSede.Location = new System.Drawing.Point(191, 221);
            this.CBSede.Name = "CBSede";
            this.CBSede.Size = new System.Drawing.Size(228, 21);
            this.CBSede.TabIndex = 79;
            this.CBSede.SelectedIndexChanged += new System.EventHandler(this.CBSede_SelectedIndexChanged);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCorreo.Location = new System.Drawing.Point(191, 296);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(311, 20);
            this.TxtCorreo.TabIndex = 78;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtTelefono.Location = new System.Drawing.Point(191, 259);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(311, 20);
            this.TxtTelefono.TabIndex = 77;
            // 
            // TxtIdentidad
            // 
            this.TxtIdentidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtIdentidad.Location = new System.Drawing.Point(191, 184);
            this.TxtIdentidad.Name = "TxtIdentidad";
            this.TxtIdentidad.Size = new System.Drawing.Size(311, 20);
            this.TxtIdentidad.TabIndex = 76;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtApellido.Location = new System.Drawing.Point(191, 147);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(311, 20);
            this.TxtApellido.TabIndex = 75;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtNombre.Location = new System.Drawing.Point(191, 110);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(311, 20);
            this.TxtNombre.TabIndex = 74;
            // 
            // txtIdCate
            // 
            this.txtIdCate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdCate.Location = new System.Drawing.Point(191, 73);
            this.txtIdCate.Name = "txtIdCate";
            this.txtIdCate.Size = new System.Drawing.Size(110, 20);
            this.txtIdCate.TabIndex = 73;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 18);
            this.label12.TabIndex = 72;
            this.label12.Text = "CORREO";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 18);
            this.label11.TabIndex = 71;
            this.label11.Text = "TELEFONO";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 70;
            this.label9.Text = "SEDE";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 18);
            this.label7.TabIndex = 69;
            this.label7.Text = "IDENTIDAD";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 68;
            this.label3.Text = "APELLIDO";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 67;
            this.label2.Text = "NOMBRE";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 18);
            this.label13.TabIndex = 66;
            this.label13.Text = "ID CATEDRATICO";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "INICIO > INFORMACION > PERFIL MAESTRO";
            // 
            // TxtIdSede
            // 
            this.TxtIdSede.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtIdSede.Location = new System.Drawing.Point(444, 221);
            this.TxtIdSede.Name = "TxtIdSede";
            this.TxtIdSede.Size = new System.Drawing.Size(96, 20);
            this.TxtIdSede.TabIndex = 84;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.BackgroundImage = global::PROYECTO_CLASE.Properties.Resources.maestro;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(604, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 152);
            this.pictureBox2.TabIndex = 113;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox6.Image = global::PROYECTO_CLASE.Properties.Resources.Liquitex2;
            this.pictureBox6.Location = new System.Drawing.Point(580, -2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(267, 355);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 118;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::PROYECTO_CLASE.Properties.Resources.Red_Barrel_S;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 119;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(704, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 120;
            this.label4.Text = "Modo: Editar";
            // 
            // lblGuardarEdicion
            // 
            this.lblGuardarEdicion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGuardarEdicion.BackColor = System.Drawing.Color.SteelBlue;
            this.lblGuardarEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardarEdicion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGuardarEdicion.Location = new System.Drawing.Point(701, 283);
            this.lblGuardarEdicion.Name = "lblGuardarEdicion";
            this.lblGuardarEdicion.Size = new System.Drawing.Size(130, 18);
            this.lblGuardarEdicion.TabIndex = 121;
            this.lblGuardarEdicion.Text = "Guardar Edicion";
            // 
            // Registro_Perfil_Catedratico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(843, 354);
            this.Controls.Add(this.lblGuardarEdicion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TxtIdSede);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnEdicion);
            this.Controls.Add(this.CBSede);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtIdentidad);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.txtIdCate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Registro_Perfil_Catedratico";
            this.Text = "Registro_Perfil_Catedratico";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnEdicion;
        private System.Windows.Forms.ComboBox CBSede;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtIdentidad;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox txtIdCate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdSede;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGuardarEdicion;
    }
}