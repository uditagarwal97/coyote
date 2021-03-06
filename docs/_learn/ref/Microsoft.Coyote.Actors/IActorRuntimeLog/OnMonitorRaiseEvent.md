---
layout: reference
section: learn
title: OnMonitorRaiseEvent
permalink: /learn/ref/Microsoft.Coyote.Actors/IActorRuntimeLog/OnMonitorRaiseEvent
---
# IActorRuntimeLog.OnMonitorRaiseEvent method

Invoked when the specified monitor raised an event.

```csharp
public void OnMonitorRaiseEvent(string monitorType, string stateName, Event e)
```

| parameter | description |
| --- | --- |
| monitorType | Name of type of the monitor raising the event. |
| stateName | The name of the state in which the event is being raised. |
| e | The event being raised. |

## See Also

* class [Event](../../Microsoft.Coyote/EventType)
* interface [IActorRuntimeLog](../IActorRuntimeLogType)
* namespace [Microsoft.Coyote.Actors](../IActorRuntimeLogType)
* assembly [Microsoft.Coyote](../../MicrosoftCoyoteAssembly)

<!-- DO NOT EDIT: generated by xmldocmd for Microsoft.Coyote.dll -->
