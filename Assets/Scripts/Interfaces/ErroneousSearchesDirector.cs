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
	public Button cassButton;
	public Button SoButton;
	public Button MarieEButton;
	public Button HugoButton;
	public Button YannButton;

	public Button Img_Portrait01;

	public Image[] portraitsToBeDisplayed;

	public TMP_InputField searchBar;

	TextMeshProUGUI displayText;

	RepositoryOfFakeNames retrieveData;

	Transform wrongSearchResults;

	public bool adrien=false, frederic=false, cassandra=false, sophie=false, marieE=false, Hugo=false, Yann=false;

	public bool adrien2=false, frederic2=false, cassandra2=false, sophie2=false, marieE2=false, Hugo2=false, Yann2=false;


	Component[] imagePosition;

	char[] verification = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
						   'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

	void Awake()
	{
		wrongSearchResults = GetComponent<Transform>();
		retrieveData = GetComponent<RepositoryOfFakeNames> ();
	}
		
	public void SortInputedData (string userSearch) 
	{
		userSearch = searchBar.GetComponent<TMP_InputField> ().text;
		char firstLetter = userSearch[0];

		if (firstLetter <= verification[25] && firstLetter >= verification[0]) 
		{
			Debug.Log ("minuscules: " + firstLetter);
			BringWrongSearchResultsPanel(firstLetter);

		}
		else if( firstLetter<= verification[51] && firstLetter >= verification[26])
		{
			Debug.Log ("MAJUSCULES: " + firstLetter);
			BringWrongSearchResultsPanel (firstLetter);
		}
	}

	void BringWrongSearchResultsPanel(char test)
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
					Img_Portrait01.enabled = false;
					adrien = true;
					adrienButton.GetComponent<Button> ().enabled = true;

					textDisplay [0].GetComponentInChildren<TextMeshProUGUI> ().text = retrieveData.A_Prenoms [0].ToString ();
					textDisplay [1].GetComponentInChildren<TextMeshProUGUI> ().text = retrieveData.A_Prenoms [1].ToString () + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
					textDisplay [2].GetComponentInChildren<TextMeshProUGUI> ().text = retrieveData.A_Prenoms [2].ToString () + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
					textDisplay [3].GetComponentInChildren<TextMeshProUGUI> ().text = retrieveData.A_Prenoms [3].ToString () + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
					textDisplay [4].GetComponentInChildren<TextMeshProUGUI> ().text = retrieveData.A_Prenoms [4].ToString () + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
				}
				//BBBBBB
				if((test == verification[1]) || (test == verification[27]))
				{
					Img_Portrait01.enabled = false;
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.B_Prenoms[i].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();

				}
				//CCCCCC
				if((test == verification[2]) || (test == verification[28]))
				{
					Img_Portrait01.enabled = false;
					cassandra = true;
					cassButton.GetComponent<Button>().enabled = true;

					textDisplay [0].GetComponentInChildren<TextMeshProUGUI> ().text = retrieveData.C_Prenoms [0].ToString ();
					textDisplay [1].GetComponentInChildren<TextMeshProUGUI> ().text = retrieveData.C_Prenoms [1].ToString () + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
					textDisplay [2].GetComponentInChildren<TextMeshProUGUI> ().text = retrieveData.C_Prenoms [2].ToString () + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
					textDisplay [3].GetComponentInChildren<TextMeshProUGUI> ().text = retrieveData.C_Prenoms [3].ToString () + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
					textDisplay [4].GetComponentInChildren<TextMeshProUGUI> ().text = retrieveData.C_Prenoms [4].ToString () + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
				}
				//DDDDDD
				if((test == verification[3]) || (test == verification[29]))
				{
					Img_Portrait01.enabled = false;
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.D_Prenoms[i].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
				}
				//EEEEEEEE
				if((test == verification[4]) || (test == verification[30]))
				{
					Img_Portrait01.enabled = false;

					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.E_Prenoms[i].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
				}
				//FFFFF
				if((test == verification[5]) || (test == verification[31]))
				{
					Img_Portrait01.enabled = false;
					frederic = true;
					fredButton.GetComponent<Button> ().enabled = true;
		
					textDisplay [0].GetComponent<TextMeshProUGUI> ().text = retrieveData.F_Prenoms[0].ToString();
					textDisplay [1].GetComponent<TextMeshProUGUI> ().text = retrieveData.F_Prenoms[1].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
					textDisplay [2].GetComponent<TextMeshProUGUI> ().text = retrieveData.F_Prenoms[2].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
					textDisplay [3].GetComponent<TextMeshProUGUI> ().text = retrieveData.F_Prenoms[3].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
					textDisplay [4].GetComponent<TextMeshProUGUI> ().text = retrieveData.F_Prenoms[4].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
				}
				//GGGGGGG
				if((test == verification[6]) || (test == verification[32]))
				{
					Img_Portrait01.enabled = false;
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.G_Prenoms[i].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
				}
				//HHHHHHHH
				if((test == verification[7]) || (test == verification[33]))
				{
					Img_Portrait01.enabled = false;
					Hugo = true;
					HugoButton.GetComponent<Button> ().enabled = true;
		
					textDisplay [0].GetComponent<TextMeshProUGUI> ().text = retrieveData.H_Prenoms[0].ToString();
					textDisplay [1].GetComponent<TextMeshProUGUI> ().text = retrieveData.H_Prenoms[1].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
					textDisplay [2].GetComponent<TextMeshProUGUI> ().text = retrieveData.H_Prenoms[2].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
					textDisplay [3].GetComponent<TextMeshProUGUI> ().text = retrieveData.H_Prenoms[3].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
					textDisplay [4].GetComponent<TextMeshProUGUI> ().text = retrieveData.H_Prenoms[4].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
				}

				//IIIIIII
				if((test == verification[8]) || (test == verification[34]))
				{
					Img_Portrait01.enabled = false;
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.I_Prenoms[i].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
				}
				//JJJJJJJ
				if((test == verification[9]) || (test == verification[35]))
				{
					Img_Portrait01.enabled = false;
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.J_Prenoms[i].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
				}
				//KKKKKKKK
				if((test == verification[10]) || (test == verification[36]))
				{
					Img_Portrait01.enabled = false;
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.K_Prenoms[i].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
				}
				//LLLLLLLL
				if((test == verification[11]) || (test == verification[37]))
				{
					Img_Portrait01.enabled = false;
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.L_Prenoms[i].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
				}
				//MMMMMMMM
				if((test == verification[12]) || (test == verification[38]))
				{
					Img_Portrait01.enabled = false;
					marieE = true;
					MarieEButton.GetComponent<Button> ().enabled = true;
		
					textDisplay [0].GetComponent<TextMeshProUGUI> ().text = retrieveData.M_Prenoms[0].ToString();
					textDisplay [1].GetComponent<TextMeshProUGUI> ().text = retrieveData.M_Prenoms[1].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
					textDisplay [2].GetComponent<TextMeshProUGUI> ().text = retrieveData.M_Prenoms[2].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
					textDisplay [3].GetComponent<TextMeshProUGUI> ().text = retrieveData.M_Prenoms[3].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
					textDisplay [4].GetComponent<TextMeshProUGUI> ().text = retrieveData.M_Prenoms[4].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();		
				}

				//NNNNNNN
				if((test == verification[13]) || (test == verification[39]))
				{
					Img_Portrait01.enabled = false;
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.N_Prenoms[i].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
				}
				//OOOOOOOO
				if((test == verification[14]) || (test == verification[40]))
				{
					Img_Portrait01.enabled = false;
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.O_Prenoms[i].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
				}
				//PPPPPPPP
				if((test == verification[15]) || (test == verification[41]))
				{
					Img_Portrait01.enabled = false;
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.P_Prenoms[i].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
				}
				//QQQQQQ
				if((test == verification[16]) || (test == verification[42]))
				{
					Img_Portrait01.enabled = false;
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.Q_Prenoms[i].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
				}
				//RRRRRRRR
				if((test == verification[17]) || (test == verification[43]))
				{
					Img_Portrait01.enabled = false;
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.R_Prenoms[i].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
				}
				//SSSSSSS
				if((test == verification[18]) || (test == verification[44]))
				{
					Img_Portrait01.enabled = false;
					sophie = true;
					SoButton.GetComponent<Button> ().enabled = true;
		
					textDisplay [0].GetComponent<TextMeshProUGUI> ().text = retrieveData.S_Prenoms[0].ToString();
					textDisplay [1].GetComponent<TextMeshProUGUI> ().text = retrieveData.S_Prenoms[1].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
					textDisplay [2].GetComponent<TextMeshProUGUI> ().text = retrieveData.S_Prenoms[2].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
					textDisplay [3].GetComponent<TextMeshProUGUI> ().text = retrieveData.S_Prenoms[3].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
					textDisplay [4].GetComponent<TextMeshProUGUI> ().text = retrieveData.S_Prenoms[4].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
				}
				//TTTTTTT
				if((test == verification[19]) || (test == verification[45]))
				{
					Img_Portrait01.enabled = false;
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.T_Prenoms[i].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
				}
				//UUUUUUU
				if((test == verification[20]) || (test == verification[46]))
				{
					Img_Portrait01.enabled = false;
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.U_Prenoms[i].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
				}
				//VVVVVVV
				if((test == verification[21]) || (test == verification[47]))
				{
					Img_Portrait01.enabled = false;
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.V_Prenoms[i].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
				}
				//WWWWWWW
				if((test == verification[22]) || (test == verification[48]))
				{
					Img_Portrait01.enabled = false;
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.W_Prenoms[i].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
				}
				//XXXXXXX
				if((test == verification[23]) || (test == verification[49]))
				{
					Img_Portrait01.enabled = false;
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.X_Prenoms[i].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
				}
				//YYYYYYYYY
				if((test == verification[24]) || (test == verification[50]))
				{
					Img_Portrait01.enabled = false;
					Yann = true;
					YannButton.GetComponent<Button> ().enabled = true;
		
					textDisplay [0].GetComponent<TextMeshProUGUI> ().text = retrieveData.Y_Prenoms[0].ToString();
					textDisplay [1].GetComponent<TextMeshProUGUI> ().text = retrieveData.Y_Prenoms[1].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
					textDisplay [2].GetComponent<TextMeshProUGUI> ().text = retrieveData.Y_Prenoms[2].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
					textDisplay [3].GetComponent<TextMeshProUGUI> ().text = retrieveData.Y_Prenoms[3].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
					textDisplay [4].GetComponent<TextMeshProUGUI> ().text = retrieveData.Y_Prenoms[4].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();			
				}

				//ZZZZZZZZ
				if((test == verification[25]) || (test == verification[51]))
				{
					Img_Portrait01.enabled = false;
					textDisplay [i].GetComponent<TextMeshProUGUI> ().text = retrieveData.Z_Prenoms[i].ToString() + " " + retrieveData.NomsDeFamille[Random.Range(0, retrieveData.NomsDeFamille.Length)].ToString();
				}
			}
		}
		RetrieveAllImages();
	}

	void RetrieveAllImages ()
	{
		Component[] imagePosition;

		imagePosition = this.gameObject.GetComponentsInChildren (typeof(Image));

		foreach (Image img in imagePosition) {
			for (int i = 0; i < imagePosition.Length; i++) {

				imagePosition [0].GetComponent<Image> ().sprite = retrieveData.photoProfil [0];
				imagePosition [1].GetComponent<Image> ().sprite = retrieveData.photoProfil [1];
				imagePosition [2].GetComponent<Image> ().sprite = retrieveData.photoProfil [2];
				imagePosition [3].GetComponent<Image> ().sprite = retrieveData.photoProfil [3];
				imagePosition [4].GetComponent<Image> ().sprite = retrieveData.photoProfil [4];	

				{

					if (frederic == true) {
						imagePosition [0].GetComponent<Image> ().sprite = retrieveData.photoProfil [6];
						imagePosition [1].GetComponent<Image> ().sprite = retrieveData.photoProfil [0];
						imagePosition [2].GetComponent<Image> ().sprite = retrieveData.photoProfil [1];
						imagePosition [3].GetComponent<Image> ().sprite = retrieveData.photoProfil [2];
						imagePosition [4].GetComponent<Image> ().sprite = retrieveData.photoProfil [3];
						frederic2 = true;
					}

					
					if (adrien == true) {
						imagePosition [0].GetComponent<Image> ().sprite = retrieveData.photoProfil [5];
						imagePosition [1].GetComponent<Image> ().sprite = retrieveData.photoProfil [0];
						imagePosition [2].GetComponent<Image> ().sprite = retrieveData.photoProfil [1];
						imagePosition [3].GetComponent<Image> ().sprite = retrieveData.photoProfil [2];
						imagePosition [4].GetComponent<Image> ().sprite = retrieveData.photoProfil [3];
						adrien2 = true;
					}

					if (cassandra == true) {
						imagePosition [0].GetComponent<Image> ().sprite = retrieveData.photoProfil [7];
						imagePosition [1].GetComponent<Image> ().sprite = retrieveData.photoProfil [0];
						imagePosition [2].GetComponent<Image> ().sprite = retrieveData.photoProfil [1];
						imagePosition [3].GetComponent<Image> ().sprite = retrieveData.photoProfil [2];
						imagePosition [4].GetComponent<Image> ().sprite = retrieveData.photoProfil [3];
						cassandra2 = true;
					}

					if (sophie == true) {
						imagePosition [0].GetComponent<Image> ().sprite = retrieveData.photoProfil [8];
						imagePosition [1].GetComponent<Image> ().sprite = retrieveData.photoProfil [0];
						imagePosition [2].GetComponent<Image> ().sprite = retrieveData.photoProfil [1];
						imagePosition [3].GetComponent<Image> ().sprite = retrieveData.photoProfil [2];
						imagePosition [4].GetComponent<Image> ().sprite = retrieveData.photoProfil [3];
						sophie2 = true;
					}

					if (marieE == true) {
						imagePosition [0].GetComponent<Image> ().sprite = retrieveData.photoProfil [9];
						imagePosition [1].GetComponent<Image> ().sprite = retrieveData.photoProfil [0];
						imagePosition [2].GetComponent<Image> ().sprite = retrieveData.photoProfil [1];
						imagePosition [3].GetComponent<Image> ().sprite = retrieveData.photoProfil [2];
						imagePosition [4].GetComponent<Image> ().sprite = retrieveData.photoProfil [3];
						marieE2 = true;
					}

					if (Yann == true) {
						imagePosition [0].GetComponent<Image> ().sprite = retrieveData.photoProfil [10];
						imagePosition [1].GetComponent<Image> ().sprite = retrieveData.photoProfil [0];
						imagePosition [2].GetComponent<Image> ().sprite = retrieveData.photoProfil [1];
						imagePosition [3].GetComponent<Image> ().sprite = retrieveData.photoProfil [2];
						imagePosition [4].GetComponent<Image> ().sprite = retrieveData.photoProfil [3];
						Yann2 = true;
					}

					if (Hugo == true) {
						imagePosition [0].GetComponent<Image> ().sprite = retrieveData.photoProfil [11];
						imagePosition [1].GetComponent<Image> ().sprite = retrieveData.photoProfil [0];
						imagePosition [2].GetComponent<Image> ().sprite = retrieveData.photoProfil [1];
						imagePosition [3].GetComponent<Image> ().sprite = retrieveData.photoProfil [2];
						imagePosition [4].GetComponent<Image> ().sprite = retrieveData.photoProfil [3];
						Hugo2 = true;
					}
				}
			}
		}

		adrien = false;
		frederic = false;
		cassandra = false;
		sophie = false;
		marieE = false;
		Yann = false;
		Hugo = false;

	}

	void OnDisable()
	{
//		Debug.Log ("This was a triumph! \n I'm making a note here: \n Huge success!");
		this.gameObject.SetActive (false);
		searchBar.GetComponent<TMP_InputField> ().text = "";
	}

	public void ButtonOfChoice ()
	{
		if (adrien2 == true) {
			GS.BoutonAdrien ();
		}

		if (frederic2 == true) {
			GS.BoutonFred ();
		}

		if (cassandra2 == true) {
			GS.BoutonCass ();
		}

		if (sophie2 == true) {
			GS.BoutonSophie ();
		}

		if (marieE2 == true) {
			GS.BoutonMarieEve ();	
		}

		if (Yann2 == true) {
			GS.BoutonYann ();
		}

		if (Hugo2 == true) {
			GS.BoutonHugo ();
		}

		cassandra2 = false;
		adrien2 = false;
		frederic2 = false;
		sophie2 = false;
		marieE2 = false;
		Yann2 = false;
		Hugo2 = false;
	}
}
