using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Balloon : MonoBehaviour
{
    public float maxSize = 0.1f;
    public float growthRate = 0.1f;
    public float scale = 0.1f;

    public int health;
    public int balloonNum;
    public GameObject popEffect;
    public GameObject Player;
    public GameObject BalloonPopping;

    [SerializeField] GameObject controller;
    [SerializeField] AudioSource audio;
  
   // public Animator BalloonAnimator;

    //public AudioSource BalloonHitAudio;
    public AudioSource BalloonPopAudio;
    
    /*
    void Start(){
        BalloonAnimator = BalloonPopping.GetComponent<Animator>();
    }
    
    */
    void Start()
    {
       
        if (controller == null)
        {
            controller = GameObject.FindGameObjectWithTag("GameController");
        }
    }

    void Update()
    {
        transform.localScale = Vector3.one * scale;
        scale += growthRate * Time.deltaTime;
        if (scale > maxSize)
        {
            //Instantiate(popEffect, transform.position, Quaternion.identity);
            balloonPopAudio();
            Destroy(gameObject);
            //restart when balloon pop
            controller.GetComponent<Score>().nextScene(); 
            SceneManager.LoadScene("highScores");
            
         //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health >= 0) 
        {
            //balloonHitAudio();
            //Pop();
        } else {
            balloonPopAudio();
            Pop();
            //AudioSource.PlayClipAtPoint(audio.clip, transform.position);
            //Player.GetComponent<ScoreManager>().UpdateScore();

            //controller.GetComponent<ScoreManager>().UpdateScore(); 
            Player.GetComponent<Score>().IncrementScore();
            
        }
    }

    /*
    public void balloonHitAudio(){
        
        if ( BalloonHitAudio == null)
        {
            BalloonHitAudio = GetComponent<AudioSource>();
            AudioSource.PlayClipAtPoint( BalloonHitAudio.clip, transform.position);
        }
    }
    */

     public void balloonPopAudio()
     {
        if (BalloonPopAudio == null)
        {
            BalloonPopAudio = GetComponent<AudioSource>();
            //AudioSource.PlayClipAtPoint(BalloonPopAudio.clip, transform.position);
        }
    }

    public void Pop()
    {
        Instantiate(popEffect, transform.position, Quaternion.identity);
       
        //BalloonAnimator.SetTrigger("pop");
        
        Destroy(gameObject);
    }



}
