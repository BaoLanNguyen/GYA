using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtplayer : MonoBehaviour
{
   Transform player;
   bool isFlipped = false;
   public void Lookplayer()
   {
     Vector3 flipped = transform.localScale;
     flipped.z *= -1f;
     if (transform.position.x > player.position.x && isFlipped)
     {
        transform.localScale= flipped;
        transform.Rotate(0f,180f,0f);
        isFlipped = false;
     }
     else if(transform.position.x < player.position.x && !isFlipped)
     {
        transform.localScale =flipped;
        transform.Rotate(0f,180f,0f);
        isFlipped=true;
     }
   }
}
