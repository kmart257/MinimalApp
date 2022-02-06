using MinimalApp.Models;
using MinimalApp.Repositories;

namespace MinimalApp.Services
{
    public class VideoGameService : IVideoGameService
    {
        public VideoGameModel Create(VideoGameModel videlGame)
        {
            videlGame.id = VideoGameRepository.VideoGames.Count + 1;
            VideoGameRepository.VideoGames.Add(videlGame);

            return videlGame;
        }

        public bool Delete(int id)
        {
            var oldvideoGame = VideoGameRepository.VideoGames.FirstOrDefault(x => x.id == id);
            if (oldvideoGame is null) return false;
            VideoGameRepository.VideoGames.Remove(oldvideoGame);

            return true;
        }

        public VideoGameModel? Get(int id)
        {
            var videlGame = VideoGameRepository.VideoGames.FirstOrDefault(x => x.id == id);

            if (videlGame == null) return null;

            return videlGame;
        }

        public List<VideoGameModel> List()
        {
            return VideoGameRepository.VideoGames;
        }

        public VideoGameModel? Update(VideoGameModel newvideoGame)
        {
            var oldvideoGame = VideoGameRepository.VideoGames.
                FirstOrDefault(o => o.id == newvideoGame.id);

            if(oldvideoGame == null) return null;

            oldvideoGame.Title = newvideoGame.Title;
            oldvideoGame.Description = newvideoGame.Description;

            return newvideoGame;
        }
    }
}
