using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuletBehaviour : MonoBehaviour {
    public int Daune;
	void Update () {
        if (gameObject.transform.position.x > 500 ||
            gameObject.transform.position.y > 500 ||
            gameObject.transform.position.z > 500 ||
            gameObject.transform.position.x < -500 ||
            gameObject.transform.position.y < -500 ||
            gameObject.transform.position.z < -500) {
            Destroy(gameObject);
        }

    }
    public void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
