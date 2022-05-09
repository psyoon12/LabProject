using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    [SerializeField] GameObject bowPreFab;
    [SerializeField] SoundManager soundManager;
    //[SerializeField] Vector3 bowForce;
    //public AudioSource shootAudio;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot() 
    {
       soundManager.PlaySound();
       GameObject bow = Instantiate(bowPreFab, firePoint.position, firePoint.rotation);
       //bow.GetComponent<Rigidbody2D>().AddRelativeForce(bowForce);
       /*
       if (shootAudio  == null)
       {
        shootAudio = GetComponent<AudioSource>();
       }
       */
       Destroy(bow, 0.5f);
    }
}
