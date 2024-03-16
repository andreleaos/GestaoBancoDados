using GestaoBancoDados.Models.Domain.Enums;

namespace GestaoBancoDados.Models.Infrastructure.Queries;

public static class SQlManager
{
    public static string GetSql(TSqlQueryType sqlQueryType)
    {
        string sql = "";

        switch (sqlQueryType)
        {
            case TSqlQueryType.CREATE_FILMES:
                sql = "insert into filme (nome, genero, ano) values ('@nome', '@genero', '@ano');";
                break;

            case TSqlQueryType.UPDATE_FILMES:
                sql = "update filme set nome = '@nome', genero = '@genero', ano = '@ano' where id = @id";
                break;

            case TSqlQueryType.DELETE_FILMES:
                sql = "delete from filme where id = @id";
                break;

            case TSqlQueryType.LIST_FILMES:
                sql = "select id, nome, genero, ano from filme order by nome;";
                break;

            case TSqlQueryType.GET_FILMES:
                sql = "select id, nome, genero, ano from filme where id = @id;";
                break;
        }

        return sql;
    }
}
