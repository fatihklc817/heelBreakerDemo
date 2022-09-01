using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heelManager : CustomBehaviour
{
    public heelBehaviour[] _heeelBehaviours;

    public override void Initialize(GameManager gameManager)
    {
        base.Initialize(gameManager);
        for (int i = 0; i < _heeelBehaviours.Length; i++)
        {
            _heeelBehaviours[i].Initialize(this);
        }
    }





}
