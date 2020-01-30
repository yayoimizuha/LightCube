Param(
    [parameter(mandatory=$true)][String]$PathArg,
    [parameter(mandatory=$true)][String]$User
)
Set-Location $PathArg
git add -A
git commit -m "LightCube Automation From Unity Collab to Github by $User"
git push origin master