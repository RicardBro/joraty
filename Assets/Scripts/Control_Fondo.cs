using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control_Fondo : MonoBehaviour {

    public Sprite [] frames;
    public int fps = 5;
    

    void Start () {
      
    }
	
	
	void Update () {
        int index = (int)(Time.time * fps) % frames.Length;
        GetComponent<Image>().sprite = frames[index]; 
	}
}
