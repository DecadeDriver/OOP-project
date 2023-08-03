using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRunner : Enemy
{
  protected override void MovingForward()
  {
    transform.Translate(Vector3.forward * Time.deltaTime * speed * 2);
  }
}
