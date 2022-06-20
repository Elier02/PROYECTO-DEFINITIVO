namespace ProyectoFinal_Estruct
{
    partial class MenuMeseros
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
            this.btnAtenderR = new System.Windows.Forms.Button();
            this.btnAtenderD = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.rtbDelivery = new System.Windows.Forms.RichTextBox();
            this.rtbRestaurante = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAtenderR
            // 
            this.btnAtenderR.BackColor = System.Drawing.Color.Lime;
            this.btnAtenderR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtenderR.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtenderR.Location = new System.Drawing.Point(666, 276);
            this.btnAtenderR.Name = "btnAtenderR";
            this.btnAtenderR.Size = new System.Drawing.Size(121, 41);
            this.btnAtenderR.TabIndex = 1;
            this.btnAtenderR.Text = "ATENDER";
            this.btnAtenderR.UseVisualStyleBackColor = false;
            this.btnAtenderR.Click += new System.EventHandler(this.btnAtenderR_Click);
            // 
            // btnAtenderD
            // 
            this.btnAtenderD.BackColor = System.Drawing.Color.Lime;
            this.btnAtenderD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtenderD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtenderD.Location = new System.Drawing.Point(933, 34);
            this.btnAtenderD.Name = "btnAtenderD";
            this.btnAtenderD.Size = new System.Drawing.Size(121, 41);
            this.btnAtenderD.TabIndex = 1;
            this.btnAtenderD.Text = "ATENDER";
            this.btnAtenderD.UseVisualStyleBackColor = false;
            this.btnAtenderD.Click += new System.EventHandler(this.btnAtenderD_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegresar.Location = new System.Drawing.Point(933, 566);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(121, 41);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // rtbDelivery
            // 
            this.rtbDelivery.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbDelivery.Location = new System.Drawing.Point(39, 81);
            this.rtbDelivery.Name = "rtbDelivery";
            this.rtbDelivery.Size = new System.Drawing.Size(1015, 143);
            this.rtbDelivery.TabIndex = 2;
            this.rtbDelivery.Text = "";
            // 
            // rtbRestaurante
            // 
            this.rtbRestaurante.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbRestaurante.Location = new System.Drawing.Point(39, 323);
            this.rtbRestaurante.Name = "rtbRestaurante";
            this.rtbRestaurante.Size = new System.Drawing.Size(748, 143);
            this.rtbRestaurante.TabIndex = 3;
            this.rtbRestaurante.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "PEDIDOS DELIVERY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(39, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "PEDIDOS EN EL RESTAURANTE";
            // 
            // MenuMeseros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_Estruct.Properties.Resources._10_tips_que_todo_mesero_debe_poner_en_practica;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1116, 639);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbRestaurante);
            this.Controls.Add(this.rtbDelivery);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAtenderD);
            this.Controls.Add(this.btnAtenderR);
            this.Name = "MenuMeseros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MenuMeseros";
            this.Load += new System.EventHandler(this.MenuMeseros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnAtenderR;
        private DataGridViewTextBoxColumn a;
        private Button btnAtenderD;
        private Button btnRegresar;
        private RichTextBox rtbDelivery;
        private RichTextBox rtbRestaurante;
        private Label label1;
        private Label label2;
    }
}