using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_run : StateMachineBehaviour
{   Transform player;
    Rigidbody2D rb;
    public float speedB;
    LookAtplayer boss;
    public float attackRange;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
      player = GameObject.FindGameObjectWithTag("Player").transform;
      rb = animator.GetComponent<Rigidbody2D>();
      boss = animator.GetComponent<LookAtplayer>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {boss.Lookplayer();
     Vector2 target= new Vector2(player.position.x,rb.position.y);
     Vector2 newPos = Vector2.MoveTowards(rb.position,target,speedB * Time.fixedDeltaTime);
     rb.MovePosition(newPos);
     if (Vector2.Distance(player.position,rb.position)<=attackRange)
     {
       animator.SetTrigger("Attack");
     }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
      animator.ResetTrigger("Attack");
    }
}
