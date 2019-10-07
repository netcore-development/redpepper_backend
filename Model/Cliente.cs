namespace RedPepper.API.Model
{
    public class Cliente
    {
        public int Id {get;set;}
        public int IdPersona { get; set; }
        public Persona Persona { get; set; }
    }
}