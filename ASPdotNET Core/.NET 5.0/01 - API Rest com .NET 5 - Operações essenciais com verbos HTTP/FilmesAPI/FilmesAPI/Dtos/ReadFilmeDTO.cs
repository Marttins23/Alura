﻿using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Dtos
{
    public class ReadFilmeDTO
    {
        [Key]
        [Required]
        public int Id { get; internal set; }
        [Required(ErrorMessage = "O campo Título é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo Diretor é obrigatório")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O Gênero não pode ultrapassar 30 caracteres.")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A Duração deve ter no mínimo 1 e no máximo 600 minutos.")]
        public int Duracao { get; set; }
        public DateTime HoraDaConsulta { get; set; }
    }
}
