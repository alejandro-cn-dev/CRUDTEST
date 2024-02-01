namespace CRUDTEST.Data
{
    public class Conexion
    {
        private string cadenaSQL = string.Empty;

        public Conexion()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            cadenaSQL = builder.GetSection("ConnectionStrings:SQLconnection").Value;
        }
        public Conexion(string v) 
        { 
            cadenaSQL = v;
        }
        public string getCadenaSQL() 
        {  
            return cadenaSQL; 
        }
    }
}
