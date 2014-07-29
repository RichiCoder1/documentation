@echo off

:Build
cls

:: Check if we need to download Cake.
if not exist tools\Cake\Cake.exe ( 
	echo Downloading Cake...
	echo ===================
	tools\nuget.exe install Cake -OutputDirectory tools -ExcludeVersion -NonInteractive -NoCache
	echo.
)

:: Check if we need to build the compiler.
if not exist tools\Compiler\Compiler.exe (
	echo Building compiler...
	echo ====================
	tools\Cake\Cake.exe build.cake -verbosity=diagnostic
	echo.
)

:: Build the documentation using the compiler.
echo Generating API documentation...
echo ===============================
tools\Compiler\Compiler.exe "tools\Cake" "source\api-documentation.rst"

:: Run Sphinx
echo.
echo Generating HTML documentation...
echo ================================
make.bat html