using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageButton : ActionButton
{
    protected override void PerformAction() => Health.TakeDamage(Amount);
}
