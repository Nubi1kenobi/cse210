using System;
public class GoodByeAnimation
    {
    private int _delay;
    private int _fade;
    private int _loopCount;
    private string[] _animation;
    
        public GoodByeAnimation()
            {
                _delay = 1000;
                _fade = 0;
                _loopCount = 1;
                _animation = new string[0];
            }

        public GoodByeAnimation(int delay, int fade, int loopCount, string[] animation)
            {
                _delay = delay;
                _fade = fade;
                _loopCount = loopCount;
                _animation = animation;
            }
        public void Animate()
            {
                Console.CursorVisible = false;
                Console.Clear();
                for (int a = _loopCount; a > 0; a--)
                    {
                        int b = 0;
                        foreach (string animateDotMe in _animation)
                            {
                                Console.Write(_animation[b]);
                                b++;
                                _delay = _delay - _fade;
                                if (_delay is < 50) { _delay = 50;}
                                Thread.Sleep(_delay);
                            }
                    }
                Console.CursorVisible = true;
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
                Console.Write("Thank you for playing, see you next time!");
                Environment.Exit(0);
            }
    }