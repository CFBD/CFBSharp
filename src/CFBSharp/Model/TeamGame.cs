/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 1.24.5
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
    /// TeamGame
    /// </summary>
    [DataContract]
    public partial class TeamGame :  IEquatable<TeamGame>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamGame" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="teams">teams.</param>
        public TeamGame(int? id = default(int?), List<TeamGameTeams> teams = default(List<TeamGameTeams>))
        {
            this.Id = id;
            this.Teams = teams;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Teams
        /// </summary>
        [DataMember(Name="teams", EmitDefaultValue=false)]
        public List<TeamGameTeams> Teams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamGame {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
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
            return this.Equals(input as TeamGame);
        }

        /// <summary>
        /// Returns true if TeamGame instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamGame to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamGame input)
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
                    this.Teams == input.Teams ||
                    this.Teams != null &&
                    this.Teams.SequenceEqual(input.Teams)
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
                if (this.Teams != null)
                    hashCode = hashCode * 59 + this.Teams.GetHashCode();
                return hashCode;
            }
        }
    }

}
