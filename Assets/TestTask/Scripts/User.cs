using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    [SerializeField] string _clientId;
    [SerializeField] private UserAnimation _userAnimation;
    public string ClientId => _clientId;
    public UserAnimation UserAnimation => _userAnimation;

    public void Attack(string animationId)
    {
        _userAnimation.StartAnimation(animationId);
    }
}
