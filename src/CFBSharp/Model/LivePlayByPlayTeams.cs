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
    /// LivePlayByPlayTeams
    /// </summary>
    [DataContract]
    public partial class LivePlayByPlayTeams :  IEquatable<LivePlayByPlayTeams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LivePlayByPlayTeams" /> class.
        /// </summary>
        /// <param name="teamId">teamId.</param>
        /// <param name="team">team.</param>
        /// <param name="homeAway">homeAway.</param>
        /// <param name="points">points.</param>
        /// <param name="drives">drives.</param>
        /// <param name="scoringOpportunities">scoringOpportunities.</param>
        /// <param name="pointsPerOpportunity">pointsPerOpportunity.</param>
        /// <param name="plays">plays.</param>
        /// <param name="lineYards">lineYards.</param>
        /// <param name="lineYardsPerRush">lineYardsPerRush.</param>
        /// <param name="secondLevelYards">secondLevelYards.</param>
        /// <param name="secondLevelYardsPerRush">secondLevelYardsPerRush.</param>
        /// <param name="openFieldYards">openFieldYards.</param>
        /// <param name="openFieldYardsPerRush">openFieldYardsPerRush.</param>
        /// <param name="epaPerPlay">epaPerPlay.</param>
        /// <param name="totalEpa">totalEpa.</param>
        /// <param name="passingEpa">passingEpa.</param>
        /// <param name="epaPerPass">epaPerPass.</param>
        /// <param name="rushingEpa">rushingEpa.</param>
        /// <param name="epaPerRush">epaPerRush.</param>
        /// <param name="successRate">successRate.</param>
        /// <param name="standardDownSuccessRate">standardDownSuccessRate.</param>
        /// <param name="passingDownSuccessRate">passingDownSuccessRate.</param>
        /// <param name="explosiveness">explosiveness.</param>
        public LivePlayByPlayTeams(int? teamId = default(int?), string team = default(string), string homeAway = default(string), int? points = default(int?), int? drives = default(int?), int? scoringOpportunities = default(int?), decimal? pointsPerOpportunity = default(decimal?), int? plays = default(int?), int? lineYards = default(int?), decimal? lineYardsPerRush = default(decimal?), int? secondLevelYards = default(int?), decimal? secondLevelYardsPerRush = default(decimal?), int? openFieldYards = default(int?), decimal? openFieldYardsPerRush = default(decimal?), decimal? epaPerPlay = default(decimal?), decimal? totalEpa = default(decimal?), decimal? passingEpa = default(decimal?), decimal? epaPerPass = default(decimal?), decimal? rushingEpa = default(decimal?), decimal? epaPerRush = default(decimal?), decimal? successRate = default(decimal?), decimal? standardDownSuccessRate = default(decimal?), decimal? passingDownSuccessRate = default(decimal?), decimal? explosiveness = default(decimal?))
        {
            this.TeamId = teamId;
            this.Team = team;
            this.HomeAway = homeAway;
            this.Points = points;
            this.Drives = drives;
            this.ScoringOpportunities = scoringOpportunities;
            this.PointsPerOpportunity = pointsPerOpportunity;
            this.Plays = plays;
            this.LineYards = lineYards;
            this.LineYardsPerRush = lineYardsPerRush;
            this.SecondLevelYards = secondLevelYards;
            this.SecondLevelYardsPerRush = secondLevelYardsPerRush;
            this.OpenFieldYards = openFieldYards;
            this.OpenFieldYardsPerRush = openFieldYardsPerRush;
            this.EpaPerPlay = epaPerPlay;
            this.TotalEpa = totalEpa;
            this.PassingEpa = passingEpa;
            this.EpaPerPass = epaPerPass;
            this.RushingEpa = rushingEpa;
            this.EpaPerRush = epaPerRush;
            this.SuccessRate = successRate;
            this.StandardDownSuccessRate = standardDownSuccessRate;
            this.PassingDownSuccessRate = passingDownSuccessRate;
            this.Explosiveness = explosiveness;
        }
        
        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public int? TeamId { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets HomeAway
        /// </summary>
        [DataMember(Name="homeAway", EmitDefaultValue=false)]
        public string HomeAway { get; set; }

        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [DataMember(Name="points", EmitDefaultValue=false)]
        public int? Points { get; set; }

        /// <summary>
        /// Gets or Sets Drives
        /// </summary>
        [DataMember(Name="drives", EmitDefaultValue=false)]
        public int? Drives { get; set; }

        /// <summary>
        /// Gets or Sets ScoringOpportunities
        /// </summary>
        [DataMember(Name="scoringOpportunities", EmitDefaultValue=false)]
        public int? ScoringOpportunities { get; set; }

        /// <summary>
        /// Gets or Sets PointsPerOpportunity
        /// </summary>
        [DataMember(Name="pointsPerOpportunity", EmitDefaultValue=false)]
        public decimal? PointsPerOpportunity { get; set; }

        /// <summary>
        /// Gets or Sets Plays
        /// </summary>
        [DataMember(Name="plays", EmitDefaultValue=false)]
        public int? Plays { get; set; }

        /// <summary>
        /// Gets or Sets LineYards
        /// </summary>
        [DataMember(Name="lineYards", EmitDefaultValue=false)]
        public int? LineYards { get; set; }

        /// <summary>
        /// Gets or Sets LineYardsPerRush
        /// </summary>
        [DataMember(Name="lineYardsPerRush", EmitDefaultValue=false)]
        public decimal? LineYardsPerRush { get; set; }

        /// <summary>
        /// Gets or Sets SecondLevelYards
        /// </summary>
        [DataMember(Name="secondLevelYards", EmitDefaultValue=false)]
        public int? SecondLevelYards { get; set; }

        /// <summary>
        /// Gets or Sets SecondLevelYardsPerRush
        /// </summary>
        [DataMember(Name="secondLevelYardsPerRush", EmitDefaultValue=false)]
        public decimal? SecondLevelYardsPerRush { get; set; }

        /// <summary>
        /// Gets or Sets OpenFieldYards
        /// </summary>
        [DataMember(Name="openFieldYards", EmitDefaultValue=false)]
        public int? OpenFieldYards { get; set; }

        /// <summary>
        /// Gets or Sets OpenFieldYardsPerRush
        /// </summary>
        [DataMember(Name="openFieldYardsPerRush", EmitDefaultValue=false)]
        public decimal? OpenFieldYardsPerRush { get; set; }

        /// <summary>
        /// Gets or Sets EpaPerPlay
        /// </summary>
        [DataMember(Name="epaPerPlay", EmitDefaultValue=false)]
        public decimal? EpaPerPlay { get; set; }

        /// <summary>
        /// Gets or Sets TotalEpa
        /// </summary>
        [DataMember(Name="totalEpa", EmitDefaultValue=false)]
        public decimal? TotalEpa { get; set; }

        /// <summary>
        /// Gets or Sets PassingEpa
        /// </summary>
        [DataMember(Name="passingEpa", EmitDefaultValue=false)]
        public decimal? PassingEpa { get; set; }

        /// <summary>
        /// Gets or Sets EpaPerPass
        /// </summary>
        [DataMember(Name="epaPerPass", EmitDefaultValue=false)]
        public decimal? EpaPerPass { get; set; }

        /// <summary>
        /// Gets or Sets RushingEpa
        /// </summary>
        [DataMember(Name="rushingEpa", EmitDefaultValue=false)]
        public decimal? RushingEpa { get; set; }

        /// <summary>
        /// Gets or Sets EpaPerRush
        /// </summary>
        [DataMember(Name="epaPerRush", EmitDefaultValue=false)]
        public decimal? EpaPerRush { get; set; }

        /// <summary>
        /// Gets or Sets SuccessRate
        /// </summary>
        [DataMember(Name="successRate", EmitDefaultValue=false)]
        public decimal? SuccessRate { get; set; }

        /// <summary>
        /// Gets or Sets StandardDownSuccessRate
        /// </summary>
        [DataMember(Name="standardDownSuccessRate", EmitDefaultValue=false)]
        public decimal? StandardDownSuccessRate { get; set; }

        /// <summary>
        /// Gets or Sets PassingDownSuccessRate
        /// </summary>
        [DataMember(Name="passingDownSuccessRate", EmitDefaultValue=false)]
        public decimal? PassingDownSuccessRate { get; set; }

        /// <summary>
        /// Gets or Sets Explosiveness
        /// </summary>
        [DataMember(Name="explosiveness", EmitDefaultValue=false)]
        public decimal? Explosiveness { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LivePlayByPlayTeams {\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  HomeAway: ").Append(HomeAway).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  Drives: ").Append(Drives).Append("\n");
            sb.Append("  ScoringOpportunities: ").Append(ScoringOpportunities).Append("\n");
            sb.Append("  PointsPerOpportunity: ").Append(PointsPerOpportunity).Append("\n");
            sb.Append("  Plays: ").Append(Plays).Append("\n");
            sb.Append("  LineYards: ").Append(LineYards).Append("\n");
            sb.Append("  LineYardsPerRush: ").Append(LineYardsPerRush).Append("\n");
            sb.Append("  SecondLevelYards: ").Append(SecondLevelYards).Append("\n");
            sb.Append("  SecondLevelYardsPerRush: ").Append(SecondLevelYardsPerRush).Append("\n");
            sb.Append("  OpenFieldYards: ").Append(OpenFieldYards).Append("\n");
            sb.Append("  OpenFieldYardsPerRush: ").Append(OpenFieldYardsPerRush).Append("\n");
            sb.Append("  EpaPerPlay: ").Append(EpaPerPlay).Append("\n");
            sb.Append("  TotalEpa: ").Append(TotalEpa).Append("\n");
            sb.Append("  PassingEpa: ").Append(PassingEpa).Append("\n");
            sb.Append("  EpaPerPass: ").Append(EpaPerPass).Append("\n");
            sb.Append("  RushingEpa: ").Append(RushingEpa).Append("\n");
            sb.Append("  EpaPerRush: ").Append(EpaPerRush).Append("\n");
            sb.Append("  SuccessRate: ").Append(SuccessRate).Append("\n");
            sb.Append("  StandardDownSuccessRate: ").Append(StandardDownSuccessRate).Append("\n");
            sb.Append("  PassingDownSuccessRate: ").Append(PassingDownSuccessRate).Append("\n");
            sb.Append("  Explosiveness: ").Append(Explosiveness).Append("\n");
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
            return this.Equals(input as LivePlayByPlayTeams);
        }

        /// <summary>
        /// Returns true if LivePlayByPlayTeams instances are equal
        /// </summary>
        /// <param name="input">Instance of LivePlayByPlayTeams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LivePlayByPlayTeams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TeamId == input.TeamId ||
                    (this.TeamId != null &&
                    this.TeamId.Equals(input.TeamId))
                ) && 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.HomeAway == input.HomeAway ||
                    (this.HomeAway != null &&
                    this.HomeAway.Equals(input.HomeAway))
                ) && 
                (
                    this.Points == input.Points ||
                    (this.Points != null &&
                    this.Points.Equals(input.Points))
                ) && 
                (
                    this.Drives == input.Drives ||
                    (this.Drives != null &&
                    this.Drives.Equals(input.Drives))
                ) && 
                (
                    this.ScoringOpportunities == input.ScoringOpportunities ||
                    (this.ScoringOpportunities != null &&
                    this.ScoringOpportunities.Equals(input.ScoringOpportunities))
                ) && 
                (
                    this.PointsPerOpportunity == input.PointsPerOpportunity ||
                    (this.PointsPerOpportunity != null &&
                    this.PointsPerOpportunity.Equals(input.PointsPerOpportunity))
                ) && 
                (
                    this.Plays == input.Plays ||
                    (this.Plays != null &&
                    this.Plays.Equals(input.Plays))
                ) && 
                (
                    this.LineYards == input.LineYards ||
                    (this.LineYards != null &&
                    this.LineYards.Equals(input.LineYards))
                ) && 
                (
                    this.LineYardsPerRush == input.LineYardsPerRush ||
                    (this.LineYardsPerRush != null &&
                    this.LineYardsPerRush.Equals(input.LineYardsPerRush))
                ) && 
                (
                    this.SecondLevelYards == input.SecondLevelYards ||
                    (this.SecondLevelYards != null &&
                    this.SecondLevelYards.Equals(input.SecondLevelYards))
                ) && 
                (
                    this.SecondLevelYardsPerRush == input.SecondLevelYardsPerRush ||
                    (this.SecondLevelYardsPerRush != null &&
                    this.SecondLevelYardsPerRush.Equals(input.SecondLevelYardsPerRush))
                ) && 
                (
                    this.OpenFieldYards == input.OpenFieldYards ||
                    (this.OpenFieldYards != null &&
                    this.OpenFieldYards.Equals(input.OpenFieldYards))
                ) && 
                (
                    this.OpenFieldYardsPerRush == input.OpenFieldYardsPerRush ||
                    (this.OpenFieldYardsPerRush != null &&
                    this.OpenFieldYardsPerRush.Equals(input.OpenFieldYardsPerRush))
                ) && 
                (
                    this.EpaPerPlay == input.EpaPerPlay ||
                    (this.EpaPerPlay != null &&
                    this.EpaPerPlay.Equals(input.EpaPerPlay))
                ) && 
                (
                    this.TotalEpa == input.TotalEpa ||
                    (this.TotalEpa != null &&
                    this.TotalEpa.Equals(input.TotalEpa))
                ) && 
                (
                    this.PassingEpa == input.PassingEpa ||
                    (this.PassingEpa != null &&
                    this.PassingEpa.Equals(input.PassingEpa))
                ) && 
                (
                    this.EpaPerPass == input.EpaPerPass ||
                    (this.EpaPerPass != null &&
                    this.EpaPerPass.Equals(input.EpaPerPass))
                ) && 
                (
                    this.RushingEpa == input.RushingEpa ||
                    (this.RushingEpa != null &&
                    this.RushingEpa.Equals(input.RushingEpa))
                ) && 
                (
                    this.EpaPerRush == input.EpaPerRush ||
                    (this.EpaPerRush != null &&
                    this.EpaPerRush.Equals(input.EpaPerRush))
                ) && 
                (
                    this.SuccessRate == input.SuccessRate ||
                    (this.SuccessRate != null &&
                    this.SuccessRate.Equals(input.SuccessRate))
                ) && 
                (
                    this.StandardDownSuccessRate == input.StandardDownSuccessRate ||
                    (this.StandardDownSuccessRate != null &&
                    this.StandardDownSuccessRate.Equals(input.StandardDownSuccessRate))
                ) && 
                (
                    this.PassingDownSuccessRate == input.PassingDownSuccessRate ||
                    (this.PassingDownSuccessRate != null &&
                    this.PassingDownSuccessRate.Equals(input.PassingDownSuccessRate))
                ) && 
                (
                    this.Explosiveness == input.Explosiveness ||
                    (this.Explosiveness != null &&
                    this.Explosiveness.Equals(input.Explosiveness))
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
                if (this.TeamId != null)
                    hashCode = hashCode * 59 + this.TeamId.GetHashCode();
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.HomeAway != null)
                    hashCode = hashCode * 59 + this.HomeAway.GetHashCode();
                if (this.Points != null)
                    hashCode = hashCode * 59 + this.Points.GetHashCode();
                if (this.Drives != null)
                    hashCode = hashCode * 59 + this.Drives.GetHashCode();
                if (this.ScoringOpportunities != null)
                    hashCode = hashCode * 59 + this.ScoringOpportunities.GetHashCode();
                if (this.PointsPerOpportunity != null)
                    hashCode = hashCode * 59 + this.PointsPerOpportunity.GetHashCode();
                if (this.Plays != null)
                    hashCode = hashCode * 59 + this.Plays.GetHashCode();
                if (this.LineYards != null)
                    hashCode = hashCode * 59 + this.LineYards.GetHashCode();
                if (this.LineYardsPerRush != null)
                    hashCode = hashCode * 59 + this.LineYardsPerRush.GetHashCode();
                if (this.SecondLevelYards != null)
                    hashCode = hashCode * 59 + this.SecondLevelYards.GetHashCode();
                if (this.SecondLevelYardsPerRush != null)
                    hashCode = hashCode * 59 + this.SecondLevelYardsPerRush.GetHashCode();
                if (this.OpenFieldYards != null)
                    hashCode = hashCode * 59 + this.OpenFieldYards.GetHashCode();
                if (this.OpenFieldYardsPerRush != null)
                    hashCode = hashCode * 59 + this.OpenFieldYardsPerRush.GetHashCode();
                if (this.EpaPerPlay != null)
                    hashCode = hashCode * 59 + this.EpaPerPlay.GetHashCode();
                if (this.TotalEpa != null)
                    hashCode = hashCode * 59 + this.TotalEpa.GetHashCode();
                if (this.PassingEpa != null)
                    hashCode = hashCode * 59 + this.PassingEpa.GetHashCode();
                if (this.EpaPerPass != null)
                    hashCode = hashCode * 59 + this.EpaPerPass.GetHashCode();
                if (this.RushingEpa != null)
                    hashCode = hashCode * 59 + this.RushingEpa.GetHashCode();
                if (this.EpaPerRush != null)
                    hashCode = hashCode * 59 + this.EpaPerRush.GetHashCode();
                if (this.SuccessRate != null)
                    hashCode = hashCode * 59 + this.SuccessRate.GetHashCode();
                if (this.StandardDownSuccessRate != null)
                    hashCode = hashCode * 59 + this.StandardDownSuccessRate.GetHashCode();
                if (this.PassingDownSuccessRate != null)
                    hashCode = hashCode * 59 + this.PassingDownSuccessRate.GetHashCode();
                if (this.Explosiveness != null)
                    hashCode = hashCode * 59 + this.Explosiveness.GetHashCode();
                return hashCode;
            }
        }
    }

}
