using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLimit3 : MonoBehaviour
{

    public Text TimeText;

    // Start is called before the first frame update
    void Start()
    {
       
    }


    // Update is called once per frame
    void Update()
    {

        TimeText.text = GameControllerr3.Instance.Time.ToString(); 
    }
}