using System.ComponentModel.DataAnnotations;

namespace T3_HUACCHA_ANGEL.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El título del libro es obligatorio.")]
        [StringLength(150, ErrorMessage = "El título no puede superar los 150 caracteres.")]
        [Display(Name = "Título")]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "El autor es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre del autor no puede superar los 100 caracteres.")]
        [Display(Name = "Autor")]
        public string Autor { get; set; } = string.Empty;

        [Required(ErrorMessage = "El tema del libro es obligatorio.")]
        [Display(Name = "Tema")]
        public string Tema { get; set; } = string.Empty;

        [Required(ErrorMessage = "La editorial es obligatoria.")]
        [Display(Name = "Editorial")]
        public string Editorial { get; set; } = string.Empty;

        [Required(ErrorMessage = "El año de publicación es obligatorio.")]
        [Range(1900, 3000, ErrorMessage = "El año de publicación debe estar entre 1900 y 3000.")]
        [Display(Name = "Año de Publicación")]
        public int AnioPublicacion { get; set; }

        [Required(ErrorMessage = "El número de páginas es obligatorio.")]
        [Range(10, 1000, ErrorMessage = "Las páginas deben estar en un rango de 10 a 1000.")]
        [Display(Name = "Páginas")]
        public int Paginas { get; set; }

        [Required(ErrorMessage = "La categoría es obligatoria.")]
        [Display(Name = "Categoría")]
        public string Categoria { get; set; } = string.Empty;

        [Required(ErrorMessage = "El material del libro es obligatorio.")]
        [Display(Name = "Material")]
        public string Material { get; set; } = string.Empty;

        [Required(ErrorMessage = "La cantidad de copias es obligatoria.")]
        [Range(1, 20, ErrorMessage = "El número de copias debe estar estrictamente entre 1 y 20.")]
        [Display(Name = "Copias")]
        public int Copias { get; set; }
    }
}