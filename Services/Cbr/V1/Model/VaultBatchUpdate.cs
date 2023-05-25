using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 存储库批量修改属性
    /// </summary>
    public class VaultBatchUpdate 
    {

        /// <summary>
        /// 存储库smn消息通知开关
        /// </summary>
        [JsonProperty("smn_notify", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SmnNotify { get; set; }

        /// <summary>
        /// 存储库容量阈值
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? Threshold { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VaultBatchUpdate {\n");
            sb.Append("  smnNotify: ").Append(SmnNotify).Append("\n");
            sb.Append("  threshold: ").Append(Threshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VaultBatchUpdate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VaultBatchUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SmnNotify == input.SmnNotify ||
                    (this.SmnNotify != null &&
                    this.SmnNotify.Equals(input.SmnNotify))
                ) && 
                (
                    this.Threshold == input.Threshold ||
                    (this.Threshold != null &&
                    this.Threshold.Equals(input.Threshold))
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
                if (this.SmnNotify != null)
                    hashCode = hashCode * 59 + this.SmnNotify.GetHashCode();
                if (this.Threshold != null)
                    hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
