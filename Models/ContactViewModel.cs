using System.ComponentModel.DataAnnotations;

public class ContactoViewModel{
    [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "El campo Correo es obligatorio.")]
    [EmailAddress(ErrorMessage = "El campo Correo no es una dirección de correo electrónico válida.")]
    public string Correo { get; set; }

    [Required(ErrorMessage = "El campo Mensaje es obligatorio.")]
    public string Mensaje { get; set; }
}