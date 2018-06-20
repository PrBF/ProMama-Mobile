﻿using DLToolkit.Forms.Controls;
using MarcelloDB;
using Plugin.Iconize;
using ProMama.Database;
using ProMama.Database.Controllers;
using ProMama.Models;
using ProMama.Views.Home;
using ProMama.Views.Inicio;
using ProMama.Views.Services;
using ProMama.ViewModels.Services;
using Xamarin.Forms;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System.Threading.Tasks;

namespace ProMama
{
    public partial class App : Application
    {
        static Session _db;

        static ConfigDatabaseController _configDatabase;
        static UsuarioDatabaseController _usuarioDatabase;
        static CriancaDatabaseController _criancaDatabase;
        static BairroDatabaseController _bairroDatabase;
        static PostoDatabaseController _postoDatabase;
        static ConversaDatabaseController _conversaDatabase;
        static InformacaoDatabaseController _informacaoDatabase;
        static SincronizacaoDatabaseController _sincronizacaoDatabase;
        static NotificacaoDatabaseController _notificacaoDatabase;
        static FotoDatabaseController _fotoDatabase;
        static ImagemDatabaseController _imagemDatabase;
        static AcompanhamentoDatabaseController _acompanhamentoDatabase;
        static MarcoDatabaseController _marcoDatabase;
        static DuvidaFrequenteDatabaseController _duvidaFrequenteDatabase;

        private Aplicativo app = Aplicativo.Instance;

        public App()
        {
            // Iconize
            Iconize.With(new Plugin.Iconize.Fonts.FontAwesomeModule());

            DependencyService.Register<INavigationService, NavigationService>();
            DependencyService.Register<IMessageService, MessageService>();
            DependencyService.Register<IRestService, RestService>();

            InitializeComponent();

            // FlowListView
            FlowListView.Init();

            //storagePermission();

            // verifica se usuário já está logado
            app._sync = SincronizacaoDatabase.Find();
            var cfg = ConfigDatabase.Find();

            if (cfg != null)
            {
                app._usuario = cfg.config_usuario;
                app._crianca = cfg.config_crianca;
                MainPage = new Home();
            }
            else
            {
                MainPage = new IntroducaoView();
            }
        }

        /*private async void storagePermission()
        {
            var MessageService = DependencyService.Get<IMessageService>();
            try
            {
                var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Storage);
                if (status != PermissionStatus.Granted)
                {
                    if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.Storage))
                    {
                        await MessageService.AlertDialog("O aplicativo precisa de acesso ao armazenamento local para pleno funcionamento.");
                    }

                    var results = await CrossPermissions.Current.RequestPermissionsAsync(Permission.Storage);
                    //Best practice to always check that the key exists
                    if (results.ContainsKey(Permission.Storage))
                        status = results[Permission.Storage];
                }

                if (status == PermissionStatus.Granted)
                {
                    var results = await CrossGeolocator.Current.GetPositionAsync(10000);
                    LabelGeolocation.Text = "Lat: " + results.Latitude + " Long: " + results.Longitude;
                }
                else if (status != PermissionStatus.Unknown)
                {
                    await DisplayAlert("Location Denied", "Can not continue, try again.", "OK");
                }
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Deu ruim: " + ex);
            }
        }*/

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static Session DB
        {
            get
            {
                if (_db == null)
                {
                    _db = DependencyService.Get<IMarcelloDB>().GetSession();
                }
                return _db;
            }
        }

        public static ConfigDatabaseController ConfigDatabase
        {
            get
            {
                if (_configDatabase == null)
                {
                    _configDatabase = new ConfigDatabaseController();
                }
                return _configDatabase;
            }
        }

        public static UsuarioDatabaseController UsuarioDatabase
        {
            get
            {
                if (_usuarioDatabase == null)
                {
                    _usuarioDatabase = new UsuarioDatabaseController();
                }
                return _usuarioDatabase;
            }
        }

        public static CriancaDatabaseController CriancaDatabase
        {
            get
            {
                if (_criancaDatabase == null)
                {
                    _criancaDatabase = new CriancaDatabaseController();
                }
                return _criancaDatabase;
            }
        }

        public static BairroDatabaseController BairroDatabase
        {
            get
            {
                if (_bairroDatabase == null)
                {
                    _bairroDatabase = new BairroDatabaseController();
                }
                return _bairroDatabase;
            }
        }

        public static PostoDatabaseController PostoDatabase
        {
            get
            {
                if (_postoDatabase == null)
                {
                    _postoDatabase = new PostoDatabaseController();
                }
                return _postoDatabase;
            }
        }

        public static ConversaDatabaseController ConversaDatabase
        {
            get
            {
                if (_conversaDatabase == null)
                {
                    _conversaDatabase = new ConversaDatabaseController();
                }
                return _conversaDatabase;
            }
        }

        public static InformacaoDatabaseController InformacaoDatabase
        {
            get
            {
                if (_informacaoDatabase == null)
                {
                    _informacaoDatabase = new InformacaoDatabaseController();
                }
                return _informacaoDatabase;
            }
        }

        public static SincronizacaoDatabaseController SincronizacaoDatabase
        {
            get
            {
                if (_sincronizacaoDatabase == null)
                {
                    _sincronizacaoDatabase = new SincronizacaoDatabaseController();
                }
                return _sincronizacaoDatabase;
            }
        }

        public static NotificacaoDatabaseController NotificacaoDatabase
        {
            get
            {
                if (_notificacaoDatabase == null)
                {
                    _notificacaoDatabase = new NotificacaoDatabaseController();
                }
                return _notificacaoDatabase;
            }
        }

        public static FotoDatabaseController FotoDatabase
        {
            get
            {
                if (_fotoDatabase == null)
                {
                    _fotoDatabase = new FotoDatabaseController();
                }
                return _fotoDatabase;
            }
        }

        public static ImagemDatabaseController ImagemDatabase
        {
            get
            {
                if (_imagemDatabase == null)
                {
                    _imagemDatabase = new ImagemDatabaseController();
                }
                return _imagemDatabase;
            }
        }

        public static AcompanhamentoDatabaseController AcompanhamentoDatabase
        {
            get
            {
                if (_acompanhamentoDatabase == null)
                {
                    _acompanhamentoDatabase = new AcompanhamentoDatabaseController();
                }
                return _acompanhamentoDatabase;
            }
        }

        public static MarcoDatabaseController MarcoDatabase
        {
            get
            {
                if (_marcoDatabase == null)
                {
                    _marcoDatabase = new MarcoDatabaseController();
                }
                return _marcoDatabase;
            }
        }

        public static DuvidaFrequenteDatabaseController DuvidaFrequenteDatabase
        {
            get
            {
                if (_duvidaFrequenteDatabase == null)
                {
                    _duvidaFrequenteDatabase = new DuvidaFrequenteDatabaseController();
                }
                return _duvidaFrequenteDatabase;
            }
        }
    }
}
