using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

using Quintessence.Models;
using Quintessence.Utils;

namespace Quintessence.Repositories
{
    public class PlanetRepository : BaseRepository, IPlanetRepository
    {
        public PlanetRepository(IConfiguration configuration) : base(configuration) { }

        public List<Planet> GetAllPlanets()
        {
            var planets = new List<Planet>();
            using (var conn = Connection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT Id, Name, ImageUrl, Distance, Gravity, Composition, Orbit, Atmosphere, Size
                                    From Planet ORDER BY name;";

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        planets.Add(new Planet
                        {
                            Id = DbUtils.GetInt(reader, "id"),
                            Name = DbUtils.GetString(reader, "name"),
                            ImageUrl = DbUtils.GetString(reader, "imageUrl"),
                            Distance = DbUtils.GetString(reader, "distance"),
                            Gravity = DbUtils.GetString(reader, "gravity"),
                            Composition = DbUtils.GetString(reader, "composition"),
                            Orbit = DbUtils.GetString(reader, "orbit"),
                            Atmosphere = DbUtils.GetString(reader, "atmosphere"),
                            Size = DbUtils.GetString(reader, "size"),

                        });
                    }
                    reader.Close();
                    return planets;
                }
            }
        }



    }
};
      
            
            
               
            

