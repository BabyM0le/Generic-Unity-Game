using UnityEngine;

public class TimeSlow : MonoBehaviour {
    
    bool active = true;
    public MeshRenderer mr;
        public AudioSource collectTimeSlow;

    void Start() {
        Time.timeScale = 1f;
    }

    void Update() {
        Time.fixedDeltaTime = Time.timeScale * 0.01f;
    }

    void OnTriggerEnter() {
        if(active == true) {
            collectTimeSlow.Play();
            active = false;
            mr.enabled = false;
            Time.timeScale = 0.25f;
            Invoke("delayReset", 1);
        }
    }

    void delayReset() {
        active = true;
        Time.timeScale = 1;
    }
}