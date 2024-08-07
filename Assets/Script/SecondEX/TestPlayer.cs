using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public interface IInteraction
{
    public void InteractionItem();
}


public class TestPlayer : MonoBehaviour
{
    private List<IInteraction> _interactionList;

    [Inject]
    private void SetList(List<IInteraction> interaction)
    {
        _interactionList = interaction; 
    }

    private void Start()
    {
        //List 规过 1
        //foreach(var interaction in _interaction)
        //{
        //    interaction.InteractionItem();
        //}

        //List 规过 2
        _interactionList[0].InteractionItem();
        _interactionList[1].InteractionItem();
        _interactionList[2].InteractionItem();


    }

}
