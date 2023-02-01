using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StandController : MonoBehaviour
{
     public float distanceLimit = 1f;
     public GameObject Stand_Helth;
     public GameObject player;
     public Text Mochila;
     public int contador;
     public GameObject fox;
    // Start is called before the first frame update
    void Start()
    {
        fox = GameObject.Find("Fox");
        contador = 0;
    }

    private void onTriggerEnter(){
        
    }
    // Update is called once per frame
    void Update()
    {
         if (Vector3.Distance(Stand_Helth.transform.position, player.transform.position) < distanceLimit) {
            Mochila.text = "Poções : " + contador;
        }
        if (Vector3.Distance(fox.transform.position, player.transform.position) < distanceLimit) {
            contador = contador + 1;
            Mochila.text = "Poções : " + contador;
        }
    }
}
