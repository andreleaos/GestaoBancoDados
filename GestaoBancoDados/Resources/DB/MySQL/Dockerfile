FROM mysql:latest

ENV MYSQL_ROOT_PASSWORD=abc@123
ENV MYSQL_DATABASE=filmedb
ENV MYSQL_USER=filme_user
ENV MYSQL_PASSWORD=abc@123

COPY init.sql /docker-entrypoint-initdb.d/

EXPOSE 3306