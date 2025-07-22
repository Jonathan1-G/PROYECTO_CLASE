namespace PROYECTO_CLASE.View
{
    partial class Lista_Notas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_Notas));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFiltrado = new System.Windows.Forms.TextBox();
            this.DGVNotas = new System.Windows.Forms.DataGridView();
            this.BtnMatricular = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "INICIO > INFORMACION > NOTAS";
            // 
            // TxtFiltrado
            // 
            this.TxtFiltrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFiltrado.Location = new System.Drawing.Point(517, 45);
            this.TxtFiltrado.Name = "TxtFiltrado";
            this.TxtFiltrado.Size = new System.Drawing.Size(384, 20);
            this.TxtFiltrado.TabIndex = 93;
            this.TxtFiltrado.TextChanged += new System.EventHandler(this.TxtFiltrado_TextChanged);
            // 
            // DGVNotas
            // 
            this.DGVNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVNotas.BackgroundColor = System.Drawing.Color.SlateGray;
            this.DGVNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNotas.Location = new System.Drawing.Point(16, 98);
            this.DGVNotas.Name = "DGVNotas";
            this.DGVNotas.RowHeadersWidth = 62;
            this.DGVNotas.Size = new System.Drawing.Size(885, 347);
            this.DGVNotas.TabIndex = 92;
            this.DGVNotas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVNotas_RowHeaderMouseClick);
            // 
            // BtnMatricular
            // 
            this.BtnMatricular.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnMatricular.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnMatricular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMatricular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnMatricular.Image = ((System.Drawing.Image)(resources.GetObject("BtnMatricular.Image")));
            this.BtnMatricular.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMatricular.Location = new System.Drawing.Point(169, 38);
            this.BtnMatricular.Name = "BtnMatricular";
            this.BtnMatricular.Size = new System.Drawing.Size(168, 54);
            this.BtnMatricular.TabIndex = 94;
            this.BtnMatricular.Text = "EDITAR NOTA";
            this.BtnMatricular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMatricular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMatricular.UseVisualStyleBackColor = false;
            this.BtnMatricular.Visible = false;
            this.BtnMatricular.Click += new System.EventHandler(this.BtnMatricular_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(28, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 66);
            this.pictureBox2.TabIndex = 100;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(463, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // Lista_Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(913, 457);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnMatricular);
            this.Controls.Add(this.TxtFiltrado);
            this.Controls.Add(this.DGVNotas);
            this.Controls.Add(this.label1);
            this.Name = "Lista_Notas";
            this.Text = "Lista_Notas";
            ((System.ComponentModel.ISupportInitialize)(this.DGVNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnMatricular;
        private System.Windows.Forms.TextBox TxtFiltrado;
        private System.Windows.Forms.DataGridView DGVNotas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}