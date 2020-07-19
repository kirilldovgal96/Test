$msBuild = "$env:windir\Microsoft.Net\Framework\v4.0.30319\msbuild.exe"
& $msBuild "C:\Test\SuperApp.sln"
Write-Host "Готово..." 