# Versta тестовое задание

## База данных

В решении используется MS SQL Server, поэтому сначала необходимо его [установить](https://www.microsoft.com/en-us/sql-server/sql-server-downloads).

## Запуск 

1. В файле `./Versta/appsettings.json` в поле `ConnectionStrings` изменить значение `DefaultConnection` на строку подключения к установленному ранее MS SQL Server.
2. Выполнить сборку проекта командой `dotnet build` или в Visual Studio.
3. Выполнить миграции базы данных командой `dotnet ef database update` или в окне Package Manager Console в Visual Studio с помощью команды `Update-Database`.
4. Запустить приложение командой `dotnet run` или в Visual Studio.
5. Приложение запускается на следующих адресах:
	* https://localhost:44359/
	* http://localhost:39966/
