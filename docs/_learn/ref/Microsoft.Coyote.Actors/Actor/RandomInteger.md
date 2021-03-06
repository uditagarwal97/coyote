---
layout: reference
section: learn
title: RandomInteger
permalink: /learn/ref/Microsoft.Coyote.Actors/Actor/RandomInteger
---
# Actor.RandomInteger method

Returns a nondeterministic integer, that can be controlled during analysis or testing. The value is used to generate an integer in the range [0..maxValue).

```csharp
protected int RandomInteger(int maxValue)
```

| parameter | description |
| --- | --- |
| maxValue | The max value. |

## Return Value

The controlled nondeterministic integer.

## See Also

* class [Actor](../ActorType)
* namespace [Microsoft.Coyote.Actors](../ActorType)
* assembly [Microsoft.Coyote](../../MicrosoftCoyoteAssembly)

<!-- DO NOT EDIT: generated by xmldocmd for Microsoft.Coyote.dll -->
