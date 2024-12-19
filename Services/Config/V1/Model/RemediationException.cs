using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 合规规则修正例外。
    /// </summary>
    public class RemediationException 
    {

        /// <summary>
        /// 资源ID。
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 加入合规规则修正例外的原因。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 加入合规规则修正例外的时间。
        /// </summary>
        [JsonProperty("joined_at", NullValueHandling = NullValueHandling.Ignore)]
        public string JoinedAt { get; set; }

        /// <summary>
        /// 合规规则修正例外的创建者。
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemediationException {\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  joinedAt: ").Append(JoinedAt).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RemediationException);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RemediationException input)
        {
            if (input == null) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.JoinedAt != input.JoinedAt || (this.JoinedAt != null && !this.JoinedAt.Equals(input.JoinedAt))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;

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
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.JoinedAt != null) hashCode = hashCode * 59 + this.JoinedAt.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                return hashCode;
            }
        }
    }
}
