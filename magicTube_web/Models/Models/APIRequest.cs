using Microsoft.AspNetCore.Mvc;
using static MagicTube_Utility.SD;

namespace magicTube_web.Models.Models
{
    public class APIRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;

        public string Url { get; set; }

        public object Data { get; set; }
    }
}
