# ActionResult In ASP.NET Core MVC

# Introduction

This article is an  overview of the use of ActionResult in ASP.Net Core MVC. ASP.NET Core MVC has different types of Action Results. Each action result returns a different format of the output. As a programmer, we need to use different action results to get the expected output.

# What is Action Method in ASP.NET Core MVC?
 
Actions are the methods in controller class which are responsible for returning the view or Json data. Action will mainly have return type “ActionResult” and it will be invoked from method InvokeAction called by controller. All the public methods inside a controller which respond to the URL are known as Action Methods. When creating an Action Method we must follow these rules.

# Action Results

|Action Method|Description| 
| :---|:---:|
|IActionResult |Defines a contract that represents the result of an action method.|
|ActionResult  |A default implementation of IActionResult.| 
|ContentResult |Represents a text result.|
|EmptyResult  |Represents an ActionResult that when executed will do nothing.| 
|JsonResult |An action result which formats the given object as JSON.|
|PartialViewResult|Represents an ActionResult that renders a partial view to the response.| 
|ViewResult|Represents an ActionResult that renders a view to the response.|
|ViewComponentResult|An IActionResult which renders a view component to the response.|

# For more information visit below link
https://www.c-sharpcorner.com/article/actionresult-in-asp-net-core-mvc/
