using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour {
    
    public GameManager gameManager;
    public Score score;
    bool active = true;
    public MeshRenderer mr;
    public AudioSource collectCoin;

    void OnTriggerEnter() {
        if(active == true) {
            collectCoin.Play();
            active = false;
            score.bonus = score.bonus + 100;
            Invoke("delayReset", 1);
            score.scoreText.GetComponent<Text>().color = Color.yellow;
            mr.enabled = false;
        }
    }

    void delayReset() {
        active = true;
        score.scoreText.GetComponent<Text>().color = Color.black;
    }
}
