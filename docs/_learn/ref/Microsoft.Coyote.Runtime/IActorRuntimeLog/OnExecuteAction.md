---
layout: reference
section: learn
title: OnExecuteAction
permalink: /learn/ref/Microsoft.Coyote.Runtime/IActorRuntimeLog/OnExecuteAction
---
# IActorRuntimeLog.OnExecuteAction method

Invoked when the specified actor executes an action.

```csharp
public void OnExecuteAction(ActorId id, string handlingStateName, string currentStateName, 
    string actionName)
```

| parameter | description |
| --- | --- |
| id | The id of the actor executing the action. |
| handlingStateName | The state that declared this action (can be different from currentStateName in the case of pushed states. |
| currentStateName | The state name, if the actor is a state machine and a state exists, else null. |
| actionName | The name of the action being executed. |

## See Also

* class [ActorId](../../Microsoft.Coyote.Actors/ActorIdType)
* interface [IActorRuntimeLog](../IActorRuntimeLogType)
* namespace [Microsoft.Coyote.Runtime](../IActorRuntimeLogType)
* assembly [Microsoft.Coyote](../../MicrosoftCoyoteAssembly)

<!-- DO NOT EDIT: generated by xmldocmd for Microsoft.Coyote.dll -->