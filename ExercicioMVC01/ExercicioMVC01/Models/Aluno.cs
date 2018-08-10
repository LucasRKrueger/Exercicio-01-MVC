using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExercicioMVC01.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Não pode ser vazio")]
        [MinLength(10, ErrorMessage = "Nome deve ter no mínimo 7 caracteres")]
        [MaxLength(100, ErrorMessage = "Nome deve conter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Não pode ser vazio")]
        [MinLength(1, ErrorMessage = "Matricula não pode ser menor que 1 caracter")]
        [MaxLength(20, ErrorMessage = "Matricula não pode ser maior que 20")]
        public string CodigoMatricula { get; set; }

        [Required(ErrorMessage = "Não pode ser vazio")]
        [Range(0, 10, ErrorMessage = "Nota não pode ser menor que 0 nem maior que 10")]
        public float Nota1 { get; set; }

        [Required(ErrorMessage = "Não pode ser vazio")]
        [Range(0, 10, ErrorMessage = "Nota não pode ser menor que 0 nem maior que 10")]
        public float Nota2 { get; set; }

        [Required(ErrorMessage = "Não pode ser vazio")]
        [Range(0, 10, ErrorMessage = "Nota não pode ser menor que 0 nem maior que 10")]
        public float Nota3 { get; set; }

        [Required(ErrorMessage = "Não pode ser vazio")]
        [Range(0, 100, ErrorMessage = "Frequencia não pode ser menor que 0 nem maior que 100")]
        public byte Frequencia { get; set; }

        public float Media{ get; set; }

    }

}