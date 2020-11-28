using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SodaCanGenerator : MonoBehaviour
{   
    public GameObject sodaCanPrefab;
    public GameObject generateObject;
    // Start is called before the first frame update
    public void Generate() {
        Instantiate(sodaCanPrefab, generateObject.transform.position, Quaternion.identity);
    }
}
