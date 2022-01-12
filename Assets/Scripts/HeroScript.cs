using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroScript : HelperBase
{
    public void Update()
    {
        Horizontal();
        Vertical();
        PlayerDamageDisplay();
    }
}
