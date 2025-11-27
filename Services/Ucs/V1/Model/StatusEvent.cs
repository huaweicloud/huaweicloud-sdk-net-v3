using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class StatusEvent 
    {

        /// <summary>
        /// 拦截事件首次发生时间
        /// </summary>
        [JsonProperty("firstTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstTimestamp { get; set; }

        /// <summary>
        /// 拦截事件资源类型
        /// </summary>
        [JsonProperty("resourceKind", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceKind { get; set; }

        /// <summary>
        /// 拦截事件资源名称
        /// </summary>
        [JsonProperty("resourceName", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 拦截事件资源命名空间，如果没有则为空
        /// </summary>
        [JsonProperty("resourceNamespace", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceNamespace { get; set; }

        /// <summary>
        /// 拦截事件详细信息
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusEvent {\n");
            sb.Append("  firstTimestamp: ").Append(FirstTimestamp).Append("\n");
            sb.Append("  resourceKind: ").Append(ResourceKind).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  resourceNamespace: ").Append(ResourceNamespace).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StatusEvent);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StatusEvent input)
        {
            if (input == null) return false;
            if (this.FirstTimestamp != input.FirstTimestamp || (this.FirstTimestamp != null && !this.FirstTimestamp.Equals(input.FirstTimestamp))) return false;
            if (this.ResourceKind != input.ResourceKind || (this.ResourceKind != null && !this.ResourceKind.Equals(input.ResourceKind))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.ResourceNamespace != input.ResourceNamespace || (this.ResourceNamespace != null && !this.ResourceNamespace.Equals(input.ResourceNamespace))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;

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
                if (this.FirstTimestamp != null) hashCode = hashCode * 59 + this.FirstTimestamp.GetHashCode();
                if (this.ResourceKind != null) hashCode = hashCode * 59 + this.ResourceKind.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.ResourceNamespace != null) hashCode = hashCode * 59 + this.ResourceNamespace.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }
}
