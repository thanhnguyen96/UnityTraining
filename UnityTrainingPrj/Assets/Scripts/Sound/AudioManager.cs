using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public enum AudioStatus
    {
        Ready,
        Playing,
        Paused
    }
    public enum AudioType
    {
        Sound,
        Music
    }
    [System.Serializable]
    public struct AudioControl
    {
        public AudioClip audioClip;
        public AudioSource audioSource;
        public Button playButton;
        public Button pauseButton;
        public Button stopButton;
        public Slider volumeSlider;
        public AudioStatus audioStatus;
        public AudioType AudioType;
        public Text pausedStatusTxt;
    }

    public AudioControl[] audioControls;
    [Header("Global Volume Slider")]
    public Slider globalVolumeSlider;
    public Slider globalMusicVolumeSlider;
    public Slider globalSoundVolumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < audioControls.Length; i++)
        {
            audioControls[i].audioSource = gameObject.AddComponent<AudioSource>();
            audioControls[i].audioSource.clip = audioControls[i].audioClip;
            audioControls[i].audioSource.loop = true;
        }
    }

    // Update is called once per frame
    private void Update()
    {
        UpdateUI();
        UpdateVolume();
    }

    private void UpdateUI()
    {
        for (int i = 0; i < audioControls.Length; i++)
        {
            AudioControl audioControl = audioControls[i];
            if (audioControl.audioClip != null)
            {
                switch (audioControl.audioStatus)
                {
                    case AudioStatus.Ready:
                        audioControl.playButton.interactable = true;
                        audioControl.pauseButton.interactable = false;
                        audioControl.stopButton.interactable = false;
                        audioControl.pausedStatusTxt.enabled = false;
                        break;
                    case AudioStatus.Playing:
                        audioControl.playButton.interactable = false;
                        audioControl.pauseButton.interactable = true;
                        audioControl.stopButton.interactable = true;
                        audioControl.pausedStatusTxt.enabled = false;
                        break;
                    case AudioStatus.Paused:
                        audioControl.playButton.interactable = true;
                        audioControl.pauseButton.interactable = false;
                        audioControl.stopButton.interactable = false;
                        audioControl.pausedStatusTxt.enabled = true;
                        break;
                }
            }
        }
    }

    private void UpdateVolume()
    {
        for (int i = 0; i < audioControls.Length; i++)
        {
            switch (audioControls[i].AudioType)
            {
                case AudioType.Music:
                    audioControls[i].audioSource.volume = audioControls[i].volumeSlider.value *globalMusicVolumeSlider.value * globalVolumeSlider.value;
                    break;
                case AudioType.Sound:
                    audioControls[i].audioSource.volume = audioControls[i].volumeSlider.value * globalSoundVolumeSlider.value * globalVolumeSlider.value;
                    break;
            }
        }
    }

    public void PlayMusic()
    {
        if (audioControls[0].audioStatus == AudioStatus.Ready)
        {
            audioControls[0].audioSource.Play();
        }
        else if(audioControls[0].audioStatus == AudioStatus.Paused)
        {
            audioControls[0].audioSource.UnPause();
        }
        audioControls[0].audioStatus = AudioStatus.Playing;
    }


    public void PauseMusic()
    {
        audioControls[0].audioSource.Pause();
        audioControls[0].audioStatus = AudioStatus.Paused;
    }
    public void StopMusic()
    {
        audioControls[0].audioSource.Stop();
        audioControls[0].audioStatus = AudioStatus.Ready;
    }

    public void PlaySound()
    {
        if (audioControls[1].audioStatus == AudioStatus.Ready)
        {
            audioControls[1].audioSource.PlayOneShot(audioControls[1].audioClip);
        }
        else if (audioControls[1].audioStatus == AudioStatus.Paused)
        {
            audioControls[1].audioSource.UnPause();
        }
        audioControls[1].audioStatus = AudioStatus.Playing;
    }
    public void PauseSound()
    {
        audioControls[1].audioSource.Pause();
        audioControls[1].audioStatus = AudioStatus.Paused;
    }
    public void StopSound()
    {
        audioControls[1].audioSource.Stop();
        audioControls[1].audioStatus = AudioStatus.Ready;
    }

    public void PlayMusic2()
    {
        if (audioControls[2].audioStatus == AudioStatus.Ready)
        {
            audioControls[2].audioSource.Play();
        }
        else if (audioControls[2].audioStatus == AudioStatus.Paused)
        {
            audioControls[2].audioSource.UnPause();
        }
        audioControls[2].audioStatus = AudioStatus.Playing;
    }

    public void PauseMusic2()
    {
        audioControls[2].audioSource.Pause();
        audioControls[2].audioStatus = AudioStatus.Paused;
    }
    public void StopMusic2()
    {
        audioControls[2].audioSource.Stop();
        audioControls[2].audioStatus = AudioStatus.Ready;
    }

    public void PlaySound2()
    {
        if (audioControls[3].audioStatus == AudioStatus.Ready)
        {
            audioControls[3].audioSource.PlayOneShot(audioControls[3].audioClip);
        }
        else if (audioControls[3].audioStatus == AudioStatus.Paused)
        {
            audioControls[3].audioSource.UnPause();
        }
        audioControls[3].audioStatus = AudioStatus.Playing;
    }
    public void PauseSound2()
    {
        audioControls[3].audioSource.Pause();
        audioControls[3].audioStatus = AudioStatus.Paused;
    }
    public void StopSound2()
    {
        audioControls[3].audioSource.Stop();
        audioControls[3].audioStatus = AudioStatus.Ready;
    }
}
