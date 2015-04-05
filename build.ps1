    try
    {
        dnvm upgrade
        dnu restore .\src
        dnu build .\src
    }
    catch
    {
        throw
    }
