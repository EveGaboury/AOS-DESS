﻿using TMPro;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class Test : MonoBehaviour
{
	void Start()
	{
		var searchAllObjectsInTheScene = FindObjectsOfType<CursorScript>();

		Debug.Log ("From Test.cs && searchAllObjectsInTheScene: " + searchAllObjectsInTheScene.Length);

		for (int i = 0; i < searchAllObjectsInTheScene.Length; i++)
		{
			Debug.Log ("The " + searchAllObjectsInTheScene[i].name + " gameObject is n°" + i % searchAllObjectsInTheScene.Length + "out of " + searchAllObjectsInTheScene.Length);
		}
	}

	//BOUT DE CODE POUR ANIMER LES LETTRES DANS LES BULLES DE TEXTE DU MESSENGER

	//	public float writtingSpeed;
	//
	//	void Update()
	//	{
	//		if (Input.GetKeyDown(KeyCode.X))
	//		{
	//			string sentence = "This was a triumph!\nI'm making a note here:\nHuge success!\n\nIt's hard to overstate\nmy satisfaction.\n\nAperture Science:\nWe do what we must\nbecause we can\nFor the good of all of us.\nExcept the ones who are dead.\n\nBut there's no sense crying\nover every mistake.\nYou just keep on trying\n'til you run out of cake.\nAnd the science gets done.\nAnd you make a neat gun\nfor the people who are\nstill alive.\n\nI'm not even angry...\nI'm being so sincere right now.\nEven though you broke my heart,\nand killed me.\n\nAnd tore me to pieces.\nAnd threw every piece into a fire.\nAs they burned it hurt because\nI was so happy for you!\n\nNow, these points of data\nmake a beautiful line.\nAnd we're out of beta.\nWe're releasing on time!\nSo I'm GLaD I got burned!\nThink of all the things we learned!\nfor the people who are\nstill alive.\n\nGo ahead and leave me...\nI think I'd prefer to stay inside...\nMaybe you'll find someone else\nto help you.\nMaybe Black Mesa?\nThat was a joke. Ha Ha. Fat Chance!\n\nAnyway this cake is great!\nIt's so delicious and moist!\n\nLook at me: still talking\nwhen there's science to do!\nWhen I look out there,\nit makes me glad I'm not you.\n\nI've experiments to run.\nThere is research to be done.\nOn the people who are\nstill alive.\nAnd believe me I am\nstill alive.\nI'm doing science and I'm\nstill alive.\nI feel fantastic and I'm\nstill alive.\nWhile you're dying I'll be\nstill alive.\nAnd when you're dead I will be\nstill alive\n\nStill alive.\n\nStill alive.";
	//			StartCoroutine (TypeSentence(sentence));
	//		}
	//	}
	//
	//	IEnumerator TypeSentence(string sentence)
	//	{
	//		//this.gameObject.GetComponent<TextMeshProUGUI> ().text = "";
	//
	//		foreach (char letter in sentence.ToCharArray())
	//		{
	//			dialogueInstance.GetComponentInChildren<TextMeshProUGUI> ().text+= letter;
	//			yield return new WaitForSeconds (writtingSpeed);
	//		}
	//	}

}