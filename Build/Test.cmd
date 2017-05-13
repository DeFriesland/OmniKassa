@echo off

cd build

nuget restore packages.config -PackagesDirectory .

cd ..

build\OpenCover.4.6.519\tools\OpenCover.Console.exe -target:"dotnet.exe" -targetargs:"test tests\OmniKassa.Tests\OmniKassa.Tests.csproj --no-build -c Release /p:codecov=true" -register:user -threshold:10 -oldStyle -safemode:off -output:.\OmniKassa.Coverage.xml -hideskipped:All  -excludebyattribute:*.ExcludeFromCodeCoverage* -returntargetcode" 

if %errorlevel% neq 0 exit /b %errorlevel%

SET PATH=C:\\Python34;C:\\Python34\\Scripts;%PATH%
pip install codecov
codecov -f "OmniKassa.Coverage.xml"