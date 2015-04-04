    try
    {
        $dnxDirectory = Join-Path -ChildPath .dnx\ -Path $env:USERPROFILE
        $env:Path += ";" + $dnxDirectory + "bin"
        dnvm upgrade
        dnu restore .\src
        dnu build .\src
    }
    catch
    {
        throw
    }
