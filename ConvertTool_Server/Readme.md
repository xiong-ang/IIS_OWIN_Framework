# Install Script
```
%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\installutil.exe [youpath]\ConvertToolService.exe
```

# Start Script
```
Net Start ConvertToolService
```

# Configurate Script
```
sc config ConvertToolService start= auto
```

# Uninstall Script
```
%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\installutil.exe /u [youpath]\ConvertToolService.exe
```