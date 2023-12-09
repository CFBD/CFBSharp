/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.5.2
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
    /// BoxScoreTeamsFieldPosition
    /// </summary>
    [DataContract]
    public partial class BoxScoreTeamsFieldPosition :  IEquatable<BoxScoreTeamsFieldPosition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoxScoreTeamsFieldPosition" /> class.
        /// </summary>
        /// <param name="team">team.</param>
        /// <param name="averageStart">averageStart.</param>
        /// <param name="averageStartingPredictedPoints">averageStartingPredictedPoints.</param>
        public BoxScoreTeamsFieldPosition(string team = default(string), decimal? averageStart = default(decimal?), decimal? averageStartingPredictedPoints = default(decimal?))
        {
            this.Team = team;
            this.AverageStart = averageStart;
            this.AverageStartingPredictedPoints = averageStartingPredictedPoints;
        }
        
        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets AverageStart
        /// </summary>
        [DataMember(Name="averageStart", EmitDefaultValue=false)]
        public decimal? AverageStart { get; set; }

        /// <summary>
        /// Gets or Sets AverageStartingPredictedPoints
        /// </summary>
        [DataMember(Name="averageStartingPredictedPoints", EmitDefaultValue=false)]
        public decimal? AverageStartingPredictedPoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoxScoreTeamsFieldPosition {\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  AverageStart: ").Append(AverageStart).Append("\n");
            sb.Append("  AverageStartingPredictedPoints: ").Append(AverageStartingPredictedPoints).Append("\n");
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
            return this.Equals(input as BoxScoreTeamsFieldPosition);
        }

        /// <summary>
        /// Returns true if BoxScoreTeamsFieldPosition instances are equal
        /// </summary>
        /// <param name="input">Instance of BoxScoreTeamsFieldPosition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoxScoreTeamsFieldPosition input)
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
                    this.AverageStart == input.AverageStart ||
                    (this.AverageStart != null &&
                    this.AverageStart.Equals(input.AverageStart))
                ) && 
                (
                    this.AverageStartingPredictedPoints == input.AverageStartingPredictedPoints ||
                    (this.AverageStartingPredictedPoints != null &&
                    this.AverageStartingPredictedPoints.Equals(input.AverageStartingPredictedPoints))
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
                if (this.AverageStart != null)
                    hashCode = hashCode * 59 + this.AverageStart.GetHashCode();
                if (this.AverageStartingPredictedPoints != null)
                    hashCode = hashCode * 59 + this.AverageStartingPredictedPoints.GetHashCode();
                return hashCode;
            }
        }
    }

}
