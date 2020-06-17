/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 1.26.0
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
    /// TeamPPAOffenseCumulative
    /// </summary>
    [DataContract]
    public partial class TeamPPAOffenseCumulative :  IEquatable<TeamPPAOffenseCumulative>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamPPAOffenseCumulative" /> class.
        /// </summary>
        /// <param name="total">total.</param>
        /// <param name="passing">passing.</param>
        /// <param name="rushing">rushing.</param>
        public TeamPPAOffenseCumulative(decimal? total = default(decimal?), decimal? passing = default(decimal?), decimal? rushing = default(decimal?))
        {
            this.Total = total;
            this.Passing = passing;
            this.Rushing = rushing;
        }
        
        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public decimal? Total { get; set; }

        /// <summary>
        /// Gets or Sets Passing
        /// </summary>
        [DataMember(Name="passing", EmitDefaultValue=false)]
        public decimal? Passing { get; set; }

        /// <summary>
        /// Gets or Sets Rushing
        /// </summary>
        [DataMember(Name="rushing", EmitDefaultValue=false)]
        public decimal? Rushing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamPPAOffenseCumulative {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Passing: ").Append(Passing).Append("\n");
            sb.Append("  Rushing: ").Append(Rushing).Append("\n");
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
            return this.Equals(input as TeamPPAOffenseCumulative);
        }

        /// <summary>
        /// Returns true if TeamPPAOffenseCumulative instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamPPAOffenseCumulative to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamPPAOffenseCumulative input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Passing == input.Passing ||
                    (this.Passing != null &&
                    this.Passing.Equals(input.Passing))
                ) && 
                (
                    this.Rushing == input.Rushing ||
                    (this.Rushing != null &&
                    this.Rushing.Equals(input.Rushing))
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Passing != null)
                    hashCode = hashCode * 59 + this.Passing.GetHashCode();
                if (this.Rushing != null)
                    hashCode = hashCode * 59 + this.Rushing.GetHashCode();
                return hashCode;
            }
        }
    }

}
