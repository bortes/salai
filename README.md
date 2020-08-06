# salai

Repositório para aplicação exemplo em `dotnet`.

# requisitos

Os seguintes requisitos são necessários para _desenvolvimento_ e _execução_ da aplicação.

+ [.Net Core](https://dotnet.microsoft.com/download)
+ [Visual Studio Code](https://code.visualstudio.com/)

# comandos

Para executar o serviço, execute:

```bash
dotnet run --project src/app/app.csproj
```

Para compilar em modo **debug**:

```bash
dotnet build src/salai.sln
```

E, para compilar em modo **release**:

```bash
dotnet publish --configuration Release src/salai.sln
```
