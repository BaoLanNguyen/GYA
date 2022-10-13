using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth{
        get;
        private set;
    }
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
    }
    public void takeDamage(float damage){
        currentHealth = Mathf.Clamp(currentHealth - damage, 0, startingHealth);
        if (currentHealth >0)
        {
            
        }
        else
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            takeDamage(1);
        }
    }
}
