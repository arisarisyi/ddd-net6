# ddd-net6
Training .Net with clean arcitecture DDD Pattern

1. 
untuk membuat sln projectnya sama halnya kayak package.json lah
	-dotnet new sln -o BuberDinner
ntr kebuat foldernya masuk dulu ke foldernya

2.
untuk membuat api..
	-dotnet new webapi -o BuberDinner.Api
	
3.
lalu membuat classlib untuk contracts,infrastructure,application,domain
	-dotnet new classlib -o BuberDinner.Contracts
	-dotnet new classlib -o BuberDinner.Infrastructure
	-dotnet new classlib -o BuberDinner.Application
	-dotnet new classlib -o BuberDinner.Domain
	
4.
Setiap lib memiliki file .sln sendiri. gabungkan seluruh .sln ke parentnya.
	-dotnet sln add $(ls -r **/*.csproj) 
untuk windows hapus *$*
lalu build
	-dotnet build

5
tambahkan reference
	-dotnet add BuberDinner.Api reference BuberDinner.Contracts BuberDinner.Application
	-dotnet add BuberDinner.Infrastructure reference Buber
	-dotnet add BuberDinner.Application reference BuberDinner.Domain 
	-dotnet add BuberDinner.Api reference BuberDinner.Infrastructure
	
contoh untuk menambahkan package
	-dotnet add ./BuberDinner.Infrastructure/ package Microsoft.Extensions.DependencyInjection.Abstractions
	
run projectnya
	-dotnet run --project ./BuberDinner.Api/

