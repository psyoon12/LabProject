using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;

    public int damage = 50;

    [SerializeField] GameObject controller;
  
    //[SerializeField] AudioSource audio;


    // Start is called before the first frame update
    void Start()
    {

        rb.velocity = transform.up * speed;

        if (controller == null)
        {
            controller = GameObject.FindGameObjectWithTag("GameController");
        }
    }


    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Balloon balloon = hitInfo.GetComponent<Balloon>();
        if(balloon != null) 
        {
            balloon.TakeDamage(damage);
            //AudioSource.PlayClipAtPoint(audio.clip, transform.position);
            controller.GetComponent<ScoreManager>().UpdateScore(); 
            Destroy(gameObject);
           
        } else {
            //controller.GetComponent<ScoreManager>().UpdateScore(); 
        }

    }

}
