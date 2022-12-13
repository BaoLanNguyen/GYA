using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : MonoBehaviour
{
    [SerializeField] private float attackCD;
    [SerializeField] private int damage;
    [SerializeField] private BoxCollider2D boxCollider;
    private float CDTimer = Mathf.Infinity;

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
        return false;
    }
}


