using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public void startGame() {
        SceneManager.LoadScene(3);
        SFXManager.sfxInstance.Audio.PlayOneShot(SFXManager.sfxInstance.Click);
    }

    public void howToPlay() {
        SceneManager.LoadScene(1);
        SFXManager.sfxInstance.Audio.PlayOneShot(SFXManager.sfxInstance.Click);
    }

    public void howToPlayBack() {
        SceneManager.LoadScene(0);
        SFXManager.sfxInstance.Audio.PlayOneShot(SFXManager.sfxInstance.Click);
    }

    public void options() {
        SceneManager.LoadScene(2);
        SFXManager.sfxInstance.Audio.PlayOneShot(SFXManager.sfxInstance.Click);
    }
}
