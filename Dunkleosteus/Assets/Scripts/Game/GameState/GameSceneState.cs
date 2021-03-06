using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneState : FiniteState
{
    public GameDirector gameDirector;

    public GameSceneState(GameDirector director)
    {
        gameDirector = director;
        _stateID = StateID.GameScene;
    }

    public override void DoBeforeEnter() 
    {
        gameDirector.EnterGameSceneState();
    }

    public override void DoBeforeExit()
    {
        gameDirector.ExitGameSceneState();
    }
}