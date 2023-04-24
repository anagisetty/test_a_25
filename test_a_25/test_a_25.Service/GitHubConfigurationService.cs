using System;
using System.Collections.Generic;
using Test_A_25.DTO;

namespace Test_A_25
{
    public class GitHubConfigurationService
    {
        private readonly GitHubConfiguration _config;

        public GitHubConfigurationService(GitHubConfiguration config)
        {
            _config = config;
        }

        // CREATE
        public void CreateConfig(GitHubConfiguration config)
        {
            // add config to database
        }

        // READ
        public GitHubConfiguration GetConfig(int id)
        {
            // get config from database
            return _config;
        }

        public List<GitHubConfiguration> GetAllConfigs()
        {
            // get all configs from database
            List<GitHubConfiguration> configs = new List<GitHubConfiguration>();
            configs.Add(_config);
            return configs;
        }

        // UPDATE
        public void UpdateConfig(GitHubConfiguration config)
        {
            // update config in database
        }

        // DELETE
        public void DeleteConfig(int id)
        {
            // delete config from database
        }
    }
}