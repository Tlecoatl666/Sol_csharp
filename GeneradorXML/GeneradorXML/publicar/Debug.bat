@echo off

title Instalador de: Generador de XML's!
echo Se instalaran los recursos necesarios para el uso apropiado de la plataforma.
echo Instalado drivers: AccessDatabaseEngine...
echo  %~d0%~p0
start %~d0%~p0\Archivos\AccessDatabaseEngine.exe
pause
echo Instalado programa: Generar_XML...
start %~d0%~p0\Archivos\setup.exe
pause
