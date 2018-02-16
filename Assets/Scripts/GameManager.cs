using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }    

    [HideInInspector] public enum GameState { Desktop, TonLivre, Gmail, BlocNotes, Studium, Browser, Bank, EditeurWord, Messenger };
    [HideInInspector] public static GameState currentState;

    public void Awake()
    {
        //Singleton - début
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }

        Instance = this;

        /* va etre important si jamais le gamemanager doit commncer avec des valeurs differentes dasn chaque scene
         * DontDestroyOnLoad(this.gameObject);*/

        //Singleton - fin
    }

    public void Start()
    {
        //currentState = GameState.Desktop;
    }

    public void UpdateAllGameStates ()
    {
        switch (currentState)
        {        
            /*case CurrentGameState.BlocNotes:
                Debug.Log("Je suis dans mon Bloc-Notes");
                break;*/

            case GameState.Desktop:
                Debug.Log("Je suis dans le Bureau");
                break;
            case GameState.TonLivre:
                Debug.Log("Je suis dans TonLivre");
                break;
            case GameState.Gmail:
                Debug.Log("Je suis dans mon Gmail");
                break;
            case GameState.Studium:
                Debug.Log("Je suis dans mon Sutidum");
                break;
            case GameState.Browser:
                Debug.Log("Je suis dans mon Browser");
                break;
            case GameState.Bank:
                Debug.Log("Je suis dans ma Banque");
                break;
            case GameState.EditeurWord:
                Debug.Log("Je suis dans mon Editeur de texte");
                break;
            case GameState.Messenger:
                Debug.Log("Je suis dans mon Messenger");
                break;
        }
    }
}


//Singleton source code: http://clearcutgames.net/home/?p=437 && https://www.studica.com/blog/how-to-create-a-singleton-in-unity-3d
//En lien avec singleton: https://stackoverflow.com/questions/35890932/unity-game-manager-script-works-only-one-time/35891919#35891919
