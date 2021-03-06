---
layout: reference
section: learn
title: WithVerbosityEnabled
permalink: /learn/ref/Microsoft.Coyote/Configuration/WithVerbosityEnabled
---
# Configuration.WithVerbosityEnabled method

Updates the configuration with verbose output enabled or disabled.

```csharp
public Configuration WithVerbosityEnabled(bool isVerbose = true, 
    LogSeverity logLevel = LogSeverity.Informational)
```

| parameter | description |
| --- | --- |
| isVerbose | If true, then messages are logged. |
| logLevel | The level of detail to provide in verbose logging. |

## See Also

* enum [LogSeverity](../../Microsoft.Coyote.IO/LogSeverityType)
* class [Configuration](../ConfigurationType)
* namespace [Microsoft.Coyote](../ConfigurationType)
* assembly [Microsoft.Coyote](../../MicrosoftCoyoteAssembly)

<!-- DO NOT EDIT: generated by xmldocmd for Microsoft.Coyote.dll -->
