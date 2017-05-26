Get-ChildItem *.cs |Remove-Item -ErrorAction SilentlyContinue
Remove-Item .\tools -Recurse -ErrorAction SilentlyContinue
nuget install XmlSchemaClassGenerator-beta -ExcludeVersion -OutputDirectory 'Tools'

#Invoke-WebRequest -Uri https://nota-game.azurewebsites.net/schema/nota.xsd -OutFile .\Tools\nota.xsd -ErrorAction Stop

.\Tools\XmlSchemaClassGenerator-beta\tools\XmlSchemaClassGenerator.Console.exe -0 --namespace=http://nota-game.azurewebsites.net/schema/nota=Core --prefix=Nota.CharacterGenerator.CoreData https://nota-game.azurewebsites.net/schema/nota.xsd

Remove-Item .\tools -Recurse
