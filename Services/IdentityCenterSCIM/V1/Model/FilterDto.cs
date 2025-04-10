using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterSCIM.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FilterDto 
    {

        /// <summary>
        /// 一个布尔值，表示服务提供商是否支持这种操作
        /// </summary>
        [JsonProperty("supported", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Supported { get; set; }

        /// <summary>
        /// 最大结果数
        /// </summary>
        [JsonProperty("maxResults", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxResults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilterDto {\n");
            sb.Append("  supported: ").Append(Supported).Append("\n");
            sb.Append("  maxResults: ").Append(MaxResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FilterDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FilterDto input)
        {
            if (input == null) return false;
            if (this.Supported != input.Supported || (this.Supported != null && !this.Supported.Equals(input.Supported))) return false;
            if (this.MaxResults != input.MaxResults || (this.MaxResults != null && !this.MaxResults.Equals(input.MaxResults))) return false;

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
                if (this.Supported != null) hashCode = hashCode * 59 + this.Supported.GetHashCode();
                if (this.MaxResults != null) hashCode = hashCode * 59 + this.MaxResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
