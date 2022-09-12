using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public bool finishedLevel = false;
    bool Reset = true;
    public new GameObject gameObject;
    bool active = false;

    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
    }

    public void EndGame() {
        if(finishedLevel == false) {
            if(gameHasEnded == false) {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
        }
    }

    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit() {
        Debug.Log("Quit");
        Application.Quit();
    }

    // ESC MENU

    void Update() {

        if(Input.GetKey(KeyCode.Escape)) {
            if(Reset == true) {
                if(active == true) {
                    Reset = false;
                    Invoke("Delay", 0.2f);
                    gameObject.SetActive(false);
                    active = false;
                } 
                else if(active == false) {
                    Reset = false;
                    Invoke("Delay", 0.2f);
                    gameObject.SetActive(true);
                    active = true;
                }
            }
        }
    }

    void Delay() {
        Reset = true;
    }

    public void escMenu(){
        SceneManager.LoadScene(0);
    }
    public void escRestart(){
        Restart();
        Debug.Log("TEst");
    }
    public void escQuit(){
        Quit();
    }
    public void escFeedback(){
        Application.OpenURL("https://tompadmanathan.com/pages/contact-me");
    }

    public void escOptions() {
        SceneManager.LoadScene(2);
    }
}