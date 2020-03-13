/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 1.25.0
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
    /// AdvancedSeasonStatDefense
    /// </summary>
    [DataContract]
    public partial class AdvancedSeasonStatDefense :  IEquatable<AdvancedSeasonStatDefense>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedSeasonStatDefense" /> class.
        /// </summary>
        /// <param name="plays">plays.</param>
        /// <param name="drives">drives.</param>
        /// <param name="ppa">ppa.</param>
        /// <param name="totalPPA">totalPPA.</param>
        /// <param name="successRate">successRate.</param>
        /// <param name="explosiveness">explosiveness.</param>
        /// <param name="powerSuccess">powerSuccess.</param>
        /// <param name="stuffRate">stuffRate.</param>
        /// <param name="lineYards">lineYards.</param>
        /// <param name="lineYardsTotal">lineYardsTotal.</param>
        /// <param name="secondLevelYards">secondLevelYards.</param>
        /// <param name="secondLevelYardsTotal">secondLevelYardsTotal.</param>
        /// <param name="openFieldYards">openFieldYards.</param>
        /// <param name="openFieldYardsTotal">openFieldYardsTotal.</param>
        /// <param name="pointsPerOpportunity">pointsPerOpportunity.</param>
        /// <param name="fieldPosition">fieldPosition.</param>
        /// <param name="havoc">havoc.</param>
        /// <param name="standardDowns">standardDowns.</param>
        /// <param name="passingDowns">passingDowns.</param>
        /// <param name="rushingPlays">rushingPlays.</param>
        /// <param name="passingPlays">passingPlays.</param>
        public AdvancedSeasonStatDefense(int? plays = default(int?), int? drives = default(int?), decimal? ppa = default(decimal?), decimal? totalPPA = default(decimal?), decimal? successRate = default(decimal?), decimal? explosiveness = default(decimal?), decimal? powerSuccess = default(decimal?), decimal? stuffRate = default(decimal?), decimal? lineYards = default(decimal?), decimal? lineYardsTotal = default(decimal?), decimal? secondLevelYards = default(decimal?), int? secondLevelYardsTotal = default(int?), decimal? openFieldYards = default(decimal?), int? openFieldYardsTotal = default(int?), decimal? pointsPerOpportunity = default(decimal?), AdvancedSeasonStatOffenseFieldPosition fieldPosition = default(AdvancedSeasonStatOffenseFieldPosition), TeamSPRatingDefenseHavoc havoc = default(TeamSPRatingDefenseHavoc), AdvancedSeasonStatOffenseStandardDowns standardDowns = default(AdvancedSeasonStatOffenseStandardDowns), AdvancedSeasonStatOffenseStandardDowns passingDowns = default(AdvancedSeasonStatOffenseStandardDowns), AdvancedSeasonStatOffenseRushingPlays rushingPlays = default(AdvancedSeasonStatOffenseRushingPlays), AdvancedSeasonStatOffenseRushingPlays passingPlays = default(AdvancedSeasonStatOffenseRushingPlays))
        {
            this.Plays = plays;
            this.Drives = drives;
            this.Ppa = ppa;
            this.TotalPPA = totalPPA;
            this.SuccessRate = successRate;
            this.Explosiveness = explosiveness;
            this.PowerSuccess = powerSuccess;
            this.StuffRate = stuffRate;
            this.LineYards = lineYards;
            this.LineYardsTotal = lineYardsTotal;
            this.SecondLevelYards = secondLevelYards;
            this.SecondLevelYardsTotal = secondLevelYardsTotal;
            this.OpenFieldYards = openFieldYards;
            this.OpenFieldYardsTotal = openFieldYardsTotal;
            this.PointsPerOpportunity = pointsPerOpportunity;
            this.FieldPosition = fieldPosition;
            this.Havoc = havoc;
            this.StandardDowns = standardDowns;
            this.PassingDowns = passingDowns;
            this.RushingPlays = rushingPlays;
            this.PassingPlays = passingPlays;
        }
        
        /// <summary>
        /// Gets or Sets Plays
        /// </summary>
        [DataMember(Name="plays", EmitDefaultValue=false)]
        public int? Plays { get; set; }

        /// <summary>
        /// Gets or Sets Drives
        /// </summary>
        [DataMember(Name="drives", EmitDefaultValue=false)]
        public int? Drives { get; set; }

        /// <summary>
        /// Gets or Sets Ppa
        /// </summary>
        [DataMember(Name="ppa", EmitDefaultValue=false)]
        public decimal? Ppa { get; set; }

        /// <summary>
        /// Gets or Sets TotalPPA
        /// </summary>
        [DataMember(Name="totalPPA", EmitDefaultValue=false)]
        public decimal? TotalPPA { get; set; }

        /// <summary>
        /// Gets or Sets SuccessRate
        /// </summary>
        [DataMember(Name="successRate", EmitDefaultValue=false)]
        public decimal? SuccessRate { get; set; }

        /// <summary>
        /// Gets or Sets Explosiveness
        /// </summary>
        [DataMember(Name="explosiveness", EmitDefaultValue=false)]
        public decimal? Explosiveness { get; set; }

        /// <summary>
        /// Gets or Sets PowerSuccess
        /// </summary>
        [DataMember(Name="powerSuccess", EmitDefaultValue=false)]
        public decimal? PowerSuccess { get; set; }

        /// <summary>
        /// Gets or Sets StuffRate
        /// </summary>
        [DataMember(Name="stuffRate", EmitDefaultValue=false)]
        public decimal? StuffRate { get; set; }

        /// <summary>
        /// Gets or Sets LineYards
        /// </summary>
        [DataMember(Name="lineYards", EmitDefaultValue=false)]
        public decimal? LineYards { get; set; }

        /// <summary>
        /// Gets or Sets LineYardsTotal
        /// </summary>
        [DataMember(Name="lineYardsTotal", EmitDefaultValue=false)]
        public decimal? LineYardsTotal { get; set; }

        /// <summary>
        /// Gets or Sets SecondLevelYards
        /// </summary>
        [DataMember(Name="secondLevelYards", EmitDefaultValue=false)]
        public decimal? SecondLevelYards { get; set; }

        /// <summary>
        /// Gets or Sets SecondLevelYardsTotal
        /// </summary>
        [DataMember(Name="secondLevelYardsTotal", EmitDefaultValue=false)]
        public int? SecondLevelYardsTotal { get; set; }

        /// <summary>
        /// Gets or Sets OpenFieldYards
        /// </summary>
        [DataMember(Name="openFieldYards", EmitDefaultValue=false)]
        public decimal? OpenFieldYards { get; set; }

        /// <summary>
        /// Gets or Sets OpenFieldYardsTotal
        /// </summary>
        [DataMember(Name="openFieldYardsTotal", EmitDefaultValue=false)]
        public int? OpenFieldYardsTotal { get; set; }

        /// <summary>
        /// Gets or Sets PointsPerOpportunity
        /// </summary>
        [DataMember(Name="pointsPerOpportunity", EmitDefaultValue=false)]
        public decimal? PointsPerOpportunity { get; set; }

        /// <summary>
        /// Gets or Sets FieldPosition
        /// </summary>
        [DataMember(Name="fieldPosition", EmitDefaultValue=false)]
        public AdvancedSeasonStatOffenseFieldPosition FieldPosition { get; set; }

        /// <summary>
        /// Gets or Sets Havoc
        /// </summary>
        [DataMember(Name="havoc", EmitDefaultValue=false)]
        public TeamSPRatingDefenseHavoc Havoc { get; set; }

        /// <summary>
        /// Gets or Sets StandardDowns
        /// </summary>
        [DataMember(Name="standardDowns", EmitDefaultValue=false)]
        public AdvancedSeasonStatOffenseStandardDowns StandardDowns { get; set; }

        /// <summary>
        /// Gets or Sets PassingDowns
        /// </summary>
        [DataMember(Name="passingDowns", EmitDefaultValue=false)]
        public AdvancedSeasonStatOffenseStandardDowns PassingDowns { get; set; }

        /// <summary>
        /// Gets or Sets RushingPlays
        /// </summary>
        [DataMember(Name="rushingPlays", EmitDefaultValue=false)]
        public AdvancedSeasonStatOffenseRushingPlays RushingPlays { get; set; }

        /// <summary>
        /// Gets or Sets PassingPlays
        /// </summary>
        [DataMember(Name="passingPlays", EmitDefaultValue=false)]
        public AdvancedSeasonStatOffenseRushingPlays PassingPlays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvancedSeasonStatDefense {\n");
            sb.Append("  Plays: ").Append(Plays).Append("\n");
            sb.Append("  Drives: ").Append(Drives).Append("\n");
            sb.Append("  Ppa: ").Append(Ppa).Append("\n");
            sb.Append("  TotalPPA: ").Append(TotalPPA).Append("\n");
            sb.Append("  SuccessRate: ").Append(SuccessRate).Append("\n");
            sb.Append("  Explosiveness: ").Append(Explosiveness).Append("\n");
            sb.Append("  PowerSuccess: ").Append(PowerSuccess).Append("\n");
            sb.Append("  StuffRate: ").Append(StuffRate).Append("\n");
            sb.Append("  LineYards: ").Append(LineYards).Append("\n");
            sb.Append("  LineYardsTotal: ").Append(LineYardsTotal).Append("\n");
            sb.Append("  SecondLevelYards: ").Append(SecondLevelYards).Append("\n");
            sb.Append("  SecondLevelYardsTotal: ").Append(SecondLevelYardsTotal).Append("\n");
            sb.Append("  OpenFieldYards: ").Append(OpenFieldYards).Append("\n");
            sb.Append("  OpenFieldYardsTotal: ").Append(OpenFieldYardsTotal).Append("\n");
            sb.Append("  PointsPerOpportunity: ").Append(PointsPerOpportunity).Append("\n");
            sb.Append("  FieldPosition: ").Append(FieldPosition).Append("\n");
            sb.Append("  Havoc: ").Append(Havoc).Append("\n");
            sb.Append("  StandardDowns: ").Append(StandardDowns).Append("\n");
            sb.Append("  PassingDowns: ").Append(PassingDowns).Append("\n");
            sb.Append("  RushingPlays: ").Append(RushingPlays).Append("\n");
            sb.Append("  PassingPlays: ").Append(PassingPlays).Append("\n");
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
            return this.Equals(input as AdvancedSeasonStatDefense);
        }

        /// <summary>
        /// Returns true if AdvancedSeasonStatDefense instances are equal
        /// </summary>
        /// <param name="input">Instance of AdvancedSeasonStatDefense to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvancedSeasonStatDefense input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Plays == input.Plays ||
                    (this.Plays != null &&
                    this.Plays.Equals(input.Plays))
                ) && 
                (
                    this.Drives == input.Drives ||
                    (this.Drives != null &&
                    this.Drives.Equals(input.Drives))
                ) && 
                (
                    this.Ppa == input.Ppa ||
                    (this.Ppa != null &&
                    this.Ppa.Equals(input.Ppa))
                ) && 
                (
                    this.TotalPPA == input.TotalPPA ||
                    (this.TotalPPA != null &&
                    this.TotalPPA.Equals(input.TotalPPA))
                ) && 
                (
                    this.SuccessRate == input.SuccessRate ||
                    (this.SuccessRate != null &&
                    this.SuccessRate.Equals(input.SuccessRate))
                ) && 
                (
                    this.Explosiveness == input.Explosiveness ||
                    (this.Explosiveness != null &&
                    this.Explosiveness.Equals(input.Explosiveness))
                ) && 
                (
                    this.PowerSuccess == input.PowerSuccess ||
                    (this.PowerSuccess != null &&
                    this.PowerSuccess.Equals(input.PowerSuccess))
                ) && 
                (
                    this.StuffRate == input.StuffRate ||
                    (this.StuffRate != null &&
                    this.StuffRate.Equals(input.StuffRate))
                ) && 
                (
                    this.LineYards == input.LineYards ||
                    (this.LineYards != null &&
                    this.LineYards.Equals(input.LineYards))
                ) && 
                (
                    this.LineYardsTotal == input.LineYardsTotal ||
                    (this.LineYardsTotal != null &&
                    this.LineYardsTotal.Equals(input.LineYardsTotal))
                ) && 
                (
                    this.SecondLevelYards == input.SecondLevelYards ||
                    (this.SecondLevelYards != null &&
                    this.SecondLevelYards.Equals(input.SecondLevelYards))
                ) && 
                (
                    this.SecondLevelYardsTotal == input.SecondLevelYardsTotal ||
                    (this.SecondLevelYardsTotal != null &&
                    this.SecondLevelYardsTotal.Equals(input.SecondLevelYardsTotal))
                ) && 
                (
                    this.OpenFieldYards == input.OpenFieldYards ||
                    (this.OpenFieldYards != null &&
                    this.OpenFieldYards.Equals(input.OpenFieldYards))
                ) && 
                (
                    this.OpenFieldYardsTotal == input.OpenFieldYardsTotal ||
                    (this.OpenFieldYardsTotal != null &&
                    this.OpenFieldYardsTotal.Equals(input.OpenFieldYardsTotal))
                ) && 
                (
                    this.PointsPerOpportunity == input.PointsPerOpportunity ||
                    (this.PointsPerOpportunity != null &&
                    this.PointsPerOpportunity.Equals(input.PointsPerOpportunity))
                ) && 
                (
                    this.FieldPosition == input.FieldPosition ||
                    (this.FieldPosition != null &&
                    this.FieldPosition.Equals(input.FieldPosition))
                ) && 
                (
                    this.Havoc == input.Havoc ||
                    (this.Havoc != null &&
                    this.Havoc.Equals(input.Havoc))
                ) && 
                (
                    this.StandardDowns == input.StandardDowns ||
                    (this.StandardDowns != null &&
                    this.StandardDowns.Equals(input.StandardDowns))
                ) && 
                (
                    this.PassingDowns == input.PassingDowns ||
                    (this.PassingDowns != null &&
                    this.PassingDowns.Equals(input.PassingDowns))
                ) && 
                (
                    this.RushingPlays == input.RushingPlays ||
                    (this.RushingPlays != null &&
                    this.RushingPlays.Equals(input.RushingPlays))
                ) && 
                (
                    this.PassingPlays == input.PassingPlays ||
                    (this.PassingPlays != null &&
                    this.PassingPlays.Equals(input.PassingPlays))
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
                if (this.Plays != null)
                    hashCode = hashCode * 59 + this.Plays.GetHashCode();
                if (this.Drives != null)
                    hashCode = hashCode * 59 + this.Drives.GetHashCode();
                if (this.Ppa != null)
                    hashCode = hashCode * 59 + this.Ppa.GetHashCode();
                if (this.TotalPPA != null)
                    hashCode = hashCode * 59 + this.TotalPPA.GetHashCode();
                if (this.SuccessRate != null)
                    hashCode = hashCode * 59 + this.SuccessRate.GetHashCode();
                if (this.Explosiveness != null)
                    hashCode = hashCode * 59 + this.Explosiveness.GetHashCode();
                if (this.PowerSuccess != null)
                    hashCode = hashCode * 59 + this.PowerSuccess.GetHashCode();
                if (this.StuffRate != null)
                    hashCode = hashCode * 59 + this.StuffRate.GetHashCode();
                if (this.LineYards != null)
                    hashCode = hashCode * 59 + this.LineYards.GetHashCode();
                if (this.LineYardsTotal != null)
                    hashCode = hashCode * 59 + this.LineYardsTotal.GetHashCode();
                if (this.SecondLevelYards != null)
                    hashCode = hashCode * 59 + this.SecondLevelYards.GetHashCode();
                if (this.SecondLevelYardsTotal != null)
                    hashCode = hashCode * 59 + this.SecondLevelYardsTotal.GetHashCode();
                if (this.OpenFieldYards != null)
                    hashCode = hashCode * 59 + this.OpenFieldYards.GetHashCode();
                if (this.OpenFieldYardsTotal != null)
                    hashCode = hashCode * 59 + this.OpenFieldYardsTotal.GetHashCode();
                if (this.PointsPerOpportunity != null)
                    hashCode = hashCode * 59 + this.PointsPerOpportunity.GetHashCode();
                if (this.FieldPosition != null)
                    hashCode = hashCode * 59 + this.FieldPosition.GetHashCode();
                if (this.Havoc != null)
                    hashCode = hashCode * 59 + this.Havoc.GetHashCode();
                if (this.StandardDowns != null)
                    hashCode = hashCode * 59 + this.StandardDowns.GetHashCode();
                if (this.PassingDowns != null)
                    hashCode = hashCode * 59 + this.PassingDowns.GetHashCode();
                if (this.RushingPlays != null)
                    hashCode = hashCode * 59 + this.RushingPlays.GetHashCode();
                if (this.PassingPlays != null)
                    hashCode = hashCode * 59 + this.PassingPlays.GetHashCode();
                return hashCode;
            }
        }
    }

}
