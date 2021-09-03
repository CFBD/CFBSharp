/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.1.8
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
    /// PlayerGamePPA
    /// </summary>
    [DataContract]
    public partial class PlayerGamePPA :  IEquatable<PlayerGamePPA>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerGamePPA" /> class.
        /// </summary>
        /// <param name="season">season.</param>
        /// <param name="week">week.</param>
        /// <param name="name">name.</param>
        /// <param name="position">position.</param>
        /// <param name="team">team.</param>
        /// <param name="opponent">opponent.</param>
        /// <param name="averagePPA">averagePPA.</param>
        public PlayerGamePPA(int? season = default(int?), int? week = default(int?), string name = default(string), string position = default(string), string team = default(string), string opponent = default(string), Object averagePPA = default(Object))
        {
            this.Season = season;
            this.Week = week;
            this.Name = name;
            this.Position = position;
            this.Team = team;
            this.Opponent = opponent;
            this.AveragePPA = averagePPA;
        }
        
        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name="season", EmitDefaultValue=false)]
        public int? Season { get; set; }

        /// <summary>
        /// Gets or Sets Week
        /// </summary>
        [DataMember(Name="week", EmitDefaultValue=false)]
        public int? Week { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public string Position { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Opponent
        /// </summary>
        [DataMember(Name="opponent", EmitDefaultValue=false)]
        public string Opponent { get; set; }

        /// <summary>
        /// Gets or Sets AveragePPA
        /// </summary>
        [DataMember(Name="averagePPA", EmitDefaultValue=false)]
        public Object AveragePPA { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayerGamePPA {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Opponent: ").Append(Opponent).Append("\n");
            sb.Append("  AveragePPA: ").Append(AveragePPA).Append("\n");
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
            return this.Equals(input as PlayerGamePPA);
        }

        /// <summary>
        /// Returns true if PlayerGamePPA instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayerGamePPA to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerGamePPA input)
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
                    this.Week == input.Week ||
                    (this.Week != null &&
                    this.Week.Equals(input.Week))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.Opponent == input.Opponent ||
                    (this.Opponent != null &&
                    this.Opponent.Equals(input.Opponent))
                ) && 
                (
                    this.AveragePPA == input.AveragePPA ||
                    (this.AveragePPA != null &&
                    this.AveragePPA.Equals(input.AveragePPA))
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
                if (this.Week != null)
                    hashCode = hashCode * 59 + this.Week.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.Opponent != null)
                    hashCode = hashCode * 59 + this.Opponent.GetHashCode();
                if (this.AveragePPA != null)
                    hashCode = hashCode * 59 + this.AveragePPA.GetHashCode();
                return hashCode;
            }
        }
    }

}
