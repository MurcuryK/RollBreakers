using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    public GameObject [] CharacterSelection;
    public GameObject Character_Panels;
    // Start is called before the first frame update
    void Start()
    {
        CharacterSelection[0].SetActive(false);
        CharacterSelection[1].SetActive(false);
        CharacterSelection[2].SetActive(false);
    }


    public void SelectNecromancer()
    {

        CharacterSelection[0].SetActive(true);
        CharacterSelection[1].SetActive(false);
        CharacterSelection[2].SetActive(false);
        Character_Panels.SetActive(false);

    }

    public void SelectPaladin()
    {
        CharacterSelection[0].SetActive(false);
        CharacterSelection[1].SetActive(true);
        CharacterSelection[2].SetActive(false);
        Character_Panels.SetActive(false);
    }

    public void SelectAssassin()
    {
        CharacterSelection[0].SetActive(false);
        CharacterSelection[1].SetActive(false);
        CharacterSelection[2].SetActive(true);
        Character_Panels.SetActive(false);
    }

    public void back()
    {
        CharacterSelection[0].SetActive(false);
        CharacterSelection[1].SetActive(false);
        CharacterSelection[2].SetActive(false);
        Character_Panels.SetActive(true);
    }







}
