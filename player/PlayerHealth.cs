using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float playerBaseHealth = 100f;
    [SerializeField] private float playerMaxHealtMod = 1f;
    private float playerMaxHealth;
    private float playerCurrentHealth;
    void Start()
    {
        playerMaxHealth = playerBaseHealth * playerMaxHealtMod;
        playerCurrentHealth = playerMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
