/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.5.1
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
    /// ConferenceSPRating
    /// </summary>
    [DataContract]
    public partial class ConferenceSPRating :  IEquatable<ConferenceSPRating>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConferenceSPRating" /> class.
        /// </summary>
        /// <param name="year">year.</param>
        /// <param name="conference">conference.</param>
        /// <param name="rating">rating.</param>
        /// <param name="secondOrderWins">secondOrderWins.</param>
        /// <param name="sos">sos.</param>
        /// <param name="offense">offense.</param>
        /// <param name="defense">defense.</param>
        /// <param name="specialTeams">specialTeams.</param>
        public ConferenceSPRating(int? year = default(int?), string conference = default(string), decimal? rating = default(decimal?), decimal? secondOrderWins = default(decimal?), decimal? sos = default(decimal?), ConferenceSPRatingOffense offense = default(ConferenceSPRatingOffense), ConferenceSPRatingDefense defense = default(ConferenceSPRatingDefense), TeamSPRatingSpecialTeams specialTeams = default(TeamSPRatingSpecialTeams))
        {
            this.Year = year;
            this.Conference = conference;
            this.Rating = rating;
            this.SecondOrderWins = secondOrderWins;
            this.Sos = sos;
            this.Offense = offense;
            this.Defense = defense;
            this.SpecialTeams = specialTeams;
        }
        
        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }

        /// <summary>
        /// Gets or Sets Conference
        /// </summary>
        [DataMember(Name="conference", EmitDefaultValue=false)]
        public string Conference { get; set; }

        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name="rating", EmitDefaultValue=false)]
        public decimal? Rating { get; set; }

        /// <summary>
        /// Gets or Sets SecondOrderWins
        /// </summary>
        [DataMember(Name="secondOrderWins", EmitDefaultValue=false)]
        public decimal? SecondOrderWins { get; set; }

        /// <summary>
        /// Gets or Sets Sos
        /// </summary>
        [DataMember(Name="sos", EmitDefaultValue=false)]
        public decimal? Sos { get; set; }

        /// <summary>
        /// Gets or Sets Offense
        /// </summary>
        [DataMember(Name="offense", EmitDefaultValue=false)]
        public ConferenceSPRatingOffense Offense { get; set; }

        /// <summary>
        /// Gets or Sets Defense
        /// </summary>
        [DataMember(Name="defense", EmitDefaultValue=false)]
        public ConferenceSPRatingDefense Defense { get; set; }

        /// <summary>
        /// Gets or Sets SpecialTeams
        /// </summary>
        [DataMember(Name="specialTeams", EmitDefaultValue=false)]
        public TeamSPRatingSpecialTeams SpecialTeams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConferenceSPRating {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  SecondOrderWins: ").Append(SecondOrderWins).Append("\n");
            sb.Append("  Sos: ").Append(Sos).Append("\n");
            sb.Append("  Offense: ").Append(Offense).Append("\n");
            sb.Append("  Defense: ").Append(Defense).Append("\n");
            sb.Append("  SpecialTeams: ").Append(SpecialTeams).Append("\n");
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
            return this.Equals(input as ConferenceSPRating);
        }

        /// <summary>
        /// Returns true if ConferenceSPRating instances are equal
        /// </summary>
        /// <param name="input">Instance of ConferenceSPRating to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConferenceSPRating input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
                ) && 
                (
                    this.Conference == input.Conference ||
                    (this.Conference != null &&
                    this.Conference.Equals(input.Conference))
                ) && 
                (
                    this.Rating == input.Rating ||
                    (this.Rating != null &&
                    this.Rating.Equals(input.Rating))
                ) && 
                (
                    this.SecondOrderWins == input.SecondOrderWins ||
                    (this.SecondOrderWins != null &&
                    this.SecondOrderWins.Equals(input.SecondOrderWins))
                ) && 
                (
                    this.Sos == input.Sos ||
                    (this.Sos != null &&
                    this.Sos.Equals(input.Sos))
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
                ) && 
                (
                    this.SpecialTeams == input.SpecialTeams ||
                    (this.SpecialTeams != null &&
                    this.SpecialTeams.Equals(input.SpecialTeams))
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
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.Conference != null)
                    hashCode = hashCode * 59 + this.Conference.GetHashCode();
                if (this.Rating != null)
                    hashCode = hashCode * 59 + this.Rating.GetHashCode();
                if (this.SecondOrderWins != null)
                    hashCode = hashCode * 59 + this.SecondOrderWins.GetHashCode();
                if (this.Sos != null)
                    hashCode = hashCode * 59 + this.Sos.GetHashCode();
                if (this.Offense != null)
                    hashCode = hashCode * 59 + this.Offense.GetHashCode();
                if (this.Defense != null)
                    hashCode = hashCode * 59 + this.Defense.GetHashCode();
                if (this.SpecialTeams != null)
                    hashCode = hashCode * 59 + this.SpecialTeams.GetHashCode();
                return hashCode;
            }
        }
    }

}
