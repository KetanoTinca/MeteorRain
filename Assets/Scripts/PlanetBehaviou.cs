using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetBehaviou : MonoBehaviour {
    public int Viata = 100;
    public GameObject lost;
    public RectTransform healthbar;

    public bool pierdut;

    public void OnCollisionEnter(Collision collision){
        if (collision.gameObject.tag.Equals("Glont") != true)
        {
            Viata -= 10;
            healthbar.localScale -= new Vector3(0.1f, 0, 0);
        }
    }
    void Update()
    {
        if (Viata <= 0)
        {
            pierdut = true;
            lost.SetActive(true);
        }    
    }
}
