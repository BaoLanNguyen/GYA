using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : MonoBehaviour
{
    [SerializeField] private float attackCD;
    [SerializeField] private float range;
    [SerializeField] private float colliderDistance;
    [SerializeField] private int damage;
    [SerializeField] private BoxCollider2D boxCollider;
    private float CDTimer = Mathf.Infinity;
    [SerializeField] private LayerMask playerLayer;
    private Animator anim;
    private void Awake() {
        anim = GetComponent<Animator>();
    }
    private void Update() {
        CDTimer += Time.deltaTime;
        if (PlayerInSight()){
            if (CDTimer >= attackCD)
        {
            CDTimer = 0;
            anim.SetTrigger("meleeAttack");
        }
    }
    }
    private bool PlayerInSight()
    {
        RaycastHit2D hit = Physics2D.BoxCast(boxCollider.bounds.center + transform.right*range*transform.localScale.x*colliderDistance, new Vector3(boxCollider.bounds.size.x * range, boxCollider.bounds.size.y, boxCollider.bounds.size.z), 0, Vector2.left, 0, playerLayer);
        return hit.collider != null;
    }
    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(boxCollider.bounds.center + transform.right*range*transform.localScale.x*colliderDistance, new Vector3(boxCollider.bounds.size.x * range, boxCollider.bounds.size.y, boxCollider.bounds.size.z));
    }
    private void DamagePlayer(){
        if (PlayerInSight()){
            
        }
    }
}


