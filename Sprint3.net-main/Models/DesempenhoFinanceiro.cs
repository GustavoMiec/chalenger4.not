using System.ComponentModel.DataAnnotations;

namespace Sprint3.Models
{
    public class DesempenhoFinanceiro
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public double Receita { get; set; }
        [Required]
        public double Lucro { get; set; }
        [Required]
        public double Crescimento { get; set; }
    }
}
