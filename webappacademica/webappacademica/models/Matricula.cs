using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webappacademica.models
{
    public class Matricula
    {
        [Key]
        public int idMatricula { get; set; }
        public int idAlumno { get; set; } 
        public int idPeriodo { get; set; } 
        public DateTime fecha { get; set; }
        
        [ForeignKey("idAlumno")]
        public Alumno Alumno { get; set; }
        
        [ForeignKey("IdPeriodo")]
        public Periodo Periodo { get; set; }
    }
}
