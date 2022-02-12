using System.Threading.Tasks;

namespace Print_data
{
    public class Generic<T> where T : class
    {
        public async Task<T> GetString(T value)
        {
            return value;
        }
    }
}
