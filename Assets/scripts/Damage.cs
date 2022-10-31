using UnityEngine;

public class Damage : MonoBehaviour
{
    private int damage = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player"){
            collision.GetComponent<Health>().takeDamage(damage);
        }
    }

}
