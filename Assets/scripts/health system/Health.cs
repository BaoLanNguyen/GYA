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
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }
    public void takeDamage(float damage){
        currentHealth = Mathf.Clamp(currentHealth - damage, 0, startingHealth);
        if (currentHealth > 0)
        {
            anim.SetTrigger("hurt");
        }
        else if (currentHealth == 0)
        {
            anim.SetTrigger("die");
            GetComponent<PlayerController>().enabled = false;
        }
    }
    public void addhealth(float value){
        currentHealth = Mathf.Clamp(currentHealth + value, 0, startingHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){
            takeDamage(1);
        }
    }

}
