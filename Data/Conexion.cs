namespace PRACTICA_AEAE_3_Juan_Quiceno.DATA
{
    public class Conexion
    {
        string cadenaSql = "";

        public Conexion()
        {
            //Obtenemos la cadena de conexión
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            cadenaSql = builder.GetSection("ConnectionStrings:CadenaSQL").Value;
        }

        public string GetCadenaSQL()
        {
            return cadenaSql;
        }
    }
}
