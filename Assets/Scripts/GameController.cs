using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public float points;
    public SpawnerController spawnerController;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        clickTiles();
        gameObject.GetComponentInChildren<Text>().text = "Score: " + points;
    }

    private void clickTiles(){
    }
}
