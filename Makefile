up:
	docker-compose up -d

down:
	docker-compose down

run:
	dotnet run

setup:
	createdb my_dotnet_webapp -h localhost -U postgres

db:
	psql -h localhost -U postgres -d my_dotnet_webapp

cleandb:
	dropdb -h localhost -U postgres my_dotnet_webapp

migrate:
	dotnet ef database update --context BloggingContext

.PHONY: up down run
