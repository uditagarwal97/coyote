---
layout: reference
section: learn
title: SendEvent
permalink: /learn/ref/Microsoft.Coyote.Actors/IActorRuntime/SendEvent
---
# IActorRuntime.SendEvent method

Sends an asynchronous [`Event`](../../Microsoft.Coyote/EventType) to an actor.

```csharp
public void SendEvent(ActorId targetId, Event e, EventGroup eventGroup = null, 
    SendOptions options = null)
```

| parameter | description |
| --- | --- |
| targetId | The id of the target. |
| e | The event to send. |
| eventGroup | An optional event group associated with this Actor. |
| options | Optional configuration of a send operation. |

## See Also

* class [ActorId](../ActorIdType)
* class [Event](../../Microsoft.Coyote/EventType)
* class [EventGroup](../EventGroupType)
* class [SendOptions](../SendOptionsType)
* interface [IActorRuntime](../IActorRuntimeType)
* namespace [Microsoft.Coyote.Actors](../IActorRuntimeType)
* assembly [Microsoft.Coyote](../../MicrosoftCoyoteAssembly)

<!-- DO NOT EDIT: generated by xmldocmd for Microsoft.Coyote.dll -->
