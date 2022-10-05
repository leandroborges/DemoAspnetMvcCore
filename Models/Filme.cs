using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoAspnetMvcCore.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Campo Título é obrigatório!")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O título precisa ter entre 3 ou 60 caracteres.")]
        public string Titulo { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Formato da data está incorreto.")]
        [Required(ErrorMessage = "O campo Data de Lançamento é obrigatório.")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres.")]
        public string Genero { get; set; }

        [Range(1, 100, ErrorMessage = "Valor de 1 a 100.")]
        [Required(ErrorMessage = "Preencha o campo valor.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Preencha o campo Avaliação")]
        [Display(Name = "Avaliação")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente números de 1 a 5")]
        public string Avaliacao { get; set; }
    }
}
