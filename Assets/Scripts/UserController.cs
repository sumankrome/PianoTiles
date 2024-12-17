using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class UserController : MonoBehaviour
{
    [SerializeField] public List<GameObject> userKeys;
    public SpawnerController spawnerController;

    private List<SpriteRenderer> spriteRenderers = new List<SpriteRenderer>();
    public GameObject[] tileInKey = new GameObject[5];
    public GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        foreach(var userKey in userKeys)
        {
            spriteRenderers.Add(userKey.GetComponent<SpriteRenderer>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        resetColor();

        if (Input.GetKey(KeyCode.Z)){
            spriteRenderers[0].color = Color.grey;
            if (tileInKey[0] != null){
                Destroy(tileInKey[0]);
                tileInKey[0] = null;
                gameController.points+=2;
            }
        }
        if (Input.GetKey(KeyCode.X)){
            spriteRenderers[1].color = Color.grey;
            if (tileInKey[1] != null){
                Destroy(tileInKey[1]);
                tileInKey[1] = null;
                gameController.points+=2;
            }
        }
        if (Input.GetKey(KeyCode.C)){
            spriteRenderers[2].color = Color.grey;
            if (tileInKey[2] != null){
                Destroy(tileInKey[2]);
                tileInKey[2] = null;
                gameController.points+=2;
            }
        }
        if (Input.GetKey(KeyCode.V)){
            spriteRenderers[3].color = Color.grey;
            if (tileInKey[3] != null){
                Destroy(tileInKey[3]);
                tileInKey[3] = null;
                gameController.points+=2;
            }
        }
        if (Input.GetKey(KeyCode.B)){
            spriteRenderers[4].color = Color.grey;
            if (tileInKey[4] != null){
                Destroy(tileInKey[4]);
                tileInKey[4] = null;
                gameController.points+=2;
            }
        }
    }

    private void resetColor(){
        spriteRenderers[0].color = Color.white;
        spriteRenderers[1].color = Color.black;
        spriteRenderers[2].color = Color.white;
        spriteRenderers[3].color = Color.black;
        spriteRenderers[4].color = Color.white;
    }
}
