using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace FlappyBlazor.Models
{
    public class GameManager : INotifyPropertyChanged
    {
        private readonly int _gravity = 2;
        public Bird Bird { get; set; }
        public bool IsRunning { get; set; } = false;

        public GameManager()
        {
            Bird = new Bird();
        }

        public async void Run()
        {
            IsRunning = true;
            while (IsRunning)
            {
                Bird.Fall(_gravity);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Bird)));

                // Sorry you lost 
                if (Bird.DistanceFromGround <= 0)
                {
                    GameOver();
                }
                
                await Task.Delay(20); // lets not go with cpu speed here -> 20ms should be fine for now
            }
        }

        public void StartGame()
        {
            if (IsRunning) return;
            Bird = new Bird(); // Create a new instance on start
            Run();
        }

        public void GameOver()
        {
            IsRunning = false;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}