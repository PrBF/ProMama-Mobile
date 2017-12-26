﻿using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProMama.View.Services
{
    class MessageService : ViewModel.Services.IMessageService
    {
        public async Task AlertDialog(string message)
        {
            await Application.Current.MainPage.DisplayAlert("Erro", message, "Voltar");
        }

        public async Task<bool> ConfirmationDialog(string message)
        {
            return await Application.Current.MainPage.DisplayAlert("Confirmação", message, "Sim", "Não");
        }
    }
}
