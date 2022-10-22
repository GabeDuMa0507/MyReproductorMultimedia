namespace MyReproductorMultimedia
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
            this.IbListaArchivos = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mpMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.mpMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // IbListaArchivos
            // 
            this.IbListaArchivos.FormattingEnabled = true;
            this.IbListaArchivos.Location = new System.Drawing.Point(457, 12);
            this.IbListaArchivos.Name = "IbListaArchivos";
            this.IbListaArchivos.Size = new System.Drawing.Size(331, 407);
            this.IbListaArchivos.TabIndex = 1;
            this.IbListaArchivos.SelectedIndexChanged += new System.EventHandler(this.IbListaArchivos_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Abrir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mpMediaPlayer
            // 
            this.mpMediaPlayer.Enabled = true;
            this.mpMediaPlayer.Location = new System.Drawing.Point(12, 12);
            this.mpMediaPlayer.Name = "mpMediaPlayer";
            this.mpMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mpMediaPlayer.OcxState")));
            this.mpMediaPlayer.Size = new System.Drawing.Size(423, 409);
            this.mpMediaPlayer.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IbListaArchivos);
            this.Controls.Add(this.mpMediaPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mpMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mpMediaPlayer;
        private System.Windows.Forms.ListBox IbListaArchivos;
        private System.Windows.Forms.Button button1;
    }
}

