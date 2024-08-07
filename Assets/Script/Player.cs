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
        Debug.Log("�߻�");
    }
}

public class Sword : ISkill
{
    public void Shoot()
    {
        Debug.Log("����");
    }
}

public class Player : MonoBehaviour
{
    //�ʵ� ����
    [Inject]
    private IWeapon _weapon;

    private ISkill _skill;

    private void Start()
    {
        _weapon.Shoot();
        _skill.Shoot(); 
    }

    //�޼��� ����
    [Inject]
    private void TestZenjent(ISkill skill)
    {
        _skill = skill;
    }

}


