# ASP0019 "Use Indexer" code fix formatting bug

## Steps to Reproduce

1. After ASP0019 is reported for the call to `Add`, apply the "Use indexer" code fix.

2. Verify that the indexer in the fixed code is on a separate line:

**Actual**
```csharp
context.Response.Headers
["Header"] = "Value";
```

**Expected**
```csharp
context.Response.Headers["Header"] = "Value";
```
