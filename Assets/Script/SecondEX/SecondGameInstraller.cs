using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SecondGameInstraller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IInteraction>().To<Box>().FromComponentInHierarchy().AsSingle();
        Container.Bind<IInteraction>().To<Mouse>().FromComponentInHierarchy().AsSingle();
        Container.Bind<IInteraction>().To<Computer>().FromComponentInHierarchy().AsSingle();
    }
}
