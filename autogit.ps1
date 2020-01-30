Param(
    [parameter(mandatory=$true)][String]$PathArg,
    [String]$User = "Anonymous",
    [String]$Date = (Get-date)
)
Set-Location $PathArg
git pull
git add -A
git commit -m "LightCube Automation From Unity Collab to Github by $User at $Date"
git push origin master