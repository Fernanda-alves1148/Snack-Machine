namespace Exerciciosnackmachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pcbxsnackmachine = new System.Windows.Forms.PictureBox();
            this.lblsnackmachine = new System.Windows.Forms.Label();
            this.barradeprogresso = new System.Windows.Forms.ProgressBar();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxsnackmachine)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbxsnackmachine
            // 
            this.pcbxsnackmachine.Image = ((System.Drawing.Image)(resources.GetObject("pcbxsnackmachine.Image")));
            this.pcbxsnackmachine.Location = new System.Drawing.Point(491, 12);
            this.pcbxsnackmachine.Name = "pcbxsnackmachine";
            this.pcbxsnackmachine.Size = new System.Drawing.Size(285, 426);
            this.pcbxsnackmachine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxsnackmachine.TabIndex = 0;
            this.pcbxsnackmachine.TabStop = false;
            // 
            // lblsnackmachine
            // 
            this.lblsnackmachine.AutoSize = true;
            this.lblsnackmachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsnackmachine.Location = new System.Drawing.Point(58, 46);
            this.lblsnackmachine.Name = "lblsnackmachine";
            this.lblsnackmachine.Size = new System.Drawing.Size(176, 29);
            this.lblsnackmachine.TabIndex = 1;
            this.lblsnackmachine.Text = "Snack Machine";
            // 
            // barradeprogresso
            // 
            this.barradeprogresso.Location = new System.Drawing.Point(63, 226);
            this.barradeprogresso.Name = "barradeprogresso";
            this.barradeprogresso.Size = new System.Drawing.Size(341, 35);
            this.barradeprogresso.TabIndex = 2;
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.barradeprogresso);
            this.Controls.Add(this.lblsnackmachine);
            this.Controls.Add(this.pcbxsnackmachine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbxsnackmachine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbxsnackmachine;
        private System.Windows.Forms.Label lblsnackmachine;
        private System.Windows.Forms.ProgressBar barradeprogresso;
        private System.Windows.Forms.Timer Temporizador;
    }
}

