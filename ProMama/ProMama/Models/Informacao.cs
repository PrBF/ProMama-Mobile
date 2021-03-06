using System;
using System.Collections.Generic;

namespace ProMama.Models
{
    public class Informacao
    {
        public int informacao_id { get; set; }
        public string informacao_titulo { get; set; }
        public string informacao_foto { get; set; }
        public string informacao_corpo { get; set; }
        public DateTime informacao_data { get; set; }
        public string informacao_autor { get; set; }
        public double informacao_idadeSemanasInicio { get; set; }
        public double informacao_idadeSemanasFim { get; set; }
        public List<Link> links { get; set; }
        
        public string informacao_resumo { get; set; }
        public bool informacao_imagem_visivel { get; set; }

        public Informacao() { }
    }
}
