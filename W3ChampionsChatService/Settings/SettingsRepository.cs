using System.Threading.Tasks;
using MongoDB.Driver;

namespace W3ChampionsChatService.Settings
{
    public class SettingsRepository : MongoDbRepositoryBase
    {
        public SettingsRepository(MongoClient mongoClient) : base(mongoClient)
        {
        }

        public Task Save(ChatSettings chatSettings)
        {
            return Upsert(chatSettings);
        }

        public Task<ChatSettings> Load(string id)
        {
            return LoadFirst<ChatSettings>(id);
        }
    }
}