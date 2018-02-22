using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

public class TonLivre : MonoBehaviour
{
    //Variables publiques
	public GameObject tonLivre, messenger, deleteButton;
    //public GameManager gameManager;

    //Variables privées (par défaut elles sont toutes considérées comme privées)
    bool isActive = false;

    //Sert à initialiser la valeur de certaines variables
    void Start ()
    {
        //En relation avec l'inputfield
        deleteButton.SetActive(false);



        //Fait que le gameObject TonLivre commence fermé == changer à true pour commencer ouvert        
        //GameManager.Instance.currentState = GameManager.GameState.Desktop;
        //GameManager.currentState = GameManager.GameState.Desktop;
        GameManager.Instance.currentState = GameManager.GameState.Desktop;
        tonLivre.SetActive(false);
        messenger.SetActive(false);
    }
	
	void Update ()
    {
        Debug.Log(GameManager.Instance.currentState);
    }








    //Sert à ouvrir la fenêtre
    public void OpenTonLivreWindow()
    {
        //GameManager.currentState = GameManager.GameState.TonLivre;

        if (!isActive)
        {
            Debug.Log("The open function of TonLivre has been called");

            tonLivre.SetActive(true);
            isActive = !isActive;
        }        
    }

    //Sert à fermer la fenêtre
    public void CloseTonLivreWindow()
    {
        //GameManager.currentState = GameManager.GameState.Desktop;

        if (isActive)
        {
            Debug.Log("The close function of TonLivre has been called");

            tonLivre.SetActive(false);
            isActive = !isActive;
        }
    }

    public void OpenMessengerWindow()
    {
        //GameManager.currentState = GameManager.GameState.Messenger;

        if (!isActive)
        {
            Debug.Log("The open function of Messenger has been called");

            messenger.SetActive(true);
            isActive = !isActive;
        }
    }

    //Sert à fermer la fenêtre
    public void CloseMessengerWindow()
    {
        //GameManager.currentState = GameManager.GameState.Desktop;

        if (isActive)
        {
            Debug.Log("The close function of Messenger has been called");

            messenger.SetActive(false);
            isActive = !isActive;
        }
    }
}
