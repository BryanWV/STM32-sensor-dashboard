# Description
IoT Dashboard with .NET <br>
A web dashboard that communicates with a STM32 to display sensor data (e.g., LM35 temperature readings).<br>
Tech Stack: .NET Web API + SignalR + Blazor. <br> <br>
## Tech stack
Frontend: Blazor WebAssembly <br>
Backend: .Net Web API <br>
Microcontroller: STM32F746ZG <br> <br>


# Project structure
STM32IoT folder containsna web application, initialized using the following command
```
dotnet new webapi -o STM32IoT && cd STM32IoT && dotnet add new package System.IO.Ports && dotnet add nee package Microsoft.AspNetCore.SignalR
```

microcontroller folder contains the PlatformIO template where the code for the stm32 is located

# Technical details

SignalR is a library mainly used for adding real-time web functionality to applications. <br>
It uses something called Hubs to communicate between clients and servers, and the server creates an endpoint for duplex communication. <br>
In a nutshell, A Hub acts like a proxy between client and server, and SignalR allows to exposes methods or functions that both server and client can use <br>

# Acknowledgements
