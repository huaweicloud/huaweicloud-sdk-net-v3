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
    /// 日志信息
    /// </summary>
    public class LtsConfigRequestAndResponseLtsIdInfo 
    {

        /// <summary>
        /// 日志组id
        /// </summary>
        [JsonProperty("lts_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsGroupId { get; set; }

        /// <summary>
        /// 日志流id
        /// </summary>
        [JsonProperty("lts_attack_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsAttackStreamId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LtsConfigRequestAndResponseLtsIdInfo {\n");
            sb.Append("  ltsGroupId: ").Append(LtsGroupId).Append("\n");
            sb.Append("  ltsAttackStreamId: ").Append(LtsAttackStreamId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LtsConfigRequestAndResponseLtsIdInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LtsConfigRequestAndResponseLtsIdInfo input)
        {
            if (input == null) return false;
            if (this.LtsGroupId != input.LtsGroupId || (this.LtsGroupId != null && !this.LtsGroupId.Equals(input.LtsGroupId))) return false;
            if (this.LtsAttackStreamId != input.LtsAttackStreamId || (this.LtsAttackStreamId != null && !this.LtsAttackStreamId.Equals(input.LtsAttackStreamId))) return false;

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
                if (this.LtsGroupId != null) hashCode = hashCode * 59 + this.LtsGroupId.GetHashCode();
                if (this.LtsAttackStreamId != null) hashCode = hashCode * 59 + this.LtsAttackStreamId.GetHashCode();
                return hashCode;
            }
        }
    }
}
