using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace SO
{
    [CreateAssetMenu(fileName = "DamageSO", menuName = "CardAbility/DamageSO")]
    public class DamageSo : CardAbility
    {
        public int Damage;
        public override void UseAbility(Actor self, Actor target)
        {
            target.TakeDamage(Damage);
        }
    }
}