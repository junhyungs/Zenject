using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using Zenject;

public class SecondGameInstraller : MonoInstaller
{
    
    public override void InstallBindings()
    {
        //Container.Bind<IInteraction>().To<Box>().FromComponentInHierarchy().AsSingle();
        //Container.Bind<IInteraction>().To<Mouse>().FromComponentInHierarchy().AsSingle();
        //Container.Bind<IInteraction>().To<Computer>().FromComponentInHierarchy().AsSingle();

        //Container.Bind<IInteraction>().To<Box>().AsSingle().WhenInjectedInto<TestPlayer>();
        //Container.Bind<IInteraction>().To<Mouse>().AsSingle().WhenInjectedInto<Player>();
        //Container.Bind<IInteraction>().To<Computer>().AsSingle().WhenInjectedInto<SecondPlayer>();

        //Container.Bind<IInteraction>().WithId("Box").To<Box>().AsSingle();
        //Container.Bind<IInteraction>().WithId("Computer").To<Computer>().AsSingle();
        //Container.Bind<IInteraction>().WithId("Mouse").To<Mouse>().AsSingle();

        //Container.Bind<IInteraction>().To<Box>().FromComponentInHierarchy().AsSingle().WhenInjectedInto<TestPlayer>();
        //Container.Bind<IInteraction>().To<Computer>().FromComponentInHierarchy().AsSingle().WhenInjectedInto<Player>();
        //Container.Bind<IInteraction>().To<Mouse>().FromComponentInHierarchy().AsSingle().WhenInjectedInto<SecondPlayer>();

        Container.Bind<IInteraction>().WithId("Box").To<Box>().FromNewComponentOnNewGameObject().AsSingle();
        Container.Bind<IInteraction>().WithId("Mouse").To<Mouse>().FromNewComponentOnNewGameObject().AsSingle();
        Container.Bind<IInteraction>().WithId("Computer").To<Computer>().FromNewComponentOnNewGameObject().AsSingle();

    }
}
