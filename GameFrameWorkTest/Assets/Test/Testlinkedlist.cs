using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Testlinkedlist : MonoBehaviour {

	// Use this for initialization
	void Start () {
        LinkedList<int> llist = new LinkedList<int>();
        var node1=llist.AddFirst(1);
        llist.AddLast(2);
        llist.AddAfter(node1,3);

        Debug.Log(llist.Find(2));

        foreach (var item in llist)
        {
            Debug.Log(item);
        }
	}

}
