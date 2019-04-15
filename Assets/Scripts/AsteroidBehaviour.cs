using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehaviour : MonoBehaviour {
    public int Viata;
    public float Viteza;
    public int Scor;
    private float velocity;
    public GameObject explozie;
    public GameObject asteroid;
    

    public Rigidbody ast;

    void Start(){
        velocity = 0f;
    }
    void Update(){
        asteroid.transform.Rotate(0, Time.deltaTime*10, Time.deltaTime*10);
        //transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, velocity);
    }
    public void OnCollisionEnter(Collision collision){
        if (collision.gameObject.tag.Equals("Planeta") == true)
        {

            ast.isKinematic = true;
            ast.detectCollisions = false;

            Viata = 0;

            explozie.SetActive(true);
            asteroid.SetActive(false);
            Invoke("Distruge", 12);
        }
        else
        {
            if(collision.gameObject.tag.Equals("Asteroid") != true)
            Viata -= collision.gameObject.GetComponent<BuletBehaviour>().Daune;
            VerificaDacaEInViata();
        }
    }

    public void VerificaDacaEInViata(){
        if (Viata <= 0){

            ast.isKinematic = true;
            ast.detectCollisions = false;

            explozie.SetActive(true);
            asteroid.SetActive(false);
            GameManager.score = GameManager.score + Scor;
            Invoke("Distruge", 12);
        }
    }
    void Distruge(){
        Destroy(gameObject);
    }
}
