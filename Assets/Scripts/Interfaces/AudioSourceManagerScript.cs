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

	void Awake()
	{
		DetectAudioSources ();
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
			audioSourcesAttachedToTheSoundManager [i].volume = resetVolumeValueAfterPlayingSound;
		}
	}

	public IEnumerator PlayAudio(AudioSource[] m_audioSource, AudioClip m_audioClip, AudioSource playSound)
	{
		for (int i = 0; i < m_audioSource.Length; i++)
		{
			m_audioSource[i].volume = 0.66f;
		}

		playSound.PlayOneShot(m_audioClip, 0.5f); 

		float localFloat = m_audioClip.length;

		yield return new WaitForSeconds (localFloat);

		ResetAllAudioSourcesVolumeSliders ();
	}
}