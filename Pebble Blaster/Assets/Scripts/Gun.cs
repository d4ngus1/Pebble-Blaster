using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform muzzle;
    public Projectile projectile;
    public float msBetweenShots = 100;
    public float muzzleVelocity = 35;

<<<<<<< HEAD
    private float nextShotTime;
=======
    public Transform shell;
    public Transform shellEjection;

    MuzzleFlash muzzleFlash;

    private float nextShotTime;

    private void Start()
    {
        muzzleFlash = GetComponent<MuzzleFlash>();
    }

>>>>>>> parent of 133c4ff... E17. Weapon Variation.
    public void Shoot()
    {
        if (Time.time > nextShotTime)
        {
            nextShotTime = Time.time + msBetweenShots / 1000;
            Projectile newProjectile = Instantiate(projectile, muzzle.position, muzzle.rotation) as Projectile;
            newProjectile.SetSpeed(muzzleVelocity);
<<<<<<< HEAD
=======

            Instantiate(shell, shellEjection.position, shellEjection.rotation);
            muzzleFlash.Activate();
>>>>>>> parent of 133c4ff... E17. Weapon Variation.
        }
    }
}
