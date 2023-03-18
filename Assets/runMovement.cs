using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runMovement : MonoBehaviour
{     
     private Animator anim;

     void Start() 
     {
          anim = gameObject.GetComponent<Animator>();
     }

     void Update() 
     {
          if (anim.GetBool("walk")) {
               transform.Rotate(0, Time.deltaTime * 180f, 0); // turn a little
          }
     }
}
