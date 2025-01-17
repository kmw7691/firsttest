using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Node : MonoBehaviour
{
    public bool IsTowerExist => _towerBuilt;
    private Tower _towerBuilt;
    private Renderer _renderer;

    private Color _originalColor;
    [SerializeField] private Color _buildAvailableColor;
    [SerializeField] private Color _buildNotAvailableColor;

    //건설하고싶은걸 만드는것
    public bool TryBuildTowerHere(string towerName)
    {
        bool isOK = false;

        if (IsTowerExist)
        {
            Debug.Log("해당위치에 타워를 건설할 수 없습니다.");
            return false;
        }

        if(TowerAssets.instance.TryGetTower(towerName,out GameObject tower))
        {
           GameObject built =  Instantiate(tower,
                        transform.position + Vector3.up * 0.5f, 
                        Quaternion.identity,
                        transform);

            _towerBuilt = built.GetComponent<Tower>();
        }
        return isOK;
    }

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        _originalColor = _renderer.material.color;
    }

    private void OnMouseEnter()
    {

        if (IsTowerExist)
            _renderer.material.color = _buildNotAvailableColor;
        else
            _renderer.material.color = _buildAvailableColor;

        _renderer.material.color = _buildAvailableColor;
        NodeManager.mouseOnNode = this;
    }

    private void OnMouseExit()
    {
        _renderer.material.color = _originalColor;
    }
}
