using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_cat : MonoBehaviour
{
    // Start is called before the first frame update
    bool mouseIsIn;
    void Start()
    {
        mouseIsIn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(mouseIsIn == true){
            if(Input.GetMouseButtonDown(0)){
                  GameObject.FindGameObjectWithTag("Cat").GetComponent<Animator> ().enabled = !GameObject.FindGameObjectWithTag("Cat").GetComponent<Animator> ().enabled;
            }
        }
    }

    void onMouseEnter(){
        mouseIsIn = true;
    }

    void onMouseExit(){
        mouseIsIn = false;
    }
}
