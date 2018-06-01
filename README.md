# P2F

The PowerShell Provider Framework (P2F) performs the heavy lifting for developing PowerShell Providers.

# Cross-Platform, and Cross-PowerShell

The P2F Framework now targets .NET Standard 2.0 and uses (a fork of) the PowerShellStandard.Library to support building providers that are cross-platform and work on PowerShell (3, 4), 5 and 6 ...

Currently, I'm referencing [my own fork of PowerShellStandard](https://github.com/Jaykul/PowerShellStandard/), 
which you'll have to download separately. 
I'm leaving it like that for now because I expect [my PR #27](https://github.com/PowerShell/PowerShellStandard/pull/27) 
to get merged into the nuget published version. 

In the meantime, be **very** careful, you must **never** package or ship System.Management.Automation.dll :wink:!