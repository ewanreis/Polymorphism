using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public virtual void AttackPlayer()
    {
        print("Enemy is attacking Player");
    }
}
