using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gridObject;
    private bool isActive = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && isActive)
        {
            gridObject.SetActive(false);
            isActive = false;
        } else if (Input.GetKeyDown(KeyCode.Tab) && !isActive)
        {
            gridObject.SetActive(true);
            isActive = true;
        }
    }
}
