---
layout: reference
section: learn
title: OnDefaultEventHandler
permalink: /learn/ref/Microsoft.Coyote.Actors/ActorRuntimeLogTextFormatter/OnDefaultEventHandler
---
# ActorRuntimeLogTextFormatter.OnDefaultEventHandler method

Invoked when the specified actor is idle (there is nothing to dequeue) and the default event handler is about to be executed.

```csharp
public virtual void OnDefaultEventHandler(ActorId id, string stateName)
```

| parameter | description |
| --- | --- |
| id | The id of the actor that the state will execute in. |
| stateName | The state name, if the actor is a state machine and a state exists, else null. |

## See Also

* class [ActorId](../ActorIdType)
* class [ActorRuntimeLogTextFormatter](../ActorRuntimeLogTextFormatterType)
* namespace [Microsoft.Coyote.Actors](../ActorRuntimeLogTextFormatterType)
* assembly [Microsoft.Coyote](../../MicrosoftCoyoteAssembly)

<!-- DO NOT EDIT: generated by xmldocmd for Microsoft.Coyote.dll -->
