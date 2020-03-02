/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 1.24.6
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
    /// AdvancedSeasonStat
    /// </summary>
    [DataContract]
    public partial class AdvancedSeasonStat :  IEquatable<AdvancedSeasonStat>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedSeasonStat" /> class.
        /// </summary>
        /// <param name="season">season.</param>
        /// <param name="team">team.</param>
        /// <param name="conference">conference.</param>
        /// <param name="offense">offense.</param>
        /// <param name="defense">defense.</param>
        public AdvancedSeasonStat(int? season = default(int?), string team = default(string), string conference = default(string), AdvancedSeasonStatOffense offense = default(AdvancedSeasonStatOffense), AdvancedSeasonStatDefense defense = default(AdvancedSeasonStatDefense))
        {
            this.Season = season;
            this.Team = team;
            this.Conference = conference;
            this.Offense = offense;
            this.Defense = defense;
        }
        
        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name="season", EmitDefaultValue=false)]
        public int? Season { get; set; }

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
        /// Gets or Sets Offense
        /// </summary>
        [DataMember(Name="offense", EmitDefaultValue=false)]
        public AdvancedSeasonStatOffense Offense { get; set; }

        /// <summary>
        /// Gets or Sets Defense
        /// </summary>
        [DataMember(Name="defense", EmitDefaultValue=false)]
        public AdvancedSeasonStatDefense Defense { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvancedSeasonStat {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Offense: ").Append(Offense).Append("\n");
            sb.Append("  Defense: ").Append(Defense).Append("\n");
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
            return this.Equals(input as AdvancedSeasonStat);
        }

        /// <summary>
        /// Returns true if AdvancedSeasonStat instances are equal
        /// </summary>
        /// <param name="input">Instance of AdvancedSeasonStat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvancedSeasonStat input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Season == input.Season ||
                    (this.Season != null &&
                    this.Season.Equals(input.Season))
                ) && 
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
                    this.Offense == input.Offense ||
                    (this.Offense != null &&
                    this.Offense.Equals(input.Offense))
                ) && 
                (
                    this.Defense == input.Defense ||
                    (this.Defense != null &&
                    this.Defense.Equals(input.Defense))
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
                if (this.Season != null)
                    hashCode = hashCode * 59 + this.Season.GetHashCode();
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.Conference != null)
                    hashCode = hashCode * 59 + this.Conference.GetHashCode();
                if (this.Offense != null)
                    hashCode = hashCode * 59 + this.Offense.GetHashCode();
                if (this.Defense != null)
                    hashCode = hashCode * 59 + this.Defense.GetHashCode();
                return hashCode;
            }
        }
    }

}
