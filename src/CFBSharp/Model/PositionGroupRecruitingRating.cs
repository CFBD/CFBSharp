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
    /// PositionGroupRecruitingRating
    /// </summary>
    [DataContract]
    public partial class PositionGroupRecruitingRating :  IEquatable<PositionGroupRecruitingRating>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PositionGroupRecruitingRating" /> class.
        /// </summary>
        /// <param name="team">team.</param>
        /// <param name="conference">conference.</param>
        /// <param name="positionGroup">positionGroup.</param>
        /// <param name="averageRating">averageRating.</param>
        /// <param name="totalRating">totalRating.</param>
        /// <param name="commits">commits.</param>
        /// <param name="averageStars">averageStars.</param>
        public PositionGroupRecruitingRating(string team = default(string), string conference = default(string), string positionGroup = default(string), decimal? averageRating = default(decimal?), decimal? totalRating = default(decimal?), decimal? commits = default(decimal?), decimal? averageStars = default(decimal?))
        {
            this.Team = team;
            this.Conference = conference;
            this.PositionGroup = positionGroup;
            this.AverageRating = averageRating;
            this.TotalRating = totalRating;
            this.Commits = commits;
            this.AverageStars = averageStars;
        }
        
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
        /// Gets or Sets PositionGroup
        /// </summary>
        [DataMember(Name="positionGroup", EmitDefaultValue=false)]
        public string PositionGroup { get; set; }

        /// <summary>
        /// Gets or Sets AverageRating
        /// </summary>
        [DataMember(Name="averageRating", EmitDefaultValue=false)]
        public decimal? AverageRating { get; set; }

        /// <summary>
        /// Gets or Sets TotalRating
        /// </summary>
        [DataMember(Name="totalRating", EmitDefaultValue=false)]
        public decimal? TotalRating { get; set; }

        /// <summary>
        /// Gets or Sets Commits
        /// </summary>
        [DataMember(Name="commits", EmitDefaultValue=false)]
        public decimal? Commits { get; set; }

        /// <summary>
        /// Gets or Sets AverageStars
        /// </summary>
        [DataMember(Name="averageStars", EmitDefaultValue=false)]
        public decimal? AverageStars { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PositionGroupRecruitingRating {\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  PositionGroup: ").Append(PositionGroup).Append("\n");
            sb.Append("  AverageRating: ").Append(AverageRating).Append("\n");
            sb.Append("  TotalRating: ").Append(TotalRating).Append("\n");
            sb.Append("  Commits: ").Append(Commits).Append("\n");
            sb.Append("  AverageStars: ").Append(AverageStars).Append("\n");
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
            return this.Equals(input as PositionGroupRecruitingRating);
        }

        /// <summary>
        /// Returns true if PositionGroupRecruitingRating instances are equal
        /// </summary>
        /// <param name="input">Instance of PositionGroupRecruitingRating to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PositionGroupRecruitingRating input)
        {
            if (input == null)
                return false;

            return 
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
                    this.PositionGroup == input.PositionGroup ||
                    (this.PositionGroup != null &&
                    this.PositionGroup.Equals(input.PositionGroup))
                ) && 
                (
                    this.AverageRating == input.AverageRating ||
                    (this.AverageRating != null &&
                    this.AverageRating.Equals(input.AverageRating))
                ) && 
                (
                    this.TotalRating == input.TotalRating ||
                    (this.TotalRating != null &&
                    this.TotalRating.Equals(input.TotalRating))
                ) && 
                (
                    this.Commits == input.Commits ||
                    (this.Commits != null &&
                    this.Commits.Equals(input.Commits))
                ) && 
                (
                    this.AverageStars == input.AverageStars ||
                    (this.AverageStars != null &&
                    this.AverageStars.Equals(input.AverageStars))
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
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.Conference != null)
                    hashCode = hashCode * 59 + this.Conference.GetHashCode();
                if (this.PositionGroup != null)
                    hashCode = hashCode * 59 + this.PositionGroup.GetHashCode();
                if (this.AverageRating != null)
                    hashCode = hashCode * 59 + this.AverageRating.GetHashCode();
                if (this.TotalRating != null)
                    hashCode = hashCode * 59 + this.TotalRating.GetHashCode();
                if (this.Commits != null)
                    hashCode = hashCode * 59 + this.Commits.GetHashCode();
                if (this.AverageStars != null)
                    hashCode = hashCode * 59 + this.AverageStars.GetHashCode();
                return hashCode;
            }
        }
    }

}
