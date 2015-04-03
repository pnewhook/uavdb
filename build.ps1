$kDirectory = Join-Path -ChildPath .k\ -Path $env:USERPROFILE
$env:Path += ";" + $kDirectory + "bin"
kvm upgrade
kpm restore .\src
kpm build .\src
