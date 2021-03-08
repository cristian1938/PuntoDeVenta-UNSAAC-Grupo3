namespace Proyecto_Metodologia
{
    partial class FrmArqueo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.USUSARIO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelcontenido = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeArqueo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lbDiferencia = new System.Windows.Forms.Label();
            this.lbTituloDiferencia = new System.Windows.Forms.Label();
            this.btnConteo = new System.Windows.Forms.Button();
            this.txtconteo = new System.Windows.Forms.TextBox();
            this.lbTituloConteo = new System.Windows.Forms.Label();
            this.lbVentas = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.dgventas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelcontenido.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgventas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.USUSARIO);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 66);
            this.panel1.TabIndex = 0;
            // 
            // USUSARIO
            // 
            this.USUSARIO.AutoSize = true;
            this.USUSARIO.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USUSARIO.ForeColor = System.Drawing.Color.White;
            this.USUSARIO.Location = new System.Drawing.Point(732, 15);
            this.USUSARIO.Name = "USUSARIO";
            this.USUSARIO.Size = new System.Drawing.Size(0, 34);
            this.USUSARIO.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(282, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARQUEO DE CAJA";
            // 
            // panelcontenido
            // 
            this.panelcontenido.BackColor = System.Drawing.Color.White;
            this.panelcontenido.Controls.Add(this.groupBox1);
            this.panelcontenido.Controls.Add(this.panel2);
            this.panelcontenido.Controls.Add(this.txttotal);
            this.panelcontenido.Controls.Add(this.lbDiferencia);
            this.panelcontenido.Controls.Add(this.lbTituloDiferencia);
            this.panelcontenido.Controls.Add(this.btnConteo);
            this.panelcontenido.Controls.Add(this.txtconteo);
            this.panelcontenido.Controls.Add(this.lbTituloConteo);
            this.panelcontenido.Controls.Add(this.lbVentas);
            this.panelcontenido.Controls.Add(this.lbFecha);
            this.panelcontenido.Controls.Add(this.dgventas);
            this.panelcontenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenido.ForeColor = System.Drawing.Color.Black;
            this.panelcontenido.Location = new System.Drawing.Point(0, 66);
            this.panelcontenido.Name = "panelcontenido";
            this.panelcontenido.Size = new System.Drawing.Size(782, 428);
            this.panelcontenido.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeArqueo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbHora);
            this.groupBox1.Location = new System.Drawing.Point(153, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 64);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARQUEO";
            // 
            // dateTimeArqueo
            // 
            this.dateTimeArqueo.CustomFormat = "yy/MM/dd";
            this.dateTimeArqueo.Enabled = false;
            this.dateTimeArqueo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeArqueo.Location = new System.Drawing.Point(52, 22);
            this.dateTimeArqueo.Name = "dateTimeArqueo";
            this.dateTimeArqueo.Size = new System.Drawing.Size(255, 24);
            this.dateTimeArqueo.TabIndex = 3;
            this.dateTimeArqueo.ValueChanged += new System.EventHandler(this.dateTimeArqueo_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "HORA:";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(417, 28);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(40, 16);
            this.lbHora.TabIndex = 6;
            this.lbHora.Text = "10:00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.iconButton3);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 56);
            this.panel2.TabIndex = 15;
            // 
            // iconButton3
            // 
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 35;
            this.iconButton3.Location = new System.Drawing.Point(69, 4);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(157, 46);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.Text = "REGISTRO DE ARQUEOS";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.Location = new System.Drawing.Point(535, 4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(157, 46);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "REGISTRAR ARQUEO";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // txttotal
            // 
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(363, 295);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(87, 13);
            this.txttotal.TabIndex = 14;
            // 
            // lbDiferencia
            // 
            this.lbDiferencia.AutoSize = true;
            this.lbDiferencia.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiferencia.Location = new System.Drawing.Point(361, 354);
            this.lbDiferencia.Name = "lbDiferencia";
            this.lbDiferencia.Size = new System.Drawing.Size(33, 16);
            this.lbDiferencia.TabIndex = 13;
            this.lbDiferencia.Text = "0:00";
            // 
            // lbTituloDiferencia
            // 
            this.lbTituloDiferencia.AutoSize = true;
            this.lbTituloDiferencia.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloDiferencia.Location = new System.Drawing.Point(262, 354);
            this.lbTituloDiferencia.Name = "lbTituloDiferencia";
            this.lbTituloDiferencia.Size = new System.Drawing.Size(86, 16);
            this.lbTituloDiferencia.TabIndex = 12;
            this.lbTituloDiferencia.Text = "DIFERENCIA:";
            // 
            // btnConteo
            // 
            this.btnConteo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConteo.Location = new System.Drawing.Point(456, 318);
            this.btnConteo.Name = "btnConteo";
            this.btnConteo.Size = new System.Drawing.Size(62, 26);
            this.btnConteo.TabIndex = 11;
            this.btnConteo.Text = "Contar";
            this.btnConteo.UseVisualStyleBackColor = true;
            this.btnConteo.Click += new System.EventHandler(this.btnConteo_Click);
            // 
            // txtconteo
            // 
            this.txtconteo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconteo.Location = new System.Drawing.Point(363, 320);
            this.txtconteo.Name = "txtconteo";
            this.txtconteo.Size = new System.Drawing.Size(87, 24);
            this.txtconteo.TabIndex = 10;
            this.txtconteo.TextChanged += new System.EventHandler(this.txtconteo_TextChanged);
            // 
            // lbTituloConteo
            // 
            this.lbTituloConteo.AutoSize = true;
            this.lbTituloConteo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloConteo.Location = new System.Drawing.Point(242, 325);
            this.lbTituloConteo.Name = "lbTituloConteo";
            this.lbTituloConteo.Size = new System.Drawing.Size(107, 16);
            this.lbTituloConteo.TabIndex = 9;
            this.lbTituloConteo.Text = "TOTAL CONTEO";
            // 
            // lbVentas
            // 
            this.lbVentas.AutoSize = true;
            this.lbVentas.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentas.Location = new System.Drawing.Point(244, 295);
            this.lbVentas.Name = "lbVentas";
            this.lbVentas.Size = new System.Drawing.Size(104, 16);
            this.lbVentas.TabIndex = 8;
            this.lbVentas.Text = "TOTAL VENTAS";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(171, 34);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(53, 16);
            this.lbFecha.TabIndex = 4;
            this.lbFecha.Text = "FECHA:";
            // 
            // dgventas
            // 
            this.dgventas.AllowUserToAddRows = false;
            this.dgventas.AllowUserToDeleteRows = false;
            this.dgventas.BackgroundColor = System.Drawing.Color.White;
            this.dgventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgventas.Location = new System.Drawing.Point(153, 76);
            this.dgventas.Name = "dgventas";
            this.dgventas.ReadOnly = true;
            this.dgventas.Size = new System.Drawing.Size(519, 202);
            this.dgventas.TabIndex = 0;
            // 
            // FrmArqueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 494);
            this.Controls.Add(this.panelcontenido);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Name = "FrmArqueo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelcontenido.ResumeLayout(false);
            this.panelcontenido.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label USUSARIO;
        private System.Windows.Forms.Panel panelcontenido;
        private System.Windows.Forms.DataGridView dgventas;
        private System.Windows.Forms.DateTimePicker dateTimeArqueo;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbTituloDiferencia;
        private System.Windows.Forms.Button btnConteo;
        private System.Windows.Forms.TextBox txtconteo;
        private System.Windows.Forms.Label lbTituloConteo;
        private System.Windows.Forms.Label lbVentas;
        private System.Windows.Forms.Label lbDiferencia;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}