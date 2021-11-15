namespace PhenProyect.Models;
public class Message
{
    [Key]
    internal int MessageId{get;set;}
    internal string? MessageText{get;set;}
    
    //referencia hacia el usuario de destino y osuario origen
    public int UserDataOrigin{get;set;}
    public UserData? UserDataOrigi{get;set;}
    public int UserDataDestiny{get;set;}
    public UserData? UserDataDestin{get;set;}

}