using System.ComponentModel.DataAnnotations;

namespace Sprint3.Models
{
    public class TendenciasGastos
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public long Ano { get; set; }
        [Required]
        public double GastoMarketing { get; set; }
        [Required]
        public double GastoAutomacao { get; set; }
    }
}
