using System.Threading.Tasks;

namespace MJIot.Storage.Properties
{
    public interface IPropertyStorage
    {
        Task<string> GetPropertyValueAsync(int deviceId, string propertyName);
        string GetPropertyValue(int deviceId, string propertyName);
        Task SetPropertyValueAsync(int deviceId, string propertyName, string propertyValue);
    }
}