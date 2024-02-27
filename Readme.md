# Game-with-dotnet--first with Hindus tutorial first starting with a dotnet

## Starting Sql server

```powershell
$sa_password ="[SA PASSWORD HERE]"
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD="ciucia123"" -p 1433:1433 -v sqlvolume:/var/opt/mssql -d --rm --name mssql mcr.microsoft.com/mssql/server:2022-latest
```

$sa_password = "[SA PASSWORD HERE]"
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Dupa123!" -p-1433:1433--vsqlvolume:/var/
opt/mssql -d --rm --name mssql mcr.microsoft.com/mssql/server:2022-latest

```
docker run --rm -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Dupa.123" -e "MSSQL_PID=Evaluation" -p 1433:1433 --name sqlpreview --hostname sqlpreview -d mcr.microsoft.com/mssql/server:2022-preview-ubuntu-22.04
```

## Secret Nabager

dotnet user-secrets set "ConnectionStrings:GameStoreContext" "Server=localhost; Database=GameStore; User Id =sa; Password=Dupa.123;TrustServerCertificate=True"

```


 docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Dupa123" -e "MSSQL_PID=Evaluation" -p 1433:1433  -d --name sqlpreview --hostname sqlpreview -d mcr.microsoft.com/mssql/server:2022-preview-ubuntu-22.04
```
