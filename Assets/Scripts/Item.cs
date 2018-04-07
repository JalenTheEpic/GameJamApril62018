using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item :MonoBehaviour{
    public enum Items { Key1, Key2, Dick };

    public Items item;

     [TextArea(3,10)]
    public string desc = "Test";
	
}
