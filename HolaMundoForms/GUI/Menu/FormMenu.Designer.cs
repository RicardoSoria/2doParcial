namespace HolaMundoForms.GUI.Menu
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.b = new System.Windows.Forms.Button();
            this.Clientes = new System.Windows.Forms.Button();
            this.Proveedores = new System.Windows.Forms.Button();
            this.Almacen = new System.Windows.Forms.Button();
            this.Sucursales = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b
            // 
            this.b.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b.BackgroundImage")));
            this.b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b.Location = new System.Drawing.Point(44, 140);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(96, 96);
            this.b.TabIndex = 0;
            this.b.UseVisualStyleBackColor = true;
            this.b.Click += new System.EventHandler(this.b_Click);
            // 
            // Clientes
            // 
            this.Clientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Clientes.BackgroundImage")));
            this.Clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Clientes.Location = new System.Drawing.Point(44, 38);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(96, 96);
            this.Clientes.TabIndex = 1;
            this.Clientes.UseVisualStyleBackColor = true;
            this.Clientes.Click += new System.EventHandler(this.Clientes_Click);
            // 
            // Proveedores
            // 
            this.Proveedores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Proveedores.BackgroundImage")));
            this.Proveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Proveedores.Location = new System.Drawing.Point(146, 38);
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Size = new System.Drawing.Size(96, 96);
            this.Proveedores.TabIndex = 2;
            this.Proveedores.UseVisualStyleBackColor = true;
            this.Proveedores.Click += new System.EventHandler(this.button3_Click);
            // 
            // Almacen
            // 
            this.Almacen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Almacen.BackgroundImage")));
            this.Almacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Almacen.Location = new System.Drawing.Point(248, 38);
            this.Almacen.Name = "Almacen";
            this.Almacen.Size = new System.Drawing.Size(96, 96);
            this.Almacen.TabIndex = 3;
            this.Almacen.UseVisualStyleBackColor = true;
            this.Almacen.Click += new System.EventHandler(this.button4_Click);
            // 
            // Sucursales
            // 
            this.Sucursales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sucursales.BackgroundImage")));
            this.Sucursales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Sucursales.Location = new System.Drawing.Point(146, 140);
            this.Sucursales.Name = "Sucursales";
            this.Sucursales.Size = new System.Drawing.Size(96, 96);
            this.Sucursales.TabIndex = 4;
            this.Sucursales.UseVisualStyleBackColor = true;
            this.Sucursales.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(248, 140);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 96);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salir.Location = new System.Drawing.Point(204, 265);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(112, 60);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.Text = "Salir";
            this.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(400, 338);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Sucursales);
            this.Controls.Add(this.Almacen);
            this.Controls.Add(this.Proveedores);
            this.Controls.Add(this.Clientes);
            this.Controls.Add(this.b);
            this.Name = "FrmMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Button Clientes;
        private System.Windows.Forms.Button Proveedores;
        private System.Windows.Forms.Button Almacen;
        private System.Windows.Forms.Button Sucursales;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_salir;
    }
}