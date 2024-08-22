public class Deportista  {
    //Propiedades
    public int IdDeportista {get;set; }    
    public string Nombre {get;set; }
    public string Apellido {get;set; }
    public string Foto {get;set; }
    public int IdPais {get;set; }    
    public int IdDeporte {get;set; }    


    //Constructor
    public Deportista () {   }

    public Deportista (int idDeportista, string nombre, string apellido, string foto, int idPais, int idDeporte) 
    {
        IdDeportista=idDeportista;
        Nombre=nombre;
        Apellido=apellido;
        Foto=foto;
        IdPais=idPais;
        IdDeporte=idDeporte;
    }

    // Métodos
  
}