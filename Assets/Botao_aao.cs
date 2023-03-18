using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
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
            if(Input.GetMouseButtonDown (0)){
                GetComponent<Light> ().enabled = !GetComponent<Light> ().enabled;
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
