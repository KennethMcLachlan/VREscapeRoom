using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoorScript : MonoBehaviour
{
    [SerializeField]
    private bool _topLockActive;
    [SerializeField]
    private bool _bottomLockActive;

    [SerializeField]
    private GameObject _chain;

    [SerializeField]
    private Animator _anim;

    [SerializeField]
    private GameObject _topKey;
    [SerializeField]
    private GameObject _bottomKey;
    void Start()
    {
        _topLockActive = true;
        _bottomLockActive = true;

        _anim = GetComponent<Animator>();
    }

    
    public void Update()
    {
        if (_topLockActive == false && _bottomLockActive == false)
        {
            _chain.SetActive(false);
            _topKey.SetActive(false);
            _bottomKey.SetActive(false);

            _anim.SetTrigger("OpenDoor");
        }
    }

    public void TopLock()
    {
        _topLockActive = false;
    }

    public void BottomLock()
    {
        _bottomLockActive = false;
    }

    
}
