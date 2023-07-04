namespace Send_Data_Arduino
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_ON = new System.Windows.Forms.Button();
            this.btn_OFF = new System.Windows.Forms.Button();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // btn_ON
            // 
            this.btn_ON.Location = new System.Drawing.Point(139, 106);
            this.btn_ON.Name = "btn_ON";
            this.btn_ON.Size = new System.Drawing.Size(107, 58);
            this.btn_ON.TabIndex = 0;
            this.btn_ON.Text = "ON LED";
            this.btn_ON.UseVisualStyleBackColor = true;
            this.btn_ON.Click += new System.EventHandler(this.btn_ON_Click);
            // 
            // btn_OFF
            // 
            this.btn_OFF.Location = new System.Drawing.Point(252, 106);
            this.btn_OFF.Name = "btn_OFF";
            this.btn_OFF.Size = new System.Drawing.Size(107, 58);
            this.btn_OFF.TabIndex = 1;
            this.btn_OFF.Text = "OFF LED";
            this.btn_OFF.UseVisualStyleBackColor = true;
            this.btn_OFF.Click += new System.EventHandler(this.btn_OFF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 271);
            this.Controls.Add(this.btn_OFF);
            this.Controls.Add(this.btn_ON);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ON;
        private System.Windows.Forms.Button btn_OFF;
        private System.IO.Ports.SerialPort SerialPort;
    }
}

