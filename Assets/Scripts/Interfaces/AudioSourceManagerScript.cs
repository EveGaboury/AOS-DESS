using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSourceManagerScript : MonoBehaviour 
{
	public AudioSource audioSourceData, audioSourceBoutons, audioSourceClicksEtTyping, audioSourceCueEmotion, audioSourceMusique;

	[HideInInspector]
	public float m_value, plus = 0.032f, minus = -0.016f;

	AudioSource[] audioSourcesAttachedToTheSoundManager;

	AudioClip cueEmotion;

	GameObject fetchGameState;

	string cueName;

	void Awake()
	{
		DetectAudioSources ();

		fetchGameState = GameObject.Find ("ScriptManager");
	}

	void Update()
	{
		if (audioSourceCueEmotion.isPlaying && audioSourceCueEmotion.clip.name == "Cue 1 Eureka")
		{
			Debug.Log ("Yay! " + "Cue 1 Eureka is PLAYING.");

			m_value = minus;
			StartCoroutine (CueSound ());

			cueName = audioSourceCueEmotion.clip.name;
			Invoke ("CueIsDonePlaying", audioSourceCueEmotion.clip.length);
		}
		else if (audioSourceCueEmotion.isPlaying && (audioSourceCueEmotion.clip.name == "Cue 2 Sadness _ I want to know"))
		{
			Debug.Log ("Yay! " + "Cue 2 Sadness _ I want to know is PLAYING.");

			m_value = minus;
			StartCoroutine (CueSound());

			cueName = audioSourceCueEmotion.clip.name;
			Invoke ("CueIsDonePlaying", audioSourceCueEmotion.clip.length);
		}
		else if (audioSourceCueEmotion.isPlaying && (audioSourceCueEmotion.clip.name == "Cue 3 World upside down"))
		{
			Debug.Log ("Yay! " + "Cue 3 World upside down is PLAYING.");

			m_value = minus;
			StartCoroutine (CueSound());

			cueName = audioSourceCueEmotion.clip.name;
			Invoke ("CueIsDonePlaying", audioSourceCueEmotion.clip.length);
		}
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
					audioSourcesAttachedToTheSoundManager [j].volume = 1.0f;
				}
			} 
			else
			{
				audioSourcesAttachedToTheSoundManager [i].volume = 1.0f;
			}
		}
	}

	public IEnumerator PlayAudio(AudioSource[] m_audioSource, AudioClip m_audioClip, AudioSource playSound)
	{
		playSound.PlayOneShot(m_audioClip, 1.0f); 

		float test = (5.0f / 20.0f);

		float autreTest = (1.0f / 20.0f); 

		for (int i = 0; i < m_audioSource.Length; i++)
		{
			for (int j = 0; j < 20; j++) 
			{
				m_audioSource [i].volume -= autreTest;
			}
		}

		float localFloat = m_audioClip.length;

		yield return new WaitForSeconds (localFloat);

		ResetAllAudioSourcesVolumeSliders ();
	}

	/*public*/ IEnumerator CueSound()
	{
		for (int i = 0; i < 20; i++) 
		{
			audioSourceMusique.volume = m_value;
			yield return new WaitForSeconds(0.1f);
		}
	}

	void CueIsDonePlaying()
	{
		if (audioSourceMusique.volume < 1.0f)
		{
			for (int i = 0; i < 20; i++) 
			{
				audioSourcesAttachedToTheSoundManager [4].volume += 0.05f;
			}

			Debug.Log (cueName + " song was playing has ENDED.");
		}
	}
}