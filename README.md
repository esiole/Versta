# Versta тестовое задание

## База данных

В решении используется MS SQL Server, поэтому сначала необходимо его [установить](https://www.microsoft.com/en-us/sql-server/sql-server-downloads).

## Запуск 

1. Перейти в директорию проекта `Versta`.
2. В файле `appsettings.json` в поле `ConnectionStrings` изменить значение `DefaultConnection` на строку подключения к установленному ранее MS SQL Server.
3. Выполнить сборку проекта командой `dotnet build` или в Visual Studio.
4. Выполнить миграции базы данных командой `dotnet ef database update` или в окне Package Manager Console в Visual Studio с помощью команды `Update-Database`.
5. Запустить приложение командой `dotnet run` или в Visual Studio.
6. Приложение запускается на следующих адресах:
	* http://localhost:5000
	* https://localhost:5001
	* При запуске с помощью IIS:
		* https://localhost:44359/
		* http://localhost:39966/
