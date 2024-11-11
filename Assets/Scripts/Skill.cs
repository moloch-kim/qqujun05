using UnityEngine;

public class Caster : IInvokable
{
    public Transform CastPoint;
    public GameObject Projectile;
    public float Speed;
    public virtual void InvokeSpell(Transform firePoint, GameObject prefab)
    {

    }
}


public class StriaghtSpell : Caster
{ 

    public override void InvokeSpell(Transform firePoint, GameObject prefab)
    {
        Projectile = Object.Instantiate(prefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = Projectile.GetComponent<Rigidbody>();
        rb.velocity = firePoint.forward * Speed;
    }
}

public class ArcSpell : Caster
{
    public override void InvokeSpell(Transform firePoint, GameObject prefab)
    {
        
    }
}

public class SpreadingSpell : Caster
{
    public override void InvokeSpell(Transform firePoint, GameObject prefab)
    {

    }
}