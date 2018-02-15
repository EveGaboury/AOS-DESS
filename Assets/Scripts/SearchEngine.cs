using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SearchEngine
{
    public abstract void Search(string userSearch);

    //public static void SearchFacebook();
    //public static void SearchYoutube();
    //public static void SearchX();
    //public static void SearchYouGoals();
    //public static void SearchU();
    //public static void SearchBing();
}


public class SearchEngineFacebook : SearchEngine
{
    public override void Search(string userSearch)
    {
        throw new System.NotImplementedException();
    }
}


//SearchEngine s = new SearchEngineFacebook();
//s.search("coucou");