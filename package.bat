@echo off

set zip=D:\SOFT\tool\7-zip\7z.exe
set outputname=202000800576崔子霖第五次作业
set outputdir=C:\Users\Zilin Cui\Desktop\%outputname%

%zip% a "%outputdir%" . -xr"@exclude.txt"