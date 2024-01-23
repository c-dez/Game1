using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
   CharacterController playerInput;
   private void Start()
   {
    playerInput = GetComponent<CharacterController>();
   }

   private void Update()
   {
    
   }
}
