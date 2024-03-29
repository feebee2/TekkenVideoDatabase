using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TekkenVideoDatabase.Services;
using TekkenVideoDatabase.Models;

namespace TekkenVideoDatabase.Controllers
{
    public class VideoController : Controller
    {
        private readonly IVideoLinkService _videoLinkService;

        public VideoController(IVideoLinkService videoLinkService)
        {
            _videoLinkService = videoLinkService;
        }


        public async Task<IActionResult> Index()
        {
            var videos = await _videoLinkService.GetVideosAsync();

            var model = new VideoViewModel()
            {
                Videos = videos
            };

            return View(model);
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddVideo(VideoLink newVideo)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            var successful = await _videoLinkService.AddVideoAsync(newVideo);
            if (!successful)
            {
                return BadRequest("Could not add video.");
            }

            return RedirectToAction("Index");
        }
    }
}
