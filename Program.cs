using System.Windows.Forms;

namespace Nome
{
    static class Nome
    {
        public static void Main()
        {
            Form tela = new Form();
            tela.Text = "Pessoa";
            tela.Size = new System.Drawing.Size(300, 250);
            tela.Icon = new System.Drawing.Icon("Assets/iconPessoa.ico");

            Label lblNome = new Label();
            lblNome.Text = "Seu nome:";
            lblNome.Location = new Point(10, 70);
            lblNome.Size = new Size(70, 20);

            TextBox txtNome = new TextBox();
            txtNome.Location = new Point(100, 70);
            txtNome.Size = new Size(100, 60);
            txtNome.Width = 150;

            Button botao = new Button();
            botao.Text = "Olá";
            botao.Location = new Point(100, 110);
            botao.Size = new Size(150, 30);
            botao.Click += (sender, e) => MessageBox.Show($"Olá, {(txtNome.Text)}!");

            Button fechar = new Button();
            fechar.Text = "Fechar";
            fechar.Location = new Point(100, 150);
            fechar.Size = new Size(150, 30);
            fechar.Click += (sender, e) => tela.Close();

            tela.Controls.Add(botao);
            tela.Controls.Add(lblNome);
            tela.Controls.Add(txtNome);
            tela.Controls.Add(fechar);

            Application.Run(tela);
        }
    }
}