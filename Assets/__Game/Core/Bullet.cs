using SpaceDefender.Core;
using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;
    public int Damage;
    public bool IsActive;
    public Vector2 Position;

    public void Move(float deltaTime) { throw new NotImplementedException(); }
    public bool CheckCollision(Enemy enemy) { throw new NotImplementedException(); }
    public void Deactivate() { throw new NotImplementedException(); }
}
