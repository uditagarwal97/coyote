---
layout: reference
section: learn
title: AwaitableEventGroup<T>
permalink: /learn/ref/Microsoft.Coyote.Actors/AwaitableEventGroup-1Type
---
# AwaitableEventGroup&lt;T&gt; class

An object representing an awaitable long running context involving one or more actors. An `AwaitableEventGroup` can be provided as an optional argument in CreateActor and SendEvent. If a null `AwaitableEventGroup` is passed then the `EventGroup` is inherited from the sender or target actors (based on which ever one has a [`CurrentEventGroup`](Actor/CurrentEventGroup)). In this way an `AwaitableEventGroup` is automatically communicated to all actors involved in completing some larger operation. Each actor involved can find the `AwaitableEventGroup` using their [`CurrentEventGroup`](Actor/CurrentEventGroup) property.

```csharp
public class AwaitableEventGroup<T> : EventGroup
```

| parameter | description |
| --- | --- |
| T | The result returned when the operation is completed. |

## Public Members

| name | description |
| --- | --- |
| [AwaitableEventGroup](AwaitableEventGroup-1/AwaitableEventGroup)(…) | Initializes a new instance of the [`AwaitableEventGroup`](AwaitableEventGroup-1Type) class. |
| [IsCanceled](AwaitableEventGroup-1/IsCanceled) { get; } | Value that indicates whether the task completed execution due to being canceled. |
| [IsCompleted](AwaitableEventGroup-1/IsCompleted) { get; } | Indicates the `AwaitableEventGroup` has been completed. |
| [IsFaulted](AwaitableEventGroup-1/IsFaulted) { get; } | Value that indicates whether the task completed due to an unhandled exception. |
| [Task](AwaitableEventGroup-1/Task) { get; } | Gets the task created by this `AwaitableEventGroup`. |
| [GetAwaiter](AwaitableEventGroup-1/GetAwaiter)() | Gets an awaiter for this awaitable. |
| virtual [SetCancelled](AwaitableEventGroup-1/SetCancelled)() | Transitions the underlying task into the Canceled state. |
| virtual [SetException](AwaitableEventGroup-1/SetException)(…) | Transitions the underlying task into the Faulted state and binds it to the specified exception. |
| virtual [SetResult](AwaitableEventGroup-1/SetResult)(…) | Transitions the underlying task into the RanToCompletion state. |
| virtual [TrySetCanceled](AwaitableEventGroup-1/TrySetCanceled)() | Attempts to transition the underlying task into the Canceled state. |
| virtual [TrySetException](AwaitableEventGroup-1/TrySetException)(…) | Attempts to transition the underlying task into the Faulted state and binds it to the specified exception. |
| virtual [TrySetResult](AwaitableEventGroup-1/TrySetResult)(…) | Attempts to transition the underlying task into the RanToCompletion state. |

## See Also

* class [EventGroup](EventGroupType)
* namespace [Microsoft.Coyote.Actors](../MicrosoftCoyoteActorsNamespace)
* assembly [Microsoft.Coyote](../MicrosoftCoyoteAssembly)

<!-- DO NOT EDIT: generated by xmldocmd for Microsoft.Coyote.dll -->
