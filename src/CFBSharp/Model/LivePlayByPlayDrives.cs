/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.4.8
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
    /// LivePlayByPlayDrives
    /// </summary>
    [DataContract]
    public partial class LivePlayByPlayDrives :  IEquatable<LivePlayByPlayDrives>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LivePlayByPlayDrives" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="offenseId">offenseId.</param>
        /// <param name="offense">offense.</param>
        /// <param name="defenseId">defenseId.</param>
        /// <param name="defense">defense.</param>
        /// <param name="playCount">playCount.</param>
        /// <param name="yards">yards.</param>
        /// <param name="startPeriod">startPeriod.</param>
        /// <param name="startClock">startClock.</param>
        /// <param name="startYardsToGoal">startYardsToGoal.</param>
        /// <param name="endPeriod">endPeriod.</param>
        /// <param name="endClock">endClock.</param>
        /// <param name="endYardsToGoal">endYardsToGoal.</param>
        /// <param name="duration">duration.</param>
        /// <param name="scoringOpportunity">scoringOpportunity.</param>
        /// <param name="plays">plays.</param>
        public LivePlayByPlayDrives(int? id = default(int?), int? offenseId = default(int?), string offense = default(string), int? defenseId = default(int?), string defense = default(string), int? playCount = default(int?), int? yards = default(int?), int? startPeriod = default(int?), string startClock = default(string), int? startYardsToGoal = default(int?), int? endPeriod = default(int?), string endClock = default(string), int? endYardsToGoal = default(int?), string duration = default(string), bool? scoringOpportunity = default(bool?), List<LivePlayByPlayPlays> plays = default(List<LivePlayByPlayPlays>))
        {
            this.Id = id;
            this.OffenseId = offenseId;
            this.Offense = offense;
            this.DefenseId = defenseId;
            this.Defense = defense;
            this.PlayCount = playCount;
            this.Yards = yards;
            this.StartPeriod = startPeriod;
            this.StartClock = startClock;
            this.StartYardsToGoal = startYardsToGoal;
            this.EndPeriod = endPeriod;
            this.EndClock = endClock;
            this.EndYardsToGoal = endYardsToGoal;
            this.Duration = duration;
            this.ScoringOpportunity = scoringOpportunity;
            this.Plays = plays;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets OffenseId
        /// </summary>
        [DataMember(Name="offenseId", EmitDefaultValue=false)]
        public int? OffenseId { get; set; }

        /// <summary>
        /// Gets or Sets Offense
        /// </summary>
        [DataMember(Name="offense", EmitDefaultValue=false)]
        public string Offense { get; set; }

        /// <summary>
        /// Gets or Sets DefenseId
        /// </summary>
        [DataMember(Name="defenseId", EmitDefaultValue=false)]
        public int? DefenseId { get; set; }

        /// <summary>
        /// Gets or Sets Defense
        /// </summary>
        [DataMember(Name="defense", EmitDefaultValue=false)]
        public string Defense { get; set; }

        /// <summary>
        /// Gets or Sets PlayCount
        /// </summary>
        [DataMember(Name="playCount", EmitDefaultValue=false)]
        public int? PlayCount { get; set; }

        /// <summary>
        /// Gets or Sets Yards
        /// </summary>
        [DataMember(Name="yards", EmitDefaultValue=false)]
        public int? Yards { get; set; }

        /// <summary>
        /// Gets or Sets StartPeriod
        /// </summary>
        [DataMember(Name="startPeriod", EmitDefaultValue=false)]
        public int? StartPeriod { get; set; }

        /// <summary>
        /// Gets or Sets StartClock
        /// </summary>
        [DataMember(Name="startClock", EmitDefaultValue=false)]
        public string StartClock { get; set; }

        /// <summary>
        /// Gets or Sets StartYardsToGoal
        /// </summary>
        [DataMember(Name="startYardsToGoal", EmitDefaultValue=false)]
        public int? StartYardsToGoal { get; set; }

        /// <summary>
        /// Gets or Sets EndPeriod
        /// </summary>
        [DataMember(Name="endPeriod", EmitDefaultValue=false)]
        public int? EndPeriod { get; set; }

        /// <summary>
        /// Gets or Sets EndClock
        /// </summary>
        [DataMember(Name="endClock", EmitDefaultValue=false)]
        public string EndClock { get; set; }

        /// <summary>
        /// Gets or Sets EndYardsToGoal
        /// </summary>
        [DataMember(Name="endYardsToGoal", EmitDefaultValue=false)]
        public int? EndYardsToGoal { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public string Duration { get; set; }

        /// <summary>
        /// Gets or Sets ScoringOpportunity
        /// </summary>
        [DataMember(Name="scoringOpportunity", EmitDefaultValue=false)]
        public bool? ScoringOpportunity { get; set; }

        /// <summary>
        /// Gets or Sets Plays
        /// </summary>
        [DataMember(Name="plays", EmitDefaultValue=false)]
        public List<LivePlayByPlayPlays> Plays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LivePlayByPlayDrives {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OffenseId: ").Append(OffenseId).Append("\n");
            sb.Append("  Offense: ").Append(Offense).Append("\n");
            sb.Append("  DefenseId: ").Append(DefenseId).Append("\n");
            sb.Append("  Defense: ").Append(Defense).Append("\n");
            sb.Append("  PlayCount: ").Append(PlayCount).Append("\n");
            sb.Append("  Yards: ").Append(Yards).Append("\n");
            sb.Append("  StartPeriod: ").Append(StartPeriod).Append("\n");
            sb.Append("  StartClock: ").Append(StartClock).Append("\n");
            sb.Append("  StartYardsToGoal: ").Append(StartYardsToGoal).Append("\n");
            sb.Append("  EndPeriod: ").Append(EndPeriod).Append("\n");
            sb.Append("  EndClock: ").Append(EndClock).Append("\n");
            sb.Append("  EndYardsToGoal: ").Append(EndYardsToGoal).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  ScoringOpportunity: ").Append(ScoringOpportunity).Append("\n");
            sb.Append("  Plays: ").Append(Plays).Append("\n");
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
            return this.Equals(input as LivePlayByPlayDrives);
        }

        /// <summary>
        /// Returns true if LivePlayByPlayDrives instances are equal
        /// </summary>
        /// <param name="input">Instance of LivePlayByPlayDrives to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LivePlayByPlayDrives input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OffenseId == input.OffenseId ||
                    (this.OffenseId != null &&
                    this.OffenseId.Equals(input.OffenseId))
                ) && 
                (
                    this.Offense == input.Offense ||
                    (this.Offense != null &&
                    this.Offense.Equals(input.Offense))
                ) && 
                (
                    this.DefenseId == input.DefenseId ||
                    (this.DefenseId != null &&
                    this.DefenseId.Equals(input.DefenseId))
                ) && 
                (
                    this.Defense == input.Defense ||
                    (this.Defense != null &&
                    this.Defense.Equals(input.Defense))
                ) && 
                (
                    this.PlayCount == input.PlayCount ||
                    (this.PlayCount != null &&
                    this.PlayCount.Equals(input.PlayCount))
                ) && 
                (
                    this.Yards == input.Yards ||
                    (this.Yards != null &&
                    this.Yards.Equals(input.Yards))
                ) && 
                (
                    this.StartPeriod == input.StartPeriod ||
                    (this.StartPeriod != null &&
                    this.StartPeriod.Equals(input.StartPeriod))
                ) && 
                (
                    this.StartClock == input.StartClock ||
                    (this.StartClock != null &&
                    this.StartClock.Equals(input.StartClock))
                ) && 
                (
                    this.StartYardsToGoal == input.StartYardsToGoal ||
                    (this.StartYardsToGoal != null &&
                    this.StartYardsToGoal.Equals(input.StartYardsToGoal))
                ) && 
                (
                    this.EndPeriod == input.EndPeriod ||
                    (this.EndPeriod != null &&
                    this.EndPeriod.Equals(input.EndPeriod))
                ) && 
                (
                    this.EndClock == input.EndClock ||
                    (this.EndClock != null &&
                    this.EndClock.Equals(input.EndClock))
                ) && 
                (
                    this.EndYardsToGoal == input.EndYardsToGoal ||
                    (this.EndYardsToGoal != null &&
                    this.EndYardsToGoal.Equals(input.EndYardsToGoal))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.ScoringOpportunity == input.ScoringOpportunity ||
                    (this.ScoringOpportunity != null &&
                    this.ScoringOpportunity.Equals(input.ScoringOpportunity))
                ) && 
                (
                    this.Plays == input.Plays ||
                    this.Plays != null &&
                    this.Plays.SequenceEqual(input.Plays)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OffenseId != null)
                    hashCode = hashCode * 59 + this.OffenseId.GetHashCode();
                if (this.Offense != null)
                    hashCode = hashCode * 59 + this.Offense.GetHashCode();
                if (this.DefenseId != null)
                    hashCode = hashCode * 59 + this.DefenseId.GetHashCode();
                if (this.Defense != null)
                    hashCode = hashCode * 59 + this.Defense.GetHashCode();
                if (this.PlayCount != null)
                    hashCode = hashCode * 59 + this.PlayCount.GetHashCode();
                if (this.Yards != null)
                    hashCode = hashCode * 59 + this.Yards.GetHashCode();
                if (this.StartPeriod != null)
                    hashCode = hashCode * 59 + this.StartPeriod.GetHashCode();
                if (this.StartClock != null)
                    hashCode = hashCode * 59 + this.StartClock.GetHashCode();
                if (this.StartYardsToGoal != null)
                    hashCode = hashCode * 59 + this.StartYardsToGoal.GetHashCode();
                if (this.EndPeriod != null)
                    hashCode = hashCode * 59 + this.EndPeriod.GetHashCode();
                if (this.EndClock != null)
                    hashCode = hashCode * 59 + this.EndClock.GetHashCode();
                if (this.EndYardsToGoal != null)
                    hashCode = hashCode * 59 + this.EndYardsToGoal.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.ScoringOpportunity != null)
                    hashCode = hashCode * 59 + this.ScoringOpportunity.GetHashCode();
                if (this.Plays != null)
                    hashCode = hashCode * 59 + this.Plays.GetHashCode();
                return hashCode;
            }
        }
    }

}
