using System.Collections.Generic;
using System.Threading.Tasks;

namespace StadiumShop.Common.Storage
{
    public interface IStorageService
    {
		string UpdloadFile<T>(string name, string type, string path, IDictionary<string, string> metadata, string file);
    }
}