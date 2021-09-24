using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Enviador_de_Emails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "[Email]")
            {
                txtEmail.Clear();
                txtEmail.ForeColor = Color.FromArgb(0, 0, 255);
            }
            //Limpa o campo de email quando clicado.
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {

            if (txtEmail.Text == "")
            {
                txtEmail.ForeColor = Color.FromArgb(200, 200, 200);
                txtEmail.Text = "[Email]";
            }
            // Quando você não está escrevendo dentro desta caixa e ela estiver vazia irá mostrar a palavra [Email].
        }

        private void txtAssunto_Enter(object sender, EventArgs e)
        {
            if (txtAssunto.Text == "[Assunto]")
            {
                txtAssunto.Clear();
                txtAssunto.ForeColor = Color.FromArgb(0, 0, 255);
            }
            //Limpa o campo de Assunto quando clicado.
        }

        private void txtAssunto_Leave(object sender, EventArgs e)
        {
            if (txtAssunto.Text == "")
            {
                txtAssunto.ForeColor = Color.FromArgb(200, 200, 200);
                txtAssunto.Text = "[Assunto]";
            }
            // Quando você não está escrevendo dentro desta caixa e ela estiver vazia irá mostrar a palavra [Assunto].
        }

        private void txtCorpo_Enter(object sender, EventArgs e)
        {
            if (txtCorpo.Text == "[Mensagem]")
            {
                txtCorpo.Clear();
                txtCorpo.ForeColor = Color.FromArgb(0, 0, 255);
            }
            // Limpa o campo da mensagem quando clicado.
        }

        private void txtCorpo_Leave(object sender, EventArgs e)
        {
            if (txtCorpo.Text == "")
            {
                txtCorpo.ForeColor = Color.FromArgb(0, 0, 255);
                txtCorpo.Text = "[Mensagem]";
            }
            // Quando você não está escrevendo dentro desta caixa e ela estiver vazia irá mostrar a palavra [Mensagem].
        }

        private void bttnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // Sai da aplicação.
        }


        private void bttnAnexar_Click(object sender, EventArgs e)
        {
            var anexo = new OpenFileDialog();
            // Abre a janela do windows.
            anexo.InitialDirectory = @"Seu local aqui";
            // Designa o local inicial que vai abrir a janela do windows.
            if (anexo.ShowDialog() == DialogResult.OK)
            {
                txtAnexos.Text = anexo.FileName;
                // Coloca o lugar do anexo dentro da caixa de texto.
            }
        }
        


        private void bttnMandar_Click(object sender, EventArgs e)
        {
            string destinatario, remetente, senha, corpo;
            MailMessage mensagem = new MailMessage();
            // Inicia uma nova mensagem.
            destinatario = txtEmail.Text;
            // Define o destinatario como sendo qual for colocado na caixa de texto.
            remetente = "Seu email aqui";
            // Seu email aqui, daonde irá mandar o email.
            // *******IMPORTANTE*******: O email do qual você irá enviar tem que ter ativar o acesso a apps menos seguros e ativar o IMAP em seu gmail. Para isso:
            // Vá em segurança e desça para acesso a apps menos seguros e o ative, no gmail vá em configurações e ative o IMAP. 
            senha = "A senha do seu email aqui";
            // Senha do seu email aqui.
            corpo = txtCorpo.Text;
            // Corpo do seu email está sendo definido na caixa de texto.
            if(txtAnexos.Text != "")
            {
                 mensagem.Attachments.Add(new Attachment(txtAnexos.Text));
            }
            // Se sua caixa de texto estiver vazia, sua aplicação irá adicionar o caminho do arquivo como anexo.
            mensagem.To.Add(destinatario);
            // Adiciona o destinatário.
            mensagem.From = new MailAddress(remetente);
            // Adiciona o remetente.
            mensagem.Body = corpo;
            // Adiciona o corpo da mensagem.
            mensagem.Subject = txtAssunto.Text;
            // Define o assunto da mensagem como sendo a caixa de texto.
            mensagem.IsBodyHtml = true;
            // Diz se a mensagem está em html ou não e como está sendo mandanda para o google está em html.
            SmtpClient cliente = new SmtpClient("smtp.gmail.com");
            // Cria o sevidor SMTP que define o email como sendo no gmail.
            cliente.EnableSsl = true;
            // Define se o cliente tem o Ssl(Secure Sockets Layer) e como é um gmail ele tem, pois tem credenciais.
            cliente.Port = 587;
            // Define o Port que o google usa.
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            // Define como o email será enviado, no caso ele será enviado por um servidor smtp pela internet.
            cliente.Credentials = new NetworkCredential(remetente, senha);
            // Define as credenciais(senha e o usuário);
            try
            {
                cliente.Send(mensagem);
                DialogResult codigo = MessageBox.Show("Email enviado com sucesso!", "Email enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(codigo == DialogResult.OK)
                {
                    txtEmail.Clear();
                    txtAssunto.Clear();
                    txtCorpo.Clear();
                    txtAnexos.Clear();
                }
                // Se a mensagem for enviada irá limpar os campos de texto e irá mostrar uma mensagem que a mensagem foi enviada.
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
                // Em caso de erro mostra o erro na tela.
            }
        }
        
    private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    

}
