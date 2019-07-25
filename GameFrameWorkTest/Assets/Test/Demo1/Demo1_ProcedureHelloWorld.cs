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
using GameFramework;
using GameFramework.Procedure;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;
using UnityEngine;
public class Demo1_ProcedureHelloWorld : ProcedureBase
{
    protected override void OnEnter(ProcedureOwner procedureOwner)
    {
        base.OnEnter(procedureOwner);
        string welcomeMessage = "helloworld";
        Debug.Log(welcomeMessage);
    }
}