# QuestionsApp

## Db configuration

Make sure you set the following user secrets. But first initialise the user secrets.

```shell
dotnet user-secrets init --project .\BlazorApp\
```

Set the connectionString with the correct connection string
```shell
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=(localdb)\\mssqllocaldb;Database=QuestionAppDB;Trusted_Connection=True;MultipleActiveResultSets=true;User=sa;Password=Your_password123;" --project .\BlazorApp\
```
