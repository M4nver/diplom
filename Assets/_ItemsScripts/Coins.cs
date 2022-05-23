using UnityEngine;
using System;
public class Coins : MonoBehaviour
{
    public static event Action<int> isCoinUpdateAction;
    public int _numberOfCoin;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            CoinUpdate();
            Destroy(gameObject);
        }
    }

    public void CoinUpdate() => isCoinUpdateAction?.Invoke(_numberOfCoin);
}