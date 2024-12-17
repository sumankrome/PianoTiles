using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.Mathematics;

public class SpawnerController : MonoBehaviour
{
    public GameController gameController;
    public GameObject tilesPrefab;
    public float tileSpeed = 4;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTiles());
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other){
        gameController.inZones[Int32.Parse(other.gameObject.name)] = true;
    }

    private void OnTriggerExit2D(Collider2D other){
        gameController.inZones[Int32.Parse(other.gameObject.name)] = false;
        gameController.points-=1;
    }

    public void DestroyTile(){
        Debug.Log(gameObject);
    }

    IEnumerator SpawnTiles()
    {
        while(true){
            GameObject newObject = tilesPrefab;
            var a = Instantiate(newObject, generateSpawnPosition(), new Quaternion(), gameObject.transform);
            a.GetComponent<Rigidbody2D>().velocity = Vector2.down * tileSpeed;
            yield return new WaitForSeconds(2f);
        }
    }

    private Vector3 generateSpawnPosition(){
        var random = new System.Random();
        var list = new List<float>{-2.2f, -1.1f, 0f, 1.1f, 2.2f};
        int index = random.Next(list.Count);
        Debug.Log(new Vector2(list[index], 3.5f));
        return new Vector3(list[index], 6f, 1);
    }

    class Tiles{
        public int index;
        public bool inZone;
        
    }
}
