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
    /// LivePlayByPlay
    /// </summary>
    [DataContract]
    public partial class LivePlayByPlay :  IEquatable<LivePlayByPlay>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LivePlayByPlay" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="status">status.</param>
        /// <param name="period">period.</param>
        /// <param name="clock">clock.</param>
        /// <param name="possession">possession.</param>
        /// <param name="down">down.</param>
        /// <param name="distance">distance.</param>
        /// <param name="yardsToGoal">yardsToGoal.</param>
        /// <param name="teams">teams.</param>
        /// <param name="drives">drives.</param>
        public LivePlayByPlay(int? id = default(int?), string status = default(string), int? period = default(int?), string clock = default(string), string possession = default(string), int? down = default(int?), int? distance = default(int?), int? yardsToGoal = default(int?), List<LivePlayByPlayTeams> teams = default(List<LivePlayByPlayTeams>), List<LivePlayByPlayDrives> drives = default(List<LivePlayByPlayDrives>))
        {
            this.Id = id;
            this.Status = status;
            this.Period = period;
            this.Clock = clock;
            this.Possession = possession;
            this.Down = down;
            this.Distance = distance;
            this.YardsToGoal = yardsToGoal;
            this.Teams = teams;
            this.Drives = drives;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

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
        /// Gets or Sets Possession
        /// </summary>
        [DataMember(Name="possession", EmitDefaultValue=false)]
        public string Possession { get; set; }

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
        /// Gets or Sets Teams
        /// </summary>
        [DataMember(Name="teams", EmitDefaultValue=false)]
        public List<LivePlayByPlayTeams> Teams { get; set; }

        /// <summary>
        /// Gets or Sets Drives
        /// </summary>
        [DataMember(Name="drives", EmitDefaultValue=false)]
        public List<LivePlayByPlayDrives> Drives { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LivePlayByPlay {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Clock: ").Append(Clock).Append("\n");
            sb.Append("  Possession: ").Append(Possession).Append("\n");
            sb.Append("  Down: ").Append(Down).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  YardsToGoal: ").Append(YardsToGoal).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
            sb.Append("  Drives: ").Append(Drives).Append("\n");
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
            return this.Equals(input as LivePlayByPlay);
        }

        /// <summary>
        /// Returns true if LivePlayByPlay instances are equal
        /// </summary>
        /// <param name="input">Instance of LivePlayByPlay to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LivePlayByPlay input)
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                    this.Possession == input.Possession ||
                    (this.Possession != null &&
                    this.Possession.Equals(input.Possession))
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
                    this.Teams == input.Teams ||
                    this.Teams != null &&
                    this.Teams.SequenceEqual(input.Teams)
                ) && 
                (
                    this.Drives == input.Drives ||
                    this.Drives != null &&
                    this.Drives.SequenceEqual(input.Drives)
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.Clock != null)
                    hashCode = hashCode * 59 + this.Clock.GetHashCode();
                if (this.Possession != null)
                    hashCode = hashCode * 59 + this.Possession.GetHashCode();
                if (this.Down != null)
                    hashCode = hashCode * 59 + this.Down.GetHashCode();
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
                if (this.YardsToGoal != null)
                    hashCode = hashCode * 59 + this.YardsToGoal.GetHashCode();
                if (this.Teams != null)
                    hashCode = hashCode * 59 + this.Teams.GetHashCode();
                if (this.Drives != null)
                    hashCode = hashCode * 59 + this.Drives.GetHashCode();
                return hashCode;
            }
        }
    }

}
