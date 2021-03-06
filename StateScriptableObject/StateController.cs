//
//Bu StateController da çeşitli parametrelerle
//statelerdeki actionların vs kontrollu yapılır.
//


using UnityEngine;

public class StateController : MonoBehaviour
{
    public State currentState;
    public State remainState;
    // çeşitli veri leri ekleyebilirsin
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void TransitiontoState(State nextState)
    {
        if (nextState != remainState)
        {
            currentState = nextState;
            remainState = nextState;
        }
    }
}
