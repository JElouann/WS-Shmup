using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollingBackground : MonoBehaviour
{
    [SerializeField] private RawImage background;
    [SerializeField] private float _x;
    [SerializeField] private float _y;


    // Update is called once per frame
    void Update()
    {
        background.uvRect = new Rect(background.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, background.uvRect.size);
    }
}
