public class Pais  {
    //Propiedades
    public int IdPais {get;set; }    
    public string Nombre {get;set; }
    public string Bandera {get;set; }
    public DateTime FechaFundacion {get;set; }
    
    //Constructor
    public Pais () {   }

    public Pais (int idPais, string nombre, string bandera, DateTime fechaFundacion) 
    {
        IdPais=idPais;
        Nombre=nombre;
        Bandera=bandera;
        FechaFundacion=fechaFundacion;
    }

    // Métodos
    public variable nombreMetodo() {
        //cuerpo    
    }
}