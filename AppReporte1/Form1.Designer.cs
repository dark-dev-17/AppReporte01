namespace AppReporte1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.P_filtros = new System.Windows.Forms.Panel();
            this.Btn_exportar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Opt_optronics = new System.Windows.Forms.RadioButton();
            this.Opt_fibremex = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Opt_VentasArticulos = new System.Windows.Forms.RadioButton();
            this.Opt_VentasEjectuvio = new System.Windows.Forms.RadioButton();
            this.Opt_inventario = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_estatus = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Dat_inicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dat_fin = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.P_filtros.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // P_filtros
            // 
            this.P_filtros.Controls.Add(this.Btn_exportar);
            this.P_filtros.Controls.Add(this.groupBox2);
            this.P_filtros.Controls.Add(this.groupBox1);
            this.P_filtros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_filtros.Location = new System.Drawing.Point(0, 0);
            this.P_filtros.Name = "P_filtros";
            this.P_filtros.Size = new System.Drawing.Size(409, 271);
            this.P_filtros.TabIndex = 0;
            // 
            // Btn_exportar
            // 
            this.Btn_exportar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_exportar.Location = new System.Drawing.Point(0, 217);
            this.Btn_exportar.Name = "Btn_exportar";
            this.Btn_exportar.Size = new System.Drawing.Size(409, 28);
            this.Btn_exportar.TabIndex = 1;
            this.Btn_exportar.Text = "Descargar";
            this.Btn_exportar.UseVisualStyleBackColor = true;
            this.Btn_exportar.Click += new System.EventHandler(this.Btn_exportar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Opt_optronics);
            this.groupBox2.Controls.Add(this.Opt_fibremex);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 48);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sociedad";
            // 
            // Opt_optronics
            // 
            this.Opt_optronics.AutoSize = true;
            this.Opt_optronics.Location = new System.Drawing.Point(98, 20);
            this.Opt_optronics.Name = "Opt_optronics";
            this.Opt_optronics.Size = new System.Drawing.Size(70, 17);
            this.Opt_optronics.TabIndex = 1;
            this.Opt_optronics.Text = "Optronics";
            this.Opt_optronics.UseVisualStyleBackColor = true;
            // 
            // Opt_fibremex
            // 
            this.Opt_fibremex.AutoSize = true;
            this.Opt_fibremex.Checked = true;
            this.Opt_fibremex.Location = new System.Drawing.Point(6, 20);
            this.Opt_fibremex.Name = "Opt_fibremex";
            this.Opt_fibremex.Size = new System.Drawing.Size(67, 17);
            this.Opt_fibremex.TabIndex = 0;
            this.Opt_fibremex.TabStop = true;
            this.Opt_fibremex.Text = "Fibremex";
            this.Opt_fibremex.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.Opt_VentasArticulos);
            this.groupBox1.Controls.Add(this.Opt_VentasEjectuvio);
            this.groupBox1.Controls.Add(this.Opt_inventario);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de reporte";
            // 
            // Opt_VentasArticulos
            // 
            this.Opt_VentasArticulos.AutoSize = true;
            this.Opt_VentasArticulos.Location = new System.Drawing.Point(228, 20);
            this.Opt_VentasArticulos.Name = "Opt_VentasArticulos";
            this.Opt_VentasArticulos.Size = new System.Drawing.Size(115, 17);
            this.Opt_VentasArticulos.TabIndex = 2;
            this.Opt_VentasArticulos.Text = "Ventas de articulos";
            this.Opt_VentasArticulos.UseVisualStyleBackColor = true;
            this.Opt_VentasArticulos.CheckedChanged += new System.EventHandler(this.ValidOptiosn);
            // 
            // Opt_VentasEjectuvio
            // 
            this.Opt_VentasEjectuvio.AutoSize = true;
            this.Opt_VentasEjectuvio.Location = new System.Drawing.Point(98, 20);
            this.Opt_VentasEjectuvio.Name = "Opt_VentasEjectuvio";
            this.Opt_VentasEjectuvio.Size = new System.Drawing.Size(124, 17);
            this.Opt_VentasEjectuvio.TabIndex = 1;
            this.Opt_VentasEjectuvio.Text = "Ventas de ejecutivos";
            this.Opt_VentasEjectuvio.UseVisualStyleBackColor = true;
            this.Opt_VentasEjectuvio.CheckedChanged += new System.EventHandler(this.ValidOptiosn);
            // 
            // Opt_inventario
            // 
            this.Opt_inventario.AutoSize = true;
            this.Opt_inventario.Checked = true;
            this.Opt_inventario.Location = new System.Drawing.Point(7, 20);
            this.Opt_inventario.Name = "Opt_inventario";
            this.Opt_inventario.Size = new System.Drawing.Size(72, 17);
            this.Opt_inventario.TabIndex = 0;
            this.Opt_inventario.TabStop = true;
            this.Opt_inventario.Text = "Inventario";
            this.Opt_inventario.UseVisualStyleBackColor = true;
            this.Opt_inventario.CheckedChanged += new System.EventHandler(this.ValidOptiosn);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lab_estatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 22);
            this.panel1.TabIndex = 3;
            // 
            // lab_estatus
            // 
            this.lab_estatus.BackColor = System.Drawing.Color.DodgerBlue;
            this.lab_estatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lab_estatus.Location = new System.Drawing.Point(0, 9);
            this.lab_estatus.Name = "lab_estatus";
            this.lab_estatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lab_estatus.Size = new System.Drawing.Size(409, 13);
            this.lab_estatus.TabIndex = 0;
            // 
            // Dat_inicio
            // 
            this.Dat_inicio.CustomFormat = "yyyy-MM-dd";
            this.Dat_inicio.Location = new System.Drawing.Point(6, 33);
            this.Dat_inicio.Name = "Dat_inicio";
            this.Dat_inicio.Size = new System.Drawing.Size(215, 20);
            this.Dat_inicio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha Fin";
            // 
            // Dat_fin
            // 
            this.Dat_fin.CustomFormat = "yyyy-MM-dd";
            this.Dat_fin.Location = new System.Drawing.Point(6, 76);
            this.Dat_fin.Name = "Dat_fin";
            this.Dat_fin.Size = new System.Drawing.Size(215, 20);
            this.Dat_fin.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Dat_inicio);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.Dat_fin);
            this.groupBox3.Location = new System.Drawing.Point(12, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 120);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 271);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.P_filtros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes Splittel";
            this.P_filtros.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_filtros;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Opt_optronics;
        private System.Windows.Forms.RadioButton Opt_fibremex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Opt_VentasArticulos;
        private System.Windows.Forms.RadioButton Opt_VentasEjectuvio;
        private System.Windows.Forms.RadioButton Opt_inventario;
        private System.Windows.Forms.Button Btn_exportar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lab_estatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dat_fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dat_inicio;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

