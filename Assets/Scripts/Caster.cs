using UnityEngine;

public class Caster :  MonoBehaviour , IInvokable
{
    public Transform CastPoint;
    public GameObject Projectile;
    public float Speed;
    public virtual void InvokeSpell()
    {

    }
}
