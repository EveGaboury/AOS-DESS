using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TonLivre : MonoBehaviour
{
    //Variables publiques
    public GameObject tonLivre, messenger, deleteButton;
    [HideInInspector]public InputField searchBar;

    //Variables privées (par défaut elles sont toutes considérées comme privées)
    bool isActive = false;
    string inputedText;

    //Sert à initialiser la valeur de certaines variables
    void Start ()
    {
        //En relation avec l'inputfield
        deleteButton.SetActive(false);

        //Fait que le gameObject TonLivre commence fermé == changer à true pour commencer ouvert
        //GameManager.Instance.currentState = GameManager.GameState.Desktop;
        GameManager.currentState = GameManager.GameState.Desktop;
        tonLivre.SetActive(false);
        messenger.SetActive(false);
    }
	
	void Update ()
    {
        
    }

    //Sert à gérer les entrées de clavier dans l'inputField
    public void UpdateInputField()
    {
        Debug.Log("Data has been inputed");
        inputedText = searchBar.text;

        if (searchBar.text.Length == 0)
        {
            deleteButton.SetActive(false);
        }
        else
        {
            deleteButton.SetActive(true);
        }
    }

    public void ClearContent()
    {
        searchBar.text = "";
    }






    //Sert à ouvrir la fenêtre
    public void OpenTonLivreWindow()
    {
        //GameManager.Instance.currentState = GameManager.GameState.TonLivre;
        GameManager.currentState = GameManager.GameState.TonLivre;
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
        //GameManager.Instance.currentState = GameManager.GameState.Desktop;
        GameManager.currentState = GameManager.GameState.Desktop;

        if (isActive)
        {
            Debug.Log("The close function of TonLivre has been called");

            tonLivre.SetActive(false);
            isActive = !isActive;
        }
    }

    public void OpenMessengerWindow()
    {
        //GameManager.Instance.currentState = GameManager.GameState.Desktop;
        GameManager.currentState = GameManager.GameState.Messenger;

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
        //GameManager.Instance.currentState = GameManager.GameState.Desktop;
        GameManager.currentState = GameManager.GameState.Desktop;

        if (isActive)
        {
            Debug.Log("The close function of Messenger has been called");

            messenger.SetActive(false);
            isActive = !isActive;
        }
    }
}
