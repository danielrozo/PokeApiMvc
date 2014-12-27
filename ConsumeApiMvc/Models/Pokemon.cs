using System;

namespace ConsumeApiMvc.Models
{
    public class Pokemon
    {
        public Ability[] abilities { get; set; }
        public int attack { get; set; }
        public int catch_rate { get; set; }
        public DateTime created { get; set; }
        public int defense { get; set; }
        public Description[] descriptions { get; set; }
        public int egg_cycles { get; set; }
        public Egg_Groups[] egg_groups { get; set; }
        public string ev_yield { get; set; }
        public Evolution[] evolutions { get; set; }
        public int exp { get; set; }
        public string growth_rate { get; set; }
        public int happiness { get; set; }
        public string height { get; set; }
        public int hp { get; set; }
        public string male_female_ratio { get; set; }
        public DateTime modified { get; set; }
        public Move[] moves { get; set; }
        public string name { get; set; }
        public int national_id { get; set; }
        public int pkdx_id { get; set; }
        public string resource_uri { get; set; }
        public int sp_atk { get; set; }
        public int sp_def { get; set; }
        public string species { get; set; }
        public int speed { get; set; }
        public Sprite[] sprites { get; set; }
        public int total { get; set; }
        public Type[] types { get; set; }
        public string weight { get; set; }
    }

   
}