using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float ForwardForce = 500f;
    public float SidewaysForce = 35f;

    void FixedUpdate() {

        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if(Input.GetKey("d") || Input.GetKey("right")) {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a") || Input.GetKey("left")) {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
