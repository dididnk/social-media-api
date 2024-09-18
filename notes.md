# Documentation

- CQRS, pour Command Query Responsibility Segregation est une architecture logiciel qui repose sur un principe simple : la s�paration, au sein d'une application, des composants de modification et de restitution de l'information sous les termes Command (pour l'�criture) et Query (pour la lecture).

Apache Kafka est un syst�me de streaming open source distribu� utilis� pour le traitement des flux, les pipelines de donn�es en temps r�el et l'int�gration des donn�es � grande �chelle.

CQRS separe les web services en deux m�thodes diff�rentes (requ�te pour l'�criture et pour la lecture):

- Command : Create, Update et Delete
- Query : Read

## Pr�requis (les outils ou programmes � installer)

- .NET : dotnet --version
- Docker : docker --version
- Docker-compose : dotnet --version

## Commandes de base pour docker

- docker ps : verifier
- docker network create --attachable -d bridge mydockernetwork
- docker network ls

## lancer docker-compose

- cd docker
- docker-compose up -d

## lancer Mongo-Db

- docker run -it -d --name mongo-container -p 27017:27017 --network mydockernetwork --restart always -v mongodb_data_container:/data/db mongo:latest

## lancer MSQL Server

docker run -d --name sql-container --network mydockernetwork --restart always -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=$tr0ngS@P@ssw0rd02' -e 'MSSQL_PID=Express' -p 1433:1433 mcr.microsoft.com/mssql/server:2017-latest-ubuntu

## Test globale

- docker ps
- docker network inspect mydockernetwork

## Rapide change read database

- docker run -d --name postgres-container -p 5432:5432 --network mydockernetwork -e POSTGRES_PASSWORD=$tr0ngS@P@ssw0rd04 --restart always -v postgresql_data:/var/lib/postgresql/data postgres:latest

