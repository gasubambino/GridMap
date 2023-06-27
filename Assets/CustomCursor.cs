using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCursor : MonoBehaviour
{
    public Sprite[] sprites;
    [SerializeField] private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePosition;
        if (Mouse.objSelected == 1)
        {
            spriteRenderer.sprite = sprites[0];
        } else if (Mouse.objSelected == 2)
        {
            spriteRenderer.sprite = sprites[1];
        } else if (Mouse.objSelected == 3)
        {
            spriteRenderer.sprite = sprites[2];
        }
    }
}
