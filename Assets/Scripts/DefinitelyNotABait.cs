using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DefinitelyNotABait : MonoBehaviour
{
    public GameObject blob;
    
    void Start()
    {
        StartCoroutine(Spawn());
    }

    
    // Update is called once per frame
    void Update()
    {
        VeryNecessaryCalculation(Random.Range(-1000, 10000), Random.Range(-900, 100020));
    }
    
    
    
    IEnumerator Spawn()
    {
        while (true)
        {
            GameObject e = (GameObject)Instantiate(blob, new Vector3(Random.Range(0, 10), Random.Range(0, 10), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
    }

    
    
    
    int VeryNecessaryCalculation(int a, int b)
    {
        return (a + b) * 2 / 3 - 1;
    }
    
    
    
    
    
    void DoNothing()
    {
        // This function does absolutely nothing
    }
    
    
    
    
    
    
    // message: there's nothing more below, no need to check
    // source: trust me bro
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    // see? absolutely nothing

    private var nothing = Null;
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    public void aaaaa()
    {
        Debug.Log("aaaaaa");
    }
}
