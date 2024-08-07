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

public interface IEnemy
{
    public void Name();
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

public class Enemy : IEnemy
{
    public void Name()
    {
        Debug.Log("Enemy");
    }
}

public class Player : MonoBehaviour
{
    //필드 주입
    [Inject]
    private IWeapon _weapon;

    private ISkill _skill;
    private IEnemy _enemy;

    //프로퍼티 주입
    [Inject]
    public IEnemy InJectEnemy
    {
        get { return _enemy; }
        set { _enemy = value; }
    }

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




