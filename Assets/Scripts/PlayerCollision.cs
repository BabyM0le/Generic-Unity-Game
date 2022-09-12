using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement PlayerMovement;
    public AudioSource obstacleCollision;

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Obstacle") {
            obstacleCollision.Play();
            PlayerMovement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
