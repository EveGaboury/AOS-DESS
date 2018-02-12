using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TonLivre : MonoBehaviour
{
    //Variables publiques
    public Image tonLivre;

    //Variables privées
    private bool isActive = false;


    void Start ()
    {        
        tonLivre.GetComponent<Image>().enabled = false;

        //isActive = false;
    }
	
	void Update ()
    {

	}

    //Sert à ouvrir la fenêtre
    public void OpenMainTonLivreWindow()
    {
        if(!isActive)
        {
            Debug.Log("The open function has been called");
            tonLivre.GetComponent<Image>().enabled = true;

            isActive = !isActive;
        }        
    }

    //Sert à fermer la fenêtre
    public void CloseMainTonLivreWindow()
    {
        if (isActive)
        {
            Debug.Log("The close function has been called");
            tonLivre.GetComponent<Image>().enabled = false;

            isActive = !isActive;
        }

    }
}
