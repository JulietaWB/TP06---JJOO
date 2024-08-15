using System.Data.SqlClient;
using Dapper;

public static class BD{

    //Propiedades

    //Constructor
    public Deporte (variable nombreEj) {
        NombreEj= nombreEj;
    }

    // Métodos
    private static string connectionString = @"Server=localhost; DataBase = TP6 bd; Trusted_Connection=True;";
    
    
    public variable nombreMetodo() {
        //cuerpo    
    }

    public static void AgregarDeportistas (Deportista dep)
    {

        string sql = "INSERT INTO Deportista(IdDeportista, Nombre, Apellido, Foto, idPais, idDeporte) VALUES (@pId, @pNom, @pApell, @pFoto, @pPais, @pDep)";
        using (SqlConnection db =  new SqlConnection (connectionString)) 
        {
            db.Execute(sql, new {pId = dep.IdDeportista, pNom = dep.Nombre, pApell = dep.Apellido, pFoto = dep.Foto, pPais = dep.IdPais, pDep = dep.IdDeporte} );
        }
    }

    public static void EliminarDeportista(int idDeportista) 
    {

        string sql = "DELETE FROM Deportista WHERE IdDeportista = @p";
        using (SqlConnection db =  new SqlConnection (connectionString)) 
        {
            int DepEliminados= db.Execute(sql, new {p = idDeportista});

        }
    }

    public static Deporte VerInfoDeporte(int idDeporte)
    {
        Deporte depo = new Deporte();

        using (SqlConnection db =  new SqlConnection (connectionString)) 
        {
            string sql = "SELECT * FROM Deporte WHERE IdDeporte = @id";
            depo = db.QueryFirstOrDefault<Deporte>(sql, new {id = idDeporte});
        }
        return depo;
    }

}