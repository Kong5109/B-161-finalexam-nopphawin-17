using UnityEngine;

public class ShieldBuff : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        if (IsEffectActive == false)
        {
            player.SetInvulnerability(true);
            Destroy(this.gameObject);
        }
    }
}
