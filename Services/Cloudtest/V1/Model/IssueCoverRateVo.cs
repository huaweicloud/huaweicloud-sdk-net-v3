using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 看板项目的需求覆盖率
    /// </summary>
    public class IssueCoverRateVo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("epic", NullValueHandling = NullValueHandling.Ignore)]
        public CoverRateVo Epic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("feature", NullValueHandling = NullValueHandling.Ignore)]
        public CoverRateVo Feature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("story", NullValueHandling = NullValueHandling.Ignore)]
        public CoverRateVo Story { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public CoverRateVo Summary { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueCoverRateVo {\n");
            sb.Append("  epic: ").Append(Epic).Append("\n");
            sb.Append("  feature: ").Append(Feature).Append("\n");
            sb.Append("  story: ").Append(Story).Append("\n");
            sb.Append("  summary: ").Append(Summary).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueCoverRateVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueCoverRateVo input)
        {
            if (input == null) return false;
            if (this.Epic != input.Epic || (this.Epic != null && !this.Epic.Equals(input.Epic))) return false;
            if (this.Feature != input.Feature || (this.Feature != null && !this.Feature.Equals(input.Feature))) return false;
            if (this.Story != input.Story || (this.Story != null && !this.Story.Equals(input.Story))) return false;
            if (this.Summary != input.Summary || (this.Summary != null && !this.Summary.Equals(input.Summary))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Epic != null) hashCode = hashCode * 59 + this.Epic.GetHashCode();
                if (this.Feature != null) hashCode = hashCode * 59 + this.Feature.GetHashCode();
                if (this.Story != null) hashCode = hashCode * 59 + this.Story.GetHashCode();
                if (this.Summary != null) hashCode = hashCode * 59 + this.Summary.GetHashCode();
                return hashCode;
            }
        }
    }
}
