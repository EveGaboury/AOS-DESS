﻿using System.Collections; using System.Collections.Generic; using UnityEngine; using UnityEngine.Audio; using UnityEngine.UI;  public class SoundDesignScript : MonoBehaviour  {  	//AudioSource pou les sound Design sounds 	public AudioSource audioSourceSD;  	//AudioClip Sound Courriel Application 	public AudioClip sound_courriel;  	//AudioClip Sound Trash Application 	public AudioClip sound_trash;  	//AudioClip Sound Browser Application 	public AudioClip sound_browser;  	//AudioClip Sound Itunes Application 	public AudioClip sound_itunes;  	//AudioClip sound Error Browser 	public AudioClip sound_browser_error;  	//AudioClip sound bonne adresse ajoute Browser 	public AudioClip sound_browser_right;  	//AudioClip sound bon mot de passe connexion 	public AudioClip sound_tl_connexion;  	//AudioClip sound mauvais mot de passe 	public AudioClip sound_tl_wrong;  	//AudioClip sound recuperation du compte TL tonlivre effectué 	public AudioClip sound_tl_hacking;  	//AudioClip sound bonne réponse  	public AudioClip sound_tl_right;   	//AudioClip starting mac 	public AudioClip sound_starting_mac;  	//AudioClip notification Courriel 	public AudioClip sound_notification_courriel;   	void Awake () 	{ 		audioSourceSD = this.gameObject.GetComponent<AudioSource> (); 	}    	//OnClickBarreAppli 	public void OnclickSoundCourriel ()  	{ 		audioSourceSD.clip = sound_courriel; 		audioSourceSD.PlayOneShot (audioSourceSD.clip); 	}  	public void OnclickSoundTrash ()   	{ 		audioSourceSD.clip = sound_trash; 		audioSourceSD.PlayOneShot (audioSourceSD.clip);   	}  	public void OnclickSoundItunes ()   	{ 		audioSourceSD.clip = sound_itunes; 		audioSourceSD.PlayOneShot (audioSourceSD.clip);  	}   	public void OnclickSoundBrowser ()   	{ 		audioSourceSD.clip = sound_browser; 		audioSourceSD.PlayOneShot (audioSourceSD.clip);  	}   	//OnclickBrowser  	public void OnclickSoundBrowserError ()   	{ 		audioSourceSD.clip = sound_browser_error; 		audioSourceSD.PlayOneShot (audioSourceSD.clip);  	}  	public void OnclickSoundBrowserRight ()   	{ 		audioSourceSD.clip = sound_browser_right; 		audioSourceSD.PlayOneShot (audioSourceSD.clip);  	}     	//OnClickTonLivre 	public void OnclickSoundTLConnexion ()   	{ 		audioSourceSD.clip = sound_tl_connexion; 		audioSourceSD.PlayOneShot (audioSourceSD.clip);  	}  	public void OnclickSoundTLWrong ()   	{ 		audioSourceSD.clip = sound_tl_wrong; 		audioSourceSD.PlayOneShot (audioSourceSD.clip);  	}  	public void OnclickSoundTLHacking ()   	{ 		audioSourceSD.clip = sound_tl_hacking; 		audioSourceSD.PlayOneShot (audioSourceSD.clip);  	}  	public void OnclickSoundTLRight ()   	{ 		audioSourceSD.clip = sound_tl_right; 		audioSourceSD.PlayOneShot (audioSourceSD.clip);  	}    	//introduction et début du jeu 	public void OnClicksoundDemarrageMac ()  	{ 		audioSourceSD.clip = sound_starting_mac; 		audioSourceSD.PlayOneShot (audioSourceSD.clip);  	}  	public void OnClickSoundNotificationCourriel ()  	{ 		audioSourceSD.clip = sound_notification_courriel; 		audioSourceSD.PlayDelayed (2f);  	}     } 