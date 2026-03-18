using System;

public class Display
{
    public void Subscribe(TemperatureSensor sensor)
    {
        sensor.TemperatureChanged += ShowTemperature;
    }

    private void ShowTemperature(double temperature)
    {
        Console.WriteLine($"Display: Поточна температура = {temperature}°C");
    }
}