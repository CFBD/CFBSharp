/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.4.9
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
    /// ScoreboardGameWeather
    /// </summary>
    [DataContract]
    public partial class ScoreboardGameWeather :  IEquatable<ScoreboardGameWeather>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreboardGameWeather" /> class.
        /// </summary>
        /// <param name="temperature">temperature.</param>
        /// <param name="description">description.</param>
        /// <param name="windSpeed">windSpeed.</param>
        /// <param name="windDirection">windDirection.</param>
        public ScoreboardGameWeather(decimal? temperature = default(decimal?), string description = default(string), decimal? windSpeed = default(decimal?), decimal? windDirection = default(decimal?))
        {
            this.Temperature = temperature;
            this.Description = description;
            this.WindSpeed = windSpeed;
            this.WindDirection = windDirection;
        }
        
        /// <summary>
        /// Gets or Sets Temperature
        /// </summary>
        [DataMember(Name="temperature", EmitDefaultValue=false)]
        public decimal? Temperature { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets WindSpeed
        /// </summary>
        [DataMember(Name="windSpeed", EmitDefaultValue=false)]
        public decimal? WindSpeed { get; set; }

        /// <summary>
        /// Gets or Sets WindDirection
        /// </summary>
        [DataMember(Name="windDirection", EmitDefaultValue=false)]
        public decimal? WindDirection { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScoreboardGameWeather {\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  WindSpeed: ").Append(WindSpeed).Append("\n");
            sb.Append("  WindDirection: ").Append(WindDirection).Append("\n");
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
            return this.Equals(input as ScoreboardGameWeather);
        }

        /// <summary>
        /// Returns true if ScoreboardGameWeather instances are equal
        /// </summary>
        /// <param name="input">Instance of ScoreboardGameWeather to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScoreboardGameWeather input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Temperature == input.Temperature ||
                    (this.Temperature != null &&
                    this.Temperature.Equals(input.Temperature))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.WindSpeed == input.WindSpeed ||
                    (this.WindSpeed != null &&
                    this.WindSpeed.Equals(input.WindSpeed))
                ) && 
                (
                    this.WindDirection == input.WindDirection ||
                    (this.WindDirection != null &&
                    this.WindDirection.Equals(input.WindDirection))
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
                if (this.Temperature != null)
                    hashCode = hashCode * 59 + this.Temperature.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.WindSpeed != null)
                    hashCode = hashCode * 59 + this.WindSpeed.GetHashCode();
                if (this.WindDirection != null)
                    hashCode = hashCode * 59 + this.WindDirection.GetHashCode();
                return hashCode;
            }
        }
    }

}
