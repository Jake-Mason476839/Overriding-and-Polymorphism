using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcScript : EnemyBase
{
    public void Update()
    {
        AttackPlayer();
    }

    public override void AttackPlayer()
    {
        print("Orc is attacking player");
    }
}
