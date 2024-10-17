using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// 通知主题对象。
    /// </summary>
    public class Notification 
    {

        /// <summary>
        /// 事件通知的对象类型。
        /// </summary>
        [JsonProperty("target_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetType { get; set; }

        /// <summary>
        /// 事件通知的对象ID。
        /// </summary>
        [JsonProperty("target_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetId { get; set; }

        /// <summary>
        /// 事件通知的对象名称。
        /// </summary>
        [JsonProperty("target_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Notification {\n");
            sb.Append("  targetType: ").Append(TargetType).Append("\n");
            sb.Append("  targetId: ").Append(TargetId).Append("\n");
            sb.Append("  targetName: ").Append(TargetName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Notification);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Notification input)
        {
            if (input == null) return false;
            if (this.TargetType != input.TargetType || (this.TargetType != null && !this.TargetType.Equals(input.TargetType))) return false;
            if (this.TargetId != input.TargetId || (this.TargetId != null && !this.TargetId.Equals(input.TargetId))) return false;
            if (this.TargetName != input.TargetName || (this.TargetName != null && !this.TargetName.Equals(input.TargetName))) return false;

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
                if (this.TargetType != null) hashCode = hashCode * 59 + this.TargetType.GetHashCode();
                if (this.TargetId != null) hashCode = hashCode * 59 + this.TargetId.GetHashCode();
                if (this.TargetName != null) hashCode = hashCode * 59 + this.TargetName.GetHashCode();
                return hashCode;
            }
        }
    }
}
