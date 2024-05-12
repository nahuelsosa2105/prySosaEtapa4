namespace prySosaEtapa4
{
    partial class frmMainEtapa4
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
            this.btnBarco = new System.Windows.Forms.Button();
            this.btnAvion = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblBarco = new System.Windows.Forms.Label();
            this.lblAvion = new System.Windows.Forms.Label();
            this.lblAuto = new System.Windows.Forms.Label();
            this.lstMostrarVehiculos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBarco
            // 
            this.btnBarco.BackColor = System.Drawing.Color.White;
            this.btnBarco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBarco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarco.Location = new System.Drawing.Point(555, 558);
            this.btnBarco.Name = "btnBarco";
            this.btnBarco.Size = new System.Drawing.Size(235, 43);
            this.btnBarco.TabIndex = 5;
            this.btnBarco.Text = "BARCO";
            this.btnBarco.UseVisualStyleBackColor = false;
            this.btnBarco.Click += new System.EventHandler(this.btnBarco_Click);
            // 
            // btnAvion
            // 
            this.btnAvion.BackColor = System.Drawing.Color.White;
            this.btnAvion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAvion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvion.Location = new System.Drawing.Point(298, 558);
            this.btnAvion.Name = "btnAvion";
            this.btnAvion.Size = new System.Drawing.Size(235, 43);
            this.btnAvion.TabIndex = 4;
            this.btnAvion.Text = "AVIÓN";
            this.btnAvion.UseVisualStyleBackColor = false;
            this.btnAvion.Click += new System.EventHandler(this.btnAvion_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.BackColor = System.Drawing.Color.White;
            this.btnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuto.Location = new System.Drawing.Point(21, 558);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(235, 43);
            this.btnAuto.TabIndex = 3;
            this.btnAuto.Text = "AUTO";
            this.btnAuto.UseVisualStyleBackColor = false;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click_1);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(555, 628);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(235, 40);
            this.btnListar.TabIndex = 6;
            this.btnListar.Text = "LISTAR";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblBarco
            // 
            this.lblBarco.AutoSize = true;
            this.lblBarco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarco.Location = new System.Drawing.Point(559, 26);
            this.lblBarco.Name = "lblBarco";
            this.lblBarco.Size = new System.Drawing.Size(0, 31);
            this.lblBarco.TabIndex = 9;
            // 
            // lblAvion
            // 
            this.lblAvion.AutoSize = true;
            this.lblAvion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvion.Location = new System.Drawing.Point(369, 26);
            this.lblAvion.Name = "lblAvion";
            this.lblAvion.Size = new System.Drawing.Size(0, 31);
            this.lblAvion.TabIndex = 8;
            // 
            // lblAuto
            // 
            this.lblAuto.AutoSize = true;
            this.lblAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuto.Location = new System.Drawing.Point(77, 26);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(0, 31);
            this.lblAuto.TabIndex = 7;
            // 
            // lstMostrarVehiculos
            // 
            this.lstMostrarVehiculos.FormattingEnabled = true;
            this.lstMostrarVehiculos.Location = new System.Drawing.Point(21, 628);
            this.lstMostrarVehiculos.Name = "lstMostrarVehiculos";
            this.lstMostrarVehiculos.Size = new System.Drawing.Size(512, 95);
            this.lstMostrarVehiculos.TabIndex = 10;
            // 
            // frmMainEtapa4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::prySosaEtapa4.Properties.Resources.FondoEtapa_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(799, 741);
            this.Controls.Add(this.lstMostrarVehiculos);
            this.Controls.Add(this.lblBarco);
            this.Controls.Add(this.lblAvion);
            this.Controls.Add(this.lblAuto);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnBarco);
            this.Controls.Add(this.btnAvion);
            this.Controls.Add(this.btnAuto);
            this.Name = "frmMainEtapa4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CREAR OBJETOS EN LISTA";
            this.Load += new System.EventHandler(this.frmMainEtapa4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBarco;
        private System.Windows.Forms.Button btnAvion;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblBarco;
        private System.Windows.Forms.Label lblAvion;
        private System.Windows.Forms.Label lblAuto;
        private System.Windows.Forms.ListBox lstMostrarVehiculos;
    }
}

