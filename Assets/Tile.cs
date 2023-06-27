using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Sprite normalSprite, highlightedSprite;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private GameObject object1Prefab;
    [SerializeField] private GameObject object2Prefab;
    [SerializeField] private GameObject object3Prefab;

    [SerializeField] private GameObject objectsParentGO;

    private bool hasObject;
    private bool mouseOver;
    // Start is called before the first frame update
    void Start()
    {
        objectsParentGO = GameObject.FindGameObjectWithTag("Object Parent");
        
        spriteRenderer.sprite = normalSprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && mouseOver)
        {
            if (!hasObject)
            {
                if (Mouse.objSelected == 1)
                {
                    var obj = Instantiate(object1Prefab, transform.position, Quaternion.identity, objectsParentGO.GetComponent<Transform>());
                    hasObject = true;
                } else if (Mouse.objSelected == 2)
                {
                    Instantiate(object2Prefab, transform.position, Quaternion.identity, objectsParentGO.GetComponent<Transform>());
                    hasObject = true;
                }
                else if (Mouse.objSelected == 3)
                {
                    Instantiate(object3Prefab, transform.position, Quaternion.identity, objectsParentGO.GetComponent<Transform>());
                    hasObject = true;
                }

            }
        }
        if (Input.GetMouseButtonDown(1) && mouseOver)
        {
            //Destroy();
        }
    }

    private void OnMouseOver()
    {
        mouseOver = true;
    }

    void OnMouseEnter()
    {
        spriteRenderer.sprite = highlightedSprite;
    }

    void OnMouseExit()
    {
        spriteRenderer.sprite = normalSprite;
        mouseOver = false;
    }

}
