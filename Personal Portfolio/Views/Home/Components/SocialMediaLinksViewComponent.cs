﻿using Microsoft.AspNetCore.Mvc;
using Personal_Portfolio.Services;


namespace Personal_Portfolio.Views.Home.Components
{
    public class SocialMediaLinksViewComponent : ViewComponent
    {
        private readonly SocialMediaService _socialMediaService;

        public SocialMediaLinksViewComponent(SocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var socialMediaLinks = await _socialMediaService.GetSocialMediaLinksAsync();
            return View(socialMediaLinks);
        }
    }
}