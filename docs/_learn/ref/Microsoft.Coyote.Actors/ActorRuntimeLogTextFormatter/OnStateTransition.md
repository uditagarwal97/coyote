---
layout: reference
section: learn
title: OnStateTransition
permalink: /learn/ref/Microsoft.Coyote.Actors/ActorRuntimeLogTextFormatter/OnStateTransition
---
# ActorRuntimeLogTextFormatter.OnStateTransition method

Invoked when the specified state machine enters or exits a state.

```csharp
public virtual void OnStateTransition(ActorId id, string stateName, bool isEntry)
```

| parameter | description |
| --- | --- |
| id | The id of the actor entering or exiting the state. |
| stateName | The name of the state being entered or exited. |
| isEntry | If true, this is called for a state entry; otherwise, exit. |

## See Also

* class [ActorId](../ActorIdType)
* class [ActorRuntimeLogTextFormatter](../ActorRuntimeLogTextFormatterType)
* namespace [Microsoft.Coyote.Actors](../ActorRuntimeLogTextFormatterType)
* assembly [Microsoft.Coyote](../../MicrosoftCoyoteAssembly)

<!-- DO NOT EDIT: generated by xmldocmd for Microsoft.Coyote.dll -->
