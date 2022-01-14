using Registro_de_Vacunados.Entities.Atributes;

namespace Registro_de_Vacunados.Entities
{
    public class RvacunadosTab
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Edad { get; set; }
        public string Ci { get; set; }
        public string Dosis1 { get; set; }
        public string Fecha1 { get; set; }
        public string Lote1 { get; set; }
        public string Dosis2 { get; set; }
        public string Fecha2 { get; set; }
        public string Lote2 { get; set; }
        public string Dosis3 { get; set; }
        public string Fecha3 { get; set; }
        public string Lote3 { get; set; }
        public string Refuerzo { get; set; }
        public string FechaRefuerzo { get; set; }
        public string LoteRefuerzo { get; set; }
        public VacunasProgreso progreso  { get; set; }
    }
}
