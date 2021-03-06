namespace ProMama.Models
{
    public class JsonMessage
    {
        public bool success { get; set; }
        public string message { get; set; }
        public string password { get; set; }
        public int id { get; set; }
        public Usuario user { get; set; }
        public string senha_reserva { get; set; }

        public JsonMessage(bool success, string message, int id)
        {
            this.success = success;
            this.message = message;
            this.id = id;
        }

        public JsonMessage(bool success, string message)
        {
            this.success = success;
            this.message = message;
        }

        public JsonMessage(bool success, int id)
        {
            this.success = success;
            this.id = id;
        }

        public JsonMessage(string message)
        {
            this.message = message;
        }

        public JsonMessage() { }
    }
}
