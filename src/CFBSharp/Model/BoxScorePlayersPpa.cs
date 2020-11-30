/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 2.3.2
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
    /// BoxScorePlayersPpa
    /// </summary>
    [DataContract]
    public partial class BoxScorePlayersPpa :  IEquatable<BoxScorePlayersPpa>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoxScorePlayersPpa" /> class.
        /// </summary>
        /// <param name="player">player.</param>
        /// <param name="team">team.</param>
        /// <param name="position">position.</param>
        /// <param name="average">average.</param>
        /// <param name="cumulative">cumulative.</param>
        public BoxScorePlayersPpa(string player = default(string), string team = default(string), string position = default(string), BoxScorePlayersAverage average = default(BoxScorePlayersAverage), BoxScorePlayersAverage cumulative = default(BoxScorePlayersAverage))
        {
            this.Player = player;
            this.Team = team;
            this.Position = position;
            this.Average = average;
            this.Cumulative = cumulative;
        }
        
        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name="player", EmitDefaultValue=false)]
        public string Player { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public string Position { get; set; }

        /// <summary>
        /// Gets or Sets Average
        /// </summary>
        [DataMember(Name="average", EmitDefaultValue=false)]
        public BoxScorePlayersAverage Average { get; set; }

        /// <summary>
        /// Gets or Sets Cumulative
        /// </summary>
        [DataMember(Name="cumulative", EmitDefaultValue=false)]
        public BoxScorePlayersAverage Cumulative { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoxScorePlayersPpa {\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Average: ").Append(Average).Append("\n");
            sb.Append("  Cumulative: ").Append(Cumulative).Append("\n");
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
            return this.Equals(input as BoxScorePlayersPpa);
        }

        /// <summary>
        /// Returns true if BoxScorePlayersPpa instances are equal
        /// </summary>
        /// <param name="input">Instance of BoxScorePlayersPpa to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoxScorePlayersPpa input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Player == input.Player ||
                    (this.Player != null &&
                    this.Player.Equals(input.Player))
                ) && 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.Average == input.Average ||
                    (this.Average != null &&
                    this.Average.Equals(input.Average))
                ) && 
                (
                    this.Cumulative == input.Cumulative ||
                    (this.Cumulative != null &&
                    this.Cumulative.Equals(input.Cumulative))
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
                if (this.Player != null)
                    hashCode = hashCode * 59 + this.Player.GetHashCode();
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Average != null)
                    hashCode = hashCode * 59 + this.Average.GetHashCode();
                if (this.Cumulative != null)
                    hashCode = hashCode * 59 + this.Cumulative.GetHashCode();
                return hashCode;
            }
        }
    }

}
