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
    /// Recruit
    /// </summary>
    [DataContract]
    public partial class Recruit :  IEquatable<Recruit>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Recruit" /> class.
        /// </summary>
        /// <param name="recruitType">recruitType.</param>
        /// <param name="year">year.</param>
        /// <param name="ranking">ranking.</param>
        /// <param name="name">name.</param>
        /// <param name="school">school.</param>
        /// <param name="committedTo">committedTo.</param>
        /// <param name="position">position.</param>
        /// <param name="height">height.</param>
        /// <param name="weight">weight.</param>
        /// <param name="stars">stars.</param>
        /// <param name="rating">rating.</param>
        /// <param name="city">city.</param>
        /// <param name="stateProvince">stateProvince.</param>
        /// <param name="country">country.</param>
        public Recruit(string recruitType = default(string), int? year = default(int?), int? ranking = default(int?), string name = default(string), string school = default(string), string committedTo = default(string), string position = default(string), int? height = default(int?), int? weight = default(int?), int? stars = default(int?), decimal? rating = default(decimal?), string city = default(string), string stateProvince = default(string), string country = default(string))
        {
            this.RecruitType = recruitType;
            this.Year = year;
            this.Ranking = ranking;
            this.Name = name;
            this.School = school;
            this.CommittedTo = committedTo;
            this.Position = position;
            this.Height = height;
            this.Weight = weight;
            this.Stars = stars;
            this.Rating = rating;
            this.City = city;
            this.StateProvince = stateProvince;
            this.Country = country;
        }
        
        /// <summary>
        /// Gets or Sets RecruitType
        /// </summary>
        [DataMember(Name="recruitType", EmitDefaultValue=false)]
        public string RecruitType { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }

        /// <summary>
        /// Gets or Sets Ranking
        /// </summary>
        [DataMember(Name="ranking", EmitDefaultValue=false)]
        public int? Ranking { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets School
        /// </summary>
        [DataMember(Name="school", EmitDefaultValue=false)]
        public string School { get; set; }

        /// <summary>
        /// Gets or Sets CommittedTo
        /// </summary>
        [DataMember(Name="committedTo", EmitDefaultValue=false)]
        public string CommittedTo { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public string Position { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public int? Weight { get; set; }

        /// <summary>
        /// Gets or Sets Stars
        /// </summary>
        [DataMember(Name="stars", EmitDefaultValue=false)]
        public int? Stars { get; set; }

        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name="rating", EmitDefaultValue=false)]
        public decimal? Rating { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets StateProvince
        /// </summary>
        [DataMember(Name="stateProvince", EmitDefaultValue=false)]
        public string StateProvince { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Recruit {\n");
            sb.Append("  RecruitType: ").Append(RecruitType).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Ranking: ").Append(Ranking).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  School: ").Append(School).Append("\n");
            sb.Append("  CommittedTo: ").Append(CommittedTo).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Stars: ").Append(Stars).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(input as Recruit);
        }

        /// <summary>
        /// Returns true if Recruit instances are equal
        /// </summary>
        /// <param name="input">Instance of Recruit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Recruit input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecruitType == input.RecruitType ||
                    (this.RecruitType != null &&
                    this.RecruitType.Equals(input.RecruitType))
                ) && 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
                ) && 
                (
                    this.Ranking == input.Ranking ||
                    (this.Ranking != null &&
                    this.Ranking.Equals(input.Ranking))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.School == input.School ||
                    (this.School != null &&
                    this.School.Equals(input.School))
                ) && 
                (
                    this.CommittedTo == input.CommittedTo ||
                    (this.CommittedTo != null &&
                    this.CommittedTo.Equals(input.CommittedTo))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.Stars == input.Stars ||
                    (this.Stars != null &&
                    this.Stars.Equals(input.Stars))
                ) && 
                (
                    this.Rating == input.Rating ||
                    (this.Rating != null &&
                    this.Rating.Equals(input.Rating))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.StateProvince == input.StateProvince ||
                    (this.StateProvince != null &&
                    this.StateProvince.Equals(input.StateProvince))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                if (this.RecruitType != null)
                    hashCode = hashCode * 59 + this.RecruitType.GetHashCode();
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.Ranking != null)
                    hashCode = hashCode * 59 + this.Ranking.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.School != null)
                    hashCode = hashCode * 59 + this.School.GetHashCode();
                if (this.CommittedTo != null)
                    hashCode = hashCode * 59 + this.CommittedTo.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.Stars != null)
                    hashCode = hashCode * 59 + this.Stars.GetHashCode();
                if (this.Rating != null)
                    hashCode = hashCode * 59 + this.Rating.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.StateProvince != null)
                    hashCode = hashCode * 59 + this.StateProvince.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                return hashCode;
            }
        }
    }

}
