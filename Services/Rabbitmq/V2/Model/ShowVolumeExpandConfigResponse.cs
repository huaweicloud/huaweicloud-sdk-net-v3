using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rabbitmq.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowVolumeExpandConfigResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 是否开启磁盘自动扩容。 **取值范围**： - true：开启。 - false：关闭。
        /// </summary>
        [JsonProperty("auto_volume_expand_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoVolumeExpandEnable { get; set; }

        /// <summary>
        /// **参数解释**： 触发磁盘自动扩容的阈值。 **取值范围**： 20%-80%。
        /// </summary>
        [JsonProperty("expand_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpandThreshold { get; set; }

        /// <summary>
        /// **参数解释**： 磁盘自动扩容的上限值。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("max_volume_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxVolumeSize { get; set; }

        /// <summary>
        /// **参数解释**： 每次磁盘自动扩容的比例。 **取值范围**： 10%-100%。
        /// </summary>
        [JsonProperty("expand_increment", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpandIncrement { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowVolumeExpandConfigResponse {\n");
            sb.Append("  autoVolumeExpandEnable: ").Append(AutoVolumeExpandEnable).Append("\n");
            sb.Append("  expandThreshold: ").Append(ExpandThreshold).Append("\n");
            sb.Append("  maxVolumeSize: ").Append(MaxVolumeSize).Append("\n");
            sb.Append("  expandIncrement: ").Append(ExpandIncrement).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowVolumeExpandConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowVolumeExpandConfigResponse input)
        {
            if (input == null) return false;
            if (this.AutoVolumeExpandEnable != input.AutoVolumeExpandEnable || (this.AutoVolumeExpandEnable != null && !this.AutoVolumeExpandEnable.Equals(input.AutoVolumeExpandEnable))) return false;
            if (this.ExpandThreshold != input.ExpandThreshold || (this.ExpandThreshold != null && !this.ExpandThreshold.Equals(input.ExpandThreshold))) return false;
            if (this.MaxVolumeSize != input.MaxVolumeSize || (this.MaxVolumeSize != null && !this.MaxVolumeSize.Equals(input.MaxVolumeSize))) return false;
            if (this.ExpandIncrement != input.ExpandIncrement || (this.ExpandIncrement != null && !this.ExpandIncrement.Equals(input.ExpandIncrement))) return false;

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
                if (this.AutoVolumeExpandEnable != null) hashCode = hashCode * 59 + this.AutoVolumeExpandEnable.GetHashCode();
                if (this.ExpandThreshold != null) hashCode = hashCode * 59 + this.ExpandThreshold.GetHashCode();
                if (this.MaxVolumeSize != null) hashCode = hashCode * 59 + this.MaxVolumeSize.GetHashCode();
                if (this.ExpandIncrement != null) hashCode = hashCode * 59 + this.ExpandIncrement.GetHashCode();
                return hashCode;
            }
        }
    }
}
