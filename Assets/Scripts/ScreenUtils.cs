using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScreenUtils
{

    //region fields
    //saved to support resolution changes
    static int screenWidth;
    static int screenHeight;

    //cached for efficient boundary checking
    static float screenLeft;
    static float screenRight;
    static float screenTop;
    static float screenBottom;

    public static float ScreenLeft
    {
        get { return screenLeft; }
    }
    public static float ScreenRight
    {
        get { return screenRight; } 
    }
    public static float ScreenTop
    {
        get { return screenTop; }
    }
    public static float ScreenBottom
    {
        get { return screenBottom; }
    }

    public static void initialize()
    {
        float screenZ = -Camera.main.transform.position.z;
        Vector3 lowerLeftCornerScreen = new Vector3(0, 0, screenZ);
        Vector3 lowerLeftCornerWorld = Camera.main.ScreenToWorldPoint(lowerLeftCornerScreen);
        Vector3 topRightCornerScreen = new Vector3(Screen.width, Screen.height, screenZ);
        Vector3 topRightCornerWorld = Camera.main.ScreenToWorldPoint(topRightCornerScreen);

        screenLeft = lowerLeftCornerWorld.x;
        screenRight = topRightCornerWorld.x;
        screenTop = topRightCornerWorld.y;
        screenBottom = lowerLeftCornerWorld.y;
    }
}
