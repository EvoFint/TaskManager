using System.Text.Json.Serialization;

namespace TaskManager.Backend.Models.DTO
{
    public class RequestDto<T>
    {
        [JsonPropertyName("data")]
        T Data { get; }

        public RequestDto(T data)
        {
            Data = data;
        }
    }
}