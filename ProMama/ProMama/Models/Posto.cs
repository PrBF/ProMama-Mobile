using ProMama.Components;

namespace ProMama.Models
{
    public class Posto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string lat_long { get; set; }
        public string image_path { get; set; }
        public bool MostraTelefone { get; set; }
        public GeoCoordinate Coordinates { get; set; }

        public Posto() {}
    }
}
