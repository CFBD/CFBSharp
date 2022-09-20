/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.4.4
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
    /// AdvancedGameStatOffenseStandardDowns
    /// </summary>
    [DataContract]
    public partial class AdvancedGameStatOffenseStandardDowns :  IEquatable<AdvancedGameStatOffenseStandardDowns>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedGameStatOffenseStandardDowns" /> class.
        /// </summary>
        /// <param name="ppa">ppa.</param>
        /// <param name="successRate">successRate.</param>
        /// <param name="explosiveness">explosiveness.</param>
        public AdvancedGameStatOffenseStandardDowns(decimal? ppa = default(decimal?), decimal? successRate = default(decimal?), decimal? explosiveness = default(decimal?))
        {
            this.Ppa = ppa;
            this.SuccessRate = successRate;
            this.Explosiveness = explosiveness;
        }
        
        /// <summary>
        /// Gets or Sets Ppa
        /// </summary>
        [DataMember(Name="ppa", EmitDefaultValue=false)]
        public decimal? Ppa { get; set; }

        /// <summary>
        /// Gets or Sets SuccessRate
        /// </summary>
        [DataMember(Name="successRate", EmitDefaultValue=false)]
        public decimal? SuccessRate { get; set; }

        /// <summary>
        /// Gets or Sets Explosiveness
        /// </summary>
        [DataMember(Name="explosiveness", EmitDefaultValue=false)]
        public decimal? Explosiveness { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvancedGameStatOffenseStandardDowns {\n");
            sb.Append("  Ppa: ").Append(Ppa).Append("\n");
            sb.Append("  SuccessRate: ").Append(SuccessRate).Append("\n");
            sb.Append("  Explosiveness: ").Append(Explosiveness).Append("\n");
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
            return this.Equals(input as AdvancedGameStatOffenseStandardDowns);
        }

        /// <summary>
        /// Returns true if AdvancedGameStatOffenseStandardDowns instances are equal
        /// </summary>
        /// <param name="input">Instance of AdvancedGameStatOffenseStandardDowns to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvancedGameStatOffenseStandardDowns input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ppa == input.Ppa ||
                    (this.Ppa != null &&
                    this.Ppa.Equals(input.Ppa))
                ) && 
                (
                    this.SuccessRate == input.SuccessRate ||
                    (this.SuccessRate != null &&
                    this.SuccessRate.Equals(input.SuccessRate))
                ) && 
                (
                    this.Explosiveness == input.Explosiveness ||
                    (this.Explosiveness != null &&
                    this.Explosiveness.Equals(input.Explosiveness))
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
                if (this.Ppa != null)
                    hashCode = hashCode * 59 + this.Ppa.GetHashCode();
                if (this.SuccessRate != null)
                    hashCode = hashCode * 59 + this.SuccessRate.GetHashCode();
                if (this.Explosiveness != null)
                    hashCode = hashCode * 59 + this.Explosiveness.GetHashCode();
                return hashCode;
            }
        }
    }

}
