using System;

public class UIHealthBar
{
    public void Subscribe(Player player)
    {
        player.DamageTaken += ShowHP;
    }

    private void ShowHP(int damage, int currentHP)
    {
        Console.WriteLine($"UIHealthBar: Поточне HP = {currentHP}");
    }
}