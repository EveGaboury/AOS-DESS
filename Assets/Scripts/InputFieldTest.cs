using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldTest : MonoBehaviour
{
    GameManager _GM;

    public InputField inputField;

    [HideInInspector]public bool valueHasBeenInputed = true;

    void Start()
    {
        //TEST

        //GameManager.Instance.currentState = GameManager.CurrentGameState.Bank;
        
        //TEST
    }

    void OnEnable()
    {
        //Register InputField Events
        inputField.onEndEdit.AddListener(delegate { inputEndEdit(); });
        inputField.onValueChanged.AddListener(delegate { inputValueChanged(); });
    }

    //Called when Input is submitted
    private void inputEndEdit()
    {
        valueHasBeenInputed = true;
        Debug.Log("Input Submitted");
    }

    //Called when Input changes
    private void inputValueChanged()
    {
        valueHasBeenInputed = false;
        Debug.Log("Input Changed");
    }

    void OnDisable()
    {
        //Un-Register InputField Events
        inputField.onEndEdit.RemoveAllListeners();
        inputField.onValueChanged.RemoveAllListeners();
    }
}


//Source: https://stackoverflow.com/questions/41391708/how-to-detect-click-touch-events-on-ui-and-gameobjects