﻿using Assets.Game.Scripts.State;
using UnityEngine;

public class GameRunner : MonoBehaviour
{
    public GameBootstrapper BootstrapperPrefab;

    private void Awake()
    {
        var bootstrapper = FindObjectOfType<GameBootstrapper>();

        if (bootstrapper == null)
            Instantiate(BootstrapperPrefab);
    }
}