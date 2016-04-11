using System.Reflection;

namespace Spectrum.API.Game
{
    public class Game
    {
        public static GameMode CurrentMode => (GameMode)G.Sys.GameManager_.Mode_.GameModeID_;

        public static bool IsDevelopmentModeActive
        {
            get { return G.Sys.GameManager_.IsDevBuild_; }
            set
            {
                var fieldInfo = G.Sys.GameManager_.GetType().GetField("isDevBuild_", BindingFlags.Instance | BindingFlags.NonPublic);
                fieldInfo?.SetValue(G.Sys.GameManager_, value);
            }
        }

        public static string LevelName => G.Sys.GameManager_.LevelName_;
        public static string LevelPath => G.Sys.GameManager_.LevelPath_;
        public static string SceneName => G.Sys.GameManager_.SceneName_;
    }
}
