using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PegarObjeto : MonoBehaviour
{
    public float distanceLimit = 1f;
    public Text Mochila;
    public double contador_seg;
    public double contador;
    public GameObject stand;
    public GameObject player;
    // Start is called before the first frame update
    public void Start()
    {
        contador_seg = 0;
    }
    // Update is called once per frame
    public void Update()
    {
        if (Vector3.Distance(stand.transform.position, player.transform.position) < distanceLimit) {
            contador_seg = contador_seg + 0.001;
            if(contador_seg >= 0.5){
                contador_seg = 0;
                contador += 100;
                Mochila.text = "Poções:" + contador + "ML";
            }
            
        }
    }

    public double getPocao(){
        return contador;
    }

    public void setPocao(){
        contador = contador - 5;
        Mochila.text = "Poções:" + contador + "ML";
    }


}
