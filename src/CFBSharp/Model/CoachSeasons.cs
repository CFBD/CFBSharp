/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.4.4
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
    /// CoachSeasons
    /// </summary>
    [DataContract]
    public partial class CoachSeasons :  IEquatable<CoachSeasons>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoachSeasons" /> class.
        /// </summary>
        /// <param name="school">school.</param>
        /// <param name="year">year.</param>
        /// <param name="games">games.</param>
        /// <param name="wins">wins.</param>
        /// <param name="losses">losses.</param>
        /// <param name="ties">ties.</param>
        /// <param name="preseasonRank">Rank in the AP preseason poll.</param>
        /// <param name="postseasonRank">Final ranking in the AP poll.</param>
        /// <param name="srs">Final SRS rankings.</param>
        /// <param name="spOverall">Final overall SP+ rating.</param>
        /// <param name="spOffense">Final SP+ offensive rating.</param>
        /// <param name="spDefense">Final SP+ defensive rating.</param>
        public CoachSeasons(string school = default(string), string year = default(string), int? games = default(int?), int? wins = default(int?), int? losses = default(int?), int? ties = default(int?), int? preseasonRank = default(int?), int? postseasonRank = default(int?), decimal? srs = default(decimal?), decimal? spOverall = default(decimal?), decimal? spOffense = default(decimal?), decimal? spDefense = default(decimal?))
        {
            this.School = school;
            this.Year = year;
            this.Games = games;
            this.Wins = wins;
            this.Losses = losses;
            this.Ties = ties;
            this.PreseasonRank = preseasonRank;
            this.PostseasonRank = postseasonRank;
            this.Srs = srs;
            this.SpOverall = spOverall;
            this.SpOffense = spOffense;
            this.SpDefense = spDefense;
        }
        
        /// <summary>
        /// Gets or Sets School
        /// </summary>
        [DataMember(Name="school", EmitDefaultValue=false)]
        public string School { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public string Year { get; set; }

        /// <summary>
        /// Gets or Sets Games
        /// </summary>
        [DataMember(Name="games", EmitDefaultValue=false)]
        public int? Games { get; set; }

        /// <summary>
        /// Gets or Sets Wins
        /// </summary>
        [DataMember(Name="wins", EmitDefaultValue=false)]
        public int? Wins { get; set; }

        /// <summary>
        /// Gets or Sets Losses
        /// </summary>
        [DataMember(Name="losses", EmitDefaultValue=false)]
        public int? Losses { get; set; }

        /// <summary>
        /// Gets or Sets Ties
        /// </summary>
        [DataMember(Name="ties", EmitDefaultValue=false)]
        public int? Ties { get; set; }

        /// <summary>
        /// Rank in the AP preseason poll
        /// </summary>
        /// <value>Rank in the AP preseason poll</value>
        [DataMember(Name="preseason_rank", EmitDefaultValue=false)]
        public int? PreseasonRank { get; set; }

        /// <summary>
        /// Final ranking in the AP poll
        /// </summary>
        /// <value>Final ranking in the AP poll</value>
        [DataMember(Name="postseason_rank", EmitDefaultValue=false)]
        public int? PostseasonRank { get; set; }

        /// <summary>
        /// Final SRS rankings
        /// </summary>
        /// <value>Final SRS rankings</value>
        [DataMember(Name="srs", EmitDefaultValue=false)]
        public decimal? Srs { get; set; }

        /// <summary>
        /// Final overall SP+ rating
        /// </summary>
        /// <value>Final overall SP+ rating</value>
        [DataMember(Name="sp_overall", EmitDefaultValue=false)]
        public decimal? SpOverall { get; set; }

        /// <summary>
        /// Final SP+ offensive rating
        /// </summary>
        /// <value>Final SP+ offensive rating</value>
        [DataMember(Name="sp_offense", EmitDefaultValue=false)]
        public decimal? SpOffense { get; set; }

        /// <summary>
        /// Final SP+ defensive rating
        /// </summary>
        /// <value>Final SP+ defensive rating</value>
        [DataMember(Name="sp_defense", EmitDefaultValue=false)]
        public decimal? SpDefense { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CoachSeasons {\n");
            sb.Append("  School: ").Append(School).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Games: ").Append(Games).Append("\n");
            sb.Append("  Wins: ").Append(Wins).Append("\n");
            sb.Append("  Losses: ").Append(Losses).Append("\n");
            sb.Append("  Ties: ").Append(Ties).Append("\n");
            sb.Append("  PreseasonRank: ").Append(PreseasonRank).Append("\n");
            sb.Append("  PostseasonRank: ").Append(PostseasonRank).Append("\n");
            sb.Append("  Srs: ").Append(Srs).Append("\n");
            sb.Append("  SpOverall: ").Append(SpOverall).Append("\n");
            sb.Append("  SpOffense: ").Append(SpOffense).Append("\n");
            sb.Append("  SpDefense: ").Append(SpDefense).Append("\n");
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
            return this.Equals(input as CoachSeasons);
        }

        /// <summary>
        /// Returns true if CoachSeasons instances are equal
        /// </summary>
        /// <param name="input">Instance of CoachSeasons to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CoachSeasons input)
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
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
                ) && 
                (
                    this.Games == input.Games ||
                    (this.Games != null &&
                    this.Games.Equals(input.Games))
                ) && 
                (
                    this.Wins == input.Wins ||
                    (this.Wins != null &&
                    this.Wins.Equals(input.Wins))
                ) && 
                (
                    this.Losses == input.Losses ||
                    (this.Losses != null &&
                    this.Losses.Equals(input.Losses))
                ) && 
                (
                    this.Ties == input.Ties ||
                    (this.Ties != null &&
                    this.Ties.Equals(input.Ties))
                ) && 
                (
                    this.PreseasonRank == input.PreseasonRank ||
                    (this.PreseasonRank != null &&
                    this.PreseasonRank.Equals(input.PreseasonRank))
                ) && 
                (
                    this.PostseasonRank == input.PostseasonRank ||
                    (this.PostseasonRank != null &&
                    this.PostseasonRank.Equals(input.PostseasonRank))
                ) && 
                (
                    this.Srs == input.Srs ||
                    (this.Srs != null &&
                    this.Srs.Equals(input.Srs))
                ) && 
                (
                    this.SpOverall == input.SpOverall ||
                    (this.SpOverall != null &&
                    this.SpOverall.Equals(input.SpOverall))
                ) && 
                (
                    this.SpOffense == input.SpOffense ||
                    (this.SpOffense != null &&
                    this.SpOffense.Equals(input.SpOffense))
                ) && 
                (
                    this.SpDefense == input.SpDefense ||
                    (this.SpDefense != null &&
                    this.SpDefense.Equals(input.SpDefense))
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
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.Games != null)
                    hashCode = hashCode * 59 + this.Games.GetHashCode();
                if (this.Wins != null)
                    hashCode = hashCode * 59 + this.Wins.GetHashCode();
                if (this.Losses != null)
                    hashCode = hashCode * 59 + this.Losses.GetHashCode();
                if (this.Ties != null)
                    hashCode = hashCode * 59 + this.Ties.GetHashCode();
                if (this.PreseasonRank != null)
                    hashCode = hashCode * 59 + this.PreseasonRank.GetHashCode();
                if (this.PostseasonRank != null)
                    hashCode = hashCode * 59 + this.PostseasonRank.GetHashCode();
                if (this.Srs != null)
                    hashCode = hashCode * 59 + this.Srs.GetHashCode();
                if (this.SpOverall != null)
                    hashCode = hashCode * 59 + this.SpOverall.GetHashCode();
                if (this.SpOffense != null)
                    hashCode = hashCode * 59 + this.SpOffense.GetHashCode();
                if (this.SpDefense != null)
                    hashCode = hashCode * 59 + this.SpDefense.GetHashCode();
                return hashCode;
            }
        }
    }

}
