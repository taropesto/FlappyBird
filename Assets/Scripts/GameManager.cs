using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void relaunchGame()
    {
        Player _player = FindObjectOfType<Player>();
        Checkpoints[] _checkpoints = FindObjectsOfType<Checkpoints>();
        Pipe[] _pipes = FindObjectsOfType<Pipe>();

        //On relaunch les pipes

        foreach (Checkpoints item in _checkpoints)
        {
            item.relaunchObject();
        }

        _player.relaunchObject();

        foreach (Pipe item in _pipes)
        {
            item.relaunchObject();
        }
    }
}
