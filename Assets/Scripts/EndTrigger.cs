using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;
    public AudioSource completeLevel;

    void OnTriggerEnter() {
        completeLevel.Play();
        gameManager.CompleteLevel();
        gameManager.finishedLevel = true;
    }
}
