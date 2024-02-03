using UnityEngine;

namespace SO
{
    [CreateAssetMenu(fileName = "DefanceSo", menuName = "CardAbility/DefanceSo")]
    public class DefanceSo : CardAbility
    {
        public int Defance;
        public override void UseAbility(Actor self, Actor target)
        {
            self.AddDefance(Defance);
        }
    }
}