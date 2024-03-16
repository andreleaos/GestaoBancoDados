namespace GestaoBancoDados.Models.Domain.Config;
public static class ConfigParameters
{
    public static bool Enable_MySql = true;
    public static bool Enable_SqlServer = false;
    public static bool Enable_Postgres = false;
    public static bool Enable_Oracle = false;

    public static string ConnStr_MySql = "";
    public static string ConnStr_SqlServer = "";
    public static string ConnStr_Postgres = "";
    public static string ConnStr_Oracle = "";
}
