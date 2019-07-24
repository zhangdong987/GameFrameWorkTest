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
using GameFramework.DataTable;
using GameFramework;
using System.IO;

public class DRTest : IDataRow
{
    public int Id
    {
        get;
        protected set;
    }
    public string Name { get; private set; }
    public int Atk { get; private set; }

    public bool ParseDataRow(GameFrameworkSegment<string> dataRowSegment)
    {
        throw new System.NotImplementedException();
    }

    public bool ParseDataRow(GameFrameworkSegment<byte[]> dataRowSegment)
    {
        throw new System.NotImplementedException();
    }

    public bool ParseDataRow(GameFrameworkSegment<Stream> dataRowSegment)
    {
        throw new System.NotImplementedException();
    }
}