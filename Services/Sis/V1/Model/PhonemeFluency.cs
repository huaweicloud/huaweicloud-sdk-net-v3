using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Sis.V1.Model
{
    /// <summary>
    ///  音素的流利度打分
    /// </summary>
    public class PhonemeFluency 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public float? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rhythm", NullValueHandling = NullValueHandling.Ignore)]
        public float? Rhythm { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhonemeFluency {\n");
            sb.Append("  score: ").Append(Score).Append("\n");
            sb.Append("  rhythm: ").Append(Rhythm).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PhonemeFluency);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PhonemeFluency input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
                ) && 
                (
                    this.Rhythm == input.Rhythm ||
                    (this.Rhythm != null &&
                    this.Rhythm.Equals(input.Rhythm))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.Rhythm != null)
                    hashCode = hashCode * 59 + this.Rhythm.GetHashCode();
                return hashCode;
            }
        }
    }
}
