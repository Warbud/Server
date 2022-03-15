#!/bin/sh
warbudHome="C:/WEBSITES/Warbud"
folderPath="Builds/RevitStats"

rm -r $warbudHome/$folderPath
dotnet publish -c Release -o $warbudHome/$folderPath