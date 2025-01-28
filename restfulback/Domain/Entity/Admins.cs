namespace restfulback.Domain
{
    public class Users 
    {
        public Guid Id {get;set;}
        public required string UserName {get;set;}
        public required string Role {get;set;}
    }
}