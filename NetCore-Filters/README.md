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
