using UnityEngine;

public class ArcSpell : Caster
{
    public override void InvokeSpell()
    {
        Projectile = Object.Instantiate(Projectile, CastPoint.position, CastPoint.rotation);
        Rigidbody rb = Projectile.GetComponent<Rigidbody>();
        rb.velocity = (Vector3.forward + Vector3.up) * Speed;
    }
}
