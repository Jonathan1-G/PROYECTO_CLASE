namespace PROYECTO_CLASE.View
{
    partial class Lista_Clases_Ofertadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_Clases_Ofertadas));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFiltrado = new System.Windows.Forms.TextBox();
            this.DGVClases_Ofertadas = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnMatricular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClases_Ofertadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 20);
            this.label1.TabIndex = 92;
            this.label1.Text = "INICIO > MATRICULA > CLASES OFERTADAS";
            // 
            // TxtFiltrado
            // 
            this.TxtFiltrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFiltrado.Location = new System.Drawing.Point(539, 71);
            this.TxtFiltrado.Name = "TxtFiltrado";
            this.TxtFiltrado.Size = new System.Drawing.Size(462, 20);
            this.TxtFiltrado.TabIndex = 89;
            this.TxtFiltrado.TextChanged += new System.EventHandler(this.TxtFiltrado_TextChanged);
            // 
            // DGVClases_Ofertadas
            // 
            this.DGVClases_Ofertadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVClases_Ofertadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClases_Ofertadas.Location = new System.Drawing.Point(14, 99);
            this.DGVClases_Ofertadas.Name = "DGVClases_Ofertadas";
            this.DGVClases_Ofertadas.Size = new System.Drawing.Size(987, 347);
            this.DGVClases_Ofertadas.TabIndex = 88;
            this.DGVClases_Ofertadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVClases_Ofertadas_CellClick);
            this.DGVClases_Ofertadas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVClases_Ofertadas_RowHeaderMouseClick);
            this.DGVClases_Ofertadas.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVClases_Ofertadas_RowHeaderMouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(503, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // BtnMatricular
            // 
            this.BtnMatricular.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnMatricular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMatricular.Image = ((System.Drawing.Image)(resources.GetObject("BtnMatricular.Image")));
            this.BtnMatricular.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMatricular.Location = new System.Drawing.Point(55, 42);
            this.BtnMatricular.Name = "BtnMatricular";
            this.BtnMatricular.Size = new System.Drawing.Size(168, 54);
            this.BtnMatricular.TabIndex = 90;
            this.BtnMatricular.Text = "MATRICULAR";
            this.BtnMatricular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMatricular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMatricular.UseVisualStyleBackColor = false;
            this.BtnMatricular.Visible = false;
            this.BtnMatricular.Click += new System.EventHandler(this.BtnMatricular_Click);
            // 
            // Lista_Clases_Ofertadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1011, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnMatricular);
            this.Controls.Add(this.TxtFiltrado);
            this.Controls.Add(this.DGVClases_Ofertadas);
            this.Name = "Lista_Clases_Ofertadas";
            this.Text = "Lista_Clases_Ofertadas";
            ((System.ComponentModel.ISupportInitialize)(this.DGVClases_Ofertadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnMatricular;
        private System.Windows.Forms.TextBox TxtFiltrado;
        private System.Windows.Forms.DataGridView DGVClases_Ofertadas;
    }
}