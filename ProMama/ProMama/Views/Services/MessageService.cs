using ProMama.ViewModels.Services;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProMama.Views.Services
{
    class MessageService : IMessageService
    {
        public async Task AlertDialog(string mensagem)
        {
            await Application.Current.MainPage.DisplayAlert("Aviso", mensagem, "OK");
        }

        public async Task<bool> ConfirmationDialog(string mensagem, string confirmacao, string negacao)
        {
            return await Application.Current.MainPage.DisplayAlert("Confirmação", mensagem, confirmacao, negacao);
        }

        public async Task<string> ActionSheet(string mensagem, string[] opcoes)
        {
            return await Application.Current.MainPage.DisplayActionSheet(mensagem, "Cancelar", null, opcoes);
        }
    }
}
