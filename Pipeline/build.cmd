@echo on
if "%1"=="" goto help
if "%1"=="-art" set BUILD_TYPE=ART

REM This is a comment

:build_code
type errors.log > another_file.log > build.log
bin\grep -n "error" another_file.log / bin\gawk "{ print \"The error is \" $1 $3 }" >> build.log
del another_file.log
%BUILD_SYS myapp.sln
goto end

:help
@echo .         Help or the build script
@echo .         Usage:  build [date-string]
dir %USERPROFILE%

:end
set BUILD_TYPE=