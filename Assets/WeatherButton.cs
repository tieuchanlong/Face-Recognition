using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class WeatherButton : MonoBehaviour
{
    public static int scene_state;
    
    // Start is called before the first frame update
    void Start()
    {
        scene_state = 3;
    }


    public void ActivateWeather()
    {
        scene_state = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
