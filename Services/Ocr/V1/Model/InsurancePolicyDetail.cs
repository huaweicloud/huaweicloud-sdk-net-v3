using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ocr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class InsurancePolicyDetail 
    {

        /// <summary>
        /// 对应识别出的文本内容
        /// </summary>
        [JsonProperty("words", NullValueHandling = NullValueHandling.Ignore)]
        public string Words { get; set; }

        /// <summary>
        /// 对应识别出的四个顶点坐标 
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<int?>> Location { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InsurancePolicyDetail {\n");
            sb.Append("  words: ").Append(Words).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InsurancePolicyDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InsurancePolicyDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Words == input.Words ||
                    (this.Words != null &&
                    this.Words.Equals(input.Words))
                ) && 
                (
                    this.Location == input.Location ||
                    this.Location != null &&
                    input.Location != null &&
                    this.Location.SequenceEqual(input.Location)
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
                if (this.Words != null)
                    hashCode = hashCode * 59 + this.Words.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                return hashCode;
            }
        }
    }
}
