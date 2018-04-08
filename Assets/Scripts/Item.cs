using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Items { Key1, Key2, Dick, InvisibleKey, InvisibleKey2, Battery, PowerOn };
public class Item :MonoBehaviour{
    

    public Items item;

     [TextArea(3,10)]
    public string desc = "Test";
	
}
