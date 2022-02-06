using MinimalApp.Models;

namespace MinimalApp.Services
{
    public interface IVideoGameService
    {
        public VideoGameModel Create(VideoGameModel videlGame);
        public VideoGameModel? Get(int id);
        public List<VideoGameModel> List();
        public VideoGameModel? Update(VideoGameModel videlGame);
        public bool Delete(int id);
    }
}
