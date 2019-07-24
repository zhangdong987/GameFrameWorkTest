/*******************************************************************
* Copyright(c) #YEAR# #COMPANY#
* All rights reserved.
*
* 文件名称: #SCRIPTFULLNAME#
* 简要描述:
* 
* 创建日期: #DATE#
* 作者:     #AUTHOR#
* 说明:  
******************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;

public class Demo2_Controller : MonoBehaviour
{
    public void EnterGame()
    {
        SceneComponent Scene = UnityGameFramework.Runtime.GameEntry.GetComponent<SceneComponent>();
        Scene.LoadScene("Assets/Test/Demo2/Demo2_Game",this);
    }
}