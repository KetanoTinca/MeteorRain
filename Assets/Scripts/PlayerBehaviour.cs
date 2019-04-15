using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

    int Viata = 100;
    int Damage = 10;
    public int VitezaGlont = 100;
    public int Inaltime = 0; // Gen sa isi poata pune playerul inaltimea la care e confortabil //
    public GameObject Glont;
    public GameObject[] SpawnGlont;
    public Vector3 Offset;


    public GameObject Planeta;



    void Update () {
        if (Input.GetButtonDown("Submit") && Planeta.GetComponent<PlanetBehaviou>().pierdut == false){
            Impusca();
        }
	}

    public void Impusca(){

        GameObject camera = transform.GetChild(0).gameObject;
        Debug.Log("Impusc");
        //GameObject bullet = Instantiate(Glont, transform.position+Offset, camera.transform.rotation, transform);
        GameObject bullet = Instantiate(Glont, SpawnGlont[1].transform.position, SpawnGlont[1].transform.rotation, transform);
        GameObject bullet2 = Instantiate(Glont, SpawnGlont[0].transform.position, SpawnGlont[0].transform.rotation, transform);
       
        //bullet.transform.Rotate(Vector3.right, 0f);
        //bullet2.transform.Rotate(Vector3.right, 0f);
       

        bullet.GetComponent<Rigidbody>().AddForce(camera.transform.forward * VitezaGlont, ForceMode.Acceleration);
        bullet2.GetComponent<Rigidbody>().AddForce(camera.transform.forward * VitezaGlont, ForceMode.Acceleration);

    }

    public void Teleport(){
        // ramane de vazut
    }

    public void Damage_Primit(){
        // la coliziune iau damageul obiectului si il scad din hp
    }

    public bool TeleportVerificare(){
        //verifica daca poate teleporta playerul
        return true;
    }

}
