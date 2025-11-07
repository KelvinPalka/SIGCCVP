using System.Windows;

namespace Wpf_Projeto_BD.View
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Password;

            // Exemplo básico de autenticação / mock
            if (usuario == "admin" && senha == "123")
            {
                MessageBox.Show("Login realizado com sucesso!", "Sistema");

                MainWindow main = new MainWindow();
                main.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!",
                                "Erro",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}