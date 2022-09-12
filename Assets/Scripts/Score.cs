using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    public float bonus = 0f;

    void Update() {
        scoreText.text = (player.position.z + bonus).ToString("0");
    }

}
