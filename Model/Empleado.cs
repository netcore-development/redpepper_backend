namespace RedPepper.API.Model
{
    public class Empleado
    {
        public int Id {get;set;}
        public Persona Persona { get; set; }
        public int IdPersona { get; set; }
    }
}