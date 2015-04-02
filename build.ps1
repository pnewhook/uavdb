$kDirectory = Join-Path -ChildPath .k\ -Path $env:USERPROFILE
$env:Path += ";" + $kDirectory + "\bin"
k upgrade
$runtime = Get-ChildItem -Directory -Path C:\Users\pnewhook\.k\runtimes | Select-Object -First 1 
$env:Path += ";" + $runtime.FullName
kpm restore .\src
kpm build .\src