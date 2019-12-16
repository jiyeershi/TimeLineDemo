using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    public Text text;

    public Animator ani;

    public Button contine;
    public PlayableDirector playableDirector;

    private Button skip;

    private bool isOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        contine.onClick.AddListener(OnContine);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnContine()
    {
        Close();
        playableDirector.Resume();
    }

    public void Open()
    {
        if (!isOpen)
        {
            ani.SetTrigger("Open");
            isOpen = true;
        }
    }

    public void Close()
    {
        if (isOpen)
        {
            ani.SetTrigger("Close");
            isOpen = false;
        }
    }

    public void ShowComplete()
    {
        playableDirector.Pause();
    }
}
