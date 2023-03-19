using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarItem : MonoBehaviour
{
	public Transform caixa;

    private void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag == "pet") {
            if (caixa.gameObject.tag == "caixa_vazia") {
                col.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                col.gameObject.GetComponent<BoxCollider>().enabled = false;
                col.transform.position = caixa.position;
                col.transform.rotation = caixa.rotation;
                col.transform.SetParent(caixa);
                caixa.gameObject.tag = "caixa_cheia";
                col.gameObject.tag = "pet_na_caixa";
            }
        }
    }
}