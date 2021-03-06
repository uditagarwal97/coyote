---
layout: reference
section: learn
title: OnEventHandledAsync
permalink: /learn/ref/Microsoft.Coyote.Actors/Actor/OnEventHandledAsync
---
# Actor.OnEventHandledAsync method

Asynchronous callback that is invoked when the actor finishes handling a dequeued event, unless the handler of the dequeued event caused the actor to halt (either normally or due to an exception). The actor will either become idle or dequeue the next event from its inbox.

```csharp
protected virtual Task OnEventHandledAsync(Event e)
```

| parameter | description |
| --- | --- |
| e | The event that was handled. |

## See Also

* class [Event](../../Microsoft.Coyote/EventType)
* class [Actor](../ActorType)
* namespace [Microsoft.Coyote.Actors](../ActorType)
* assembly [Microsoft.Coyote](../../MicrosoftCoyoteAssembly)

<!-- DO NOT EDIT: generated by xmldocmd for Microsoft.Coyote.dll -->
