rm -rf _builds _steps _projects _cache _temp
wercker build --git-domain github.com --git-owner skvimpact --git-repository CalcService
rm -rf _builds _steps _projects _cache _temp