using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private float Cronometru;
    private GameObject SpawnCurent;
    [Tooltip("Delay between respawn in seconds")]
    public float Intarziere;
    public GameObject Asteroid;
    public List<GameObject> PuncteDeSpawn;
    public static int score = 0;
    public int scor;
    int target = 10;

    public GameObject Planeta;

    void Start(){
        Cronometru = Time.time + Intarziere;
    }
    void Update(){
        if (scor > target)
        {
            Intarziere -= 1;
            target += 10;
        }
        scor = score;
        if (Cronometru < Time.time && Planeta.GetComponent<PlanetBehaviou>().pierdut == false)
        {
            SpawnCurent = PuncteDeSpawn[Random.Range(0, 3)];
            Instantiate(Asteroid, SpawnCurent.transform);     
            Cronometru += Intarziere;
        }

        if( Planeta.GetComponent<PlanetBehaviou>().pierdut == true)
        {
            this.enabled = false;
            GameObject[] gameObjects;
            gameObjects = GameObject.FindGameObjectsWithTag("Asteroid");

            for (var i = 0; i < gameObjects.Length; i++)
            {
                Destroy(gameObjects[i]);
            }
        }
    }
}
