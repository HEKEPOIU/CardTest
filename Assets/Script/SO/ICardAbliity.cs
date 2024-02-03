using UnityEngine;

namespace SO
{

    public abstract class CardAbility : ScriptableObject
    {
       public abstract void UseAbility(Actor self , Actor target);
    }
}