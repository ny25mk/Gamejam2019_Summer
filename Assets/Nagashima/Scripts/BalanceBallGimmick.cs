﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalanceBallGimmick : BaseGimmick
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        base.OnUpdate();

    }

    /// <summary>
    /// 左方向へ直進する
    /// </summary>
    protected override void Move()
    {

        transform.Translate(-0.05f, 0.0f, 0.0f);

    }

}
