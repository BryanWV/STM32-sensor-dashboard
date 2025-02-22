/* Main program to read serial data from the microcontroller */
using Microsoft.AspNetCore.SignalR;
using System.IO.Ports;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSignalR();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.MapHub<SensorHub>("/sensorHub");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();


var serialPort = new SerialPort("/dev/ttyACM0", 115200);
if (!serialPort.IsOpen)
{
	serialPort.Open();
}

Task.Run(async () =>
{
    while (true)
    {
        try
        {
            string data = serialPort.ReadLine();

            Console.WriteLine($"Received: {data}");

            await app.Services.GetRequiredService<IHubContext<SensorHub>>().Clients.All.SendAsync("ReceiveData", data);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
});

app.Run();

public class SensorHub : Hub { }

