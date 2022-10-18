using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLevelManager : MonoBehaviour
{
    public float Timer = 0.0f;
    public float reachTarget = 1.3f;
    public static float increaseRate = 0.0027f;
    public float reduceTotalWater = 0.4f;
    public float currentY = 0.5f;
    //public Vector3 transformY = new Vector3(0, 0.0027f, 0);
    public static Vector3 transformY = new Vector3(-11f, 0.5f, 60.9f);
    private void Update()
    {
        Timer += Time.deltaTime;
        Debug.Log(Timer); 
        if(Timer >= 1.0f)
        {
            Timer = 0.0f;
            transformY.y += increaseRate;
            this.transform.position = transformY;
            //Debug.Log(transformY);
        }

    }

    public void AddTime()
    {
        
        transformY.y -= reduceTotalWater;
        if(transformY.y < 0.5f)
        {
            transformY.y = 0.5f;
        }
        this.transform.position = transformY;
    }
}
