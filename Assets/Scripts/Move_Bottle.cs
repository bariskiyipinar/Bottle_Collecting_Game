using System.Collections;
using System.Collections.Generic;
using TMPro; //TextMeshPro kullanabilmek için bir kütüphanedir.
using UnityEngine;

public class Move_Bottle : MonoBehaviour
{
    
    public AudioSource Bottle_Volume;
    public  Transform Bottle;
    public TextMeshProUGUI ScoreText;
    public int score;
    public int Health = 3;
    public TextMeshProUGUI Health_Point;
    public GameObject GameOverPanel;
    public AudioSource BackGroundVolume;


    void Update()
    {
        ScoreText.text = "Score:" + score;
        Health_Point.text = "Health:" + Health;
    }

    void OnCollisionEnter2D(Collision2D temas)
    {
        float xposition = Random.Range(-5.61f, 5.61f);
        float yposition = Random.Range(5.94f, 9.14f);

        if (temas.gameObject.tag == "Control")
        {
            Health--;
             Bottle.position=new Vector3(xposition, yposition);
            Bottle_Volume.Play();

            if(Health == 0)
            {
                Time.timeScale = 0;
                Debug.Log(":::: Game Over ::::");
                GameOverPanel.SetActive(true);
                BackGroundVolume.Pause();
            }
        }

        else if (temas.gameObject.tag == "Box")
        {
            Bottle.position = new Vector3(xposition, yposition);
            score++;
            
        }
       
    }
    
}
