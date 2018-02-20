using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager
{

    //Singleton - début
    private static GameManager instance;

    private GameManager() { }

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
            }
            return instance;
        }
    }
    //Singleton - fin

    [HideInInspector] public enum GameState { Desktop, TonLivre, Gmail, BlocNotes, Studium, Browser, Bank, EditeurWord, Messenger };
    [HideInInspector] public GameState currentState;

	public float gaugePsycho = 10, gaugeFinances = 10, gaugeConsomation = 10, gaugeHarassement = 10, currPsy = 3, currFin, currCon, currHar;   

    void Awake()
    {
        //gaugePsycho = 10;
        //currPsy = 1;
    }

    void Start()
    {

    }

    public void UpdateAllGameStates ()
    {
        switch (currentState)
        {        
            case GameState.BlocNotes:
                Debug.Log("Je suis dans mon Bloc-Notes");
                break;
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


//Singleton source code: http://clearcutgames.net/home/?p=437 && https://www.studica.com/blog/how-to-create-a-singleton-in-unity-3d &&https://msdn.microsoft.com/en-us/library/ff650316.aspx
//En lien avec singleton: https://stackoverflow.com/questions/35890932/unity-game-manager-script-works-only-one-time/35891919#35891919


/*
 * public static GameManager Instance { get; private set; }
 * 
   //Singleton - début
    if (Instance != null && Instance != this)
    {
        Destroy(gameObject);
    }

    Instance = this;

       va etre important si jamais le gamemanager doit commncer avec des valeurs differentes dasn chaque scene
      DontDestroyOnLoad(this.gameObject);

//Singleton - fin
*/
