using System.Collections;
using System.Collections.Generic;
using TMPro; 
using UnityEngine;


public class Move_Box : MonoBehaviour
{
    public float box_move;
    public AudioSource Box_Volume;
    
    void Start()
    {
     
    }

   
    void Update()
    {
        float x_move = Input.GetAxis("Horizontal")*box_move;

        transform.Translate(x_move * Time.deltaTime,0f,0f);
        box_clamp();

    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bottle")
        {
            Box_Volume.Play();

        }
    }

    void box_clamp()
    {
        float clamp_x = Mathf.Clamp(transform.position.x, -5.61f, 5.61f);
        transform.position=new Vector2(clamp_x,transform.position.y);
    }
}
