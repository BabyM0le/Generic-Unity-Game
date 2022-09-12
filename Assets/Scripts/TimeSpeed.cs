using UnityEngine;

public class TimeSpeed : MonoBehaviour {

    bool active = true;
    public MeshRenderer mr;
    public AudioSource collectTimeSpeed;

    void Start() {
        Time.timeScale = 1f;
    }

    void Update() {
        Time.fixedDeltaTime = Time.timeScale * 0.01f;
    }

    void OnTriggerEnter() {
        if(active == true) {
            collectTimeSpeed.Play();
            active = false;
            mr.enabled = false;
            Time.timeScale = 1.5f;
            Invoke("delayReset", 2f);
        }
    }

    void delayReset() {
        active = true;
        Time.timeScale = 1;
    }
}
