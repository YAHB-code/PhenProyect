namespace PhenProyect.Models;
public class Phone
{
    [Key]
    internal int PhoneId{get;set;}
    internal string? Number{get;set;}
    internal string? Country{get;set;}
    //referencia hacia la tabla userData
    public int Id{get;set;}
    public UserData? UserData{get;set;}

}