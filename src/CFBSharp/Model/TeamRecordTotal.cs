/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 2.2.1
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
    /// TeamRecordTotal
    /// </summary>
    [DataContract]
    public partial class TeamRecordTotal :  IEquatable<TeamRecordTotal>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRecordTotal" /> class.
        /// </summary>
        /// <param name="games">games.</param>
        /// <param name="wins">wins.</param>
        /// <param name="losses">losses.</param>
        /// <param name="ties">ties.</param>
        public TeamRecordTotal(int? games = default(int?), int? wins = default(int?), int? losses = default(int?), int? ties = default(int?))
        {
            this.Games = games;
            this.Wins = wins;
            this.Losses = losses;
            this.Ties = ties;
        }
        
        /// <summary>
        /// Gets or Sets Games
        /// </summary>
        [DataMember(Name="games", EmitDefaultValue=false)]
        public int? Games { get; set; }

        /// <summary>
        /// Gets or Sets Wins
        /// </summary>
        [DataMember(Name="wins", EmitDefaultValue=false)]
        public int? Wins { get; set; }

        /// <summary>
        /// Gets or Sets Losses
        /// </summary>
        [DataMember(Name="losses", EmitDefaultValue=false)]
        public int? Losses { get; set; }

        /// <summary>
        /// Gets or Sets Ties
        /// </summary>
        [DataMember(Name="ties", EmitDefaultValue=false)]
        public int? Ties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamRecordTotal {\n");
            sb.Append("  Games: ").Append(Games).Append("\n");
            sb.Append("  Wins: ").Append(Wins).Append("\n");
            sb.Append("  Losses: ").Append(Losses).Append("\n");
            sb.Append("  Ties: ").Append(Ties).Append("\n");
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
            return this.Equals(input as TeamRecordTotal);
        }

        /// <summary>
        /// Returns true if TeamRecordTotal instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamRecordTotal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamRecordTotal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Games == input.Games ||
                    (this.Games != null &&
                    this.Games.Equals(input.Games))
                ) && 
                (
                    this.Wins == input.Wins ||
                    (this.Wins != null &&
                    this.Wins.Equals(input.Wins))
                ) && 
                (
                    this.Losses == input.Losses ||
                    (this.Losses != null &&
                    this.Losses.Equals(input.Losses))
                ) && 
                (
                    this.Ties == input.Ties ||
                    (this.Ties != null &&
                    this.Ties.Equals(input.Ties))
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
                if (this.Games != null)
                    hashCode = hashCode * 59 + this.Games.GetHashCode();
                if (this.Wins != null)
                    hashCode = hashCode * 59 + this.Wins.GetHashCode();
                if (this.Losses != null)
                    hashCode = hashCode * 59 + this.Losses.GetHashCode();
                if (this.Ties != null)
                    hashCode = hashCode * 59 + this.Ties.GetHashCode();
                return hashCode;
            }
        }
    }

}
