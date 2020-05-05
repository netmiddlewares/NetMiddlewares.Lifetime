# NetMiddlewares.RouteLifetime

[![GitHub license](https://img.shields.io/github/license/netmiddlewares/NetMiddlewares.RouteLifetime)](https://github.com/netmiddlewares/NetMiddlewares.RouteLifetime)
[![Build Status](https://travis-ci.org/netmiddlewares/NetMiddlewares.RouteLifetime.svg?branch=master)](https://travis-ci.org/netmiddlewares/NetMiddlewares.RouteLifetime)
[![Nuget](https://buildstats.info/nuget/NetMiddlewares.RouteLifetime)](http://www.nuget.org/packages/NetMiddlewares.RouteLifetime)

.NET Core middleware to 

# How to use

## Step 1 - Add the middleware to the services declaration

```
public void ConfigureServices(IServiceCollection services)
{
    //...
    services.AddRouteLifetime();
}
  ```
  
## Step 2 - Add the middleware to the pipeline

```
public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    //...
    
    app.UseRouteLifetime();
    
    //...
}
  ```

Done!

From now on, everytime the pipeline is run, we will store the Date the route was used.
Currently, we are just storing a Dictionary with the route path as the key and the last DateTime it was used as the value.
We can access it by using:
```
var repository = Container.GetInstance<ILifetimeRepository>();
var lastUsedDateTime = repository.GetEntries()["/api/login"];
```