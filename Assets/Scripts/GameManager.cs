using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject player;
   public Material blue;
    // Use this for initialization
    private static int ArohaMax;
    private static int ArohaCount;
    private static bool gameStart;
	void Start () {
        ArohaMax = 5;
        ArohaCount = 0;
        gameStart = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (ArohaCount==ArohaMax)
        {
            player.GetComponent<SkinnedMeshRenderer>().material = blue;
            ArohaMax++;
            gameStart = true;
        }
        if (!gameStart&&player.transform.parent.transform.parent.transform.position.y <= 30)
        {
            player.transform.parent.transform.parent.transform.position = new Vector3(238,90,207);
        }
	}
    public static void ArohaGet()
    {
        ArohaCount++;
    }
}