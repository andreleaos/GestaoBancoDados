FROM mcr.microsoft.com/mssql/server:2019-latest

ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=abc@123
ENV MSSQL_PID=Express
ENV DB_NAME=filmedb

EXPOSE 1433

ENV MSSQL_TCP_PORT=1433
ENV MSSQL_BIND_ADDRESS=0.0.0.0

WORKDIR /scripts

COPY ./setup.sql /scripts/setup.sql

CMD /bin/bash -c '/opt/mssql/bin/sqlservr & /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P $SA_PASSWORD -d master -i /scripts/setup.sql'
