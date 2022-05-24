using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using System;

public class Testing : MonoBehaviour
{
    [CMSType]
    class Data
    {
        //[CMSField]
        private int data;
    }

    //public class CMSTypeAttribute : Attribute { }
    //public class CMSFieldAttribute : Attribute { }

}
