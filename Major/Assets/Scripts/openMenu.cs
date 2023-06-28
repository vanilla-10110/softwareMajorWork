using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class openMenu : MonoBehaviour
{
    public GameObject gameplayCanvas;
    public GameObject accessibilityCanvas;
    public GameObject audioCanvas;

    public Button gameplayButton;
    public Button accessibilityButton;
    public Button audioButton;

    private void Start()
    {
        gameplayButton.onClick.AddListener(TaskOnClick);
    }

     void TaskOnClick()
    {
        gameplayCanvas.SetActive(!gameplayCanvas.activeSelf);
    }

    private void Update()
    {
        if(gameplayButton.)
    }

}
