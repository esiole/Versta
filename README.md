# Versta �������� �������

## ���� ������

� ������� ������������ MS SQL Server, ������� ������� ���������� ��� [����������](https://www.microsoft.com/en-us/sql-server/sql-server-downloads).

## ������ 

1. � ����� `./Versta/appsettings.json` � ���� `ConnectionStrings` �������� �������� `DefaultConnection` �� ������ ����������� � �������������� ����� MS SQL Server.
2. ��������� ������ ������� �������� `dotnet build` ��� � Visual Studio.
3. ��������� �������� ���� ������ �������� `dotnet ef database update` ��� � ���� Package Manager Console � Visual Studio � ������� ������� `Update-Database`.
4. ��������� ���������� �������� `dotnet run` ��� � Visual Studio.
5. ���������� ����������� �� ��������� �������:
	* https://localhost:44359/
	* http://localhost:39966/
