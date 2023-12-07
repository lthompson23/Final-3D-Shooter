using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class playerShoot : MonoBehaviour
{
    public float lifetime;

    public float lifetimeCounter;

    public float fireCooldown;

    public float fireRate;

    public GameObject bulletPrefab;

    public float speed;

    public GameObject bulletPoint;

    public AudioSource m_shootingSound;



    void Start()
    {
        fireCooldown = fireRate;
        m_shootingSound = GetComponent<AudioSource>();
    }

    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
           GameObject bullet = Instantiate(bulletPrefab, bulletPoint.transform.position, bulletPoint.transform.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * speed);
            m_shootingSound.Play();
        }
    }
     void Update()
    {
        fireCooldown += Time.deltaTime;

        if (fireCooldown >= fireRate && Input.GetMouseButtonDown (0)) 
        {
            //Call the Shoot function 
            Shoot();
            
            //Reset the cooldown
            fireCooldown = 0;


        }
    }
}
