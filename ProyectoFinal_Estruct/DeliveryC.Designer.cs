namespace ProyectoFinal_Estruct
{
    partial class DeliveryC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryC));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxDistrito = new System.Windows.Forms.ComboBox();
            this.txtEstimacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.txtTotalD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.Name = "txtNombre";
            // 
            // txtDireccion
            // 
            resources.ApplyResources(this.txtDireccion, "txtDireccion");
            this.txtDireccion.Name = "txtDireccion";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Name = "label4";
            // 
            // cboxDistrito
            // 
            this.cboxDistrito.FormattingEnabled = true;
            this.cboxDistrito.Items.AddRange(new object[] {
            resources.GetString("cboxDistrito.Items"),
            resources.GetString("cboxDistrito.Items1"),
            resources.GetString("cboxDistrito.Items2"),
            resources.GetString("cboxDistrito.Items3"),
            resources.GetString("cboxDistrito.Items4"),
            resources.GetString("cboxDistrito.Items5"),
            resources.GetString("cboxDistrito.Items6"),
            resources.GetString("cboxDistrito.Items7"),
            resources.GetString("cboxDistrito.Items8")});
            resources.ApplyResources(this.cboxDistrito, "cboxDistrito");
            this.cboxDistrito.Name = "cboxDistrito";
            this.cboxDistrito.SelectedIndexChanged += new System.EventHandler(this.cboxDistrito_SelectedIndexChanged);
            // 
            // txtEstimacion
            // 
            resources.ApplyResources(this.txtEstimacion, "txtEstimacion");
            this.txtEstimacion.Name = "txtEstimacion";
            this.txtEstimacion.TextChanged += new System.EventHandler(this.txtEstimacion_TextChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Name = "label5";
            // 
            // rbEfectivo
            // 
            resources.ApplyResources(this.rbEfectivo, "rbEfectivo");
            this.rbEfectivo.Checked = true;
            this.rbEfectivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            resources.ApplyResources(this.rbTarjeta, "rbTarjeta");
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            this.rbTarjeta.CheckedChanged += new System.EventHandler(this.rbTarjeta_CheckedChanged);
            // 
            // txtTotalD
            // 
            resources.ApplyResources(this.txtTotalD, "txtTotalD");
            this.txtTotalD.Name = "txtTotalD";
            this.txtTotalD.TextChanged += new System.EventHandler(this.txtTotalD_TextChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Name = "label6";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.Lime;
            this.btnOrdenar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnOrdenar, "btnOrdenar");
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnRegresar, "btnRegresar");
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // DeliveryC
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_Estruct.Properties.Resources.article;
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalD);
            this.Controls.Add(this.rbTarjeta);
            this.Controls.Add(this.rbEfectivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEstimacion);
            this.Controls.Add(this.cboxDistrito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Name = "DeliveryC";
            this.Load += new System.EventHandler(this.DeliveryC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtDireccion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cboxDistrito;
        private TextBox txtEstimacion;
        private Label label5;
        private RadioButton rbEfectivo;
        private RadioButton rbTarjeta;
        private TextBox txtTotalD;
        private Label label6;
        private Button btnOrdenar;
        private Button btnRegresar;
    }
}