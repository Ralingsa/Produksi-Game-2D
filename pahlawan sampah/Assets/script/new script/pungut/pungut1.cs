using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pungut1 : MonoBehaviour
{
    public GameObject[] organik;
    public GameObject[] anorganik;
    private int sampah;
    
    // Start is called before the first frame update
    void Start()
    {
        sampah = 0;
    }

    // Update is called once per frame
    void Update()
    {
        while (sampah <= 15)
        {
            spawnSampahOrganik();
            spawnSampahAnorganik();
        }
    }

    public void spawnSampahOrganik()
    {
        int index = Random.Range(0, organik.Length);
        Instantiate(organik[index], new Vector2(Random.Range(-8f, 8f), Random.Range(-1.5f, -5f)), transform.rotation);
        sampah++;
    }

    public void spawnSampahAnorganik()
    {
        int index = Random.Range(0, anorganik.Length);
        Instantiate(anorganik[index], new Vector2(Random.Range(-8f, 8f), Random.Range(-1.5f, -5f)), transform.rotation);
        sampah++;
    }
}
