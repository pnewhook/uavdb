    $dnxDirectory = Join-Path -ChildPath .k\ -Path $env:USERPROFILE
    $env:Path += ";" + $dnxDirectory + "bin"
    dnvm upgrade
    dnu restore .\src
    dnu build .\src
