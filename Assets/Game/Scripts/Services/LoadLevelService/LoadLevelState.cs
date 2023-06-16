using static Assets.Game.Scripts.State.GameStateMachine;

namespace Assets.Game.Scripts.State
{
    public class LoadLevelState : IPayLoadedState<string>
    {
        private readonly GameStateMachine _stateMachine;
        private readonly SceneLoader _sceneLoader;
        private readonly PopupController _popupController;

        public LoadLevelState(GameStateMachine stateMachine, SceneLoader sceneLoader, PopupController popupController)
        {
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
            _popupController = popupController;
        }

        public void Enter(string sceneName)
        {
            _popupController.Show();
            _sceneLoader.Load(sceneName, OnLoaded);
        }

        private void OnLoaded()
        {
            _stateMachine.Enter<GameLoopState>();
        }

        public void Exit()
        {
            _popupController.Hide();
        }
    }
}