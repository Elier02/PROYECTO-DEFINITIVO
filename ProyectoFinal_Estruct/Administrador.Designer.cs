namespace ProyectoFinal_Estruct
{
    partial class Administrador
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuarioA = new System.Windows.Forms.TextBox();
            this.btnUsuarioA = new System.Windows.Forms.Button();
            this.txtContraseñaA = new System.Windows.Forms.TextBox();
            this.btnRegresarA = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(216, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "PURO SABOR PERUANO";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUsuarioA);
            this.groupBox1.Controls.Add(this.btnUsuarioA);
            this.groupBox1.Controls.Add(this.txtContraseñaA);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(152, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 277);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGIN ADMINISTRADOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(115, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(115, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // txtUsuarioA
            // 
            this.txtUsuarioA.Location = new System.Drawing.Point(245, 64);
            this.txtUsuarioA.Name = "txtUsuarioA";
            this.txtUsuarioA.Size = new System.Drawing.Size(122, 35);
            this.txtUsuarioA.TabIndex = 0;
            // 
            // btnUsuarioA
            // 
            this.btnUsuarioA.BackColor = System.Drawing.Color.Lime;
            this.btnUsuarioA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarioA.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsuarioA.Location = new System.Drawing.Point(170, 202);
            this.btnUsuarioA.Name = "btnUsuarioA";
            this.btnUsuarioA.Size = new System.Drawing.Size(121, 42);
            this.btnUsuarioA.TabIndex = 1;
            this.btnUsuarioA.Text = "INGRESAR";
            this.btnUsuarioA.UseVisualStyleBackColor = false;
            this.btnUsuarioA.Click += new System.EventHandler(this.btnUsuarioA_Click);
            // 
            // txtContraseñaA
            // 
            this.txtContraseñaA.Location = new System.Drawing.Point(245, 103);
            this.txtContraseñaA.Name = "txtContraseñaA";
            this.txtContraseñaA.Size = new System.Drawing.Size(122, 35);
            this.txtContraseñaA.TabIndex = 0;
            this.txtContraseñaA.UseSystemPasswordChar = true;
            // 
            // btnRegresarA
            // 
            this.btnRegresarA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRegresarA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresarA.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegresarA.Location = new System.Drawing.Point(602, 471);
            this.btnRegresarA.Name = "btnRegresarA";
            this.btnRegresarA.Size = new System.Drawing.Size(121, 42);
            this.btnRegresarA.TabIndex = 3;
            this.btnRegresarA.Text = "REGRESAR";
            this.btnRegresarA.UseVisualStyleBackColor = false;
            this.btnRegresarA.Click += new System.EventHandler(this.btnRegresarA_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_Estruct.Properties.Resources.administrador;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(763, 570);
            this.Controls.Add(this.btnRegresarA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtUsuarioA;
        private Button btnUsuarioA;
        private TextBox txtContraseñaA;
        private Button btnRegresarA;
    }
}