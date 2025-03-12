namespace Random_miscellaneous.Models
{
    public class OptionModel
    {
        required public int Id { get; set; }
        required public string Nombre { get; set; }
        public string? Descripción { get; set; }
        public string? URL_Icono { get; set; }
        public string? URL_Fondo { get; set; }
        required public string Vista { get; set; }
        required public string Controlador { get; set; }
    }

}
