using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : MonoBehaviour
{
    [SerializeField] private float attackCD;
    [SerializeField] private int damage;
    [SerializeField] private BoxCollider2D boxCollider;
    private float CDTimer = Mathf.Infinity;
    [SerializeField] private LayerMask playerLayer;

    private void Update() {
        CDTimer += Time.deltaTime;
        if (PlayerInSight()){
            if (CDTimer >= attackCD)
        {
            
        }
    }
    }
    private bool PlayerInSight()
    {
        RaycastHit2D hit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.left, 0, playerLayer);
        return hit.collider != null;
    }
}


