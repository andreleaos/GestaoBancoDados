FROM postgres:latest

ENV POSTGRES_DB=filmedb
ENV POSTGRES_USER=filme_user
ENV POSTGRES_PASSWORD=abc@123

COPY init.sql /docker-entrypoint-initdb.d/

EXPOSE 5432
