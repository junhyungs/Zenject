using UnityEngine;
using Zenject;

public interface IWeapon
{
    public void Shoot();
}

public interface ISkill
{
    public void Shoot();
}

public class Gun : IWeapon
{
    public void Shoot()
    {
        Debug.Log("발사");
    }
}

public class Sword : ISkill
{
    public void Shoot()
    {
        Debug.Log("서걱");
    }
}

public class Player : MonoBehaviour
{
    //필드 주입
    [Inject]
    private IWeapon _weapon;

    private ISkill _skill;

    private void Start()
    {
        _weapon.Shoot();
        _skill.Shoot(); 
    }

    //메서드 주입
    [Inject]
    private void TestZenjent(ISkill skill)
    {
        _skill = skill;
    }

}


