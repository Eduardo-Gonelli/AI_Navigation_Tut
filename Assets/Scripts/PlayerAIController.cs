using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAIController : MonoBehaviour
{
    Camera cam;
    NavMeshAgent agent;
    void Start()
    {
        cam = Camera.main;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Reconhece o input do botão esquerdo do mouse
        if (Input.GetMouseButtonDown(0))
        {
            // Cria um raio que vai da câmera até o ponto onde o mouse está
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Se o raio colidir com um objeto
            if (Physics.Raycast(ray, out hit))
            {
                // Move o jogador para a posição do ponto de colisão
                agent.SetDestination(hit.point);
            }
        }
    }
}
