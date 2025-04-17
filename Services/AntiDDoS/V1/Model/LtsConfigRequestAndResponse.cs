using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.AntiDDoS.V1.Model
{
    /// <summary>
    /// 日志配置请求
    /// </summary>
    public class LtsConfigRequestAndResponse 
    {

        /// <summary>
        /// 是否开启日志
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lts_id_info", NullValueHandling = NullValueHandling.Ignore)]
        public LtsConfigRequestAndResponseLtsIdInfo LtsIdInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LtsConfigRequestAndResponse {\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  ltsIdInfo: ").Append(LtsIdInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LtsConfigRequestAndResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LtsConfigRequestAndResponse input)
        {
            if (input == null) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.LtsIdInfo != input.LtsIdInfo || (this.LtsIdInfo != null && !this.LtsIdInfo.Equals(input.LtsIdInfo))) return false;

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
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.LtsIdInfo != null) hashCode = hashCode * 59 + this.LtsIdInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
