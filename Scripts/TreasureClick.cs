using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureClick : MonoBehaviour {

    public Transform TreasureTop;
    public GameObject signPostBefore;
    public GameObject signPostAfter;

    private float OpenTreasureTimer= 0.0f;
    private bool isTreasureOpen = false;

    public void OnTreasureClick()
    {
        isTreasureOpen = true;
        signPostBefore.SetActive(false);
        signPostAfter.SetActive(true);
    }
    // Update is called once per frame
    void Update () {
        if (isTreasureOpen)
        {
            if (OpenTreasureTimer < 1.5f)
            {
                TreasureTop.Rotate(50 * Time.deltaTime, 0, 0);
                OpenTreasureTimer += Time.deltaTime;
            }
            
        }
	}
}
