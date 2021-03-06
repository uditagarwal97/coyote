---
layout: reference
section: learn
title: Task<TResult>
permalink: /learn/ref/Microsoft.Coyote.Tasks/Task-1Type
---
# Task&lt;TResult&gt; class

Represents an asynchronous operation that can return a value. Each [`Task`](Task-1Type) is a thin wrapper over Task and each call simply invokes the wrapped task. During testing, a [`Task`](TaskType) is controlled by the runtime and systematically interleaved with other asynchronous operations to find bugs.

```csharp
public class Task<TResult> : Task
```

| parameter | description |
| --- | --- |
| TResult | The type of the produced result. |

## Public Members

| name | description |
| --- | --- |
| [Result](Task-1/Result) { get; } | Gets the result value of this task. |
| [UncontrolledTask](Task-1/UncontrolledTask) { get; } | The uncontrolled Task that is wrapped inside this controlled [`Task`](Task-1Type). |
| [ConfigureAwait](Task-1/ConfigureAwait)(…) | Configures an awaiter used to await this task. |
| [GetAwaiter](Task-1/GetAwaiter)() | Gets an awaiter for this awaitable. |

## See Also

* class [Task](TaskType)
* namespace [Microsoft.Coyote.Tasks](../MicrosoftCoyoteTasksNamespace)
* assembly [Microsoft.Coyote](../MicrosoftCoyoteAssembly)

<!-- DO NOT EDIT: generated by xmldocmd for Microsoft.Coyote.dll -->
