using Assets.Game.Scripts.Services;
using Assets.Game.Scripts.State;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartLevel : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
            AllServices.Container.Single<IGameStateMachine>().Enter<LoadLevelState, string>("main");
    }
}
