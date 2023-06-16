using Assets.Game.Scripts.Services;
using Assets.Game.Scripts.State;

namespace Assets.Game
{
    public class Game
    {
        public GameStateMachine StateMachine;

        public Game(ICorutineRunner corutineRunner, PopupController popupController)
        {
            StateMachine = new GameStateMachine(new SceneLoader(corutineRunner), popupController, AllServices.Container);
        }
    }
}