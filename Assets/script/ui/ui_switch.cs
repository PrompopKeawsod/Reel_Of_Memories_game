using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ui_switch : MonoBehaviour
{
    public List<GameObject> game_ui = new List<GameObject>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        change_UI(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void change_UI(int num)
    {
        for(int i = 0; i < game_ui.Count; i++)
        {
            if(i == num)
            {
                game_ui[i].SetActive(true);
            }
            else
            {
                game_ui[i].SetActive(false);
            }
        }
    }
}
