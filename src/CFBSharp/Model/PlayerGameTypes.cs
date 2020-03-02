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
    /// PlayerGameTypes
    /// </summary>
    [DataContract]
    public partial class PlayerGameTypes :  IEquatable<PlayerGameTypes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerGameTypes" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="athletes">athletes.</param>
        public PlayerGameTypes(string name = default(string), List<PlayerGameAthletes> athletes = default(List<PlayerGameAthletes>))
        {
            this.Name = name;
            this.Athletes = athletes;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Athletes
        /// </summary>
        [DataMember(Name="athletes", EmitDefaultValue=false)]
        public List<PlayerGameAthletes> Athletes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayerGameTypes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Athletes: ").Append(Athletes).Append("\n");
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
            return this.Equals(input as PlayerGameTypes);
        }

        /// <summary>
        /// Returns true if PlayerGameTypes instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayerGameTypes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerGameTypes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Athletes == input.Athletes ||
                    this.Athletes != null &&
                    this.Athletes.SequenceEqual(input.Athletes)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Athletes != null)
                    hashCode = hashCode * 59 + this.Athletes.GetHashCode();
                return hashCode;
            }
        }
    }

}
