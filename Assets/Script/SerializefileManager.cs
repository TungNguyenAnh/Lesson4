using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class SerializefileManager : MonoBehaviour
{
    // public float nextTime = 0;
    // public GameObject prefab;
    [HideInInspector]
    public int valueTemp = 5;
    [SerializeField]
    private int privateValue = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time);

        // if (Input.GetButton("Fire1") && Time.time > nextTime)
        // {
        //     nextTime = Time.time + 0.5f;
        //     Debug.Log(nextTime);
        //     Instantiate(prefab, new Vector3(Random.RandomRange(0, 100), 0, 0), Quaternion.identity)
        // }

        // if (Input.GetButton("Fire1"))
        // {
        //     Debug.Log("Fire1");
        // }
        // if (Input.GetButton("Fire2"))
        // {
        //     Debug.Log("Fire2");
        // }
        // if (Input.GetButton("Fire3"))
        // {
        //     Debug.Log("Fire3");
        // }

        // if (Input.GetMouseButtonDown(0))
        // {
        //     Debug.Log("hehe");
        // }
        // if (Input.GetMouseButtonDown(1))
        // {
        //     Debug.Log("huhu");
        // }
    }
}
