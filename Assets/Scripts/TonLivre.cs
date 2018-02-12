using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TonLivre : MonoBehaviour
{
    //Variables publiques
    public GameObject tonLivre;
    public InputField searchBar;
    public Text displayText;

    //public InputFieldTest iFT;
    public GameObject deleteButton;

    //Variables privées (par défaut elles sont toutes considérées comme privées)
    bool isActive, textWasInputed;
    string inputedText;

    //Sert à initialiser la valeur de certaines variables
    void Start ()
    {
        searchBar.text = "";
        deleteButton.SetActive(false);

        //Fait que le gameObject TonLivre commence fermé == changer à true pour commencer ouvert
        tonLivre.SetActive(false);
        isActive = false;
    }
	
	void Update ()
    {
       // searchBar.GetComponent<InputField>().
    }

    //Sert à ouvrir la fenêtre
    public void OpenMainTonLivreWindow()
    {
        if(!isActive)
        {
            Debug.Log("The open function has been called");

            tonLivre.SetActive(true);
            isActive = !isActive;
        }        
    }

    //Sert à fermer la fenêtre
    public void CloseMainTonLivreWindow()
    {
        if (isActive)
        {
            Debug.Log("The close function has been called");

            tonLivre.SetActive(false);
            isActive = !isActive;
        }

    }

    //Sert à gérer les entrées de clavier dans l'inputField
    public void ManageInputField()
    {
        inputedText = searchBar.text;
        displayText.text = searchBar.text;
    }

    
    //Sert à gérer l'affichage du petit bouton qui efface le texte inputé
    public void DeleteCurrentInputedText()
    {
        deleteButton.SetActive(true);
        //searchBar.text = "";
    }
    public void UNDeleteCurrentInputedText()
    {
        searchBar.text = "";
        deleteButton.SetActive(false);        
    }
}
