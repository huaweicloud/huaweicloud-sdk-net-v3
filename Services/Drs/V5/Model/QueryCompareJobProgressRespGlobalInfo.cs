using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 全局对比信息。
    /// </summary>
    public class QueryCompareJobProgressRespGlobalInfo 
    {

        /// <summary>
        /// 全局对比速率。
        /// </summary>
        [JsonProperty("src_speed", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcSpeed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryCompareJobProgressRespGlobalInfo {\n");
            sb.Append("  srcSpeed: ").Append(SrcSpeed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryCompareJobProgressRespGlobalInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryCompareJobProgressRespGlobalInfo input)
        {
            if (input == null) return false;
            if (this.SrcSpeed != input.SrcSpeed || (this.SrcSpeed != null && !this.SrcSpeed.Equals(input.SrcSpeed))) return false;

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
                if (this.SrcSpeed != null) hashCode = hashCode * 59 + this.SrcSpeed.GetHashCode();
                return hashCode;
            }
        }
    }
}
