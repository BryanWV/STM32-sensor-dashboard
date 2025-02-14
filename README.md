# Description
IoT Dashboard with .NET <br>
A web dashboard that communicates with a STM32 to display sensor data (LM35 temperature sensor).<br>
Tech Stack: .NET Web API + SignalR + Blazor.
<br> <br>
## Tech stack
Frontend: Blazor WebAssembly <br>
Backend: .Net Web API <br>
Microcontroller: STM32F746ZG
<br> <br>

# Project structure
*STM32IoT* folder contains web application template, initialized using the following command
```bash
dotnet new webapi -o STM32IoT && cd STM32IoT && dotnet add new package System.IO.Ports && dotnet add new package Microsoft.AspNetCore.SignalR
```

*microcontroller* folder contains the PlatformIO template where the code for the stm32 is located
<br> <br>
# Technical details

SignalR is a library mainly used for adding real-time web functionality to applications. <br>
It uses something called *Hubs* to communicate between clients and servers, and the server creates an endpoint for duplex communication. <br>
In a nutshell, A Hub acts like a proxy between client and server, and SignalR allows to expose methods or functions that both server and client can use. <br>
It is also used a Web Api, a framework (more like a template) that creates a RESTful API, which works as a component that allows communication through requests.
<br> <br>
## Keywords
1. .NET
2. Cloud Architecture
3. Client/Server requests
4. RESTful API
5. SignalR
6. Dasboard
7. Microcontroller
<br> <br>

# Acknowledgements
* [What is an API](https://aws.amazon.com/what-is/api/)
* [How SignalR Works](https://learn.microsoft.com/en-us/training/modules/aspnet-core-signalr/3-how-signalr-works)
* [Hubs: Functions](https://learn.microsoft.com/en-us/aspnet/core/signalr/hubs?view=aspnetcore-9.0)
