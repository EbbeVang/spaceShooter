﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    private float Speed = 0.5f;

    private Renderer render;

    // Use this for initialization
    void Start()
    {
        render = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(0, Time.time * Speed);
        render.material.mainTextureOffset = offset;
    }
}
