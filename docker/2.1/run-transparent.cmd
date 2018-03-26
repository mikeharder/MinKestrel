@echo off

for /f "usebackq tokens=*" %%a in (`docker network ls -f "driver=transparent" -q`) do docker run -it --rm --network %%a minkestrel %%*

 
