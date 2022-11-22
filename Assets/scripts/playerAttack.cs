using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    [SerializeField] private float attackCD;
    [SerializeField] private Transform firePoint;
    public GameObject shotPrefab;
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
    private void Attack(){
        CDtimer = 0;
        Instantiate(shotPrefab, firePoint.position, firePoint.rotation);
    }
}
