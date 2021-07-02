using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveParty : MonoBehaviour
{
    // stores how many party members which the player has 
     public static int PlayersParty = 7;
    // An array of the UI party members elements 
    public GameObject[] Partymembers;

    // Start is called before the first frame update
    void Start()
    {
        // At the start of the game the party members elements are turned off 
        Partymembers[0].SetActive(false);
        Partymembers[1].SetActive(false);
        Partymembers[2].SetActive(false);
        Partymembers[3].SetActive(false);
        Partymembers[4].SetActive(false);
        Partymembers[5].SetActive(false);
        Partymembers[6].SetActive(false);
        Partymembers[7].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ActivePartyMembers();
    }
    // function which determins how many party members which the player has.
    // the more the members the more part memeber UI elements are active 
    // if there are less party members the UI elements go invisable. 
    public void ActivePartyMembers()
    {
        switch (PlayersParty)
        {
            // case 0 checks against the PlayersParty vatiable and if the value is less than or equal to 0 then nothing will happen
            // since there is nobody to add to the party 
            case 0:
                if (PlayersParty <= 0)
                {

                }
                break;
              // case 1 checks the variable again and if the player had picked up a party member then the first UI element is visable
              // while all of the others are still false since there is nobody else to add to the part currently
              // basically the increase in party members the more part member slots become visable
              // if there are less party mebers the party member slots become invisable 
            case 1:
                if (PlayersParty == 1)
                {
                    Partymembers[0].SetActive(true);
                    Partymembers[1].SetActive(false);
                    Partymembers[2].SetActive(false);
                    Partymembers[3].SetActive(false);
                    Partymembers[4].SetActive(false);
                    Partymembers[5].SetActive(false);
                    Partymembers[6].SetActive(false);
                    Partymembers[7].SetActive(false);
                }
                break;
            case 2:
                if (PlayersParty == 2)
                {
                    Partymembers[0].SetActive(true);
                    Partymembers[1].SetActive(true);
                    Partymembers[2].SetActive(false);
                    Partymembers[3].SetActive(false);
                    Partymembers[4].SetActive(false);
                    Partymembers[5].SetActive(false);
                    Partymembers[6].SetActive(false);
                    Partymembers[7].SetActive(false);
                }
                break;
            case 3:
                if (PlayersParty == 3)
                {
                    Partymembers[0].SetActive(true);
                    Partymembers[1].SetActive(true);
                    Partymembers[2].SetActive(true);
                    Partymembers[3].SetActive(false);
                    Partymembers[4].SetActive(false);
                    Partymembers[5].SetActive(false);
                    Partymembers[6].SetActive(false);
                    Partymembers[7].SetActive(false);
                }
                break;
            case 4:
                if (PlayersParty == 4)
                {
                    Partymembers[0].SetActive(true);
                    Partymembers[1].SetActive(true);
                    Partymembers[2].SetActive(true);
                    Partymembers[3].SetActive(true);
                    Partymembers[4].SetActive(false);
                    Partymembers[5].SetActive(false);
                    Partymembers[6].SetActive(false);
                    Partymembers[7].SetActive(false);
                }
                break;
            case 5:
                if (PlayersParty == 5)
                {
                    Partymembers[0].SetActive(true);
                    Partymembers[1].SetActive(true);
                    Partymembers[2].SetActive(true);
                    Partymembers[3].SetActive(true);
                    Partymembers[4].SetActive(true);
                    Partymembers[5].SetActive(false);
                    Partymembers[6].SetActive(false);
                    Partymembers[7].SetActive(false);
                }
                break;
            case 6:
                if (PlayersParty == 6)
                {
                    Partymembers[0].SetActive(true);
                    Partymembers[1].SetActive(true);
                    Partymembers[2].SetActive(true);
                    Partymembers[3].SetActive(true);
                    Partymembers[4].SetActive(true);
                    Partymembers[5].SetActive(true);
                    Partymembers[6].SetActive(false);
                    Partymembers[7].SetActive(false);
                }
                break;
            case 7:
                if (PlayersParty == 7)
                {
                    Partymembers[0].SetActive(true);
                    Partymembers[1].SetActive(true);
                    Partymembers[2].SetActive(true);
                    Partymembers[3].SetActive(true);
                    Partymembers[4].SetActive(true);
                    Partymembers[5].SetActive(true);
                    Partymembers[6].SetActive(true);
                    Partymembers[7].SetActive(false);
                }
                break;
            case 8:
                if (PlayersParty >= 8)
                {
                    Partymembers[0].SetActive(true);
                    Partymembers[1].SetActive(true);
                    Partymembers[2].SetActive(true);
                    Partymembers[3].SetActive(true);
                    Partymembers[4].SetActive(true);
                    Partymembers[5].SetActive(true);
                    Partymembers[6].SetActive(true);
                    Partymembers[7].SetActive(true);

                }
                break;
        }
    }
}
