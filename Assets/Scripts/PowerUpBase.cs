using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    [SerializeField] protected bool IsEffectActive { get; set; } = false;

    public abstract void ApplyEffect(Player player);
}
