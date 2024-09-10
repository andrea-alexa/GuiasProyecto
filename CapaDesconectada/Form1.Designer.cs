namespace CapaDesconectada
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObtenerNoTipado = new System.Windows.Forms.Button();
            this.GridNoTipado = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOptenerTipado = new System.Windows.Forms.Button();
            this.GridTipado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarNT = new System.Windows.Forms.TextBox();
            this.btnBuscarNT = new System.Windows.Forms.Button();
            this.btnBuscarT = new System.Windows.Forms.Button();
            this.txtBuscarT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridNoTipado)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObtenerNoTipado);
            this.groupBox1.Controls.Add(this.GridNoTipado);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 484);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DataSet no Tipado";
            // 
            // btnObtenerNoTipado
            // 
            this.btnObtenerNoTipado.Location = new System.Drawing.Point(96, 417);
            this.btnObtenerNoTipado.Name = "btnObtenerNoTipado";
            this.btnObtenerNoTipado.Size = new System.Drawing.Size(245, 41);
            this.btnObtenerNoTipado.TabIndex = 1;
            this.btnObtenerNoTipado.Text = "Otener datos no tipados";
            this.btnObtenerNoTipado.UseVisualStyleBackColor = true;
            this.btnObtenerNoTipado.Click += new System.EventHandler(this.btnObtenerNoTipado_Click);
            // 
            // GridNoTipado
            // 
            this.GridNoTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridNoTipado.Location = new System.Drawing.Point(21, 32);
            this.GridNoTipado.Name = "GridNoTipado";
            this.GridNoTipado.RowHeadersWidth = 51;
            this.GridNoTipado.RowTemplate.Height = 24;
            this.GridNoTipado.Size = new System.Drawing.Size(407, 367);
            this.GridNoTipado.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOptenerTipado);
            this.groupBox2.Controls.Add(this.GridTipado);
            this.groupBox2.Location = new System.Drawing.Point(468, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 484);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DataSet Tipado";
            // 
            // btnOptenerTipado
            // 
            this.btnOptenerTipado.Location = new System.Drawing.Point(112, 417);
            this.btnOptenerTipado.Name = "btnOptenerTipado";
            this.btnOptenerTipado.Size = new System.Drawing.Size(220, 41);
            this.btnOptenerTipado.TabIndex = 2;
            this.btnOptenerTipado.Text = "Optener datos tipados";
            this.btnOptenerTipado.UseVisualStyleBackColor = true;
            this.btnOptenerTipado.Click += new System.EventHandler(this.btnOptenerTipado_Click);
            // 
            // GridTipado
            // 
            this.GridTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTipado.Location = new System.Drawing.Point(14, 32);
            this.GridTipado.Name = "GridTipado";
            this.GridTipado.RowHeadersWidth = 51;
            this.GridTipado.RowTemplate.Height = 24;
            this.GridTipado.Size = new System.Drawing.Size(413, 367);
            this.GridTipado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar cliente:";
            // 
            // txtBuscarNT
            // 
            this.txtBuscarNT.Location = new System.Drawing.Point(192, 531);
            this.txtBuscarNT.Name = "txtBuscarNT";
            this.txtBuscarNT.Size = new System.Drawing.Size(137, 22);
            this.txtBuscarNT.TabIndex = 3;
            // 
            // btnBuscarNT
            // 
            this.btnBuscarNT.Location = new System.Drawing.Point(202, 578);
            this.btnBuscarNT.Name = "btnBuscarNT";
            this.btnBuscarNT.Size = new System.Drawing.Size(112, 32);
            this.btnBuscarNT.TabIndex = 4;
            this.btnBuscarNT.Text = "Buscar";
            this.btnBuscarNT.UseVisualStyleBackColor = true;
            this.btnBuscarNT.Click += new System.EventHandler(this.btnBuscarNT_Click);
            // 
            // btnBuscarT
            // 
            this.btnBuscarT.Location = new System.Drawing.Point(660, 575);
            this.btnBuscarT.Name = "btnBuscarT";
            this.btnBuscarT.Size = new System.Drawing.Size(112, 32);
            this.btnBuscarT.TabIndex = 7;
            this.btnBuscarT.Text = "Buscar";
            this.btnBuscarT.UseVisualStyleBackColor = true;
            this.btnBuscarT.Click += new System.EventHandler(this.btnBuscarT_Click);
            // 
            // txtBuscarT
            // 
            this.txtBuscarT.Location = new System.Drawing.Point(650, 528);
            this.txtBuscarT.Name = "txtBuscarT";
            this.txtBuscarT.Size = new System.Drawing.Size(137, 22);
            this.txtBuscarT.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar cliente:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 655);
            this.Controls.Add(this.btnBuscarT);
            this.Controls.Add(this.txtBuscarT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarNT);
            this.Controls.Add(this.txtBuscarNT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridNoTipado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridTipado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GridNoTipado;
        private System.Windows.Forms.DataGridView GridTipado;
        private System.Windows.Forms.Button btnObtenerNoTipado;
        private System.Windows.Forms.Button btnOptenerTipado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarNT;
        private System.Windows.Forms.Button btnBuscarNT;
        private System.Windows.Forms.Button btnBuscarT;
        private System.Windows.Forms.TextBox txtBuscarT;
        private System.Windows.Forms.Label label2;
    }
}

