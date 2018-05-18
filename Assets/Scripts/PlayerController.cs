using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

   private float maxSpeed = 5;

   void Start() {

   }

   void Update() {
      float xVel = 0f;
      float yVel = 0f;

      if (Input.GetKey(KeyCode.A)) {
         xVel -= maxSpeed;
      }
      if (Input.GetKey(KeyCode.W)) {
         yVel += maxSpeed;
      }
      if (Input.GetKey(KeyCode.D)) {
         xVel += maxSpeed;
      }
      if (Input.GetKey(KeyCode.S)) {
         yVel -= maxSpeed;
      }

      GetComponent<Rigidbody2D>().velocity = new Vector2(xVel, yVel);
   }
}
