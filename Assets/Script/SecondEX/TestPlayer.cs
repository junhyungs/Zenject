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
    //private List<IInteraction> _interactionList;

    [Inject]
    private IInteraction _whenInjectIntoInteraction;

    //[Inject]
    //private void SetList(List<IInteraction> interaction)
    //{
    //    _interactionList = interaction; 
    //}

    //[Inject(Id = "Box")]
    //private IInteraction _boxInteraction;

    //[Inject(Id = "Computer")]
    //private IInteraction _computerInteraction;

    //[Inject(Id = "Mouse")]
    //private IInteraction _mouseInteraction;

    private void Start()
    {
        //List 规过 1
        //foreach(var interaction in _interaction)
        //{
        //    interaction.InteractionItem();
        //}

        //List 规过 2
        //_interactionList[0].InteractionItem();
        //_interactionList[1].InteractionItem();
        //_interactionList[2].InteractionItem();

        //_whenInjectIntoInteraction.InteractionItem();

        //_boxInteraction.InteractionItem();
        //_computerInteraction.InteractionItem();
        //_mouseInteraction.InteractionItem();

        _whenInjectIntoInteraction.InteractionItem();
    }

}
