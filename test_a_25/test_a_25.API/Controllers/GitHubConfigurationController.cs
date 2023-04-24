using System;
using System.Collections.Generic;
using Test_A_25.DTO;
using Test_A_25.Service;
using Microsoft.AspNetCore.Mvc;

namespace Test_A_25.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class GitHubConfigurationController : ControllerBase
    {
        private readonly GitHubConfigurationService _configService;

        public GitHubConfigurationController(GitHubConfigurationService configService)
        {
            _configService = configService;
        }

        // CREATE
        [HttpPost]
        public IActionResult CreateConfig(GitHubConfiguration config)
        {
            _configService.CreateConfig(config);
            return Ok();
        }

        // READ
        [HttpGet("{id}")]
        public IActionResult GetConfig(int id)
        {
            var config = _configService.GetConfig(id);
            return Ok(config);
        }

        [HttpGet]
        public IActionResult GetAllConfigs()
        {
            var configs = _configService.GetAllConfigs();
            return Ok(configs);
        }

        // UPDATE
        [HttpPut]
        public IActionResult UpdateConfig(GitHubConfiguration config)
        {
            _configService.UpdateConfig(config);
            return Ok();
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult DeleteConfig(int id)
        {
            _configService.DeleteConfig(id);
            return Ok();
        }
    }
}