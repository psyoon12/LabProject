using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f; 
    public int damage = 20;
    public Rigidbody2D rb; 
    public Animator animator;
    public AudioSource shootAudio;
    Vector2 movement;
    public GameObject popEffect;
    [SerializeField] AudioSource audio;
    
   
    void Start()
    {
        if (shootAudio == null)
        {
           shootAudio = GetComponent<AudioSource>();
        }
    }

    void Update()
    {
  
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
    
    void FixedUpdate() 
    {
        rb.MovePosition(rb.position + movement * moveSpeed* Time.fixedDeltaTime);
        
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Balloon balloon = hitInfo.GetComponent<Balloon>();
        if (hitInfo.gameObject.tag == "Balloon") 
        {
            balloon.TakeDamage(damage);
            //balloon.balloonHitAudio();
            balloon.balloonPopAudio();
           // AudioSource.PlayClipAtPoint(audio.clip, transform.position);
        }

        /*
        Balloon balloon = hitInfo.GetComponent<Balloon>();
        if(balloon != null)
        {
            balloon.TakeDamage(damage);
            balloon.balloonHitAudio();
            balloon.balloonPopAudio();
            Instantiate(popEffect,transform.position,transform.rotation);
        }
        Destroy(gameObject);
     }
     */
    }

}
