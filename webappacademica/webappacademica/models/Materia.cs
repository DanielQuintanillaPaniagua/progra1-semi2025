using System.ComponentModel.DataAnnotations;

namespace webappacademica.models
{
    public class Materia
    {
        [Key]
        public int idMateria { get; set; }
        public string codigo { get; set; }
        public int nombre { get; set; }

        public int uv { get; set; }
    }
}
