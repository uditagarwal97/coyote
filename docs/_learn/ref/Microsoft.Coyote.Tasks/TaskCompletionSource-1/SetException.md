---
layout: reference
section: learn
title: SetException
permalink: /learn/ref/Microsoft.Coyote.Tasks/TaskCompletionSource-1/SetException
---
# TaskCompletionSource&lt;TResult&gt;.SetException method

Transitions the underlying task into the Faulted state and binds it to the specified exception.

```csharp
public virtual void SetException(Exception exception)
```

| parameter | description |
| --- | --- |
| exception | The exception to bind to this task. |

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | The underlying [`Task`](../Task-1Type) is already in one of the three final states: RanToCompletion, Faulted, or Canceled. |

## See Also

* class [TaskCompletionSource&lt;TResult&gt;](../TaskCompletionSource-1Type)
* namespace [Microsoft.Coyote.Tasks](../TaskCompletionSource-1Type)
* assembly [Microsoft.Coyote](../../MicrosoftCoyoteAssembly)

<!-- DO NOT EDIT: generated by xmldocmd for Microsoft.Coyote.dll -->
