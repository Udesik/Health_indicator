using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealButton : ActionButton
{
    protected override void PerformAction() => Health.ApplyHeal(Amount);
}
