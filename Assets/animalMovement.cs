using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalMovement : MonoBehaviour
{     
     private Animator anim;

     void Start() 
     {
          anim = gameObject.GetComponent<Animator>();
     }

     void Update() 
     {
          if (anim.GetBool("walk")) {
               transform.Translate(0, 0, Time.deltaTime * 0.5f); // move forward
               transform.Rotate(0, Time.deltaTime * 20f, 0); // turn a little
          }
     }
}
