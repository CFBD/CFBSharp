/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 1.27.0
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
    /// ReturningProduction
    /// </summary>
    [DataContract]
    public partial class ReturningProduction :  IEquatable<ReturningProduction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturningProduction" /> class.
        /// </summary>
        /// <param name="team">team.</param>
        /// <param name="conference">conference.</param>
        /// <param name="totalPPA">totalPPA.</param>
        /// <param name="totalPassingPPA">totalPassingPPA.</param>
        /// <param name="totalReceivingPPA">totalReceivingPPA.</param>
        /// <param name="totalRushingPPA">totalRushingPPA.</param>
        /// <param name="percentPPA">percentPPA.</param>
        /// <param name="percentPassingPPA">percentPassingPPA.</param>
        /// <param name="percentReceivingPPA">percentReceivingPPA.</param>
        /// <param name="percentRushingPPA">percentRushingPPA.</param>
        /// <param name="usage">usage.</param>
        /// <param name="passingUsage">passingUsage.</param>
        /// <param name="receivingUsage">receivingUsage.</param>
        /// <param name="rushingUsage">rushingUsage.</param>
        public ReturningProduction(string team = default(string), string conference = default(string), decimal? totalPPA = default(decimal?), decimal? totalPassingPPA = default(decimal?), decimal? totalReceivingPPA = default(decimal?), decimal? totalRushingPPA = default(decimal?), decimal? percentPPA = default(decimal?), decimal? percentPassingPPA = default(decimal?), decimal? percentReceivingPPA = default(decimal?), decimal? percentRushingPPA = default(decimal?), decimal? usage = default(decimal?), decimal? passingUsage = default(decimal?), decimal? receivingUsage = default(decimal?), decimal? rushingUsage = default(decimal?))
        {
            this.Team = team;
            this.Conference = conference;
            this.TotalPPA = totalPPA;
            this.TotalPassingPPA = totalPassingPPA;
            this.TotalReceivingPPA = totalReceivingPPA;
            this.TotalRushingPPA = totalRushingPPA;
            this.PercentPPA = percentPPA;
            this.PercentPassingPPA = percentPassingPPA;
            this.PercentReceivingPPA = percentReceivingPPA;
            this.PercentRushingPPA = percentRushingPPA;
            this.Usage = usage;
            this.PassingUsage = passingUsage;
            this.ReceivingUsage = receivingUsage;
            this.RushingUsage = rushingUsage;
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
        /// Gets or Sets TotalPPA
        /// </summary>
        [DataMember(Name="totalPPA", EmitDefaultValue=false)]
        public decimal? TotalPPA { get; set; }

        /// <summary>
        /// Gets or Sets TotalPassingPPA
        /// </summary>
        [DataMember(Name="totalPassingPPA", EmitDefaultValue=false)]
        public decimal? TotalPassingPPA { get; set; }

        /// <summary>
        /// Gets or Sets TotalReceivingPPA
        /// </summary>
        [DataMember(Name="totalReceivingPPA", EmitDefaultValue=false)]
        public decimal? TotalReceivingPPA { get; set; }

        /// <summary>
        /// Gets or Sets TotalRushingPPA
        /// </summary>
        [DataMember(Name="totalRushingPPA", EmitDefaultValue=false)]
        public decimal? TotalRushingPPA { get; set; }

        /// <summary>
        /// Gets or Sets PercentPPA
        /// </summary>
        [DataMember(Name="percentPPA", EmitDefaultValue=false)]
        public decimal? PercentPPA { get; set; }

        /// <summary>
        /// Gets or Sets PercentPassingPPA
        /// </summary>
        [DataMember(Name="percentPassingPPA", EmitDefaultValue=false)]
        public decimal? PercentPassingPPA { get; set; }

        /// <summary>
        /// Gets or Sets PercentReceivingPPA
        /// </summary>
        [DataMember(Name="percentReceivingPPA", EmitDefaultValue=false)]
        public decimal? PercentReceivingPPA { get; set; }

        /// <summary>
        /// Gets or Sets PercentRushingPPA
        /// </summary>
        [DataMember(Name="percentRushingPPA", EmitDefaultValue=false)]
        public decimal? PercentRushingPPA { get; set; }

        /// <summary>
        /// Gets or Sets Usage
        /// </summary>
        [DataMember(Name="usage", EmitDefaultValue=false)]
        public decimal? Usage { get; set; }

        /// <summary>
        /// Gets or Sets PassingUsage
        /// </summary>
        [DataMember(Name="passingUsage", EmitDefaultValue=false)]
        public decimal? PassingUsage { get; set; }

        /// <summary>
        /// Gets or Sets ReceivingUsage
        /// </summary>
        [DataMember(Name="receivingUsage", EmitDefaultValue=false)]
        public decimal? ReceivingUsage { get; set; }

        /// <summary>
        /// Gets or Sets RushingUsage
        /// </summary>
        [DataMember(Name="rushingUsage", EmitDefaultValue=false)]
        public decimal? RushingUsage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReturningProduction {\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  TotalPPA: ").Append(TotalPPA).Append("\n");
            sb.Append("  TotalPassingPPA: ").Append(TotalPassingPPA).Append("\n");
            sb.Append("  TotalReceivingPPA: ").Append(TotalReceivingPPA).Append("\n");
            sb.Append("  TotalRushingPPA: ").Append(TotalRushingPPA).Append("\n");
            sb.Append("  PercentPPA: ").Append(PercentPPA).Append("\n");
            sb.Append("  PercentPassingPPA: ").Append(PercentPassingPPA).Append("\n");
            sb.Append("  PercentReceivingPPA: ").Append(PercentReceivingPPA).Append("\n");
            sb.Append("  PercentRushingPPA: ").Append(PercentRushingPPA).Append("\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
            sb.Append("  PassingUsage: ").Append(PassingUsage).Append("\n");
            sb.Append("  ReceivingUsage: ").Append(ReceivingUsage).Append("\n");
            sb.Append("  RushingUsage: ").Append(RushingUsage).Append("\n");
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
            return this.Equals(input as ReturningProduction);
        }

        /// <summary>
        /// Returns true if ReturningProduction instances are equal
        /// </summary>
        /// <param name="input">Instance of ReturningProduction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReturningProduction input)
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
                    this.TotalPPA == input.TotalPPA ||
                    (this.TotalPPA != null &&
                    this.TotalPPA.Equals(input.TotalPPA))
                ) && 
                (
                    this.TotalPassingPPA == input.TotalPassingPPA ||
                    (this.TotalPassingPPA != null &&
                    this.TotalPassingPPA.Equals(input.TotalPassingPPA))
                ) && 
                (
                    this.TotalReceivingPPA == input.TotalReceivingPPA ||
                    (this.TotalReceivingPPA != null &&
                    this.TotalReceivingPPA.Equals(input.TotalReceivingPPA))
                ) && 
                (
                    this.TotalRushingPPA == input.TotalRushingPPA ||
                    (this.TotalRushingPPA != null &&
                    this.TotalRushingPPA.Equals(input.TotalRushingPPA))
                ) && 
                (
                    this.PercentPPA == input.PercentPPA ||
                    (this.PercentPPA != null &&
                    this.PercentPPA.Equals(input.PercentPPA))
                ) && 
                (
                    this.PercentPassingPPA == input.PercentPassingPPA ||
                    (this.PercentPassingPPA != null &&
                    this.PercentPassingPPA.Equals(input.PercentPassingPPA))
                ) && 
                (
                    this.PercentReceivingPPA == input.PercentReceivingPPA ||
                    (this.PercentReceivingPPA != null &&
                    this.PercentReceivingPPA.Equals(input.PercentReceivingPPA))
                ) && 
                (
                    this.PercentRushingPPA == input.PercentRushingPPA ||
                    (this.PercentRushingPPA != null &&
                    this.PercentRushingPPA.Equals(input.PercentRushingPPA))
                ) && 
                (
                    this.Usage == input.Usage ||
                    (this.Usage != null &&
                    this.Usage.Equals(input.Usage))
                ) && 
                (
                    this.PassingUsage == input.PassingUsage ||
                    (this.PassingUsage != null &&
                    this.PassingUsage.Equals(input.PassingUsage))
                ) && 
                (
                    this.ReceivingUsage == input.ReceivingUsage ||
                    (this.ReceivingUsage != null &&
                    this.ReceivingUsage.Equals(input.ReceivingUsage))
                ) && 
                (
                    this.RushingUsage == input.RushingUsage ||
                    (this.RushingUsage != null &&
                    this.RushingUsage.Equals(input.RushingUsage))
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
                if (this.TotalPPA != null)
                    hashCode = hashCode * 59 + this.TotalPPA.GetHashCode();
                if (this.TotalPassingPPA != null)
                    hashCode = hashCode * 59 + this.TotalPassingPPA.GetHashCode();
                if (this.TotalReceivingPPA != null)
                    hashCode = hashCode * 59 + this.TotalReceivingPPA.GetHashCode();
                if (this.TotalRushingPPA != null)
                    hashCode = hashCode * 59 + this.TotalRushingPPA.GetHashCode();
                if (this.PercentPPA != null)
                    hashCode = hashCode * 59 + this.PercentPPA.GetHashCode();
                if (this.PercentPassingPPA != null)
                    hashCode = hashCode * 59 + this.PercentPassingPPA.GetHashCode();
                if (this.PercentReceivingPPA != null)
                    hashCode = hashCode * 59 + this.PercentReceivingPPA.GetHashCode();
                if (this.PercentRushingPPA != null)
                    hashCode = hashCode * 59 + this.PercentRushingPPA.GetHashCode();
                if (this.Usage != null)
                    hashCode = hashCode * 59 + this.Usage.GetHashCode();
                if (this.PassingUsage != null)
                    hashCode = hashCode * 59 + this.PassingUsage.GetHashCode();
                if (this.ReceivingUsage != null)
                    hashCode = hashCode * 59 + this.ReceivingUsage.GetHashCode();
                if (this.RushingUsage != null)
                    hashCode = hashCode * 59 + this.RushingUsage.GetHashCode();
                return hashCode;
            }
        }
    }

}