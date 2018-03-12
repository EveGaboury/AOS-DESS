using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
//using System;
using UnityEngine.UI;

public class ErroneousSearchesDirector : MonoBehaviour 
{
	public GameState GS;
	public RepositoryOfFakeNames RFN;

	public Button fredButton;
	public Button adrienButton;

	public Image[] portraitsToBeDisplayed;

	public TMP_InputField searchBar;

	TextMeshProUGUI displayText;

	RepositoryOfFakeNames retrieveData;

	Transform wrongSearchResults;

	public bool adrien=false, frederic=false, adrien2=false, frederic2=false;

	char[] verification = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
						   'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

	void Awake()
	{
		wrongSearchResults = GetComponent<Transform>();
//		searchBar = GetComponent<TMP_InputField> ();
		retrieveData = GetComponent<RepositoryOfFakeNames> ();
//		this.gameObject.GetComponentInParent<Transform>().transform.parent.gameObject.GetComponentInParent<Transform>().parent.gameObject.GetComponentInChildren<TMP_InputField>().text;
//		Debug.Log (this.gameObject.GetComponentInParent<Transform>().transform.parent.gameObject.GetComponentInParent<Transform>().parent.gameObject.GetComponentInChildren<TMP_InputField>().text);
	}
		
	public void SortInputedData (string userSearch) 
	{
		userSearch = searchBar.GetComponent<TMP_InputField> ().text;
//		Debug.Log ("The value of 'userSearch' from SortInputedData(): " + userSearch[0]);
		char firstLetter = userSearch[0];

		if (firstLetter <= verification[25] && firstLetter >= verification[0]) 
		{
			Debug.Log ("minuscules: " + firstLetter);
			BringWrongSearchResultsPanel(firstLetter);
//			RetrieveAllImages ();

		}
		else if( firstLetter<= verification[51] && firstLetter >= verification[26])
		{
			Debug.Log ("MAJUSCULES: " + firstLetter);
			BringWrongSearchResultsPanel (firstLetter);
//			RetrieveAllImages ();
		}
		else
		{
			//BringWrongSearchResultsPanel (userSearch);
			//RetrieveAllImages ();
			//Debug.Log ("The greatest FAILURE of: " + userSearch);
		}
	}

	void BringWrongSearchResultsPanel(/*string test*/char test)
	{
		Debug.Log ("The value of 'test' from BringWrongSearchResultsPanel(): " + test);

		this.gameObject.transform.parent.gameObject.SetActive(true);

		if (this.gameObject.transform.parent.gameObject.activeSelf == true)
		{
			this.gameObject.SetActive(true);
		}


		Component[] textDisplay;

		textDisplay = this.gameObject.GetComponentsInChildren (typeof(TextMeshProUGUI));

		foreach (TextMeshProUGUI txt in textDisplay)
		{
			for (int i = 0; i < textDisplay.Length; i++)
			{
				//AAAAAAA
				if ((test == verification [0]) || (test == verification [26]))
				{
					adrien = true;
					Debug.Log (adrien);
					adrienButton.GetComponent<Button> ().enabled = true;

					textDisplay [i].GetComponentInChildren<TextMeshProUGUI> ().text = retrieveData.A_Prenoms [i].ToString ();
				}
				//BBBBBB
				if((test == verification[1]) || (test == verification[27]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.B_Prenoms[i].ToString();
				}
				//CCCCCC
				if((test == verification[2]) || (test == verification[28]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.C_Prenoms[i].ToString();
				}
				//DDDDDD
				if((test == verification[3]) || (test == verification[29]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.D_Prenoms[i].ToString();
				}
				//EEEEEEEE
				if((test == verification[4]) || (test == verification[30]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.E_Prenoms[i].ToString();
				}
				//FFFFF
				if((test == verification[5]) || (test == verification[31]))
				{
					frederic = true;
					fredButton.GetComponent<Button> ().enabled = true;
		
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.F_Prenoms[i].ToString();

				}
				//GGGGGGG
				if((test == verification[6]) || (test == verification[32]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.G_Prenoms[i].ToString();
				}
				//HHHHHHHH
				if((test == verification[7]) || (test == verification[33]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.H_Prenoms[i].ToString();
				}
				//IIIIIII
				if((test == verification[8]) || (test == verification[34]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.I_Prenoms[i].ToString();
				}
				//JJJJJJJ
				if((test == verification[9]) || (test == verification[35]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.J_Prenoms[i].ToString();
				}
				//KKKKKKKK
				if((test == verification[10]) || (test == verification[36]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.K_Prenoms[i].ToString();
				}
				//LLLLLLLL
				if((test == verification[11]) || (test == verification[37]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.L_Prenoms[i].ToString();
				}
				//MMMMMMMM
				if((test == verification[12]) || (test == verification[38]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.M_Prenoms[i];
				}
				//NNNNNNN
				if((test == verification[13]) || (test == verification[39]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.N_Prenoms[i].ToString();
				}
				//OOOOOOOO
				if((test == verification[14]) || (test == verification[40]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.O_Prenoms[i].ToString();
				}
				//PPPPPPPP
				if((test == verification[15]) || (test == verification[41]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.P_Prenoms[i].ToString();
				}
				//QQQQQQ
				if((test == verification[16]) || (test == verification[42]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.Q_Prenoms[i].ToString();
				}
				//RRRRRRRR
				if((test == verification[17]) || (test == verification[43]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.R_Prenoms[i].ToString();
				}
				//SSSSSSS
				if((test == verification[18]) || (test == verification[44]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.S_Prenoms[i].ToString();
				}
				//TTTTTTT
				if((test == verification[19]) || (test == verification[45]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.T_Prenoms[i].ToString();
				}
				//UUUUUUU
				if((test == verification[20]) || (test == verification[46]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.U_Prenoms[i].ToString();
				}
				//VVVVVVV
				if((test == verification[21]) || (test == verification[47]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.V_Prenoms[i].ToString();
				}
				//WWWWWWW
				if((test == verification[22]) || (test == verification[48]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.W_Prenoms[i].ToString();
				}
				//XXXXXXX
				if((test == verification[23]) || (test == verification[49]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.X_Prenoms[i].ToString();
				}
				//YYYYYYYYY
				if((test == verification[24]) || (test == verification[50]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.Y_Prenoms[i].ToString();
				}
				//ZZZZZZZZ
				if((test == verification[25]) || (test == verification[51]))
				{
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.Z_Prenoms[i].ToString();
				}
			}
		}
//IMPORTANT PERMET PEUT ETRE D AGILISER TOUT LE BASTRINGUE >>>>>>>>>>>>>>>>>>>>>>>>>
//				for (int j = 0; j < (25+1); j++)
//				{
//					for (int k = 51; k > (25); k--) 
//					{
//						if ((userSearch == verification[j].ToString()) || (userSearch == verification[k].ToString())) 
//						{
//							textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData[A][i];
//							print ("AAAROLOLO");
//						}
//					}
//IMPORTANT PERMET PEUT ETRE D AGILISER TOUT LE BASTRINGUE >>>>>>>>>>>>>>>>>>>>>>>>>
		RetrieveAllImages();
	}

	void RetrieveAllImages()
	{
		Component[] imagePosition;

		imagePosition = this.gameObject.GetComponentsInChildren (typeof(Image));

		foreach (Image img in imagePosition)
		{
			for (int i = 0; i < imagePosition.Length; i++) 
			{	

				if (adrien == false) 
				{
				
					if (frederic == false)
						imagePosition [i].GetComponent<Image> ().sprite = retrieveData.photoProfil [i];
					if (frederic == true) {
						imagePosition[0].GetComponent<Image>().sprite = retrieveData.photoProfil[6];
						imagePosition[1].GetComponent<Image>().sprite = retrieveData.photoProfil[0];
						imagePosition[2].GetComponent<Image>().sprite = retrieveData.photoProfil[1];
						imagePosition[3].GetComponent<Image>().sprite = retrieveData.photoProfil[2];
						imagePosition[4].GetComponent<Image>().sprite = retrieveData.photoProfil[3];
						frederic2 = true;
					}
				}
					
				if (adrien == true) {
					imagePosition [0].GetComponent<Image> ().sprite = retrieveData.photoProfil [5];
					imagePosition [1].GetComponent<Image> ().sprite = retrieveData.photoProfil [0];
					imagePosition [2].GetComponent<Image> ().sprite = retrieveData.photoProfil [1];
					imagePosition [3].GetComponent<Image> ().sprite = retrieveData.photoProfil [2];
					imagePosition [4].GetComponent<Image> ().sprite = retrieveData.photoProfil [3];
					adrien2 = true;
				}
		
				//imagePosition[i].GetComponent<Image>().sprite = retrieveData.photoProfil[i];				
//				if (imagePosition [i].GetComponent<Image> ().sprite == null) 
//				{
//					imagePosition [i].GetComponent<Image> ().sprite = retrieveData.photoProfil [Random.Range (0, retrieveData.photoProfil.Length)];
//				}
//				else if (imagePosition [i].GetComponent<Image> ().sprite != null)
//				{
//					if (imagePosition [i].GetComponent<Image> ().sprite.name == retrieveData.profilePhotos[i].name)
//					{
//						retrieveData.profilePhotos.RemoveAt (i);
//					}
//				}
			}
		}

		adrien = false;
		frederic = false;

	}

	void OnDisable()
	{
//		Debug.Log ("This was a triumph! \n I'm making a note here: \n Huge success!");
		this.gameObject.SetActive (false);
		searchBar.GetComponent<TMP_InputField> ().text = "";
	}

	public void ButtonOfChoice ()
	{
		if (adrien2==true) {
			GS.BoutonAdrien ();
		}

		if (frederic2==true) {
			GS.BoutonFred ();
		}

		adrien2 = false;
		frederic2 = false;
	}


//	void Update ()
//	{
//		Debug.Log (adrien + "adrien");
//		Debug.Log (frederic + "frederic");
//	}

}
