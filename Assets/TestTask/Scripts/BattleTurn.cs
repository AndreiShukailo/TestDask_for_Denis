using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class BattleTurn
{
    public string id;
    public List<Team> teams;
    public List<Round> rounds;
}

[Serializable]
public class Team
{
    public string name;
    public string leaderId;
}

[Serializable]
public class Round
{
    public string id;
    public int number;
    public string battleId;
    public List<Turn> turns; 
}

[Serializable]
public class Turn
{
    public string clientId;
    public string attack;
    public string defense;
}