using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoltarPet : MonoBehaviour
{
    public GameObject caixa;
    public GameObject pet; 

    private void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "boneco") {
            
            caixa = GameObject.FindWithTag("caixa_cheia");
            
            if (caixa != null) {

                pet = GameObject.FindWithTag("pet_na_caixa");
                caixa.gameObject.tag = "caixa_vazia";
                Destroy(pet);
                
            }
        }
    }
}