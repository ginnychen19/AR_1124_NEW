﻿using UnityEngine;
using UnityEngine.XR.ARFoundation;
using System.Collections.Generic;

                         //(套用的原件)
[RequireComponent(typeof(ARRaycastManager))]
public class ARManager : MonoBehaviour
{
    [Header("點擊後要生成的物件")]
    public GameObject OBJ;
    [Header("AR 管理器")]
    public ARRaycastManager arManager;

    private Vector2 pointMouse;
    private List<ARRaycastHit> hits;

    /// <summary>
    /// 點擊
    /// </summary>
    private void Tap()
    {
        // 判斷玩家是否點擊
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            pointMouse = Input.mousePosition;           // 滑鼠座標 = 玩家的滑鼠座標
            print(pointMouse);                          // 輸出座標測試用
        }
        // 判斷射線是否打到物件
        // 生成物件
    }

    private void Update()
    {
        Tap();
    }
}