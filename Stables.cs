using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stables : MonoBehaviour 
{
    [Header("Numbers")]
    public float horses;
    public float trainTime;
    public float timer;
    public float timer_;

    [Header("Bools")]
    public bool canWork;
    

    [Header("Refs")]
    public RectTransform trainSlider;
    public Text horseText;
    public Transform horse;
    

    void Start ()
    {
        InvokeRepeating("TrainHorse", trainTime, trainTime);
        InvokeRepeating("Timer", 0.01f, 0.01f);
    }

    

    void Update ()
    {
        horseText.text = "Horses   " + horses;    

        //timer = trainTime;

        if (horses >= 5)
        {
            canWork = false;
        }
        else
        {
            canWork = true;
        }
        
        if (timer >= timer_)
        {
          timer -= timer_;
        }
      
    }

    void TrainHorse ()
    {
        if (canWork == true)
        {
             horses += 1;
             Instantiate(horse, transform.position, transform.rotation);
        }      
    }
    
    void Timer ()
    {
        if (canWork == true)
        { 
            timer += 0.01f;
            trainSlider.sizeDelta = new Vector2(timer, trainSlider.sizeDelta.y);
        }       
    }

   

}
