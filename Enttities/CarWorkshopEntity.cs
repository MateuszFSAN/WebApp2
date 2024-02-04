namespace WebApplication1.Enttities
{
    public class CarWorkshopEntity
    {
        public int Id { get; set; }
        public string Nazwa { get; set; } = default! ;
        public string? Opis { get; set; } 
        public string Adres { get; set; } = default! ;
        public string? Telefon { get; set; } 
    }
}
