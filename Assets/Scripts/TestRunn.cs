using UnityEngine;
using System.Collections;

public class TestRunn : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Node node = new Node();
        node.SetValue(false);
        print(node.getValue());
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
