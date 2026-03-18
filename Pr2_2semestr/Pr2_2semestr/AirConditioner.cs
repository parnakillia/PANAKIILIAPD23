using System;

public class AirConditioner
{
    public void Subscribe(TemperatureSensor sensor)
    {
        sensor.TemperatureChanged += ReactToTemperature;
    }

    private void ReactToTemperature(double temperature)
    {
        if (temperature < 17)
            Console.WriteLine("AirConditioner: Увімкнено ОБІГРІВ");
        else if (temperature <= 25)
            Console.WriteLine("AirConditioner: Кондиціонер ВИМКНЕНИЙ");
        else
            Console.WriteLine("AirConditioner: Увімкнено ОХОЛОДЖЕННЯ");
    }
}