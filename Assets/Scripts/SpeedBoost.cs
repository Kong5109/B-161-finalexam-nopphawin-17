using UnityEngine;

public class SpeedBoost : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        player.SetMoveSpeed(player.MoveSpeed * 2); //Add Player speed by 2 times
        Destroy(this.gameObject);
    }
}
