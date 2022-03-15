@echo off
setlocal enableextensions enabledelayedexpansion

if exist "Update\LiberatorY5.exe" (
mkdir Old >nul
TASKKILL.EXE /IM LiberatorY5.exe /F
move LiberatorY5.exe Old >nul
move Update\LiberatorY5.exe . >nul
rd /s /q Update
rd /s /q Old
echo Update Successful^!
) else (
echo Update file not found, probably you running the newest version^!
)
pause
start LiberatorY5.exe