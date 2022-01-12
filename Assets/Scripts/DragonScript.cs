using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonScript : EnemyBase
{
    public void Update()
    {
        AttackPlayer();
    }

    public override void AttackPlayer()
    {
        print("Dragon is attacking player");
    }
}
