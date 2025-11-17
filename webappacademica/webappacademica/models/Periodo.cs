using System.ComponentModel.DataAnnotations;

namespace webappacademica.models
{
    public class Periodo
    {
        [Key]
        public int idPeriodo { get; set; }
        public DateTime fecha { get; set; }
        public string periodo { get; set; }

    }
}
