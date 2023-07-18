/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.4.13
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
    /// BoxScoreTeamsScoringOpportunities
    /// </summary>
    [DataContract]
    public partial class BoxScoreTeamsScoringOpportunities :  IEquatable<BoxScoreTeamsScoringOpportunities>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoxScoreTeamsScoringOpportunities" /> class.
        /// </summary>
        /// <param name="team">team.</param>
        /// <param name="opportunities">opportunities.</param>
        /// <param name="points">points.</param>
        /// <param name="pointsPerOpportunity">pointsPerOpportunity.</param>
        public BoxScoreTeamsScoringOpportunities(string team = default(string), int? opportunities = default(int?), int? points = default(int?), decimal? pointsPerOpportunity = default(decimal?))
        {
            this.Team = team;
            this.Opportunities = opportunities;
            this.Points = points;
            this.PointsPerOpportunity = pointsPerOpportunity;
        }
        
        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Opportunities
        /// </summary>
        [DataMember(Name="opportunities", EmitDefaultValue=false)]
        public int? Opportunities { get; set; }

        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [DataMember(Name="points", EmitDefaultValue=false)]
        public int? Points { get; set; }

        /// <summary>
        /// Gets or Sets PointsPerOpportunity
        /// </summary>
        [DataMember(Name="pointsPerOpportunity", EmitDefaultValue=false)]
        public decimal? PointsPerOpportunity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoxScoreTeamsScoringOpportunities {\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Opportunities: ").Append(Opportunities).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  PointsPerOpportunity: ").Append(PointsPerOpportunity).Append("\n");
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
            return this.Equals(input as BoxScoreTeamsScoringOpportunities);
        }

        /// <summary>
        /// Returns true if BoxScoreTeamsScoringOpportunities instances are equal
        /// </summary>
        /// <param name="input">Instance of BoxScoreTeamsScoringOpportunities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoxScoreTeamsScoringOpportunities input)
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
                    this.Opportunities == input.Opportunities ||
                    (this.Opportunities != null &&
                    this.Opportunities.Equals(input.Opportunities))
                ) && 
                (
                    this.Points == input.Points ||
                    (this.Points != null &&
                    this.Points.Equals(input.Points))
                ) && 
                (
                    this.PointsPerOpportunity == input.PointsPerOpportunity ||
                    (this.PointsPerOpportunity != null &&
                    this.PointsPerOpportunity.Equals(input.PointsPerOpportunity))
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
                if (this.Opportunities != null)
                    hashCode = hashCode * 59 + this.Opportunities.GetHashCode();
                if (this.Points != null)
                    hashCode = hashCode * 59 + this.Points.GetHashCode();
                if (this.PointsPerOpportunity != null)
                    hashCode = hashCode * 59 + this.PointsPerOpportunity.GetHashCode();
                return hashCode;
            }
        }
    }

}
