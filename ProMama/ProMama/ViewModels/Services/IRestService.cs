using ProMama.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProMama.ViewModels.Services
{
    public interface IRestService
    {
        Task<JsonMessage> UsuarioCreate(Usuario u);

        Task<JsonMessage> UsuarioUpdate(Usuario u);

        Task<JsonMessage> UsuarioLogin(Usuario u);

        Task<Usuario> UsuarioRead(JsonMessage msg);

        Task<JsonMessage> CriancaCreate(Crianca c, string token);

        Task<JsonMessage> CriancaUpdate(Crianca c, string token);

        Task<List<Crianca>> CriancasReadByUser(Usuario u);

        Task<List<Informacao>> InformacoesRead(string token);

        Task<JsonMessage> ConversaCreate(JsonMessage msg, string token);

        Task<List<Conversa>> ConversasRead(string token);

        Task<List<Conversa>> ConversasUsuarioRead(string token);

        Task<List<Bairro>> BairrosRead();

        Task<List<Posto>> PostosRead(string token);

        Task<Sincronizacao> SincronizacaoRead(string token);

        Task<JsonMessage> SincronizacaoBairroRead();

        Task<List<Notificacao>> NotificacoesRead(string token);

        Task<JsonMessage> FotoCriancaUpload(Foto foto, string token);

        Task<JsonMessage> FotoUserUpload(string foto, string token);

        Task<List<Foto>> FotoRead(string token);

        Task<List<DuvidaFrequente>> DuvidasFrequentesRead(string token);

        Task<JsonMessage> AcompanhamentoUpload(Acompanhamento a, string token);

        Task<List<Acompanhamento>> AcompanhamentoRead(string token);

        Task<JsonMessage> MarcoUpload(Marco m, string token);

        Task<List<Marco>> MarcoRead(string token);

        Task<JsonMessage> RecuperarSenha(JsonMessage msg);

        Task<JsonMessage> RemoverFoto(int foto, string token);

        Task<JsonMessage> RemoverCrianca(int crianca, string token);
    }
}
