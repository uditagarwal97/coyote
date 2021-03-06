---
layout: reference
section: learn
title: Write
permalink: /learn/ref/Microsoft.Coyote.IO/ILogger/Write
---
# ILogger.Write method (1 of 4)

Writes an informational string to the log.

```csharp
public void Write(string value)
```

| parameter | description |
| --- | --- |
| value | The string to write. |

## See Also

* interface [ILogger](../ILoggerType)
* namespace [Microsoft.Coyote.IO](../ILoggerType)
* assembly [Microsoft.Coyote](../../MicrosoftCoyoteAssembly)

---

# ILogger.Write method (2 of 4)

Writes a string to the log.

```csharp
public void Write(LogSeverity severity, string value)
```

| parameter | description |
| --- | --- |
| severity | The severity of the issue being logged. |
| value | The string to write. |

## See Also

* enum [LogSeverity](../LogSeverityType)
* interface [ILogger](../ILoggerType)
* namespace [Microsoft.Coyote.IO](../ILoggerType)
* assembly [Microsoft.Coyote](../../MicrosoftCoyoteAssembly)

---

# ILogger.Write method (3 of 4)

Writes an informational string to the log.

```csharp
public void Write(string format, params object[] args)
```

| parameter | description |
| --- | --- |
| format | The string format to write. |
| args | The arguments needed to format the string. |

## See Also

* interface [ILogger](../ILoggerType)
* namespace [Microsoft.Coyote.IO](../ILoggerType)
* assembly [Microsoft.Coyote](../../MicrosoftCoyoteAssembly)

---

# ILogger.Write method (4 of 4)

Writes a string to the log.

```csharp
public void Write(LogSeverity severity, string format, params object[] args)
```

| parameter | description |
| --- | --- |
| severity | The severity of the issue being logged. |
| format | The string format to write. |
| args | The arguments needed to format the string. |

## See Also

* enum [LogSeverity](../LogSeverityType)
* interface [ILogger](../ILoggerType)
* namespace [Microsoft.Coyote.IO](../ILoggerType)
* assembly [Microsoft.Coyote](../../MicrosoftCoyoteAssembly)

<!-- DO NOT EDIT: generated by xmldocmd for Microsoft.Coyote.dll -->
