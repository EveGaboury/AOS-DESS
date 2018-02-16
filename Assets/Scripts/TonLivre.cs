using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TonLivre : MonoBehaviour
{
    //Variables publiques
    public GameObject tonLivre, deleteButton;
    [HideInInspector]public InputField searchBar;
    //public Text displayText;
    public Dropdown dropTheBass;

    //Variables privées (par défaut elles sont toutes considérées comme privées)
    bool isActive, textWasInputed;
    string inputedText;

    //Sert à initialiser la valeur de certaines variables
    void Start ()
    {
        //En relation avec l'inputfield
        deleteButton.SetActive(false);

        //Fait que le gameObject TonLivre commence fermé == changer à true pour commencer ouvert
        tonLivre.SetActive(false);
        isActive = false;


    }
	
	void Update ()
    {
        //UpdateInputField();

        //Test
        if (Input.GetKey(KeyCode.H))
        {
            //faire que sa commence ouvert
            //dropTheBass.options.

        }
        //Fin Test
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
    public void UpdateInputField()
    {
        Debug.Log("Data has been inputed");
        inputedText = searchBar.text;
        //displayText.text = searchBar.text;
        

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
}
