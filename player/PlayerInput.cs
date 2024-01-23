using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
   CharacterController cc;
   private void Start()
   {
    cc = GetComponent<CharacterController>();
   }

   private void Update()
   {
    Vector3 playerInput = new Vector3(Input.GetAxis("Horizontal"),
    0,Input.GetAxis("Vertical"));
    Debug.Log(playerInput);

   }
}
