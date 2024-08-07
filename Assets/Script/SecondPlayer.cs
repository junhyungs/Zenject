using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SecondPlayer : MonoBehaviour
{
    private Player _player;

    [Inject]
    private void SetInJect(Player player)
    {
        _player = player;
    }

    private void Start()
    {
        _player.InJectEnemy.Name();
    }
}
