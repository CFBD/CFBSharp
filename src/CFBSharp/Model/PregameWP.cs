/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 2.3.0
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
    /// PregameWP
    /// </summary>
    [DataContract]
    public partial class PregameWP :  IEquatable<PregameWP>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PregameWP" /> class.
        /// </summary>
        /// <param name="season">season.</param>
        /// <param name="seasonType">seasonType.</param>
        /// <param name="week">week.</param>
        /// <param name="gameId">gameId.</param>
        /// <param name="homeTeam">homeTeam.</param>
        /// <param name="awayTeam">awayTeam.</param>
        /// <param name="spread">spread.</param>
        /// <param name="homeWinProb">homeWinProb.</param>
        public PregameWP(int? season = default(int?), string seasonType = default(string), int? week = default(int?), int? gameId = default(int?), string homeTeam = default(string), string awayTeam = default(string), decimal? spread = default(decimal?), decimal? homeWinProb = default(decimal?))
        {
            this.Season = season;
            this.SeasonType = seasonType;
            this.Week = week;
            this.GameId = gameId;
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.Spread = spread;
            this.HomeWinProb = homeWinProb;
        }
        
        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name="season", EmitDefaultValue=false)]
        public int? Season { get; set; }

        /// <summary>
        /// Gets or Sets SeasonType
        /// </summary>
        [DataMember(Name="seasonType", EmitDefaultValue=false)]
        public string SeasonType { get; set; }

        /// <summary>
        /// Gets or Sets Week
        /// </summary>
        [DataMember(Name="week", EmitDefaultValue=false)]
        public int? Week { get; set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name="gameId", EmitDefaultValue=false)]
        public int? GameId { get; set; }

        /// <summary>
        /// Gets or Sets HomeTeam
        /// </summary>
        [DataMember(Name="homeTeam", EmitDefaultValue=false)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// Gets or Sets AwayTeam
        /// </summary>
        [DataMember(Name="awayTeam", EmitDefaultValue=false)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// Gets or Sets Spread
        /// </summary>
        [DataMember(Name="spread", EmitDefaultValue=false)]
        public decimal? Spread { get; set; }

        /// <summary>
        /// Gets or Sets HomeWinProb
        /// </summary>
        [DataMember(Name="homeWinProb", EmitDefaultValue=false)]
        public decimal? HomeWinProb { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PregameWP {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  SeasonType: ").Append(SeasonType).Append("\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  HomeTeam: ").Append(HomeTeam).Append("\n");
            sb.Append("  AwayTeam: ").Append(AwayTeam).Append("\n");
            sb.Append("  Spread: ").Append(Spread).Append("\n");
            sb.Append("  HomeWinProb: ").Append(HomeWinProb).Append("\n");
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
            return this.Equals(input as PregameWP);
        }

        /// <summary>
        /// Returns true if PregameWP instances are equal
        /// </summary>
        /// <param name="input">Instance of PregameWP to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PregameWP input)
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
                    this.SeasonType == input.SeasonType ||
                    (this.SeasonType != null &&
                    this.SeasonType.Equals(input.SeasonType))
                ) && 
                (
                    this.Week == input.Week ||
                    (this.Week != null &&
                    this.Week.Equals(input.Week))
                ) && 
                (
                    this.GameId == input.GameId ||
                    (this.GameId != null &&
                    this.GameId.Equals(input.GameId))
                ) && 
                (
                    this.HomeTeam == input.HomeTeam ||
                    (this.HomeTeam != null &&
                    this.HomeTeam.Equals(input.HomeTeam))
                ) && 
                (
                    this.AwayTeam == input.AwayTeam ||
                    (this.AwayTeam != null &&
                    this.AwayTeam.Equals(input.AwayTeam))
                ) && 
                (
                    this.Spread == input.Spread ||
                    (this.Spread != null &&
                    this.Spread.Equals(input.Spread))
                ) && 
                (
                    this.HomeWinProb == input.HomeWinProb ||
                    (this.HomeWinProb != null &&
                    this.HomeWinProb.Equals(input.HomeWinProb))
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
                if (this.SeasonType != null)
                    hashCode = hashCode * 59 + this.SeasonType.GetHashCode();
                if (this.Week != null)
                    hashCode = hashCode * 59 + this.Week.GetHashCode();
                if (this.GameId != null)
                    hashCode = hashCode * 59 + this.GameId.GetHashCode();
                if (this.HomeTeam != null)
                    hashCode = hashCode * 59 + this.HomeTeam.GetHashCode();
                if (this.AwayTeam != null)
                    hashCode = hashCode * 59 + this.AwayTeam.GetHashCode();
                if (this.Spread != null)
                    hashCode = hashCode * 59 + this.Spread.GetHashCode();
                if (this.HomeWinProb != null)
                    hashCode = hashCode * 59 + this.HomeWinProb.GetHashCode();
                return hashCode;
            }
        }
    }

}
