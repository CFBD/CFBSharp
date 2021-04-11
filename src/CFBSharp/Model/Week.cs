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
    /// Week
    /// </summary>
    [DataContract]
    public partial class Week :  IEquatable<Week>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Week" /> class.
        /// </summary>
        /// <param name="season">season.</param>
        /// <param name="week">week.</param>
        /// <param name="seasonType">seasonType.</param>
        /// <param name="firstGameStart">firstGameStart.</param>
        /// <param name="lastGameStart">lastGameStart.</param>
        public Week(int? season = default(int?), int? week = default(int?), string seasonType = default(string), string firstGameStart = default(string), string lastGameStart = default(string))
        {
            this.Season = season;
            this._Week = week;
            this.SeasonType = seasonType;
            this.FirstGameStart = firstGameStart;
            this.LastGameStart = lastGameStart;
        }
        
        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name="season", EmitDefaultValue=false)]
        public int? Season { get; set; }

        /// <summary>
        /// Gets or Sets _Week
        /// </summary>
        [DataMember(Name="week", EmitDefaultValue=false)]
        public int? _Week { get; set; }

        /// <summary>
        /// Gets or Sets SeasonType
        /// </summary>
        [DataMember(Name="seasonType", EmitDefaultValue=false)]
        public string SeasonType { get; set; }

        /// <summary>
        /// Gets or Sets FirstGameStart
        /// </summary>
        [DataMember(Name="firstGameStart", EmitDefaultValue=false)]
        public string FirstGameStart { get; set; }

        /// <summary>
        /// Gets or Sets LastGameStart
        /// </summary>
        [DataMember(Name="lastGameStart", EmitDefaultValue=false)]
        public string LastGameStart { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Week {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  _Week: ").Append(_Week).Append("\n");
            sb.Append("  SeasonType: ").Append(SeasonType).Append("\n");
            sb.Append("  FirstGameStart: ").Append(FirstGameStart).Append("\n");
            sb.Append("  LastGameStart: ").Append(LastGameStart).Append("\n");
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
            return this.Equals(input as Week);
        }

        /// <summary>
        /// Returns true if Week instances are equal
        /// </summary>
        /// <param name="input">Instance of Week to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Week input)
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
                    this._Week == input._Week ||
                    (this._Week != null &&
                    this._Week.Equals(input._Week))
                ) && 
                (
                    this.SeasonType == input.SeasonType ||
                    (this.SeasonType != null &&
                    this.SeasonType.Equals(input.SeasonType))
                ) && 
                (
                    this.FirstGameStart == input.FirstGameStart ||
                    (this.FirstGameStart != null &&
                    this.FirstGameStart.Equals(input.FirstGameStart))
                ) && 
                (
                    this.LastGameStart == input.LastGameStart ||
                    (this.LastGameStart != null &&
                    this.LastGameStart.Equals(input.LastGameStart))
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
                if (this._Week != null)
                    hashCode = hashCode * 59 + this._Week.GetHashCode();
                if (this.SeasonType != null)
                    hashCode = hashCode * 59 + this.SeasonType.GetHashCode();
                if (this.FirstGameStart != null)
                    hashCode = hashCode * 59 + this.FirstGameStart.GetHashCode();
                if (this.LastGameStart != null)
                    hashCode = hashCode * 59 + this.LastGameStart.GetHashCode();
                return hashCode;
            }
        }
    }

}
