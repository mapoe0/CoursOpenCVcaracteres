
namespace CoursOpenCVcaracteres
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pbTraitement1 = new System.Windows.Forms.PictureBox();
            this.pbTraitement2 = new System.Windows.Forms.PictureBox();
            this.pbTraitement3 = new System.Windows.Forms.PictureBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtResult2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTraitement1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTraitement2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTraitement3)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(12, 12);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(256, 256);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // pbTraitement1
            // 
            this.pbTraitement1.Location = new System.Drawing.Point(296, 12);
            this.pbTraitement1.Name = "pbTraitement1";
            this.pbTraitement1.Size = new System.Drawing.Size(256, 256);
            this.pbTraitement1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTraitement1.TabIndex = 1;
            this.pbTraitement1.TabStop = false;
            // 
            // pbTraitement2
            // 
            this.pbTraitement2.Location = new System.Drawing.Point(590, 12);
            this.pbTraitement2.Name = "pbTraitement2";
            this.pbTraitement2.Size = new System.Drawing.Size(256, 256);
            this.pbTraitement2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTraitement2.TabIndex = 2;
            this.pbTraitement2.TabStop = false;
            // 
            // pbTraitement3
            // 
            this.pbTraitement3.Location = new System.Drawing.Point(885, 12);
            this.pbTraitement3.Name = "pbTraitement3";
            this.pbTraitement3.Size = new System.Drawing.Size(256, 256);
            this.pbTraitement3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTraitement3.TabIndex = 3;
            this.pbTraitement3.TabStop = false;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(640, 289);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(415, 284);
            this.txtResult.TabIndex = 4;
            // 
            // txtResult2
            // 
            this.txtResult2.Location = new System.Drawing.Point(79, 289);
            this.txtResult2.Multiline = true;
            this.txtResult2.Name = "txtResult2";
            this.txtResult2.Size = new System.Drawing.Size(415, 284);
            this.txtResult2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 585);
            this.Controls.Add(this.txtResult2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.pbTraitement3);
            this.Controls.Add(this.pbTraitement2);
            this.Controls.Add(this.pbTraitement1);
            this.Controls.Add(this.pbImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTraitement1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTraitement2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTraitement3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.PictureBox pbTraitement1;
        private System.Windows.Forms.PictureBox pbTraitement2;
        private System.Windows.Forms.PictureBox pbTraitement3;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtResult2;
    }
}

