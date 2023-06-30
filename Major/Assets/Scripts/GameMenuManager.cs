using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameMenuManager : MonoBehaviour
{
    GameObject menu;
    public InputActionProperty showButton;

    public GameObject optionsMenu;
    public GameObject gameplayOptions;
    public GameObject accessibilityOptions;
    public GameObject audioOptions;

    public Button gameplayButton;
    public Button accessibilityButton;
    public Button audioButton;


    private void Start()
    {
        menu = optionsMenu;

        gameplayButton.onClick.AddListener(activateGameplayOptions);
        accessibilityButton.onClick.AddListener(activateAccessibilityOptions);
        audioButton.onClick.AddListener(activateAudioOptions);
    }

    void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            if (menu == gameplayOptions || menu == accessibilityOptions || menu == audioOptions)
            {
                menu.SetActive(!menu.activeSelf);
                menu = optionsMenu;
            }
            else
            {
                menu.SetActive(!menu.activeSelf);
            }
        }
    }

    void activateGameplayOptions()
    {
        menu = gameplayOptions;
        optionsMenu.SetActive(false);
    }

    void activateAccessibilityOptions()
    {
        menu = accessibilityOptions;
        optionsMenu.SetActive(false);
        accessibilityOptions.SetActive(true);
    }

    void activateAudioOptions()
    {
        menu = audioOptions;
        optionsMenu.SetActive(false);
        audioOptions.SetActive(true);
    }
}
    


