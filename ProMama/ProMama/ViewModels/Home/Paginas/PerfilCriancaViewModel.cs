using ProMama.Models;
using ProMama.ViewModels.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProMama.ViewModels.Home.Paginas
{
    class PerfilCriancaViewModel : ViewModelBase
    {
        private Aplicativo app = Aplicativo.Instance;

        private ImageSource _foto;
        public ImageSource Foto
        {
            get
            {
                return _foto;
            }
            set
            {
                _foto = value;
                Notify("Foto");
            }
        }

        private string _nomeCompleto;
        public string NomeCompleto
        {
            get { return _nomeCompleto; }
            set
            {
                _nomeCompleto = value;
                Notify("NomeCompleto");
            }
        }

        private string _dataNascimento;
        public string DataNascimento
        {
            get { return _dataNascimento; }
            set
            {
                _dataNascimento = value;
                Notify("DataNascimento");
            }
        }

        private string _sexo;
        public string Sexo
        {
            get { return _sexo; }
            set
            {
                _sexo = value;
                Notify("Sexo");
            }
        }

        private string _pesoAoNascer;
        public string PesoAoNascer
        {
            get { return _pesoAoNascer; }
            set
            {
                _pesoAoNascer = value;
                Notify("PesoAoNascer");
            }
        }

        private string _alturaAoNascer;
        public string AlturaAoNascer
        {
            get { return _alturaAoNascer; }
            set
            {
                _alturaAoNascer = value;
                Notify("AlturaAoNascer");
            }
        }

        private string _tipoDeParto;
        public string TipoDeParto
        {
            get { return _tipoDeParto; }
            set
            {
                _tipoDeParto = value;
                Notify("TipoDeParto");
            }
        }

        private string _idadeGestacional;
        public string IdadeGestacional
        {
            get { return _idadeGestacional; }
            set
            {
                _idadeGestacional = value;
                Notify("IdadeGestacional");
            }
        }

        private string _outrasInformacoes;
        public string OutrasInformacoes
        {
            get { return _outrasInformacoes; }
            set
            {
                _outrasInformacoes = value;
                Notify("OutrasInformacoes");
            }
        }

        private INavigation Navigation { get; set; }
        public ICommand EditarCommand { get; set; }

        private readonly INavigationService NavigationService;
        private readonly IMessageService MessageService;

        public PerfilCriancaViewModel(INavigation _navigation)
        {
            Foto              = App.FotoDatabase.GetMostRecent(app._crianca.crianca_id);
            NomeCompleto      = app._crianca.crianca_primeiro_nome + " " + app._crianca.crianca_sobrenome;
            DataNascimento    = app._crianca.crianca_dataNascimento.ToString("dd/MM/yyyy");
            Sexo              = app._crianca.crianca_sexo == 1 ? "Menina" : "Menino";
            PesoAoNascer      = app._crianca.crianca_pesoAoNascer != 0 ? app._crianca.crianca_pesoAoNascer.ToString() + "g" : "";
            AlturaAoNascer    = app._crianca.crianca_alturaAoNascer != 0 ? app._crianca.crianca_alturaAoNascer.ToString() + "cm" : "";
            TipoDeParto       = app._crianca.crianca_tipo_parto != -1 ? (app._crianca.crianca_tipo_parto == 1 ? "Cesáreo" : "Normal") : "";
            IdadeGestacional  = app._crianca.crianca_idade_gestacional >= 20 ? app._crianca.crianca_idade_gestacional + " semanas" : "";
            OutrasInformacoes = app._crianca.crianca_outrasInformacoes;

            Navigation = _navigation;
            EditarCommand = new Command(Editar);

            MessageService = DependencyService.Get<IMessageService>();
            NavigationService = DependencyService.Get<INavigationService>();
        }

        private async void Editar()
        {
            await NavigationService.NavigatePerfilCriancaEdit(Navigation);
        }
    }
}
