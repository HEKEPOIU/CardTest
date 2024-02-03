using System;
using SO;
using UnityEngine;

public class Actor : MonoBehaviour
{
    [SerializeField] private CardDataBase _cardData;
    [SerializeField] private Actor _target;

    private void Start()
    {
        _cardData.UseAbility(this, _target);
    }


    public void TakeDamage(int damage)
    {
        print(name +" :take"+ damage);
    }
    public void AddDefance(int defance)
    {
        print(name +" :add"+ defance);
    }
}