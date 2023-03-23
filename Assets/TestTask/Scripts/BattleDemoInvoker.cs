using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class BattleDemoInvoker : MonoBehaviour
{
    [SerializeField] private List<User> users;
    [SerializeField] private float _roundDeley = 5f;
    [SerializeField] private float _turnDeley = 3f;
    private DataLoader _dataLoader;
    private BattleTurn _battleTurn;

    private void Awake()
    {
        _dataLoader = new DataLoader();
        _battleTurn = _dataLoader.BattleTurn;
    }

    private void Start()
    {
        StartCoroutine(Battle());
    }

    private IEnumerator Battle()
    {
        yield return new WaitForSeconds(_roundDeley);
        foreach (var round in _battleTurn.rounds)
        {
            foreach (var turn in round.turns)
            {
                var turnId = turn.clientId;
                var id = users.FindIndex(p => p.ClientId == turnId);
                if (id >= 0)
                    users[id].Attack(turn.attack);
                yield return new WaitForSeconds(_turnDeley);
            }

            yield return new WaitForSeconds(_roundDeley);
        }
    }
}
