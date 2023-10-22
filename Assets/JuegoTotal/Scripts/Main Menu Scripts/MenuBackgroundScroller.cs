using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuBackgroundScroller : MonoBehaviour
{

    [SerializeField] private RawImage _img1;
    [SerializeField] private float _x, _y; 

    // Update is called once per frame
    void Update()
    {
        _img1.uvRect = new Rect(_img1.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, _img1.uvRect.size);
    }
}
