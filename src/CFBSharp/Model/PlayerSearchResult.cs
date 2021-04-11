/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\").
 *
 * OpenAPI spec version: 3.2.0
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
    /// PlayerSearchResult
    /// </summary>
    [DataContract]
    public partial class PlayerSearchResult :  IEquatable<PlayerSearchResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerSearchResult" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="team">team.</param>
        /// <param name="name">name.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="weight">weight.</param>
        /// <param name="height">height.</param>
        /// <param name="jersey">jersey.</param>
        /// <param name="position">position.</param>
        /// <param name="hometown">hometown.</param>
        /// <param name="teamColor">teamColor.</param>
        /// <param name="teamColorSecondary">teamColorSecondary.</param>
        public PlayerSearchResult(int? id = default(int?), string team = default(string), string name = default(string), string firstName = default(string), string lastName = default(string), int? weight = default(int?), int? height = default(int?), int? jersey = default(int?), string position = default(string), string hometown = default(string), string teamColor = default(string), string teamColorSecondary = default(string))
        {
            this.Id = id;
            this.Team = team;
            this.Name = name;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Weight = weight;
            this.Height = height;
            this.Jersey = jersey;
            this.Position = position;
            this.Hometown = hometown;
            this.TeamColor = teamColor;
            this.TeamColorSecondary = teamColorSecondary;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public int? Weight { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or Sets Jersey
        /// </summary>
        [DataMember(Name="jersey", EmitDefaultValue=false)]
        public int? Jersey { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public string Position { get; set; }

        /// <summary>
        /// Gets or Sets Hometown
        /// </summary>
        [DataMember(Name="hometown", EmitDefaultValue=false)]
        public string Hometown { get; set; }

        /// <summary>
        /// Gets or Sets TeamColor
        /// </summary>
        [DataMember(Name="teamColor", EmitDefaultValue=false)]
        public string TeamColor { get; set; }

        /// <summary>
        /// Gets or Sets TeamColorSecondary
        /// </summary>
        [DataMember(Name="teamColorSecondary", EmitDefaultValue=false)]
        public string TeamColorSecondary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayerSearchResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Jersey: ").Append(Jersey).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Hometown: ").Append(Hometown).Append("\n");
            sb.Append("  TeamColor: ").Append(TeamColor).Append("\n");
            sb.Append("  TeamColorSecondary: ").Append(TeamColorSecondary).Append("\n");
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
            return this.Equals(input as PlayerSearchResult);
        }

        /// <summary>
        /// Returns true if PlayerSearchResult instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayerSearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerSearchResult input)
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
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Jersey == input.Jersey ||
                    (this.Jersey != null &&
                    this.Jersey.Equals(input.Jersey))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.Hometown == input.Hometown ||
                    (this.Hometown != null &&
                    this.Hometown.Equals(input.Hometown))
                ) && 
                (
                    this.TeamColor == input.TeamColor ||
                    (this.TeamColor != null &&
                    this.TeamColor.Equals(input.TeamColor))
                ) && 
                (
                    this.TeamColorSecondary == input.TeamColorSecondary ||
                    (this.TeamColorSecondary != null &&
                    this.TeamColorSecondary.Equals(input.TeamColorSecondary))
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
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Jersey != null)
                    hashCode = hashCode * 59 + this.Jersey.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Hometown != null)
                    hashCode = hashCode * 59 + this.Hometown.GetHashCode();
                if (this.TeamColor != null)
                    hashCode = hashCode * 59 + this.TeamColor.GetHashCode();
                if (this.TeamColorSecondary != null)
                    hashCode = hashCode * 59 + this.TeamColorSecondary.GetHashCode();
                return hashCode;
            }
        }
    }

}
