using System;

public class SecuritySystem
{
    public void Subscribe(TemperatureSensor sensor)
    {
        sensor.TemperatureChanged += CheckTemperature;
    }

    private void CheckTemperature(double temperature)
    {
        if (temperature > 40)
            Console.WriteLine("SecuritySystem: ⚠ Перегрів системи!");
        else if (temperature < 5)
            Console.WriteLine("SecuritySystem: ⚠ Ризик замерзання систем!");
    }
}