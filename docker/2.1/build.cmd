@echo off

docker build -t minkestrel -f %~dp0/Dockerfile %~dp0/../.. %*
