using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonScript : EnemyBase
{
    public override void AttackPlayer()
    {
        print("Dragon is attacking player");
    }
    void Update()
    {
        AttackPlayer();
    }
}
