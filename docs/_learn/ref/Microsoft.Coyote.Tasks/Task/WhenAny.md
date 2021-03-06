---
layout: reference
section: learn
title: WhenAny
permalink: /learn/ref/Microsoft.Coyote.Tasks/Task/WhenAny
---
# Task.WhenAny method (1 of 4)

Creates a [`Task`](../TaskType) that will complete when any task in the specified enumerable collection have completed.

```csharp
public static Task<Task> WhenAny(IEnumerable<Task> tasks)
```

| parameter | description |
| --- | --- |
| tasks | The tasks to wait for completion. |

## See Also

* class [Task&lt;TResult&gt;](../Task-1Type)
* class [Task](../TaskType)
* namespace [Microsoft.Coyote.Tasks](../TaskType)
* assembly [Microsoft.Coyote](../../MicrosoftCoyoteAssembly)

---

# Task.WhenAny method (2 of 4)

Creates a [`Task`](../TaskType) that will complete when any task in the specified array have completed.

```csharp
public static Task<Task> WhenAny(params Task[] tasks)
```

| parameter | description |
| --- | --- |
| tasks | The tasks to wait for completion. |

## See Also

* class [Task&lt;TResult&gt;](../Task-1Type)
* class [Task](../TaskType)
* namespace [Microsoft.Coyote.Tasks](../TaskType)
* assembly [Microsoft.Coyote](../../MicrosoftCoyoteAssembly)

---

# Task.WhenAny&lt;TResult&gt; method (3 of 4)

Creates a [`Task`](../TaskType) that will complete when any task in the specified enumerable collection have completed.

```csharp
public static Task<Task<TResult>> WhenAny<TResult>(IEnumerable<Task<TResult>> tasks)
```

| parameter | description |
| --- | --- |
| tasks | The tasks to wait for completion. |

## See Also

* class [Task&lt;TResult&gt;](../Task-1Type)
* class [Task](../TaskType)
* namespace [Microsoft.Coyote.Tasks](../TaskType)
* assembly [Microsoft.Coyote](../../MicrosoftCoyoteAssembly)

---

# Task.WhenAny&lt;TResult&gt; method (4 of 4)

Creates a [`Task`](../TaskType) that will complete when any task in the specified array have completed.

```csharp
public static Task<Task<TResult>> WhenAny<TResult>(params Task<TResult>[] tasks)
```

| parameter | description |
| --- | --- |
| tasks | The tasks to wait for completion. |

## See Also

* class [Task&lt;TResult&gt;](../Task-1Type)
* class [Task](../TaskType)
* namespace [Microsoft.Coyote.Tasks](../TaskType)
* assembly [Microsoft.Coyote](../../MicrosoftCoyoteAssembly)

<!-- DO NOT EDIT: generated by xmldocmd for Microsoft.Coyote.dll -->
