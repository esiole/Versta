# Versta �������� �������

## ���� ������

� ������� ������������ MS SQL Server, ������� ������� ���������� ��� [����������](https://www.microsoft.com/en-us/sql-server/sql-server-downloads).

## ������ 

1. ������� � ���������� ������� `Versta`.
2. � ����� `appsettings.json` � ���� `ConnectionStrings` �������� �������� `DefaultConnection` �� ������ ����������� � �������������� ����� MS SQL Server.
3. ��������� ������ ������� �������� `dotnet build` ��� � Visual Studio.
4. ��������� �������� ���� ������ �������� `dotnet ef database update` ��� � ���� Package Manager Console � Visual Studio � ������� ������� `Update-Database`.
5. ��������� ���������� �������� `dotnet run` ��� � Visual Studio.
6. ���������� ����������� �� ��������� �������:
	* http://localhost:5000
	* https://localhost:5001
	* ��� ������� � ������� IIS:
		* https://localhost:44359/
		* http://localhost:39966/
