using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CapacitySettingVO 
    {

        /// <summary>
        /// **参数解释**: 容量阈值。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("capacity_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? CapacityThreshold { get; set; }

        /// <summary>
        /// **参数解释**: 消息类型。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("message_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? MessageType { get; set; }

        /// <summary>
        /// **参数解释**: 是否启用邮件。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("is_mail_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsMailEnabled { get; set; }

        /// <summary>
        /// **参数解释**: 是否启用短信。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("is_sms_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsSmsEnabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CapacitySettingVO {\n");
            sb.Append("  capacityThreshold: ").Append(CapacityThreshold).Append("\n");
            sb.Append("  messageType: ").Append(MessageType).Append("\n");
            sb.Append("  isMailEnabled: ").Append(IsMailEnabled).Append("\n");
            sb.Append("  isSmsEnabled: ").Append(IsSmsEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CapacitySettingVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CapacitySettingVO input)
        {
            if (input == null) return false;
            if (this.CapacityThreshold != input.CapacityThreshold || (this.CapacityThreshold != null && !this.CapacityThreshold.Equals(input.CapacityThreshold))) return false;
            if (this.MessageType != input.MessageType || (this.MessageType != null && !this.MessageType.Equals(input.MessageType))) return false;
            if (this.IsMailEnabled != input.IsMailEnabled || (this.IsMailEnabled != null && !this.IsMailEnabled.Equals(input.IsMailEnabled))) return false;
            if (this.IsSmsEnabled != input.IsSmsEnabled || (this.IsSmsEnabled != null && !this.IsSmsEnabled.Equals(input.IsSmsEnabled))) return false;

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
                if (this.CapacityThreshold != null) hashCode = hashCode * 59 + this.CapacityThreshold.GetHashCode();
                if (this.MessageType != null) hashCode = hashCode * 59 + this.MessageType.GetHashCode();
                if (this.IsMailEnabled != null) hashCode = hashCode * 59 + this.IsMailEnabled.GetHashCode();
                if (this.IsSmsEnabled != null) hashCode = hashCode * 59 + this.IsSmsEnabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
