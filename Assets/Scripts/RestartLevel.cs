using UnityEngine;

public class RestartLevel : MonoBehaviour {

    public GameManager gameManager;

    void Update() {
        if(Input.GetKey("r")) {
            gameManager.Restart();
        }
    }
}
