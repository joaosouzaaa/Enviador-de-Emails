
namespace Enviador_de_Emails
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtCorpo = new System.Windows.Forms.TextBox();
            this.bttnAnexar = new System.Windows.Forms.Button();
            this.bttnMandar = new System.Windows.Forms.Button();
            this.bttnSair = new System.Windows.Forms.Button();
            this.txtAnexos = new System.Windows.Forms.TextBox();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Enviador_de_Emails.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(49, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enviador de emails";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtEmail.Location = new System.Drawing.Point(12, 191);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(334, 30);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "[Email]";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtAssunto
            // 
            this.txtAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssunto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtAssunto.Location = new System.Drawing.Point(12, 237);
            this.txtAssunto.Multiline = true;
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(334, 30);
            this.txtAssunto.TabIndex = 2;
            this.txtAssunto.Text = "[Assunto]";
            this.txtAssunto.Enter += new System.EventHandler(this.txtAssunto_Enter);
            this.txtAssunto.Leave += new System.EventHandler(this.txtAssunto_Leave);
            // 
            // txtCorpo
            // 
            this.txtCorpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorpo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtCorpo.Location = new System.Drawing.Point(12, 273);
            this.txtCorpo.Multiline = true;
            this.txtCorpo.Name = "txtCorpo";
            this.txtCorpo.Size = new System.Drawing.Size(334, 147);
            this.txtCorpo.TabIndex = 2;
            this.txtCorpo.Text = "[Mensagem]";
            this.txtCorpo.Enter += new System.EventHandler(this.txtCorpo_Enter);
            this.txtCorpo.Leave += new System.EventHandler(this.txtCorpo_Leave);
            // 
            // bttnAnexar
            // 
            this.bttnAnexar.BackColor = System.Drawing.SystemColors.Highlight;
            this.bttnAnexar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAnexar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAnexar.ForeColor = System.Drawing.SystemColors.Window;
            this.bttnAnexar.Location = new System.Drawing.Point(201, 426);
            this.bttnAnexar.Name = "bttnAnexar";
            this.bttnAnexar.Size = new System.Drawing.Size(145, 32);
            this.bttnAnexar.TabIndex = 3;
            this.bttnAnexar.Text = "Anexar Arquivos";
            this.bttnAnexar.UseVisualStyleBackColor = false;
            this.bttnAnexar.Click += new System.EventHandler(this.bttnAnexar_Click);
            // 
            // bttnMandar
            // 
            this.bttnMandar.BackColor = System.Drawing.SystemColors.Highlight;
            this.bttnMandar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMandar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnMandar.ForeColor = System.Drawing.SystemColors.Window;
            this.bttnMandar.Location = new System.Drawing.Point(12, 464);
            this.bttnMandar.Name = "bttnMandar";
            this.bttnMandar.Size = new System.Drawing.Size(334, 69);
            this.bttnMandar.TabIndex = 4;
            this.bttnMandar.Text = "Enviar email";
            this.bttnMandar.UseVisualStyleBackColor = false;
            this.bttnMandar.Click += new System.EventHandler(this.bttnMandar_Click);
            // 
            // bttnSair
            // 
            this.bttnSair.BackColor = System.Drawing.SystemColors.Highlight;
            this.bttnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSair.ForeColor = System.Drawing.SystemColors.Window;
            this.bttnSair.Location = new System.Drawing.Point(106, 539);
            this.bttnSair.Name = "bttnSair";
            this.bttnSair.Size = new System.Drawing.Size(127, 34);
            this.bttnSair.TabIndex = 5;
            this.bttnSair.Text = "Sair";
            this.bttnSair.UseVisualStyleBackColor = false;
            this.bttnSair.Click += new System.EventHandler(this.bttnSair_Click);
            // 
            // txtAnexos
            // 
            this.txtAnexos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnexos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtAnexos.Location = new System.Drawing.Point(12, 433);
            this.txtAnexos.Multiline = true;
            this.txtAnexos.Name = "txtAnexos";
            this.txtAnexos.Size = new System.Drawing.Size(183, 22);
            this.txtAnexos.TabIndex = 6;
            this.txtAnexos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(358, 585);
            this.Controls.Add(this.txtAnexos);
            this.Controls.Add(this.bttnSair);
            this.Controls.Add(this.bttnMandar);
            this.Controls.Add(this.bttnAnexar);
            this.Controls.Add(this.txtCorpo);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.TextBox txtCorpo;
        private System.Windows.Forms.Button bttnAnexar;
        private System.Windows.Forms.Button bttnMandar;
        private System.Windows.Forms.Button bttnSair;
        private System.Windows.Forms.TextBox txtAnexos;
        private System.Windows.Forms.OpenFileDialog ofd1;
    }
}

