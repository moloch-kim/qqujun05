using UnityEngine;

public class SpreadingSpell : Caster
{
    public int ShootAmount;
    public override void InvokeSpell()
    {
        float angleStep = 360f / ShootAmount;
        float angle = 0f;

        for (int i = 0; i < ShootAmount; i++)
        {
            float x = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180);
            float z = transform.position.z + Mathf.Cos((angle * Mathf.PI) / 180);

            Vector3 projectileVector = new Vector3(x, transform.position.y, z);
            Vector3 projectileMoveDirection = (projectileVector - transform.position).normalized;
 
            Projectile = Object.Instantiate(Projectile, CastPoint.position, CastPoint.rotation);
            Rigidbody rb = Projectile.GetComponent<Rigidbody>();
            rb.velocity = projectileMoveDirection * Speed;


            angle += angleStep;
        }
    }
}