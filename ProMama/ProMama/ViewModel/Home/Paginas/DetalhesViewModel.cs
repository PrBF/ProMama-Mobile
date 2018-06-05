﻿using ProMama.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProMama.ViewModel.Home.Paginas
{
    class DetalhesViewModel : ViewModelBase
    {
        public string Titulo { get; set; }
        public string Imagem { get; set; }
        public bool ImagemVisivel { get; set; }
        public string Texto { get; set; }
        public List<Link> Links { get; set; }
        public bool LinksVisivel { get; set; }

        public ICommand AbrirLinkCommand { get; set; }

        public DetalhesViewModel(Informacao i)
        {
            Titulo = i.informacao_titulo;
            Imagem = i.informacao_foto;
            ImagemVisivel = i.informacao_imagem_visivel;
            Texto = i.informacao_corpo;
            Links = i.links;
            LinksVisivel = Links.Count == 0 ? false : true;
            
            AbrirLinkCommand = new Command<Link>(AbrirLink);
        }

        private void AbrirLink(Link l)
        {
            try
            {
                Device.OpenUri(new Uri(l.url));
            } catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            
        }

        public DetalhesViewModel(Duvida d)
        {
            Titulo = d.duvida_pergunta;
            ImagemVisivel = false;
            Texto = d.duvida_resposta;
            LinksVisivel = false;
        }
    }
}
