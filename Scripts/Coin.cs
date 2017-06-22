using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public ParticleSystem CoinPoofPrefab;
    public CollectionManager collectionManager;

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        Instantiate(CoinPoofPrefab,transform.position, CoinPoofPrefab.transform.rotation);
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
        collectionManager.CoinNum+=1;
        Destroy(gameObject);
    }
}
