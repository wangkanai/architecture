param(
	[Parameter(ParameterSetName = "Add")]
	[string]$Add
)

if ($Add)
{
	dotnet ef migrations add $Add --project src\Infrastructure --startup-project src\Server --output-dir Data\Migrations
}