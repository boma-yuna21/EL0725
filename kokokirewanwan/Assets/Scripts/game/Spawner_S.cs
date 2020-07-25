using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_S : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int t = System.DateTime.Now.Millisecond;
        Debug.Log("Seed : " + t);
        Random.InitState(t);
        CreateObject();
    }

    // Update is called once per frame
    void Update()
    {
        time_ += Time.deltaTime;
        if(time_>spawnRate)
        {
            CreateObject();
            time_ = 0.0f;
        }
        
        
    }

    void CreateObject()
    {
        int width = Random.Range(0, (int)area.width) - (int)area.width / 2;
        int height = Random.Range(0, (int)area.height)- (int)area.height / 2;
        GameObject gameObject = Instantiate(spawnObject[0], new Vector3(width, height, 0), Quaternion.identity);
    }

    private float time_ = 0;
    [SerializeField] private float spawnRate = 1.0f;
    [SerializeField] private int maxSpawn = 10;
    [SerializeField] private Rect area = new Rect(0.0f, 0.0f, 1920.0f, 1080.0f);
    [SerializeField] private GameObject[] spawnObject;


}
