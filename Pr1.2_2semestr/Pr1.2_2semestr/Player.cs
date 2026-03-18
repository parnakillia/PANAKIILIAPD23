using System;

public class Player
{
    private int _hp;

    public event Action<int, int> DamageTaken;


    public Player(int hp)
    {
        _hp = hp;
    }

    public void TakeDamage(int damage)
    {
        _hp -= damage;
        if (_hp < 0)
            _hp = 0;

        OnDamageTaken(damage, _hp);
    }

    protected virtual void OnDamageTaken(int damage, int currentHP)
    {
        DamageTaken?.Invoke(damage, currentHP);
    }
}