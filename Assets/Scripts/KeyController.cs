using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    public UserController userController;
    public GameController gameController;
    private void OnTriggerEnter2D(Collider2D other){
        userController.tileInKey[Int32.Parse(gameObject.name)] = other.gameObject;
    }

    private void OnTriggerExit2D(Collider2D other){
        userController.tileInKey[Int32.Parse(gameObject.name)] = null;
        Destroy(other.gameObject);
        gameController.points--;
        Debug.Log("Minus");
    }
}
