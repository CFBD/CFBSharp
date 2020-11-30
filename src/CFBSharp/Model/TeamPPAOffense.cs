/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 2.3.0
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
    /// TeamPPAOffense
    /// </summary>
    [DataContract]
    public partial class TeamPPAOffense :  IEquatable<TeamPPAOffense>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamPPAOffense" /> class.
        /// </summary>
        /// <param name="overall">overall.</param>
        /// <param name="passing">passing.</param>
        /// <param name="rushing">rushing.</param>
        /// <param name="firstDown">firstDown.</param>
        /// <param name="secondDown">secondDown.</param>
        /// <param name="thirdDown">thirdDown.</param>
        /// <param name="cumulative">cumulative.</param>
        public TeamPPAOffense(decimal? overall = default(decimal?), decimal? passing = default(decimal?), decimal? rushing = default(decimal?), decimal? firstDown = default(decimal?), decimal? secondDown = default(decimal?), decimal? thirdDown = default(decimal?), TeamPPAOffenseCumulative cumulative = default(TeamPPAOffenseCumulative))
        {
            this.Overall = overall;
            this.Passing = passing;
            this.Rushing = rushing;
            this.FirstDown = firstDown;
            this.SecondDown = secondDown;
            this.ThirdDown = thirdDown;
            this.Cumulative = cumulative;
        }
        
        /// <summary>
        /// Gets or Sets Overall
        /// </summary>
        [DataMember(Name="overall", EmitDefaultValue=false)]
        public decimal? Overall { get; set; }

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
        /// Gets or Sets FirstDown
        /// </summary>
        [DataMember(Name="firstDown", EmitDefaultValue=false)]
        public decimal? FirstDown { get; set; }

        /// <summary>
        /// Gets or Sets SecondDown
        /// </summary>
        [DataMember(Name="secondDown", EmitDefaultValue=false)]
        public decimal? SecondDown { get; set; }

        /// <summary>
        /// Gets or Sets ThirdDown
        /// </summary>
        [DataMember(Name="thirdDown", EmitDefaultValue=false)]
        public decimal? ThirdDown { get; set; }

        /// <summary>
        /// Gets or Sets Cumulative
        /// </summary>
        [DataMember(Name="cumulative", EmitDefaultValue=false)]
        public TeamPPAOffenseCumulative Cumulative { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamPPAOffense {\n");
            sb.Append("  Overall: ").Append(Overall).Append("\n");
            sb.Append("  Passing: ").Append(Passing).Append("\n");
            sb.Append("  Rushing: ").Append(Rushing).Append("\n");
            sb.Append("  FirstDown: ").Append(FirstDown).Append("\n");
            sb.Append("  SecondDown: ").Append(SecondDown).Append("\n");
            sb.Append("  ThirdDown: ").Append(ThirdDown).Append("\n");
            sb.Append("  Cumulative: ").Append(Cumulative).Append("\n");
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
            return this.Equals(input as TeamPPAOffense);
        }

        /// <summary>
        /// Returns true if TeamPPAOffense instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamPPAOffense to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamPPAOffense input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Overall == input.Overall ||
                    (this.Overall != null &&
                    this.Overall.Equals(input.Overall))
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
                ) && 
                (
                    this.FirstDown == input.FirstDown ||
                    (this.FirstDown != null &&
                    this.FirstDown.Equals(input.FirstDown))
                ) && 
                (
                    this.SecondDown == input.SecondDown ||
                    (this.SecondDown != null &&
                    this.SecondDown.Equals(input.SecondDown))
                ) && 
                (
                    this.ThirdDown == input.ThirdDown ||
                    (this.ThirdDown != null &&
                    this.ThirdDown.Equals(input.ThirdDown))
                ) && 
                (
                    this.Cumulative == input.Cumulative ||
                    (this.Cumulative != null &&
                    this.Cumulative.Equals(input.Cumulative))
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
                if (this.Overall != null)
                    hashCode = hashCode * 59 + this.Overall.GetHashCode();
                if (this.Passing != null)
                    hashCode = hashCode * 59 + this.Passing.GetHashCode();
                if (this.Rushing != null)
                    hashCode = hashCode * 59 + this.Rushing.GetHashCode();
                if (this.FirstDown != null)
                    hashCode = hashCode * 59 + this.FirstDown.GetHashCode();
                if (this.SecondDown != null)
                    hashCode = hashCode * 59 + this.SecondDown.GetHashCode();
                if (this.ThirdDown != null)
                    hashCode = hashCode * 59 + this.ThirdDown.GetHashCode();
                if (this.Cumulative != null)
                    hashCode = hashCode * 59 + this.Cumulative.GetHashCode();
                return hashCode;
            }
        }
    }

}
