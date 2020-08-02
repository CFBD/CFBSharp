/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 2.2.7
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
    /// DriveStartTime
    /// </summary>
    [DataContract]
    public partial class DriveStartTime :  IEquatable<DriveStartTime>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DriveStartTime" /> class.
        /// </summary>
        /// <param name="minutes">minutes.</param>
        /// <param name="seconds">seconds.</param>
        public DriveStartTime(int? minutes = default(int?), int? seconds = default(int?))
        {
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
        
        /// <summary>
        /// Gets or Sets Minutes
        /// </summary>
        [DataMember(Name="minutes", EmitDefaultValue=false)]
        public int? Minutes { get; set; }

        /// <summary>
        /// Gets or Sets Seconds
        /// </summary>
        [DataMember(Name="seconds", EmitDefaultValue=false)]
        public int? Seconds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DriveStartTime {\n");
            sb.Append("  Minutes: ").Append(Minutes).Append("\n");
            sb.Append("  Seconds: ").Append(Seconds).Append("\n");
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
            return this.Equals(input as DriveStartTime);
        }

        /// <summary>
        /// Returns true if DriveStartTime instances are equal
        /// </summary>
        /// <param name="input">Instance of DriveStartTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DriveStartTime input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Minutes == input.Minutes ||
                    (this.Minutes != null &&
                    this.Minutes.Equals(input.Minutes))
                ) && 
                (
                    this.Seconds == input.Seconds ||
                    (this.Seconds != null &&
                    this.Seconds.Equals(input.Seconds))
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
                if (this.Minutes != null)
                    hashCode = hashCode * 59 + this.Minutes.GetHashCode();
                if (this.Seconds != null)
                    hashCode = hashCode * 59 + this.Seconds.GetHashCode();
                return hashCode;
            }
        }
    }

}
