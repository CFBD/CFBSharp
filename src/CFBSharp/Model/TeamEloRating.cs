/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.5.1
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
    /// TeamEloRating
    /// </summary>
    [DataContract]
    public partial class TeamEloRating :  IEquatable<TeamEloRating>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamEloRating" /> class.
        /// </summary>
        /// <param name="year">year.</param>
        /// <param name="team">team.</param>
        /// <param name="conference">conference.</param>
        /// <param name="elo">elo.</param>
        public TeamEloRating(int? year = default(int?), string team = default(string), string conference = default(string), decimal? elo = default(decimal?))
        {
            this.Year = year;
            this.Team = team;
            this.Conference = conference;
            this.Elo = elo;
        }
        
        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Conference
        /// </summary>
        [DataMember(Name="conference", EmitDefaultValue=false)]
        public string Conference { get; set; }

        /// <summary>
        /// Gets or Sets Elo
        /// </summary>
        [DataMember(Name="elo", EmitDefaultValue=false)]
        public decimal? Elo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamEloRating {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Elo: ").Append(Elo).Append("\n");
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
            return this.Equals(input as TeamEloRating);
        }

        /// <summary>
        /// Returns true if TeamEloRating instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamEloRating to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamEloRating input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
                ) && 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.Conference == input.Conference ||
                    (this.Conference != null &&
                    this.Conference.Equals(input.Conference))
                ) && 
                (
                    this.Elo == input.Elo ||
                    (this.Elo != null &&
                    this.Elo.Equals(input.Elo))
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
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.Conference != null)
                    hashCode = hashCode * 59 + this.Conference.GetHashCode();
                if (this.Elo != null)
                    hashCode = hashCode * 59 + this.Elo.GetHashCode();
                return hashCode;
            }
        }
    }

}
