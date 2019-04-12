dotnet build && dotnet publish --configuration Release --output c:\svc
TIMEOUT /T 3
sc.exe create HONService start= auto binPath="C:\svc\SampleApp.exe"
TIMEOUT /T 3
sc.exe query HonService
TIMEOUT /T 3
sc.exe start HonService