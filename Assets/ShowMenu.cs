using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.UI;

public class ShowMenu : MonoBehaviour
{
    [SerializeField] private GameObject musicMenu;
    bool show;

    private void Start()
    {
        musicMenu.SetActive(false);
    }
    public void Show()
    {
        show = !show;
        
            musicMenu.SetActive(show);
            show = true;
       
            musicMenu.SetActive(show);
            show = false;
        
    }
}
