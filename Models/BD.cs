using System.Data.SqlClient;
using Dapper;

public static class BD{

    // Métodos
    private static string connectionString = @"Server=localhost; DataBase = TP6 bd; Trusted_Connection=True;";

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

        string sql = "DELETE FROM Deportistas WHERE IdDeportista = @p";
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
            string sql = "SELECT * FROM Deportes WHERE IdDeporte = @id";
            depo = db.QueryFirstOrDefault<Deporte>(sql, new {id = idDeporte});
        }
        return depo;
    }

    public static Pais VerInfoPais(int idPais)
    {
        Pais pais = new Pais();
        using (SqlConnection db =  new SqlConnection (connectionString))
        {
            string sql = "SELECT * FROM Paises WHERE IdPais = @id";
            pais = db.QueryFirstOrDefault<Pais>(sql, new {id = idPais});
        }
        return pais;
    }

    public static Deportista VerInfoDeportista(int idDeportista)
    {
        Deportista deport = new Deportista();
        using (SqlConnection db =  new SqlConnection (connectionString))
        {
            string sql = "SELECT * FROM Deportistas WHERE IdDeportista = @id";
            deport = db.QueryFirstOrDefault<Deportista>(sql, new {id = idDeportista});
        }
        return deport;
    }

    public static List<Pais> ListarPaises()
    {
        // SELECT, Dapper Query, QueryFirstOrDefault
        // INSERT, DELETE, UPDATE, Dapper Execute
        string sql = "SELECT * FROM Paises";
        List<Pais> ListaPaises = new List<Pais>(); 
        using (SqlConnection db =  new SqlConnection (connectionString)) 
        {
            ListaPaises= db.Query<Pais>(sql).ToList();
        }
        return ListaPaises;
    }
    public static List<Deportista> ListarDeportistasxDeporte (int idDeporte)
    {
        string sql = "SELECT * FROM Deportistas WHERE IdDeporte= @p";
        List<Deportista> ListaDeportistas = new List<Deportista>(); 
        using (SqlConnection db =  new SqlConnection (connectionString)) 
        {
            ListaDeportistas= db.Query<Deportista>(sql, new {p = idDeporte}).ToList();
        }
        return ListaDeportistas;
    }

    public static List<Deportista> ListarDeportistasxPais(int idPais)
    {
        string sql = "SELECT * FROM Deportistas WHERE IdPais= @p";
        List<Deportista> ListaDeportistas = new List<Deportista>(); 
        using (SqlConnection db =  new SqlConnection (connectionString)) 
        {
            ListaDeportistas= db.Query<Deportista>(sql, new {p = idPais}).ToList();
        }
        return ListaDeportistas;
    }
    

}