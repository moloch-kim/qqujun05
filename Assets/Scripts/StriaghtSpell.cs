using UnityEngine;

public class StriaghtSpell : Caster
{ 

    public override void InvokeSpell()
    {
        Projectile = Object.Instantiate(Projectile, CastPoint.position, CastPoint.rotation);
        Rigidbody rb = Projectile.GetComponent<Rigidbody>();
        rb.velocity = CastPoint.forward * Speed;
    }
}
