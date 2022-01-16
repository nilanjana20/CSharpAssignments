run:
	 dotnet run 

createapp:
	 dotnet new classlib -n $(app)
	 dotnet sln ./*.sln add **/*.csproj


message:
	echo "hello"

git_initialisation:
	git init