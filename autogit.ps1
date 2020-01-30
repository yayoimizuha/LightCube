Param(
    [parameter(mandatory=$true)][String]$PathArg
)
cd $PathArg
git add -A
git commit -m "LightCube Automation From Unity Collab to Github"
git push origin master