using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] private Transform leftEdge;
    [SerializeField] private Transform rightEdge;
    [SerializeField] private Transform enemy;
    [SerializeField]private float speed;
    private Vector3 InScale;
    private bool MovingLeft;
    private void Awake() {
        InScale = enemy.localScale;
    }
    private void Update() {
        if (MovingLeft)
        {    if(enemy.position.x >= leftEdge.position.x) 
             MoveInDirection(-1);
             else
             DirectionChange();
        }
        else
        {
            if(enemy.position.x <= rightEdge.position.x)
            MoveInDirection(1);
            else
            DirectionChange();
        }
    }
   private void DirectionChange()
   {
    MovingLeft= !MovingLeft;
   }
   private void MoveInDirection( int _direction)
    {        enemy.localScale = new Vector3(Mathf.Abs(InScale.x) * - _direction,InScale.y,InScale.z);
             enemy.position = new Vector3(enemy.position.x + Time.deltaTime* _direction* speed, enemy.position.y, enemy.position.z);
    }
}
