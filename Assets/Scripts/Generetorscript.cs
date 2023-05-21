using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generetorscript : MonoBehaviour
{
    [SerializeField] public carmanager _carmanager;
    public int span = 2;
    public int vec = 1;
    public GameObject prefab;
    void Start()
    {
        StartCoroutine("Change");
    }
    IEnumerator Change()
    {
        while (true)
        {
            Instantiate(_carmanager).Initialize(vec);
            yield return new WaitForSeconds(span);
        }
    }
}
