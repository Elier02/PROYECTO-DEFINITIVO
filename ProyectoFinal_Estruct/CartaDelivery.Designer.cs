namespace ProyectoFinal_Estruct
{
    partial class CartaDelivery
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
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.Entradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegresarCarta = new System.Windows.Forms.Button();
            this.dgvPlatos = new System.Windows.Forms.DataGridView();
            this.Platos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBebidas = new System.Windows.Forms.DataGridView();
            this.Bebidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbEntradas = new System.Windows.Forms.ComboBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPentradas = new System.Windows.Forms.TextBox();
            this.rbPapa = new System.Windows.Forms.RadioButton();
            this.rbWantan = new System.Windows.Forms.RadioButton();
            this.rbEnsalada = new System.Windows.Forms.RadioButton();
            this.rbSopa = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPplatos = new System.Windows.Forms.TextBox();
            this.rbPollo = new System.Windows.Forms.RadioButton();
            this.rbPato = new System.Windows.Forms.RadioButton();
            this.rbCebiche = new System.Windows.Forms.RadioButton();
            this.rbChaufa = new System.Windows.Forms.RadioButton();
            this.cbPlatos = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPbebidas = new System.Windows.Forms.TextBox();
            this.rbAgua = new System.Windows.Forms.RadioButton();
            this.rbLimonada = new System.Windows.Forms.RadioButton();
            this.rbGaseosa = new System.Windows.Forms.RadioButton();
            this.cbBebidas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Entradas,
            this.Precio});
            this.dgvEntradas.Location = new System.Drawing.Point(59, 22);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.RowTemplate.Height = 25;
            this.dgvEntradas.Size = new System.Drawing.Size(349, 161);
            this.dgvEntradas.TabIndex = 0;
            this.dgvEntradas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntradas_CellContentClick);
            // 
            // Entradas
            // 
            this.Entradas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Entradas.HeaderText = "Entradas";
            this.Entradas.Name = "Entradas";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // RegresarCarta
            // 
            this.RegresarCarta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RegresarCarta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegresarCarta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegresarCarta.Location = new System.Drawing.Point(753, 633);
            this.RegresarCarta.Name = "RegresarCarta";
            this.RegresarCarta.Size = new System.Drawing.Size(88, 37);
            this.RegresarCarta.TabIndex = 1;
            this.RegresarCarta.Text = "Regresar";
            this.RegresarCarta.UseVisualStyleBackColor = false;
            this.RegresarCarta.Click += new System.EventHandler(this.RegresarCarta_Click);
            // 
            // dgvPlatos
            // 
            this.dgvPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Platos,
            this.dataGridViewTextBoxColumn1});
            this.dgvPlatos.Location = new System.Drawing.Point(59, 205);
            this.dgvPlatos.Name = "dgvPlatos";
            this.dgvPlatos.RowTemplate.Height = 25;
            this.dgvPlatos.Size = new System.Drawing.Size(349, 161);
            this.dgvPlatos.TabIndex = 2;
            // 
            // Platos
            // 
            this.Platos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Platos.HeaderText = "Platos de fondo";
            this.Platos.Name = "Platos";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dgvBebidas
            // 
            this.dgvBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bebidas,
            this.dataGridViewTextBoxColumn2});
            this.dgvBebidas.Location = new System.Drawing.Point(59, 390);
            this.dgvBebidas.Name = "dgvBebidas";
            this.dgvBebidas.RowTemplate.Height = 25;
            this.dgvBebidas.Size = new System.Drawing.Size(349, 161);
            this.dgvBebidas.TabIndex = 3;
            // 
            // Bebidas
            // 
            this.Bebidas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Bebidas.HeaderText = "Bebidas";
            this.Bebidas.Name = "Bebidas";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // cbEntradas
            // 
            this.cbEntradas.FormattingEnabled = true;
            this.cbEntradas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbEntradas.Location = new System.Drawing.Point(249, 62);
            this.cbEntradas.Name = "cbEntradas";
            this.cbEntradas.Size = new System.Drawing.Size(59, 28);
            this.cbEntradas.TabIndex = 6;
            this.cbEntradas.SelectedIndexChanged += new System.EventHandler(this.cbEntradas_SelectedIndexChanged);
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Lime;
            this.btnContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContinuar.Location = new System.Drawing.Point(753, 566);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(88, 61);
            this.btnContinuar.TabIndex = 29;
            this.btnContinuar.Text = "Continuar con la orden";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPentradas);
            this.groupBox1.Controls.Add(this.rbPapa);
            this.groupBox1.Controls.Add(this.rbWantan);
            this.groupBox1.Controls.Add(this.rbEnsalada);
            this.groupBox1.Controls.Add(this.rbSopa);
            this.groupBox1.Controls.Add(this.cbEntradas);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(444, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 161);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ENTRADAS";
            // 
            // txtPentradas
            // 
            this.txtPentradas.Location = new System.Drawing.Point(249, 101);
            this.txtPentradas.Name = "txtPentradas";
            this.txtPentradas.Size = new System.Drawing.Size(59, 27);
            this.txtPentradas.TabIndex = 7;
            // 
            // rbPapa
            // 
            this.rbPapa.AutoSize = true;
            this.rbPapa.Location = new System.Drawing.Point(20, 113);
            this.rbPapa.Name = "rbPapa";
            this.rbPapa.Size = new System.Drawing.Size(164, 24);
            this.rbPapa.TabIndex = 3;
            this.rbPapa.TabStop = true;
            this.rbPapa.Text = "Papa a la huancaína";
            this.rbPapa.UseVisualStyleBackColor = true;
            this.rbPapa.CheckedChanged += new System.EventHandler(this.rdPapa_CheckedChanged);
            // 
            // rbWantan
            // 
            this.rbWantan.AutoSize = true;
            this.rbWantan.Location = new System.Drawing.Point(20, 88);
            this.rbWantan.Name = "rbWantan";
            this.rbWantan.Size = new System.Drawing.Size(81, 24);
            this.rbWantan.TabIndex = 2;
            this.rbWantan.TabStop = true;
            this.rbWantan.Text = "Wantan";
            this.rbWantan.UseVisualStyleBackColor = true;
            // 
            // rbEnsalada
            // 
            this.rbEnsalada.AutoSize = true;
            this.rbEnsalada.Location = new System.Drawing.Point(20, 62);
            this.rbEnsalada.Name = "rbEnsalada";
            this.rbEnsalada.Size = new System.Drawing.Size(88, 24);
            this.rbEnsalada.TabIndex = 1;
            this.rbEnsalada.TabStop = true;
            this.rbEnsalada.Text = "Ensalada";
            this.rbEnsalada.UseVisualStyleBackColor = true;
            // 
            // rbSopa
            // 
            this.rbSopa.AutoSize = true;
            this.rbSopa.Location = new System.Drawing.Point(20, 37);
            this.rbSopa.Name = "rbSopa";
            this.rbSopa.Size = new System.Drawing.Size(61, 24);
            this.rbSopa.TabIndex = 0;
            this.rbSopa.TabStop = true;
            this.rbSopa.Text = "Sopa";
            this.rbSopa.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPplatos);
            this.groupBox2.Controls.Add(this.rbPollo);
            this.groupBox2.Controls.Add(this.rbPato);
            this.groupBox2.Controls.Add(this.rbCebiche);
            this.groupBox2.Controls.Add(this.rbChaufa);
            this.groupBox2.Controls.Add(this.cbPlatos);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(444, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 161);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PLATOS DE FONDO";
            // 
            // txtPplatos
            // 
            this.txtPplatos.Location = new System.Drawing.Point(249, 111);
            this.txtPplatos.Name = "txtPplatos";
            this.txtPplatos.Size = new System.Drawing.Size(59, 27);
            this.txtPplatos.TabIndex = 8;
            this.txtPplatos.TextChanged += new System.EventHandler(this.txtPplatos_TextChanged);
            // 
            // rbPollo
            // 
            this.rbPollo.AutoSize = true;
            this.rbPollo.Location = new System.Drawing.Point(20, 113);
            this.rbPollo.Name = "rbPollo";
            this.rbPollo.Size = new System.Drawing.Size(132, 24);
            this.rbPollo.TabIndex = 3;
            this.rbPollo.TabStop = true;
            this.rbPollo.Text = "Pollo a la brasa";
            this.rbPollo.UseVisualStyleBackColor = true;
            // 
            // rbPato
            // 
            this.rbPato.AutoSize = true;
            this.rbPato.Location = new System.Drawing.Point(20, 88);
            this.rbPato.Name = "rbPato";
            this.rbPato.Size = new System.Drawing.Size(131, 24);
            this.rbPato.TabIndex = 2;
            this.rbPato.TabStop = true;
            this.rbPato.Text = "Arroz con Pato";
            this.rbPato.UseVisualStyleBackColor = true;
            // 
            // rbCebiche
            // 
            this.rbCebiche.AutoSize = true;
            this.rbCebiche.Location = new System.Drawing.Point(20, 62);
            this.rbCebiche.Name = "rbCebiche";
            this.rbCebiche.Size = new System.Drawing.Size(81, 24);
            this.rbCebiche.TabIndex = 1;
            this.rbCebiche.TabStop = true;
            this.rbCebiche.Text = "Cebiche";
            this.rbCebiche.UseVisualStyleBackColor = true;
            // 
            // rbChaufa
            // 
            this.rbChaufa.AutoSize = true;
            this.rbChaufa.Location = new System.Drawing.Point(20, 37);
            this.rbChaufa.Name = "rbChaufa";
            this.rbChaufa.Size = new System.Drawing.Size(119, 24);
            this.rbChaufa.TabIndex = 0;
            this.rbChaufa.TabStop = true;
            this.rbChaufa.Text = "Arroz Chaufa";
            this.rbChaufa.UseVisualStyleBackColor = true;
            // 
            // cbPlatos
            // 
            this.cbPlatos.FormattingEnabled = true;
            this.cbPlatos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbPlatos.Location = new System.Drawing.Point(249, 72);
            this.cbPlatos.Name = "cbPlatos";
            this.cbPlatos.Size = new System.Drawing.Size(59, 28);
            this.cbPlatos.TabIndex = 6;
            this.cbPlatos.SelectedIndexChanged += new System.EventHandler(this.cbPlatos_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtPbebidas);
            this.groupBox3.Controls.Add(this.rbAgua);
            this.groupBox3.Controls.Add(this.rbLimonada);
            this.groupBox3.Controls.Add(this.rbGaseosa);
            this.groupBox3.Controls.Add(this.cbBebidas);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(444, 390);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 161);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BEBIDAS";
            // 
            // txtPbebidas
            // 
            this.txtPbebidas.Location = new System.Drawing.Point(249, 88);
            this.txtPbebidas.Name = "txtPbebidas";
            this.txtPbebidas.Size = new System.Drawing.Size(59, 27);
            this.txtPbebidas.TabIndex = 9;
            // 
            // rbAgua
            // 
            this.rbAgua.AutoSize = true;
            this.rbAgua.Location = new System.Drawing.Point(20, 100);
            this.rbAgua.Name = "rbAgua";
            this.rbAgua.Size = new System.Drawing.Size(64, 24);
            this.rbAgua.TabIndex = 2;
            this.rbAgua.TabStop = true;
            this.rbAgua.Text = "Agua";
            this.rbAgua.UseVisualStyleBackColor = true;
            // 
            // rbLimonada
            // 
            this.rbLimonada.AutoSize = true;
            this.rbLimonada.Location = new System.Drawing.Point(20, 74);
            this.rbLimonada.Name = "rbLimonada";
            this.rbLimonada.Size = new System.Drawing.Size(96, 24);
            this.rbLimonada.TabIndex = 1;
            this.rbLimonada.TabStop = true;
            this.rbLimonada.Text = "Limonada";
            this.rbLimonada.UseVisualStyleBackColor = true;
            // 
            // rbGaseosa
            // 
            this.rbGaseosa.AutoSize = true;
            this.rbGaseosa.Location = new System.Drawing.Point(20, 49);
            this.rbGaseosa.Name = "rbGaseosa";
            this.rbGaseosa.Size = new System.Drawing.Size(85, 24);
            this.rbGaseosa.TabIndex = 0;
            this.rbGaseosa.TabStop = true;
            this.rbGaseosa.Text = "Gaseosa";
            this.rbGaseosa.UseVisualStyleBackColor = true;
            // 
            // cbBebidas
            // 
            this.cbBebidas.FormattingEnabled = true;
            this.cbBebidas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbBebidas.Location = new System.Drawing.Point(249, 49);
            this.cbBebidas.Name = "cbBebidas";
            this.cbBebidas.Size = new System.Drawing.Size(59, 28);
            this.cbBebidas.TabIndex = 6;
            this.cbBebidas.SelectedIndexChanged += new System.EventHandler(this.cbBebidas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(205, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "S/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(205, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "S/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(205, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "S/";
            // 
            // CartaDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_Estruct.Properties.Resources.repartidorF;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(853, 679);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.dgvBebidas);
            this.Controls.Add(this.dgvPlatos);
            this.Controls.Add(this.RegresarCarta);
            this.Controls.Add(this.dgvEntradas);
            this.Name = "CartaDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carta";
            this.Load += new System.EventHandler(this.Carta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public DataGridView dgvEntradas;
        private Button RegresarCarta;
        private DataGridViewTextBoxColumn Entradas;
        private DataGridViewTextBoxColumn Precio;
        private DataGridView dgvPlatos;
        private DataGridViewTextBoxColumn Platos;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridView dgvBebidas;
        private DataGridViewTextBoxColumn Bebidas;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private ComboBox cbEntradas;
        private Button btnContinuar;
        private GroupBox groupBox1;
        private RadioButton rbPapa;
        private RadioButton rbWantan;
        private RadioButton rbEnsalada;
        private RadioButton rbSopa;
        private GroupBox groupBox2;
        private RadioButton rbPollo;
        private RadioButton rbPato;
        private RadioButton rbCebiche;
        private RadioButton rbChaufa;
        private ComboBox cbPlatos;
        private GroupBox groupBox3;
        private RadioButton rbAgua;
        private RadioButton rbLimonada;
        private RadioButton rbGaseosa;
        private ComboBox cbBebidas;
        public TextBox txtPentradas;
        public TextBox txtPplatos;
        public TextBox txtPbebidas;
        private Label label3;
        private Label label1;
        private Label label2;
    }
}