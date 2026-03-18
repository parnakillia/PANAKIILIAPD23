using System;

public class GameLogger
{
    public void Subscribe(Player player)
    {
        player.DamageTaken += Log;
    }

    private void Log(int damage, int currentHP)
    {
        Console.WriteLine($"GameLogger: Отримано урону: {damage}, Поточне HP: {currentHP}");
    }
}