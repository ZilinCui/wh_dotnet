@echo off

set zip=D:\SOFT\tool\7-zip\7z.exe
set outputname=202000800576�����ص������ҵ
set outputdir=C:\Users\Zilin Cui\Desktop\%outputname%

%zip% a "%outputdir%" . -xr"@exclude.txt"