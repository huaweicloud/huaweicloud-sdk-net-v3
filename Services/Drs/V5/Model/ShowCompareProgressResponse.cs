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
    /// Response Object
    /// </summary>
    public class ShowCompareProgressResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("full_info", NullValueHandling = NullValueHandling.Ignore)]
        public QueryCompareJobProgressRespFullInfo FullInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("incre_info", NullValueHandling = NullValueHandling.Ignore)]
        public QueryCompareJobProgressRespIncreInfo IncreInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("global_info", NullValueHandling = NullValueHandling.Ignore)]
        public QueryCompareJobProgressRespGlobalInfo GlobalInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCompareProgressResponse {\n");
            sb.Append("  fullInfo: ").Append(FullInfo).Append("\n");
            sb.Append("  increInfo: ").Append(IncreInfo).Append("\n");
            sb.Append("  globalInfo: ").Append(GlobalInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCompareProgressResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCompareProgressResponse input)
        {
            if (input == null) return false;
            if (this.FullInfo != input.FullInfo || (this.FullInfo != null && !this.FullInfo.Equals(input.FullInfo))) return false;
            if (this.IncreInfo != input.IncreInfo || (this.IncreInfo != null && !this.IncreInfo.Equals(input.IncreInfo))) return false;
            if (this.GlobalInfo != input.GlobalInfo || (this.GlobalInfo != null && !this.GlobalInfo.Equals(input.GlobalInfo))) return false;

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
                if (this.FullInfo != null) hashCode = hashCode * 59 + this.FullInfo.GetHashCode();
                if (this.IncreInfo != null) hashCode = hashCode * 59 + this.IncreInfo.GetHashCode();
                if (this.GlobalInfo != null) hashCode = hashCode * 59 + this.GlobalInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
