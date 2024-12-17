using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class UserController : MonoBehaviour
{
    [SerializeField] public List<SpriteRenderer> spriteRenderers;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        changeColor();
    }

    private void changeColor(){
        spriteRenderers[0].color = Color.white;
        spriteRenderers[1].color = Color.black;
        spriteRenderers[2].color = Color.white;
        spriteRenderers[3].color = Color.black;
        spriteRenderers[4].color = Color.white;
        
        if (Input.GetKey(KeyCode.Z)){
            spriteRenderers[0].color = Color.grey;
        }
        if (Input.GetKey(KeyCode.X)){
            spriteRenderers[1].color = Color.grey;
        }
        if (Input.GetKey(KeyCode.C)){
            spriteRenderers[2].color = Color.grey;
        }
        if (Input.GetKey(KeyCode.V)){
            spriteRenderers[3].color = Color.grey;
        }
        if (Input.GetKey(KeyCode.B)){
            spriteRenderers[4].color = Color.grey;
        }
    }    
}
