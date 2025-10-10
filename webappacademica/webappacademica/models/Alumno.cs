using System.ComponentModel.DataAnnotations;

namespace webappacademica.models
{
    public class Alumno
    {
        [Key]
        public int idAlumno { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Dirrecion { get; set; }
        public string Telefono { get; set; }
    }
}
