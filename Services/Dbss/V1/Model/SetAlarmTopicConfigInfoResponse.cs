using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class SetAlarmTopicConfigInfoResponse : SdkResponse
    {

        /// <summary>
        /// 主题使用状态  - true: 已被使用  - false: 未被使用
        /// </summary>
        [JsonProperty("is_use_topic", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUseTopic { get; set; }

        /// <summary>
        /// 状态  - SUCCESS: 成功  - FAILED: 失败
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetAlarmTopicConfigInfoResponse {\n");
            sb.Append("  isUseTopic: ").Append(IsUseTopic).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetAlarmTopicConfigInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetAlarmTopicConfigInfoResponse input)
        {
            if (input == null) return false;
            if (this.IsUseTopic != input.IsUseTopic || (this.IsUseTopic != null && !this.IsUseTopic.Equals(input.IsUseTopic))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.IsUseTopic != null) hashCode = hashCode * 59 + this.IsUseTopic.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
