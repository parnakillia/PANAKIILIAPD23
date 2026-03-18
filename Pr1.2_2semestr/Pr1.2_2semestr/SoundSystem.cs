using System;

public class SoundSystem
{
    public void Subscribe(Player player)
    {
        player.DamageTaken += PlaySound;
    }

    private void PlaySound(int damage, int currentHP)
    {
        Console.WriteLine("SoundSystem: Звук отримання урону!");

        if (currentHP <= 20 && currentHP > 0)
            Console.WriteLine("SoundSystem: 🔊 Критичний стан!");
    }
}