﻿namespace PROYECTO_CLASE.View
{
    partial class Lista_Alumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_Alumno));
            this.DGVAlumno = new System.Windows.Forms.DataGridView();
            this.TxtFiltrado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVAlumno
            // 
            this.DGVAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAlumno.Location = new System.Drawing.Point(16, 98);
            this.DGVAlumno.Name = "DGVAlumno";
            this.DGVAlumno.RowHeadersWidth = 62;
            this.DGVAlumno.Size = new System.Drawing.Size(875, 347);
            this.DGVAlumno.TabIndex = 0;
            this.DGVAlumno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAlumno_CellClick);
            this.DGVAlumno.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVAlumno_RowHeaderMouseClick);
            this.DGVAlumno.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVAlumno_RowHeaderMouseDoubleClick);
            // 
            // TxtFiltrado
            // 
            this.TxtFiltrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFiltrado.Location = new System.Drawing.Point(541, 51);
            this.TxtFiltrado.Name = "TxtFiltrado";
            this.TxtFiltrado.Size = new System.Drawing.Size(360, 20);
            this.TxtFiltrado.TabIndex = 1;
            this.TxtFiltrado.TextChanged += new System.EventHandler(this.TxtFiltrado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "INICIO > PARAMETROS > ESTUDIANTE";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Image = global::PROYECTO_CLASE.Properties.Resources.icons8_eliminar_48;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminar.Location = new System.Drawing.Point(264, 41);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(156, 48);
            this.BtnEliminar.TabIndex = 88;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(488, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Cyan;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Image = global::PROYECTO_CLASE.Properties.Resources.icons8_agregar_a_favoritos_35;
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregar.Location = new System.Drawing.Point(54, 38);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(156, 54);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // Lista_Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(913, 457);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtFiltrado);
            this.Controls.Add(this.DGVAlumno);
            this.Name = "Lista_Alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista_Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.DGVAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVAlumno;
        private System.Windows.Forms.TextBox TxtFiltrado;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}