using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrowing : MonoBehaviour
{

    public GameObject spawnPosition;
    public GameObject projectilePrefab;
    public float throwForce = 10;

    public void Throw(float chargePower)
    {
        GameObject projectile = Instantiate(projectilePrefab, spawnPosition.transform.position, spawnPosition.transform.rotation);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        rb.AddForce(spawnPosition.transform.up * throwForce * chargePower, ForceMode2D.Impulse);
        rb.AddForce(spawnPosition.transform.right * throwForce * chargePower /2, ForceMode2D.Impulse);
        rb.AddTorque(throwForce * chargePower * 2);
        Destroy(projectile, 5);
        
        GameObject heldBall = GameObject.FindGameObjectWithTag("HeldBall");
        heldBall.GetComponent<SpriteRenderer>().enabled = false;
         
    }
}
