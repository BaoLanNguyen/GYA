using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    [SerializeField] private float attackCD;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] shots;
    private PlayerController playermovement;
    private float CDtimer = Mathf.Infinity;
    // Start is called before the first frame update
    void Start()
    {
        playermovement = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && CDtimer > attackCD)
        {
            Attack();
        }
        CDtimer += Time.deltaTime;
    }
    public void Attack(){
        CDtimer = 0;
        shots[0].transform.position = firePoint.position;
        shots[0].GetComponent<Projectile>().SetDirection(Mathf.Sign(transform.localScale.x));
    }
}
