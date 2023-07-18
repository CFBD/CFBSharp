/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.4.13
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
    /// RankingWeekPolls
    /// </summary>
    [DataContract]
    public partial class RankingWeekPolls :  IEquatable<RankingWeekPolls>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RankingWeekPolls" /> class.
        /// </summary>
        /// <param name="poll">poll.</param>
        /// <param name="ranks">ranks.</param>
        public RankingWeekPolls(string poll = default(string), List<RankingWeekRanks> ranks = default(List<RankingWeekRanks>))
        {
            this.Poll = poll;
            this.Ranks = ranks;
        }
        
        /// <summary>
        /// Gets or Sets Poll
        /// </summary>
        [DataMember(Name="poll", EmitDefaultValue=false)]
        public string Poll { get; set; }

        /// <summary>
        /// Gets or Sets Ranks
        /// </summary>
        [DataMember(Name="ranks", EmitDefaultValue=false)]
        public List<RankingWeekRanks> Ranks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RankingWeekPolls {\n");
            sb.Append("  Poll: ").Append(Poll).Append("\n");
            sb.Append("  Ranks: ").Append(Ranks).Append("\n");
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
            return this.Equals(input as RankingWeekPolls);
        }

        /// <summary>
        /// Returns true if RankingWeekPolls instances are equal
        /// </summary>
        /// <param name="input">Instance of RankingWeekPolls to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RankingWeekPolls input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Poll == input.Poll ||
                    (this.Poll != null &&
                    this.Poll.Equals(input.Poll))
                ) && 
                (
                    this.Ranks == input.Ranks ||
                    this.Ranks != null &&
                    this.Ranks.SequenceEqual(input.Ranks)
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
                if (this.Poll != null)
                    hashCode = hashCode * 59 + this.Poll.GetHashCode();
                if (this.Ranks != null)
                    hashCode = hashCode * 59 + this.Ranks.GetHashCode();
                return hashCode;
            }
        }
    }

}
