---
layout: reference
section: learn
title: IsAssemblyRewrittenAttribute
permalink: /learn/ref/Microsoft.Coyote.Rewriting/IsAssemblyRewrittenAttributeType
---
# IsAssemblyRewrittenAttribute class

Attribute for checking if an assembly has been rewritten by Coyote. If this attribute is applied to an assembly, it denotes that the assembly has been rewritten.

```csharp
[AttributeUsage(AttributeTargets.Assembly)]
public sealed class IsAssemblyRewrittenAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [IsAssemblyRewrittenAttribute](IsAssemblyRewrittenAttribute/IsAssemblyRewrittenAttribute)(…) | Initializes a new instance of the [`IsAssemblyRewrittenAttribute`](IsAssemblyRewrittenAttributeType) class. |
| readonly [Version](IsAssemblyRewrittenAttribute/Version) | The version of Coyote used for the rewritting. |

## See Also

* namespace [Microsoft.Coyote.Rewriting](../MicrosoftCoyoteRewritingNamespace)
* assembly [Microsoft.Coyote.Test](../MicrosoftCoyoteTestAssembly)

<!-- DO NOT EDIT: generated by xmldocmd for Microsoft.Coyote.Test.dll -->
