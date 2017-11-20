
namespace Web.Models
{
    public class Item
    {
        public int ItemID { get; set; }

        public string Nome { get; set; }

        public int DanoMaximo { get; set; }

        public int Forca { get; set; }

        public int Agilidade { get; set; }

        public int Defesa { get; set; }


        // Relacionamento item -- TipoItem
        public int TipoItemID { get; set; }

        public virtual TipoItem _TipoItem { get; set; }

    }
}