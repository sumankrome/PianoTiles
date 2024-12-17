using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float points;
    [HideInInspector] public List<bool> inZones;
    public UserController userController;
    public SpawnerController spawnerController;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        inZones = new List<bool>(new bool[userController.spriteRenderers.Count]);
    }

    // Update is called once per frame
    void Update()
    {
        clickTiles();
    }

    private void clickTiles(){
        for (int i = 0; i < inZones.Count; i++){
            if (inZones[i] && Input.GetKey(KeyCode.Z)){
                inZones[i] = false;
                points+=1;
                // Debug.Log("Nice! " + points);
                spawnerController.DestroyTile();
            }
        }
    }
}
