using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TekkenVideoDatabase.Models;

namespace TekkenVideoDatabase.Services
{
    public interface IVideoLinkService
    {
        Task<VideoLink[]> GetVideosAsync();

        Task<bool> AddVideoAsync(VideoLink newVideo);
    }
}