using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
   CharacterController cc;
   [SerializeField] private float moveSpeed;
   private void Start()
   {
    cc = GetComponent<CharacterController>();
   }

   private void Update()
   {
    Vector3 playerInput = new Vector3(Input.GetAxis("Horizontal"),
    0,Input.GetAxis("Vertical"));

    playerInput = Vector3.ClampMagnitude(playerInput, 1);
    cc.Move(playerInput * moveSpeed * Time.deltaTime);
    // Debug.Log(playerInput);
    


   }
}
