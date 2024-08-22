public class Deporte  {
    //Propiedades
    public int IdDeporte {get;set; }
    
    public string Nombre {get;set; }

    public string Foto {get;set; }


    //Constructor
     public Deporte () {   }

    public Deporte (int idDeporte, string nombre, string foto) 
    {
        IdDeporte=idDeporte;
        Nombre=nombre;
        Foto=foto;
    }

   
    }
