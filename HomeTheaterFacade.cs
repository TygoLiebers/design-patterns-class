namespace FacadePattern
{
    internal class HomeTheaterFacade
    {
        private Amplifier amp;
        private CdPlayer cdPlayer;
        private DvdPlayer dvdPlayer;
        private PopcornPopper popcornPopper;
        private Projector projector;
        private Screen screen;
        private TheaterLights lights;
        private Tuner tuner;

        public HomeTheaterFacade(Amplifier Amp, CdPlayer CdPlayer, DvdPlayer DvdPlayer, PopcornPopper PopcornPopper, Projector Projector, Screen Screen, TheaterLights Lights, Tuner Tuner)
        {
            amp = Amp;
            cdPlayer = CdPlayer;
            dvdPlayer = DvdPlayer;
            popcornPopper = PopcornPopper;
            projector = Projector;
            screen = Screen;
            lights = Lights;
            tuner = Tuner;
        }

        public void WatchMovie(string title)
        {
            popcornPopper.On();
            popcornPopper.Pop();

            lights.Dim(10);

            screen.Down();

            projector.On();
            projector.SetInput(dvdPlayer);
            projector.WideScreenMode();

            amp.On();
            amp.SetDvd(dvdPlayer);
            amp.SetSurroundSound();
            amp.SetVolume(5);

            dvdPlayer.On();
            dvdPlayer.Play(title);
        }

        public void EndMovie()
        {
            popcornPopper.Off();

            lights.Dim(100);

            screen.Up();

            projector.TvMode();
            projector.Off();
            
            amp.SetSurroundSound();
            amp.SetVolume(0);
            amp.Off();

            dvdPlayer.Stop();
            dvdPlayer.Off();
        }
    }
}
