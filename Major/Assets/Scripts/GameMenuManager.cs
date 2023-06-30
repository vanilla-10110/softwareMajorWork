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

        //gameplayButton.onClick.AddListener(activateGameplayOptions);
        //accessibilityButton.onClick.AddListener(activateAccessibilityOptions);
        //audioButton.onClick.AddListener(activateAudioOptions);
        gameplayButton.onClick.AddListener(() => switchMenu(gameplayOptions));
        accessibilityButton.onClick.AddListener(() => switchMenu(accessibilityOptions));
        audioButton.onClick.AddListener(() => switchMenu(audioOptions));
    }

    void Update()
    {
        if ((showButton.action.WasPressedThisFrame()) && (menu == gameplayOptions || menu == accessibilityOptions || menu == audioOptions))
        {
            menu.SetActive(!menu.activeSelf);
            menu = optionsMenu;
        }
        else if (showButton.action.WasPressedThisFrame())
        {
            menu.SetActive(!menu.activeSelf);
        }
    }

    /*These three are silly and we should use the bottom one instead. put them all into the one switchMenu() with parameters 
    void activateGameplayOptions()
    {
        menu = gameplayOptions;
        optionsMenu.SetActive(false);
    }

    void activateAccessibilityOptions()
    {
        menu = accessibilityOptions;
        optionsMenu.SetActive(false);
        //accessibilityOptions.SetActive(true);
    }

    void activateAudioOptions()
    {
        menu = audioOptions;
        optionsMenu.SetActive(false);
        //audioOptions.SetActive(true);
    }*/
    void switchMenu(GameObject newMenu)
    {
        menu = newMenu;
        optionsMenu.SetActive(false);
        newMenu.SetActive(true);
    }
}
    


