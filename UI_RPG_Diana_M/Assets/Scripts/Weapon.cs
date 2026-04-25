using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] internal float baseDamage;

    public virtual float GetDamage()
    {
        return baseDamage;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
