# Filters
Filters in .NET offer a great way to hook into the MVC action invocation pipeline. Therefore, we can use filters to extract code that can be reused and make our actions cleaner and maintainable. There are some filters that are already provided by ASP.NET Core like the authorization filter, and there are the custom ones that we can create ourselves.

### There are different filter types:
* Authorization filters – They run first to determine whether a user is authorized for the current request
* Resource filters – They run right after the authorization filters and are very useful for caching and performance
* Action filters – They run right before and after the action method execution
* Exception filters – They are used to handle exceptions before the response body is populated
* Result filters – They run before and after the execution of the action methods result.

 `Like the other types of filters, the action filter can be added to different scope levels: Global, Action, Controller.`

#### Global type
```csharp
builder.Services.AddControllers(config => 
{ 
    config.Filters.Add(new GlobalFilterExample()); 
});
```

#### Action/Controller type
```csharp
services.AddScoped<ActionFilterExample>();
services.AddScoped<ControllerFilterExample>();
```


## Each filter type is executed at a different stage in the filter pipeline:

### Authorization filters:
* Run first.
* Determine whether the user is authorized for the request.
* Short-circuit the pipeline if the request is not authorized.

### Resource filters:
* Run after authorization.
* xref:Microsoft.AspNetCore.Mvc.Filters.IResourceFilter.OnResourceExecuting%2A runs code before the rest of the filter pipeline. For example, OnResourceExecuting runs code before model binding.
* xref:Microsoft.AspNetCore.Mvc.Filters.IResourceFilter.OnResourceExecuted%2A runs code after the rest of the pipeline has completed.

### Action filters:
* Run immediately before and after an action method is called.
* Can change the arguments passed into an action.
* Can change the result returned from the action.
* Are not supported in Razor Pages.

### Endpoint filters:
* Run immediately before and after an action method is called.
* Can change the arguments passed into an action.
* Can change the result returned from the action.
* Are not supported in Razor Pages.
* Can be invoked on both actions and route handler-based endpoints.
* Exception filters apply global policies to unhandled exceptions that occur before the response body has been written to.

### Result filters:
* Run immediately before and after the execution of action results.
* Run only when the action method executes successfully.
* Are useful for logic that must surround view or formatter execution.
