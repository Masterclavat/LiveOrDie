using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

   void Start() {

   }

   void Update() {
      float xVel = 0f;
      float yVel = 0f;

      if (Input.GetKey(KeyCode.A)) {
         xVel -= 0;
      }
   }
}
