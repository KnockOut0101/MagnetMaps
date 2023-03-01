using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Waypoints : MonoBehaviour
{
    public Image img;
    public Transform target;

    private void Update()
    {
        float minX = img.GetPixelAdjustedRect().width/2;
        float maxX = Screen.width - minX;

        float minY = img.GetPixelAdjustedRect().height/2;
        float maxY = Screen.height - minY;

        Vector2 position = Camera.main.WorldToScreenPoint(target.position);

        position.x = Mathf.Clamp(position.x, minX, maxX);
        position.y = Mathf.Clamp(position.y, minY, maxX);

        img.transform.position = position;
    }
}
