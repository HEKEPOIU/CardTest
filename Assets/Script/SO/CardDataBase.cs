using UnityEngine;
using UnityEngine.Serialization;

namespace SO
{
    [CreateAssetMenu(fileName = "CardDataBase", menuName = "CardDataBase")]
    public class CardDataBase : ScriptableObject
    {
        public Sprite CardSprite;
        public string CardName;
        public string CardDescription;
        public CardAbility[] CardAbility;
        
        public void UseAbility(Actor self , Actor target)
        {
            foreach (CardAbility ability in CardAbility)
            {
                ability.UseAbility(self, target);
            }
        }
    }

}
