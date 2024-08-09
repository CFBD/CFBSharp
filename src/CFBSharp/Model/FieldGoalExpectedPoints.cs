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
    /// FieldGoalExpectedPoints
    /// </summary>
    [DataContract]
    public partial class FieldGoalExpectedPoints :  IEquatable<FieldGoalExpectedPoints>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldGoalExpectedPoints" /> class.
        /// </summary>
        /// <param name="yardsToGoal">yardsToGoal.</param>
        /// <param name="distance">distance.</param>
        /// <param name="expectedPoints">expectedPoints.</param>
        public FieldGoalExpectedPoints(int? yardsToGoal = default(int?), int? distance = default(int?), decimal? expectedPoints = default(decimal?))
        {
            this.YardsToGoal = yardsToGoal;
            this.Distance = distance;
            this.ExpectedPoints = expectedPoints;
        }
        
        /// <summary>
        /// Gets or Sets YardsToGoal
        /// </summary>
        [DataMember(Name="yardsToGoal", EmitDefaultValue=false)]
        public int? YardsToGoal { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public int? Distance { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedPoints
        /// </summary>
        [DataMember(Name="expectedPoints", EmitDefaultValue=false)]
        public decimal? ExpectedPoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldGoalExpectedPoints {\n");
            sb.Append("  YardsToGoal: ").Append(YardsToGoal).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  ExpectedPoints: ").Append(ExpectedPoints).Append("\n");
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
            return this.Equals(input as FieldGoalExpectedPoints);
        }

        /// <summary>
        /// Returns true if FieldGoalExpectedPoints instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldGoalExpectedPoints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldGoalExpectedPoints input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.YardsToGoal == input.YardsToGoal ||
                    (this.YardsToGoal != null &&
                    this.YardsToGoal.Equals(input.YardsToGoal))
                ) && 
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
                ) && 
                (
                    this.ExpectedPoints == input.ExpectedPoints ||
                    (this.ExpectedPoints != null &&
                    this.ExpectedPoints.Equals(input.ExpectedPoints))
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
                if (this.YardsToGoal != null)
                    hashCode = hashCode * 59 + this.YardsToGoal.GetHashCode();
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
                if (this.ExpectedPoints != null)
                    hashCode = hashCode * 59 + this.ExpectedPoints.GetHashCode();
                return hashCode;
            }
        }
    }

}