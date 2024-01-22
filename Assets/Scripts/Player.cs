using UnityEngine;

public class Player : MonoBehaviour
{
    #region CONSTANTS

    private bool _moveRight, _moveLeft;

    public AudioSource Phonk;

    #endregion

    #region MOVE_PLAYER

    #region MOVE_RIGHT
    public void MoveR(bool moveRight)
    {
        _moveRight = moveRight;
    }
    #endregion

    #region MOVE_LEFT
    public void MoveL(bool moveLeft)
    {
        _moveLeft = moveLeft;
    }
    #endregion

    #endregion

    #region UPDATE
    private void FixedUpdate()
    {
        if(_moveRight) 
        {
            Phonk.enabled = true;
            transform.Translate(0.2f, 0, 0);
        }
        else if(_moveLeft) 
        {
            Phonk.enabled = true;
            transform.Translate(-0.2f, 0, 0);
        }
        else
        {
            Phonk.enabled = false;
        }
    }
    #endregion
}
