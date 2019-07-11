@echo off
echo [[95m=============== [91mAUTOMATED UNITY BUILD[0m [95m==============[0m]
echo [[95m=============== [91mTEAM DIAMOND DONKEYS[0m [95m===============[0m]
echo [[95m=============== [91mVANCOUVER FILM SCHOOL[0m [95m==============[0m]
echo [[95m================== [91mGD54 and PG15[0m [95m===================[0m]

timeout 3 > NUL

REM Initialize Paths
set CURRENT_DIR=%cd%
set WORKSPACE=C:\Users\pg15teddy\Perforce\Unity\...
set EDITOR="C:\Program Files\Unity\Hub\Editor\2019.1.8f1\Editor\Unity.exe"
set PROJECT_DIR=C:\Users\pg15teddy\Perforce\Unity\Test\

echo .
echo .
echo [[95m========== [92mPERFORCE SYNCING [95m==========[0m]
timeout 3 > NUL
p4 set P4PORT=perforce:1666
p4 set P4USER=pg15teddy
p4 set P4CLIENT=pg15teddy_SCT201-03
set P4PASSWD=0BD45470B11E9CD84AFE28387BD98B48
p4 set P4IGNORE=.p4ignore.txt
p4 sync -f %WORKSPACE%
echo [[95m========== [92mPERFORCE SYNCED [95m===========[0m]
echo .
echo .

echo [[95m========== [93mUNITY BUILDING [95m============[0m]
%EDITOR% -quit -batchmode -logFile .\Builds\build.log -projectPath %PROJECT_DIR% -buildWindows64Player %CURRENT_DIR%\Builds\Test.exe
echo [[95m========== [93mUNITY BUILDED [95m=============[0m]

echo [96m
pause
echo [0m