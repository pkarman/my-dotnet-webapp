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

.PHONY: up down run
