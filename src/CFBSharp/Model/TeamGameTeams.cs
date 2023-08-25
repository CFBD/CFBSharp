/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.4.14
 * Contact: admin@collegefootballdata.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = CFBSharp.Client.SwaggerDateConverter;

namespace CFBSharp.Model
{
    /// <summary>
    /// TeamGameTeams
    /// </summary>
    [DataContract]
    public partial class TeamGameTeams :  IEquatable<TeamGameTeams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamGameTeams" /> class.
        /// </summary>
        /// <param name="school">school.</param>
        /// <param name="conference">conference.</param>
        /// <param name="homeAway">homeAway.</param>
        /// <param name="points">points.</param>
        /// <param name="stats">stats.</param>
        public TeamGameTeams(string school = default(string), string conference = default(string), string homeAway = default(string), int? points = default(int?), List<TeamGameStats> stats = default(List<TeamGameStats>))
        {
            this.School = school;
            this.Conference = conference;
            this.HomeAway = homeAway;
            this.Points = points;
            this.Stats = stats;
        }
        
        /// <summary>
        /// Gets or Sets School
        /// </summary>
        [DataMember(Name="school", EmitDefaultValue=false)]
        public string School { get; set; }

        /// <summary>
        /// Gets or Sets Conference
        /// </summary>
        [DataMember(Name="conference", EmitDefaultValue=false)]
        public string Conference { get; set; }

        /// <summary>
        /// Gets or Sets HomeAway
        /// </summary>
        [DataMember(Name="homeAway", EmitDefaultValue=false)]
        public string HomeAway { get; set; }

        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [DataMember(Name="points", EmitDefaultValue=false)]
        public int? Points { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public List<TeamGameStats> Stats { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamGameTeams {\n");
            sb.Append("  School: ").Append(School).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  HomeAway: ").Append(HomeAway).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TeamGameTeams);
        }

        /// <summary>
        /// Returns true if TeamGameTeams instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamGameTeams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamGameTeams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.School == input.School ||
                    (this.School != null &&
                    this.School.Equals(input.School))
                ) && 
                (
                    this.Conference == input.Conference ||
                    (this.Conference != null &&
                    this.Conference.Equals(input.Conference))
                ) && 
                (
                    this.HomeAway == input.HomeAway ||
                    (this.HomeAway != null &&
                    this.HomeAway.Equals(input.HomeAway))
                ) && 
                (
                    this.Points == input.Points ||
                    (this.Points != null &&
                    this.Points.Equals(input.Points))
                ) && 
                (
                    this.Stats == input.Stats ||
                    this.Stats != null &&
                    this.Stats.SequenceEqual(input.Stats)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.School != null)
                    hashCode = hashCode * 59 + this.School.GetHashCode();
                if (this.Conference != null)
                    hashCode = hashCode * 59 + this.Conference.GetHashCode();
                if (this.HomeAway != null)
                    hashCode = hashCode * 59 + this.HomeAway.GetHashCode();
                if (this.Points != null)
                    hashCode = hashCode * 59 + this.Points.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                return hashCode;
            }
        }
    }

}
