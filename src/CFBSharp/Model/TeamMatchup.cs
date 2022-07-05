/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.4.0
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
    /// TeamMatchup
    /// </summary>
    [DataContract]
    public partial class TeamMatchup :  IEquatable<TeamMatchup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMatchup" /> class.
        /// </summary>
        /// <param name="team1">team1.</param>
        /// <param name="team2">team2.</param>
        /// <param name="startYear">startYear.</param>
        /// <param name="endYear">endYear.</param>
        /// <param name="team1Wins">team1Wins.</param>
        /// <param name="team2Wins">team2Wins.</param>
        /// <param name="ties">ties.</param>
        /// <param name="games">games.</param>
        public TeamMatchup(string team1 = default(string), string team2 = default(string), int? startYear = default(int?), int? endYear = default(int?), int? team1Wins = default(int?), int? team2Wins = default(int?), int? ties = default(int?), List<Object> games = default(List<Object>))
        {
            this.Team1 = team1;
            this.Team2 = team2;
            this.StartYear = startYear;
            this.EndYear = endYear;
            this.Team1Wins = team1Wins;
            this.Team2Wins = team2Wins;
            this.Ties = ties;
            this.Games = games;
        }
        
        /// <summary>
        /// Gets or Sets Team1
        /// </summary>
        [DataMember(Name="team1", EmitDefaultValue=false)]
        public string Team1 { get; set; }

        /// <summary>
        /// Gets or Sets Team2
        /// </summary>
        [DataMember(Name="team2", EmitDefaultValue=false)]
        public string Team2 { get; set; }

        /// <summary>
        /// Gets or Sets StartYear
        /// </summary>
        [DataMember(Name="startYear", EmitDefaultValue=false)]
        public int? StartYear { get; set; }

        /// <summary>
        /// Gets or Sets EndYear
        /// </summary>
        [DataMember(Name="endYear", EmitDefaultValue=false)]
        public int? EndYear { get; set; }

        /// <summary>
        /// Gets or Sets Team1Wins
        /// </summary>
        [DataMember(Name="team1Wins", EmitDefaultValue=false)]
        public int? Team1Wins { get; set; }

        /// <summary>
        /// Gets or Sets Team2Wins
        /// </summary>
        [DataMember(Name="team2Wins", EmitDefaultValue=false)]
        public int? Team2Wins { get; set; }

        /// <summary>
        /// Gets or Sets Ties
        /// </summary>
        [DataMember(Name="ties", EmitDefaultValue=false)]
        public int? Ties { get; set; }

        /// <summary>
        /// Gets or Sets Games
        /// </summary>
        [DataMember(Name="games", EmitDefaultValue=false)]
        public List<Object> Games { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamMatchup {\n");
            sb.Append("  Team1: ").Append(Team1).Append("\n");
            sb.Append("  Team2: ").Append(Team2).Append("\n");
            sb.Append("  StartYear: ").Append(StartYear).Append("\n");
            sb.Append("  EndYear: ").Append(EndYear).Append("\n");
            sb.Append("  Team1Wins: ").Append(Team1Wins).Append("\n");
            sb.Append("  Team2Wins: ").Append(Team2Wins).Append("\n");
            sb.Append("  Ties: ").Append(Ties).Append("\n");
            sb.Append("  Games: ").Append(Games).Append("\n");
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
            return this.Equals(input as TeamMatchup);
        }

        /// <summary>
        /// Returns true if TeamMatchup instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamMatchup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamMatchup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Team1 == input.Team1 ||
                    (this.Team1 != null &&
                    this.Team1.Equals(input.Team1))
                ) && 
                (
                    this.Team2 == input.Team2 ||
                    (this.Team2 != null &&
                    this.Team2.Equals(input.Team2))
                ) && 
                (
                    this.StartYear == input.StartYear ||
                    (this.StartYear != null &&
                    this.StartYear.Equals(input.StartYear))
                ) && 
                (
                    this.EndYear == input.EndYear ||
                    (this.EndYear != null &&
                    this.EndYear.Equals(input.EndYear))
                ) && 
                (
                    this.Team1Wins == input.Team1Wins ||
                    (this.Team1Wins != null &&
                    this.Team1Wins.Equals(input.Team1Wins))
                ) && 
                (
                    this.Team2Wins == input.Team2Wins ||
                    (this.Team2Wins != null &&
                    this.Team2Wins.Equals(input.Team2Wins))
                ) && 
                (
                    this.Ties == input.Ties ||
                    (this.Ties != null &&
                    this.Ties.Equals(input.Ties))
                ) && 
                (
                    this.Games == input.Games ||
                    this.Games != null &&
                    this.Games.SequenceEqual(input.Games)
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
                if (this.Team1 != null)
                    hashCode = hashCode * 59 + this.Team1.GetHashCode();
                if (this.Team2 != null)
                    hashCode = hashCode * 59 + this.Team2.GetHashCode();
                if (this.StartYear != null)
                    hashCode = hashCode * 59 + this.StartYear.GetHashCode();
                if (this.EndYear != null)
                    hashCode = hashCode * 59 + this.EndYear.GetHashCode();
                if (this.Team1Wins != null)
                    hashCode = hashCode * 59 + this.Team1Wins.GetHashCode();
                if (this.Team2Wins != null)
                    hashCode = hashCode * 59 + this.Team2Wins.GetHashCode();
                if (this.Ties != null)
                    hashCode = hashCode * 59 + this.Ties.GetHashCode();
                if (this.Games != null)
                    hashCode = hashCode * 59 + this.Games.GetHashCode();
                return hashCode;
            }
        }
    }

}
