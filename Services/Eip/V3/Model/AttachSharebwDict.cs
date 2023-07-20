using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// 共享带宽加入弹性公网IP参数
    /// </summary>
    public class AttachSharebwDict 
    {

        /// <summary>
        /// - 带宽id
        /// </summary>
        [JsonProperty("bandwidth_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BandwidthId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachSharebwDict {\n");
            sb.Append("  bandwidthId: ").Append(BandwidthId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachSharebwDict);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachSharebwDict input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BandwidthId == input.BandwidthId ||
                    (this.BandwidthId != null &&
                    this.BandwidthId.Equals(input.BandwidthId))
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
                if (this.BandwidthId != null)
                    hashCode = hashCode * 59 + this.BandwidthId.GetHashCode();
                return hashCode;
            }
        }
    }
}
