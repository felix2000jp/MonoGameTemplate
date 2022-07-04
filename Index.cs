using System;

namespace Mono
{
    public static class Index {
        [STAThread]
        static void Main() {
            using (var game = new Source.Main()) game.Run();
        }
    }
}
