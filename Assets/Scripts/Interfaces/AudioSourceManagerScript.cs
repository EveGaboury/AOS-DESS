using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSourceManagerScript : MonoBehaviour 
{
	public AudioMixer audioMixer;

	public float resetVolumeValueAfterPlayingSound;

	public AudioSource audioSourceData, audioSourceBoutons, audioSourceClicksEtTyping, audioSourceCueEmotion, audioSourceMusique;

	AudioSource[] audioSourcesAttachedToTheSoundManager;

	AudioClip cueEmotion;

	GameObject fetchGameState;

	void Awake()
	{
		DetectAudioSources ();

		fetchGameState = GameObject.Find ("ScriptManager");
	}

	void Update()
	{
		if (audioSourceCueEmotion.isPlaying) 
		{
			
		}
		else if (!audioSourceCueEmotion.isPlaying) 
		{
			Debug.Log ("This function has been called.");
			audioSourceMusique.volume = 1.0f;
		}
//		if (this.gameObject.GetComponent<SoundDesignScript> ().m_hasSFXBeenPlayedBefore [0] == true) 
//		{
//			audioSourceMusique.volume = 0.0f;
//		} 
//		if (this.gameObject.GetComponent<SoundDesignScript> ().m_hasSFXBeenPlayedBefore [1] == true) 
//		{
//			audioSourceMusique.volume = 0.0f;
//		}
	}

	public void DetectAudioSources()
	{
		audioSourcesAttachedToTheSoundManager = this.gameObject.GetComponents<AudioSource> ();

		audioSourceData = audioSourcesAttachedToTheSoundManager [0];

		audioSourceBoutons = audioSourcesAttachedToTheSoundManager [1]; 

		audioSourceClicksEtTyping = audioSourcesAttachedToTheSoundManager [2];

		audioSourceCueEmotion = audioSourcesAttachedToTheSoundManager [3];

		audioSourceMusique = audioSourcesAttachedToTheSoundManager [4];
	}

	public void ResetAllAudioSourcesVolumeSliders()
	{
		for (int i = 0; i < audioSourcesAttachedToTheSoundManager.Length; i++)
		{
			if (this.gameObject.GetComponent<SoundDesignScript>().hasSFXBeenPlayedBefore[0] == true || this.gameObject.GetComponent<SoundDesignScript>().hasSFXBeenPlayedBefore[1] == true || fetchGameState.GetComponent<GameState>().playCueOnce == true) 
			{
				for (int j = 0; j < 4; j++) 
				{
					audioSourcesAttachedToTheSoundManager [j].volume = resetVolumeValueAfterPlayingSound;
				}
			} 
			else
			{
				audioSourcesAttachedToTheSoundManager [i].volume = resetVolumeValueAfterPlayingSound;
			}
		}
	}

	public IEnumerator PlayAudio(AudioSource[] m_audioSource, AudioClip m_audioClip, AudioSource playSound)
	{
		//if (this.gameObject.GetComponent<SoundDesignScript> ().hasSFXBeenPlayedBefore [0] == true 
		//	|| this.gameObject.GetComponent<SoundDesignScript> ().hasSFXBeenPlayedBefore [1] == true 
		//	|| fetchGameState.GetComponent<GameState> ().playCueOnce == true) 
		//{
		//	audioSourceMusique.volume = 0.0f;
		//} 
		//else
		//{
			for (int i = 0; i < m_audioSource.Length; i++)
			{
				m_audioSource[i].volume = 0.66f;
			}
		//}
		playSound.PlayOneShot(m_audioClip, 0.5f); 

		float localFloat = m_audioClip.length;

		yield return new WaitForSeconds (localFloat);

		ResetAllAudioSourcesVolumeSliders ();

//		if (this.gameObject.GetComponent<SoundDesignScript> ().m_hasSFXBeenPlayedBefore[0] == true) 
//		{
//			this.gameObject.GetComponent<SoundDesignScript> ().m_hasSFXBeenPlayedBefore[0] = false;
//		}
//		if (this.gameObject.GetComponent<SoundDesignScript> ().m_hasSFXBeenPlayedBefore[1] == true) 
//		{
//			this.gameObject.GetComponent<SoundDesignScript> ().m_hasSFXBeenPlayedBefore[1] = false;
//		}
//		if ( fetchGameState.GetComponent<GameState> ().playCueOnce == true) 
//		{
//			fetchGameState.GetComponent<GameState> ().playCueOnce = false;
//		}
	}
}