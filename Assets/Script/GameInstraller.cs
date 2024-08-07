using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameInstraller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IWeapon>().To<Gun>().AsSingle();
        Container.Bind<ISkill>().To<Sword>().AsSingle();
        Container.Bind<IEnemy>().To<Enemy>().AsSingle();    
    }
}
