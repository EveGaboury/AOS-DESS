using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class InputFieldTest : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    //Public
    public Text selectable;
    public bool isOver = false;

    //Privée
    Color startingColor = Color.black, highlighted = Color.red;

    void Start()
    {
        selectable.GetComponent<Outline>().enabled = false;
        selectable.GetComponent<Shadow>().enabled = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse enter");
        isOver = true;

        selectable.GetComponent<Outline>().enabled = isOver;
        selectable.color = highlighted;
        selectable.GetComponent<Shadow>().enabled = isOver;

        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse exit");
        isOver = false;

        selectable.GetComponent<Outline>().enabled = isOver;
        selectable.color = startingColor;
        selectable.GetComponent<Shadow>().enabled = isOver;

        
    }
}


//Source pour le pointer dans le UI: https://stackoverflow.com/questions/41391708/how-to-detect-click-touch-events-on-ui-and-gameobjects && https://gamedev.stackexchange.com/questions/108625/how-to-detect-mouse-over-for-ui-image-in-unity-5

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

/*
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
 */
