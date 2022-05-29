﻿using Heyday.Application.Catalog.Contracts;
using Heyday.Shared.Schedule;
using Microsoft.AspNetCore.Mvc;

namespace Heyday.Api.Main.Controllers
{
    public class ScheduleController : BaseController
    {
        private readonly IScheduleService _service;

        public ScheduleController(IScheduleService scheduleService)
        {
            _service = scheduleService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateScheduleRequest request)
        {
            return Ok(await _service.CreateScheduleAsync(request));
        }

        [HttpGet("/Test")]
        public IActionResult Test()
        {
            return Ok("Test Çalıştı");
        }
    }
}
