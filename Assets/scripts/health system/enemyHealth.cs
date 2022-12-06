using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    private bool isDead;
    public float currentHealth{
        get;
        private set;
    }
    private Animator anim;
    [SerializeField] private float iFramesDuration;
    [SerializeField] private int numberOfFlashes;
    private SpriteRenderer spriterend;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        spriterend = GetComponent<SpriteRenderer>();
       
    }
    public void takeDamage(float damage){
        currentHealth = Mathf.Clamp(currentHealth - damage, 0, startingHealth);
        if (currentHealth > 0)
        {
            StartCoroutine(Invulnerability());
        }
        else if (currentHealth == 0 && !isDead)
        {   isDead=true;
            anim.SetTrigger("die");
            ScoreCounter.scoreValue += 10;
        }
    }
    public void die(){
        GameObject.Destroy(gameObject);
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
    private IEnumerator Invulnerability(){
        Physics2D.IgnoreLayerCollision(7, 8, true);
        for (int i = 0; i < numberOfFlashes; i++)
        {
            spriterend.color = new Color(1,0,0,0.5f);
            yield return new WaitForSeconds(iFramesDuration / (numberOfFlashes * 2));
            spriterend.color = Color.white;
            yield return new WaitForSeconds(iFramesDuration / (numberOfFlashes * 2));
        }
        Physics2D.IgnoreLayerCollision(7, 8, false);
    }

}

