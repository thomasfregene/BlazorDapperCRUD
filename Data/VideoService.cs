using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDapperCRUD.Data
{
    public class VideoService : IVideoService
    {
        //database connection
        private readonly SqlConnectionConfiguration _configuration;

        public VideoService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        //Add (create) a video table row (SQL Insert)
        public async Task<bool> VideoInsert(Video video)
        {
            //connects to database for inserting row
            using (var conn = new SqlConnection(_configuration.Value))
            {
                //dapper
                var parameters = new DynamicParameters();
                parameters.Add("Title", video.Title, DbType.String);
                parameters.Add("DatePublished", video.DatePublished, DbType.Date);
                parameters.Add("IsActive", video.IsActive, DbType.Boolean);
                //Raw SQL method
                const string query = @"INSERT INTO Video(Title, DatePublished, IsActive)VALUES(@Title, @DatePublished, @IsActive)";
                await conn.ExecuteAsync(query, new { video.Title, video.DatePublished, video.IsActive }, commandType: CommandType.Text);
            }

            return true;
        }
    }
}
