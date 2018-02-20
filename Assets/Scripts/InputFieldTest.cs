using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class InputFieldTest
{
    private static InputFieldTest instance;

    private InputFieldTest() { }

    public int HP;

    public static InputFieldTest Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new InputFieldTest();
            }
            return instance;
        } 
    }

}


//Source: https://stackoverflow.com/questions/41391708/how-to-detect-click-touch-events-on-ui-and-gameobjects

/*
 public class InputFieldTest : MonoBehaviour
{
public int HP = 3;
public static InputFieldTest instance = null;


void Awake()
{
    if (instance == null)
    {
        instance = this;
    }
    else if (instance != this)
    {
        Destroy(gameObject);
    }
}
 */

/*
     //void Update()
//{
//    if (Input.GetKeyUp(KeyCode.G))
//    {
//        GameManager.gaugePsycho++;
//        Debug.Log(GameManager.gaugePsycho);
//    }
//}  
 */
