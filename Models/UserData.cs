 global using System.ComponentModel.DataAnnotations;
 //parece que solo el using global a los archivos que pertenecen al mismo espacio de nombres?

namespace PhenProyect.Models;
public class UserData
{
    [Key]
    public int Id{get;set;}
    public string? UserName{get;set;}
    public string? UserPassword{get;set;}
    public string? UserFirstName{get;set;}
    public string? UserSecondName{get;set;}
    public string? About{get;set;}
    public string? Location{get;set;}
    public string? Direction{get;set;}
    public string? Country{get;set;}
    public DateTime DateBirth{get;set;}
    public string? UserEmail{get;set;}
    public string? RecoveryEmail{get;set;}


    //refencia de 1 -> N numeros de telefono
    public List<Phone>? PhoneList{get;set;}
}