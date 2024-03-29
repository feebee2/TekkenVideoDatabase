using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TekkenVideoDatabase.Data;
using TekkenVideoDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace TekkenVideoDatabase.Services
{
    public class VideoLinkService : IVideoLinkService
    {
        private readonly ApplicationDbContext _context;

        public VideoLinkService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<VideoLink[]> GetVideosAsync()
        {
            return await _context.Videos

            .ToArrayAsync(); 
        }

        public async Task<bool> AddVideoAsync(VideoLink newVideo)
        {
            newVideo.Id = Guid.NewGuid();
            

            _context.Videos.Add(newVideo);

            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }

    }
}