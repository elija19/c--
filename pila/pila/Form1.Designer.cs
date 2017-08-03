namespace pila
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmaximo = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btncrear = new System.Windows.Forms.Button();
            this.btnpush = new System.Windows.Forms.Button();
            this.btnpop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "PILA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "MAXIMO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "NUMERO";
            // 
            // txtmaximo
            // 
            this.txtmaximo.Location = new System.Drawing.Point(124, 108);
            this.txtmaximo.Name = "txtmaximo";
            this.txtmaximo.Size = new System.Drawing.Size(100, 20);
            this.txtmaximo.TabIndex = 3;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(135, 196);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 4;
            // 
            // btncrear
            // 
            this.btncrear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncrear.Location = new System.Drawing.Point(321, 101);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(75, 23);
            this.btncrear.TabIndex = 5;
            this.btncrear.Text = "CREAR";
            this.btncrear.UseVisualStyleBackColor = false;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // btnpush
            // 
            this.btnpush.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnpush.Location = new System.Drawing.Point(321, 141);
            this.btnpush.Name = "btnpush";
            this.btnpush.Size = new System.Drawing.Size(75, 23);
            this.btnpush.TabIndex = 6;
            this.btnpush.Text = "PUSH";
            this.btnpush.UseVisualStyleBackColor = false;
            this.btnpush.Click += new System.EventHandler(this.btnpush_Click);
            // 
            // btnpop
            // 
            this.btnpop.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnpop.Location = new System.Drawing.Point(321, 194);
            this.btnpop.Name = "btnpop";
            this.btnpop.Size = new System.Drawing.Size(75, 23);
            this.btnpop.TabIndex = 7;
            this.btnpop.Text = "POP";
            this.btnpop.UseVisualStyleBackColor = false;
            this.btnpop.Click += new System.EventHandler(this.btnpop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 279);
            this.Controls.Add(this.btnpop);
            this.Controls.Add(this.btnpush);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtmaximo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmaximo;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Button btnpush;
        private System.Windows.Forms.Button btnpop;
    }
}

