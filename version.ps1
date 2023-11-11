try
{
	$root 					= "D:\Sources\Architecture\"
	$e      				= [char]27
	$result 				= @()
	$path   				= $root + "Wangkanai.Architecture.Templates.csproj";
	$xml    				= New-Object System.Xml.XmlDocument
	$xml.PreserveWhitespace = $true
	$xml.Load($path);
	$node   				= $xml.SelectSingleNode("/Project/PropertyGroup/PackageVersion");
	$old    				= [System.Version]$node.InnerText;
	$new    				= [System.Version]::new($old.Major, $old.Minor, $old.Build + 1); #, $old.Build + 1); #0);
	$node.InnerText 		= $new.ToString();
	$xml.Save($path);
	$result += [PSCustomObject]@{ NuGet = "$e[36m" + "templates" + "$e[0m"; Version = "$e[32m$old => $new $e[0m" }
}
catch
{
	$result += [PSCustomObject]@{ NuGet = "$e[31m" + "templates" + "$e[0m"; Version = "$e[31mError $e[0m" }
}
$result