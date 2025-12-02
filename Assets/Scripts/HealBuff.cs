using UnityEngine;

public class HealBuff : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        Debug.Log("Heal Player +50 HP");
    }
}
