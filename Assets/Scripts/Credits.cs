using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {
    
    public void Quit() {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void MainMenu() {
        SceneManager.LoadScene(0);
        SFXManager.sfxInstance.Audio.PlayOneShot(SFXManager.sfxInstance.Click);
    }

    public void Website() {
        Application.OpenURL("http://tompadmanathan.com/");
    }

    public void Github() {
        Application.OpenURL("https://github.com/BabyM0le");
    }

    public void Linkedin() {
        Application.OpenURL("https://www.linkedin.com/in/tom-padmanathan/");
    }
}
