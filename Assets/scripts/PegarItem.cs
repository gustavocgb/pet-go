using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarItem : MonoBehaviour
{
	public Transform mao;


    private void OnCollisionEnter(Collision col) {
            if(col.gameObject.tag == "pet") {
                col.gameObject.GetComponent<Rigidbody>().isKinematic = true;
		        col.gameObject.GetComponent<BoxCollider>().enabled = false;
                col.transform.position = mao.position;
		        col.transform.rotation = mao.rotation;
		        col.transform.SetParent(mao);
            }
    }
}