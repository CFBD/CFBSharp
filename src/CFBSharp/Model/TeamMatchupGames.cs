/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 1.24.5
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
    /// TeamMatchupGames
    /// </summary>
    [DataContract]
    public partial class TeamMatchupGames :  IEquatable<TeamMatchupGames>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMatchupGames" /> class.
        /// </summary>
        /// <param name="season">season.</param>
        /// <param name="week">week.</param>
        /// <param name="seasonType">seasonType.</param>
        /// <param name="date">date.</param>
        /// <param name="neutralSite">neutralSite.</param>
        /// <param name="venue">venue.</param>
        /// <param name="homeTeam">homeTeam.</param>
        /// <param name="homeScore">homeScore.</param>
        /// <param name="awayTeam">awayTeam.</param>
        /// <param name="awayScore">awayScore.</param>
        /// <param name="winner">winner.</param>
        public TeamMatchupGames(int? season = default(int?), int? week = default(int?), string seasonType = default(string), string date = default(string), bool? neutralSite = default(bool?), string venue = default(string), string homeTeam = default(string), int? homeScore = default(int?), string awayTeam = default(string), int? awayScore = default(int?), string winner = default(string))
        {
            this.Season = season;
            this.Week = week;
            this.SeasonType = seasonType;
            this.Date = date;
            this.NeutralSite = neutralSite;
            this.Venue = venue;
            this.HomeTeam = homeTeam;
            this.HomeScore = homeScore;
            this.AwayTeam = awayTeam;
            this.AwayScore = awayScore;
            this.Winner = winner;
        }
        
        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name="season", EmitDefaultValue=false)]
        public int? Season { get; set; }

        /// <summary>
        /// Gets or Sets Week
        /// </summary>
        [DataMember(Name="week", EmitDefaultValue=false)]
        public int? Week { get; set; }

        /// <summary>
        /// Gets or Sets SeasonType
        /// </summary>
        [DataMember(Name="season_type", EmitDefaultValue=false)]
        public string SeasonType { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }

        /// <summary>
        /// Gets or Sets NeutralSite
        /// </summary>
        [DataMember(Name="neutralSite", EmitDefaultValue=false)]
        public bool? NeutralSite { get; set; }

        /// <summary>
        /// Gets or Sets Venue
        /// </summary>
        [DataMember(Name="venue", EmitDefaultValue=false)]
        public string Venue { get; set; }

        /// <summary>
        /// Gets or Sets HomeTeam
        /// </summary>
        [DataMember(Name="homeTeam", EmitDefaultValue=false)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// Gets or Sets HomeScore
        /// </summary>
        [DataMember(Name="homeScore", EmitDefaultValue=false)]
        public int? HomeScore { get; set; }

        /// <summary>
        /// Gets or Sets AwayTeam
        /// </summary>
        [DataMember(Name="awayTeam", EmitDefaultValue=false)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// Gets or Sets AwayScore
        /// </summary>
        [DataMember(Name="awayScore", EmitDefaultValue=false)]
        public int? AwayScore { get; set; }

        /// <summary>
        /// Gets or Sets Winner
        /// </summary>
        [DataMember(Name="winner", EmitDefaultValue=false)]
        public string Winner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamMatchupGames {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
            sb.Append("  SeasonType: ").Append(SeasonType).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  NeutralSite: ").Append(NeutralSite).Append("\n");
            sb.Append("  Venue: ").Append(Venue).Append("\n");
            sb.Append("  HomeTeam: ").Append(HomeTeam).Append("\n");
            sb.Append("  HomeScore: ").Append(HomeScore).Append("\n");
            sb.Append("  AwayTeam: ").Append(AwayTeam).Append("\n");
            sb.Append("  AwayScore: ").Append(AwayScore).Append("\n");
            sb.Append("  Winner: ").Append(Winner).Append("\n");
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
            return this.Equals(input as TeamMatchupGames);
        }

        /// <summary>
        /// Returns true if TeamMatchupGames instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamMatchupGames to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamMatchupGames input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Season == input.Season ||
                    (this.Season != null &&
                    this.Season.Equals(input.Season))
                ) && 
                (
                    this.Week == input.Week ||
                    (this.Week != null &&
                    this.Week.Equals(input.Week))
                ) && 
                (
                    this.SeasonType == input.SeasonType ||
                    (this.SeasonType != null &&
                    this.SeasonType.Equals(input.SeasonType))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.NeutralSite == input.NeutralSite ||
                    (this.NeutralSite != null &&
                    this.NeutralSite.Equals(input.NeutralSite))
                ) && 
                (
                    this.Venue == input.Venue ||
                    (this.Venue != null &&
                    this.Venue.Equals(input.Venue))
                ) && 
                (
                    this.HomeTeam == input.HomeTeam ||
                    (this.HomeTeam != null &&
                    this.HomeTeam.Equals(input.HomeTeam))
                ) && 
                (
                    this.HomeScore == input.HomeScore ||
                    (this.HomeScore != null &&
                    this.HomeScore.Equals(input.HomeScore))
                ) && 
                (
                    this.AwayTeam == input.AwayTeam ||
                    (this.AwayTeam != null &&
                    this.AwayTeam.Equals(input.AwayTeam))
                ) && 
                (
                    this.AwayScore == input.AwayScore ||
                    (this.AwayScore != null &&
                    this.AwayScore.Equals(input.AwayScore))
                ) && 
                (
                    this.Winner == input.Winner ||
                    (this.Winner != null &&
                    this.Winner.Equals(input.Winner))
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
                if (this.Season != null)
                    hashCode = hashCode * 59 + this.Season.GetHashCode();
                if (this.Week != null)
                    hashCode = hashCode * 59 + this.Week.GetHashCode();
                if (this.SeasonType != null)
                    hashCode = hashCode * 59 + this.SeasonType.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.NeutralSite != null)
                    hashCode = hashCode * 59 + this.NeutralSite.GetHashCode();
                if (this.Venue != null)
                    hashCode = hashCode * 59 + this.Venue.GetHashCode();
                if (this.HomeTeam != null)
                    hashCode = hashCode * 59 + this.HomeTeam.GetHashCode();
                if (this.HomeScore != null)
                    hashCode = hashCode * 59 + this.HomeScore.GetHashCode();
                if (this.AwayTeam != null)
                    hashCode = hashCode * 59 + this.AwayTeam.GetHashCode();
                if (this.AwayScore != null)
                    hashCode = hashCode * 59 + this.AwayScore.GetHashCode();
                if (this.Winner != null)
                    hashCode = hashCode * 59 + this.Winner.GetHashCode();
                return hashCode;
            }
        }
    }

}
