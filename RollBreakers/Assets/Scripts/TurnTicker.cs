using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTicker : MonoBehaviour
{

    static Dictionary<string, List<PlayerMovement>> units = new Dictionary<string, List<PlayerMovement>>();
    static Queue<string> turnKey = new Queue<string>();
    static Queue<PlayerMovement> turnTeam = new Queue<PlayerMovement>();


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (turnTeam.Count == 0)
        {
            InitTeamTurnQueue();
        }

    }

    static void InitTeamTurnQueue()
    {
        List<PlayerMovement> teamList = units[turnKey.Peek()];

        foreach (PlayerMovement unit in teamList)
        {
            turnTeam.Enqueue(unit);
        }

        StartTurn();
    }

    public static void StartTurn()
    {
        if (turnTeam.Count > 0)
        {
            turnTeam.Peek().BeginTurn();
        }
    }

    public static void EndTurn()
    {
        PlayerMovement unit = turnTeam.Dequeue();
        unit.EndTurn();

        if (turnTeam.Count > 0)
        {
            StartTurn();
        }
        else
        {
            string team = turnKey.Dequeue();
            turnKey.Enqueue(team);
            InitTeamTurnQueue();
        }
    }

    public static void AddUnit(PlayerMovement unit)
    {
        List<PlayerMovement> list;

        if (!units.ContainsKey(unit.tag))
        {
            list = new List<PlayerMovement>();
            units[unit.tag] = list;

            if (!turnKey.Contains(unit.tag))
            {
                turnKey.Enqueue(unit.tag);
            }
        }
        else
        {
            list = units[unit.tag];
        }

        list.Add(unit);
    }

}
