using GestaoBancoDados.Models.Domain.Config;
using GestaoBancoDados.Models.Domain.Interfaces;
using GestaoBancoDados.Models.Infrastructure.Repositories;
using GestaoBancoDados.Models.Services;
using MySql.Data.MySqlClient;
using System.Data;

namespace GestaoBancoDados.Models.IoC;

public static class Startup
{
    public static void Configure(IConfiguration configuration, IServiceCollection services)
    {
        ConfigureDatabase(configuration, services);

        services.AddScoped<IFilmeRepository, FilmeRepository>();
        services.AddScoped<IFilmeService, FilmeService>();
    }
    private static void ConfigureDatabase(IConfiguration configuration, IServiceCollection services)
    {
        bool mySql_flags = bool.Parse(configuration.GetSection("DatabaseFlags")["Enable_MySql"]);
        bool sqlserver_flags = bool.Parse(configuration.GetSection("DatabaseFlags")["Enable_SqlServer"]);
        bool postgres_flags = bool.Parse(configuration.GetSection("DatabaseFlags")["Enable_Postgres"]);
        bool oracle_flags = bool.Parse(configuration.GetSection("DatabaseFlags")["Enable_Oracle"]);

        ConfigParameters.Enable_MySql = mySql_flags;
        ConfigParameters.Enable_SqlServer = sqlserver_flags;
        ConfigParameters.Enable_Postgres = postgres_flags;
        ConfigParameters.Enable_Oracle = oracle_flags;

        string connStrMySql = configuration.GetConnectionString("ConnStr_MySql");
        string connStrSqlServer = configuration.GetConnectionString("ConnStr_SqlServer");
        string connStrPostgres = configuration.GetConnectionString("ConnStr_Postgres");
        string connStrOracle = configuration.GetConnectionString("ConnStr_Oracle");

        ConfigParameters.ConnStr_MySql = connStrMySql;
        ConfigParameters.ConnStr_SqlServer = connStrSqlServer;
        ConfigParameters.ConnStr_Postgres = connStrPostgres;
        ConfigParameters.ConnStr_Oracle = connStrOracle;

        if (ConfigParameters.Enable_MySql)
            services.AddScoped<IDbConnection>(provider => new MySqlConnection(connStrMySql));
        else if (ConfigParameters.Enable_SqlServer)
            services.AddScoped<IDbConnection>(provider => new MySqlConnection(connStrSqlServer));
        else if (ConfigParameters.Enable_Postgres)
            services.AddScoped<IDbConnection>(provider => new MySqlConnection(connStrPostgres));
        else if (ConfigParameters.Enable_Oracle)
            services.AddScoped<IDbConnection>(provider => new MySqlConnection(connStrOracle));
    }
}
