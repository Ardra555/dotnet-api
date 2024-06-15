using System.ComponentModel.DataAnnotations;

namespace Domain.Entites;

class User {
    public Guid Id {get; set;}

    [Required(ErrorMessage ="UserName can not be null")]
    public string  UserName {get;set;}

    [Required(ErrorMessage ="Password can not be empty")]
    public string password {get;set;}

}