using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class padle : MonoBehaviour
{
    //public= acesso dentro e fora da unity; private= so na programação.
    public bool _isPlayerOne;
    public float speed;
    private bool _isPressingUp;
    private bool _isPressingDown;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Objeto Criado");
    }

    // Update is called once per frame
    void Update()
    {
        _isPressingUp = Input.GetKey(KeyCode.W);
        _isPressingDown = Input.GetKey(KeyCode.S);

        //distinção de Playes
        if (_isPlayerOne)
        {
            _isPressingUp = Input.GetKey(KeyCode.UpArrow);
            _isPressingDown = Input.GetKey(KeyCode.DownArrow);
        }
        else
        {
            _isPressingUp = Input.GetKey(KeyCode.W);
            _isPressingDown = Input.GetKey(KeyCode.S);
        }
        //execução de movimento
        if (_isPressingUp)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (_isPressingDown) 
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
         }
    }
}
