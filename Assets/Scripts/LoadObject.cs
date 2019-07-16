﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class LoadObject : MonoBehaviour
{

    public GameObject Game_Temp;
    public int State;

    public int counter = 1;
    public GameObject Sun;
    public GameObject Moon;
    public GameObject Storm;
    public GameObject Rain;
    public GameObject Cloud;
    public GameObject ARCamera;

    GameObject MoonObject;
    GameObject SunObject;
    GameObject StormObject;
    GameObject RainObject;
    GameObject CloudObject;


    /*public void Button_Click()
    {
        Debug.Log("Click");
        switch (counter)
        {
            case 5:
                print("Cloud");
                Destroy(MoonObject);
                Destroy(RainObject);
                Destroy(StormObject);
                Destroy(SunObject);
                CloudObject = (GameObject)Instantiate(Cloud);
                CloudObject.transform.parent = ARCamera.transform;
                CloudObject.transform.position = Vector3.zero;
                CloudObject.transform.localScale = new Vector3(.1f, .1f, .1f);
                break;
            case 4:
                print("Rain");
                Destroy(MoonObject);
                Destroy(StormObject);
                Destroy(SunObject);
                RainObject = (GameObject)Instantiate(Rain);
                RainObject.transform.parent = ARCamera.transform;
                RainObject.transform.position = Vector3.zero;
                RainObject.transform.localScale = new Vector3(.1f, .1f, .1f);
                break;
            case 3:
                print("Sun");
                Destroy(RainObject);
                Destroy(MoonObject);
                Destroy(StormObject);
                SunObject = (GameObject)Instantiate(Sun);
                SunObject.transform.parent = ARCamera.transform;
                SunObject.transform.position = Vector3.zero;
                SunObject.transform.localScale = new Vector3(.1f, .1f, .1f);
                break;
            case 2:
                print("Moon");
                Destroy(RainObject);
                Destroy(SunObject);
                Destroy(StormObject);
                MoonObject = (GameObject)Instantiate(Moon);
                MoonObject.transform.parent = ARCamera.transform;
                MoonObject.transform.position = Vector3.zero;
                MoonObject.transform.localScale = new Vector3(.1f, .1f, .1f);
                break;
            case 1:
                print("Storm");
                Destroy(CloudObject);
                Destroy(RainObject);
                Destroy(SunObject);
                Destroy(MoonObject);
                StormObject = (GameObject)Instantiate(Storm);
                StormObject.transform.parent = ARCamera.transform;
                StormObject.transform.position = Vector3.zero;
                StormObject.transform.localScale = new Vector3(.1f, .1f, .1f);
                break;
            default:
                print("Nothing Doing.");
                break;
        }
        if (counter >= 5)
        {
            counter = 1;
        }
        else
        {
            counter++;
        }
        Debug.Log(counter);


    }*/
    // Use this for initialization
    void Start()
    {
        //Game_Temp = GameObject.FindWithTag("TAG_WEATHER");
    }

    void Update()
    {
        State = Game_Temp.GetComponent<Weather_Text>().StateWeather;
        Debug.Log("Hey " + State);

        if (WeatherButton.scene_state == 1)
        {
            switch (counter)
            {
                case 5:
                    print("Cloud");
                    Destroy(MoonObject);
                    Destroy(RainObject);
                    Destroy(StormObject);
                    Destroy(SunObject);
                    if (counter != State) CloudObject = (GameObject)Instantiate(Cloud);
                    CloudObject.transform.parent = ARCamera.transform;
                    CloudObject.transform.position = Vector3.zero;
                    CloudObject.transform.localScale = new Vector3(1f, 1f, 1f);
                    counter = State;
                    break;
                case 4:
                    print("Rain");
                    Destroy(MoonObject);
                    Destroy(StormObject);
                    Destroy(SunObject);
                    if (counter != State) RainObject = (GameObject)Instantiate(Rain);
                    RainObject.transform.parent = ARCamera.transform;
                    RainObject.transform.position = Vector3.zero;
                    RainObject.transform.localScale = new Vector3(1f, 1f, 1f);
                    counter = State;
                    break;
                case 3:
                    print("Sun");
                    Destroy(RainObject);
                    Destroy(MoonObject);
                    Destroy(StormObject);
                    if (counter != State) SunObject = (GameObject)Instantiate(Sun);
                    SunObject.transform.parent = ARCamera.transform;
                    SunObject.transform.position = Vector3.zero;
                    SunObject.transform.localScale = new Vector3(1f, 1f, 1f);
                    counter = State;
                    break;
                case 2:
                    print("Moon");
                    Destroy(RainObject);
                    Destroy(SunObject);
                    Destroy(StormObject);
                    if (counter != State) MoonObject = (GameObject)Instantiate(Moon);
                    MoonObject.transform.parent = ARCamera.transform;
                    MoonObject.transform.position = Vector3.zero;
                    MoonObject.transform.localScale = new Vector3(1f, 1f, 1f);
                    counter = State;
                    break;
                case 1:
                    print("Storm");
                    Destroy(CloudObject);
                    Destroy(RainObject);
                    Destroy(SunObject);
                    Destroy(MoonObject);
                    if (counter != State) StormObject = (GameObject)Instantiate(Storm);
                    StormObject.transform.parent = ARCamera.transform;
                    StormObject.transform.position = Vector3.zero;
                    StormObject.transform.localScale = new Vector3(1f, 1f, 1f);
                    counter = State;
                    break;
                default:
                    print("Nothing Doing.");
                    break;
            }
        }

    }







}