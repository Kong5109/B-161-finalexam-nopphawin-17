using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    [SerializeField] protected bool IsEffectActive = false;

    public abstract void ApplyEffect(Player player);
}
