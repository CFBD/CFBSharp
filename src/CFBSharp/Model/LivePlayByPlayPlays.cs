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
    /// LivePlayByPlayPlays
    /// </summary>
    [DataContract]
    public partial class LivePlayByPlayPlays :  IEquatable<LivePlayByPlayPlays>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LivePlayByPlayPlays" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="homeScore">homeScore.</param>
        /// <param name="awayScore">awayScore.</param>
        /// <param name="period">period.</param>
        /// <param name="clock">clock.</param>
        /// <param name="wallclock">wallclock.</param>
        /// <param name="teamId">teamId.</param>
        /// <param name="team">team.</param>
        /// <param name="down">down.</param>
        /// <param name="distance">distance.</param>
        /// <param name="yardsToGoal">yardsToGoal.</param>
        /// <param name="yardsGained">yardsGained.</param>
        /// <param name="playTypeId">playTypeId.</param>
        /// <param name="playType">playType.</param>
        /// <param name="epa">epa.</param>
        /// <param name="garbageTime">garbageTime.</param>
        /// <param name="success">success.</param>
        /// <param name="rushPass">rushPass.</param>
        /// <param name="downType">downType.</param>
        /// <param name="playText">playText.</param>
        public LivePlayByPlayPlays(int? id = default(int?), int? homeScore = default(int?), int? awayScore = default(int?), int? period = default(int?), string clock = default(string), string wallclock = default(string), int? teamId = default(int?), string team = default(string), int? down = default(int?), int? distance = default(int?), int? yardsToGoal = default(int?), int? yardsGained = default(int?), int? playTypeId = default(int?), string playType = default(string), decimal? epa = default(decimal?), bool? garbageTime = default(bool?), bool? success = default(bool?), string rushPass = default(string), string downType = default(string), string playText = default(string))
        {
            this.Id = id;
            this.HomeScore = homeScore;
            this.AwayScore = awayScore;
            this.Period = period;
            this.Clock = clock;
            this.Wallclock = wallclock;
            this.TeamId = teamId;
            this.Team = team;
            this.Down = down;
            this.Distance = distance;
            this.YardsToGoal = yardsToGoal;
            this.YardsGained = yardsGained;
            this.PlayTypeId = playTypeId;
            this.PlayType = playType;
            this.Epa = epa;
            this.GarbageTime = garbageTime;
            this.Success = success;
            this.RushPass = rushPass;
            this.DownType = downType;
            this.PlayText = playText;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets HomeScore
        /// </summary>
        [DataMember(Name="homeScore", EmitDefaultValue=false)]
        public int? HomeScore { get; set; }

        /// <summary>
        /// Gets or Sets AwayScore
        /// </summary>
        [DataMember(Name="awayScore", EmitDefaultValue=false)]
        public int? AwayScore { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public int? Period { get; set; }

        /// <summary>
        /// Gets or Sets Clock
        /// </summary>
        [DataMember(Name="clock", EmitDefaultValue=false)]
        public string Clock { get; set; }

        /// <summary>
        /// Gets or Sets Wallclock
        /// </summary>
        [DataMember(Name="wallclock", EmitDefaultValue=false)]
        public string Wallclock { get; set; }

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
        /// Gets or Sets Down
        /// </summary>
        [DataMember(Name="down", EmitDefaultValue=false)]
        public int? Down { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public int? Distance { get; set; }

        /// <summary>
        /// Gets or Sets YardsToGoal
        /// </summary>
        [DataMember(Name="yardsToGoal", EmitDefaultValue=false)]
        public int? YardsToGoal { get; set; }

        /// <summary>
        /// Gets or Sets YardsGained
        /// </summary>
        [DataMember(Name="yardsGained", EmitDefaultValue=false)]
        public int? YardsGained { get; set; }

        /// <summary>
        /// Gets or Sets PlayTypeId
        /// </summary>
        [DataMember(Name="playTypeId", EmitDefaultValue=false)]
        public int? PlayTypeId { get; set; }

        /// <summary>
        /// Gets or Sets PlayType
        /// </summary>
        [DataMember(Name="playType", EmitDefaultValue=false)]
        public string PlayType { get; set; }

        /// <summary>
        /// Gets or Sets Epa
        /// </summary>
        [DataMember(Name="epa", EmitDefaultValue=false)]
        public decimal? Epa { get; set; }

        /// <summary>
        /// Gets or Sets GarbageTime
        /// </summary>
        [DataMember(Name="garbageTime", EmitDefaultValue=false)]
        public bool? GarbageTime { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Gets or Sets RushPass
        /// </summary>
        [DataMember(Name="rushPass", EmitDefaultValue=false)]
        public string RushPass { get; set; }

        /// <summary>
        /// Gets or Sets DownType
        /// </summary>
        [DataMember(Name="downType", EmitDefaultValue=false)]
        public string DownType { get; set; }

        /// <summary>
        /// Gets or Sets PlayText
        /// </summary>
        [DataMember(Name="playText", EmitDefaultValue=false)]
        public string PlayText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LivePlayByPlayPlays {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  HomeScore: ").Append(HomeScore).Append("\n");
            sb.Append("  AwayScore: ").Append(AwayScore).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Clock: ").Append(Clock).Append("\n");
            sb.Append("  Wallclock: ").Append(Wallclock).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Down: ").Append(Down).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  YardsToGoal: ").Append(YardsToGoal).Append("\n");
            sb.Append("  YardsGained: ").Append(YardsGained).Append("\n");
            sb.Append("  PlayTypeId: ").Append(PlayTypeId).Append("\n");
            sb.Append("  PlayType: ").Append(PlayType).Append("\n");
            sb.Append("  Epa: ").Append(Epa).Append("\n");
            sb.Append("  GarbageTime: ").Append(GarbageTime).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  RushPass: ").Append(RushPass).Append("\n");
            sb.Append("  DownType: ").Append(DownType).Append("\n");
            sb.Append("  PlayText: ").Append(PlayText).Append("\n");
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
            return this.Equals(input as LivePlayByPlayPlays);
        }

        /// <summary>
        /// Returns true if LivePlayByPlayPlays instances are equal
        /// </summary>
        /// <param name="input">Instance of LivePlayByPlayPlays to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LivePlayByPlayPlays input)
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
                    this.HomeScore == input.HomeScore ||
                    (this.HomeScore != null &&
                    this.HomeScore.Equals(input.HomeScore))
                ) && 
                (
                    this.AwayScore == input.AwayScore ||
                    (this.AwayScore != null &&
                    this.AwayScore.Equals(input.AwayScore))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.Clock == input.Clock ||
                    (this.Clock != null &&
                    this.Clock.Equals(input.Clock))
                ) && 
                (
                    this.Wallclock == input.Wallclock ||
                    (this.Wallclock != null &&
                    this.Wallclock.Equals(input.Wallclock))
                ) && 
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
                    this.Down == input.Down ||
                    (this.Down != null &&
                    this.Down.Equals(input.Down))
                ) && 
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
                ) && 
                (
                    this.YardsToGoal == input.YardsToGoal ||
                    (this.YardsToGoal != null &&
                    this.YardsToGoal.Equals(input.YardsToGoal))
                ) && 
                (
                    this.YardsGained == input.YardsGained ||
                    (this.YardsGained != null &&
                    this.YardsGained.Equals(input.YardsGained))
                ) && 
                (
                    this.PlayTypeId == input.PlayTypeId ||
                    (this.PlayTypeId != null &&
                    this.PlayTypeId.Equals(input.PlayTypeId))
                ) && 
                (
                    this.PlayType == input.PlayType ||
                    (this.PlayType != null &&
                    this.PlayType.Equals(input.PlayType))
                ) && 
                (
                    this.Epa == input.Epa ||
                    (this.Epa != null &&
                    this.Epa.Equals(input.Epa))
                ) && 
                (
                    this.GarbageTime == input.GarbageTime ||
                    (this.GarbageTime != null &&
                    this.GarbageTime.Equals(input.GarbageTime))
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.RushPass == input.RushPass ||
                    (this.RushPass != null &&
                    this.RushPass.Equals(input.RushPass))
                ) && 
                (
                    this.DownType == input.DownType ||
                    (this.DownType != null &&
                    this.DownType.Equals(input.DownType))
                ) && 
                (
                    this.PlayText == input.PlayText ||
                    (this.PlayText != null &&
                    this.PlayText.Equals(input.PlayText))
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
                if (this.HomeScore != null)
                    hashCode = hashCode * 59 + this.HomeScore.GetHashCode();
                if (this.AwayScore != null)
                    hashCode = hashCode * 59 + this.AwayScore.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.Clock != null)
                    hashCode = hashCode * 59 + this.Clock.GetHashCode();
                if (this.Wallclock != null)
                    hashCode = hashCode * 59 + this.Wallclock.GetHashCode();
                if (this.TeamId != null)
                    hashCode = hashCode * 59 + this.TeamId.GetHashCode();
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.Down != null)
                    hashCode = hashCode * 59 + this.Down.GetHashCode();
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
                if (this.YardsToGoal != null)
                    hashCode = hashCode * 59 + this.YardsToGoal.GetHashCode();
                if (this.YardsGained != null)
                    hashCode = hashCode * 59 + this.YardsGained.GetHashCode();
                if (this.PlayTypeId != null)
                    hashCode = hashCode * 59 + this.PlayTypeId.GetHashCode();
                if (this.PlayType != null)
                    hashCode = hashCode * 59 + this.PlayType.GetHashCode();
                if (this.Epa != null)
                    hashCode = hashCode * 59 + this.Epa.GetHashCode();
                if (this.GarbageTime != null)
                    hashCode = hashCode * 59 + this.GarbageTime.GetHashCode();
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.RushPass != null)
                    hashCode = hashCode * 59 + this.RushPass.GetHashCode();
                if (this.DownType != null)
                    hashCode = hashCode * 59 + this.DownType.GetHashCode();
                if (this.PlayText != null)
                    hashCode = hashCode * 59 + this.PlayText.GetHashCode();
                return hashCode;
            }
        }
    }

}
