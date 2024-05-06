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
        // Reconhece o input do bot�o esquerdo do mouse
        if (Input.GetMouseButtonDown(0))
        {
            // Cria um raio que vai da c�mera at� o ponto onde o mouse est�
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Se o raio colidir com um objeto
            if (Physics.Raycast(ray, out hit))
            {
                // Move o jogador para a posi��o do ponto de colis�o
                agent.SetDestination(hit.point);
            }
        }
    }
}
