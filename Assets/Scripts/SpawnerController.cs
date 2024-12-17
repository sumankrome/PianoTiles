using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.Mathematics;
using Unity.VisualScripting;

public class SpawnerController : MonoBehaviour
{
    public GameController gameController;
    public GameObject tilesPrefab;
    public float tileSpeed = 4;
    public List<Tiles> tilesList = new List<Tiles>();

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTiles());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator SpawnTiles()
    {
        var index = 0;
        while(true){
            GameObject newObject = tilesPrefab;
            var a = Instantiate(newObject, generateSpawnPosition(), new Quaternion(), gameObject.transform);
            a.name = "Key " + index;
            a.GetComponent<Rigidbody2D>().velocity = Vector2.down * tileSpeed;
            tilesList.Add(new Tiles(a));

            yield return new WaitForSeconds(2f);
            index++;
        }
    }

    private Vector3 generateSpawnPosition(){
        var random = new System.Random();
        var list = new List<float>{-2.2f, -1.1f, 0f, 1.1f, 2.2f};
        int index = random.Next(list.Count);
        return new Vector3(list[index], 6f, -1);
    }

    public class Tiles{
        public Tiles(GameObject gameObject){
            gameObject = this.gameObject;
        }
        public GameObject gameObject;
        public int? inZone = null;
    }
}
