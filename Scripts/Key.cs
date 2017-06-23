using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    public ParticleSystem KeyPoofPrefab;
    public Door door;
    public CollectionManager collectionManager;
    //Create a reference to the KeyPoofPrefab and Door

    void Update()
	{
        //Not required, but for fun why not try adding a Key Floating Animation here :)
        transform.Rotate(0, 100 * Time.deltaTime, 300 * Time.deltaTime);
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        Instantiate(KeyPoofPrefab, transform.position, KeyPoofPrefab.transform.rotation);
        // Call the Unlock() method on the Door
        door.Unlock();
        collectionManager.isKey = true;
        // Set the Key Collected Variable to true
        // Destroy the key. Check the Unity documentation on how to use Destroy
        Destroy(gameObject);
    }

}
