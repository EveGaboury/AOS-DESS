﻿using System.Collections; using System.Collections.Generic; using UnityEngine; using UnityEngine.Audio; using UnityEngine.UI;  public class SoundDesignScript : MonoBehaviour  { 	public AudioClip  					sound_courriel, 				//AudioClip Sound Courriel Application 					sound_trash,					//AudioClip Sound Trash Application 					sound_browser, 					//AudioClip Sound Browser Application 					sound_itunes, 					//AudioClip Sound Itunes Application 					sound_browser_error, 			//AudioClip sound Error Browser 					sound_browser_right, 			//AudioClip sound bonne adresse ajoute Browser 					sound_tl_connexion, 			//AudioClip sound bon mot de passe connexion 					sound_tl_wrong, 				//AudioClip sound mauvais mot de passe 					sound_tl_hacking,				//AudioClip sound recuperation du compte TL tonlivre effectué 					sound_tl_right, 				//AudioClip sound bonne réponse  					sound_starting_mac,  			//AudioClip starting mac  					sound_notification_courriel,	//AudioClip notification Courriel 					cue_emotion_1,					//AudioCLip cue d'emotion numero 1 					cue_emotion_2; 					//AudioClip cue d'emotion numero 2  	//Private 	AudioSourceManagerScript ASMS_Boutons;  	bool[] hasSFXBeenPlayedBefore = new bool[2];  	void Start () 	{ 		ASMS_Boutons = this.gameObject.GetComponent<AudioSourceManagerScript> (); 	}  	//OnClickBarreAppli 	public void OnclickSoundCourriel ()  	{ 		ASMS_Boutons.audioSourceBoutons.PlayOneShot (sound_courriel);   		//ici faire jouer une seule fois la "cue 2" 		if(hasSFXBeenPlayedBefore[1] == false) 		{ 			hasSFXBeenPlayedBefore[1] = true;  //			AudioSource[] localArrayAudioSourcesForCueEmotion = new AudioSource[] {ASMS_Boutons.audioSourceMusique, ASMS_Boutons.audioSourceBoutons, ASMS_Boutons.audioSourceClicksEtTyping, ASMS_Boutons.audioSourceData }; // //			for (int i = 0; i < localArrayAudioSourcesForCueEmotion.Length; i++) //			{ //				StopAllCoroutines (); //				StartCoroutine (ASMS_Boutons.GetComponent<AudioSourceManagerScript> ().PlayAudio (localArrayAudioSourcesForCueEmotion, cue_emotion_1, ASMS_Boutons.audioSourceCueEmotion)); //			} 		} 	}  	public void OnclickSoundTrash ()  	{ 		ASMS_Boutons.audioSourceBoutons.PlayOneShot (sound_trash); 	}  	public void OnclickSoundItunes ()  	{ 		ASMS_Boutons.audioSourceBoutons.PlayOneShot (sound_itunes); 	}  	public void OnclickSoundBrowser ()  	{ 		ASMS_Boutons.audioSourceBoutons.PlayOneShot (sound_browser); 	} 		 	//OnclickBrowser 	public void OnclickSoundBrowserError ()  	{ 		ASMS_Boutons.audioSourceBoutons.PlayOneShot (sound_browser_error); 	}  	public void OnclickSoundBrowserRight ()  	{ 		ASMS_Boutons.audioSourceBoutons.PlayOneShot (sound_browser_right); 	}  	//OnClickTonLivre 	public void OnclickSoundTLConnexion ()  	{ 		ASMS_Boutons.audioSourceBoutons.PlayOneShot (sound_tl_connexion); 	}  	public void OnclickSoundTLWrong () 	{ 		ASMS_Boutons.audioSourceBoutons.PlayOneShot (sound_tl_wrong); 	}  	public void OnclickSoundTLHacking ()  	{ 		ASMS_Boutons.audioSourceBoutons.PlayOneShot (sound_tl_hacking);  		//ici faire jouer une seule fois la "cue 1" 		if (hasSFXBeenPlayedBefore[0] == false)  		{ 			hasSFXBeenPlayedBefore[0] = true;  //			AudioSource[] localArrayAudioSourcesForCueEmotion = new AudioSource[] {ASMS_Boutons.audioSourceMusique, ASMS_Boutons.audioSourceBoutons, ASMS_Boutons.audioSourceClicksEtTyping, ASMS_Boutons.audioSourceData }; // //			for (int i = 0; i < localArrayAudioSourcesForCueEmotion.Length; i++) //			{ //				StopAllCoroutines (); //				StartCoroutine (ASMS_Boutons.GetComponent<AudioSourceManagerScript> ().PlayAudio (localArrayAudioSourcesForCueEmotion, cue_emotion_2, ASMS_Boutons.audioSourceCueEmotion)); //			} 		} 	}  	public void OnclickSoundTLRight ()  	{ 		ASMS_Boutons.audioSourceBoutons.PlayOneShot (sound_tl_right); 	} 		 	//introduction et début du jeu 	public void OnClicksoundDemarrageMac ()  	{ 		ASMS_Boutons.audioSourceBoutons.PlayOneShot (sound_starting_mac); 	}  	public void OnClickSoundNotificationCourriel ()  	{ 		ASMS_Boutons.audioSourceBoutons.clip = sound_notification_courriel; 		ASMS_Boutons.audioSourceBoutons.PlayDelayed (1.7f); 	} }