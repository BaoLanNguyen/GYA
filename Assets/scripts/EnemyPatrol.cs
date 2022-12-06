using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
   [SerializeField] private Transform leftEdge;
   [SerializeField] private Transform rightEdge;
   [SerializeField] private Transform enemy;
   [SerializeField] private float speed;
   private Vector3 InScale;
   private void Awake() {
    
   }
   private void Update()
   {
    MoveInDirection(1);
   }
   private void MoveInDirection(int _direction)
   {
    enemy.position=new Vector3(enemy.position.x + Time.deltaTime * _direction* speed, enemy.position.y, enemy.position.z);
   }
}
