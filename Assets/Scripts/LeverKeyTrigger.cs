using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverKeyTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject _keySpawn;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "LeverOne" && other.tag == "LeverTwo")
        {
            Debug.Log("LeverOne and LeverTwo have triggered");
            _keySpawn.SetActive(true);
        }
    }
}
