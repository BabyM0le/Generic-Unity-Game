using UnityEngine;
using UnityEngine.Audio;

public class Options : MonoBehaviour {

    public AudioMixer audioMixer;

    public void SetMasterVolume(float MasterVolume) {
        audioMixer.SetFloat("MasterVolume", MasterVolume);
    }

    public void SetMusicVolume(float MusicVolume) {
        audioMixer.SetFloat("MusicVolume", MusicVolume);
    }

    public void SetSFXVolume(float SFXVolume) {
        audioMixer.SetFloat("SFXVolume", SFXVolume);
    }
}
