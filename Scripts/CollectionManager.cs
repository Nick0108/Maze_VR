using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionManager : MonoBehaviour {

    public int CoinNum = 0;
    public bool isKey = false;
    public Text CollectionText;
    public Text CollectionText2;

    // Update is called once per frame
    void Update () {
        CollectionText2.text = CollectionText.text = "Coins Number : "+ (CoinNum.ToString()) +"/10\nGetKey: "+ (isKey.ToString());
    }
}
