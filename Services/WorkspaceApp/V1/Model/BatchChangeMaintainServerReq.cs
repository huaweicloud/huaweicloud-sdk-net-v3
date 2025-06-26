using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 标记指定的服务器维护状态请求。
    /// </summary>
    public class BatchChangeMaintainServerReq 
    {

        /// <summary>
        /// 批量请求的服务器ID列表，一次请求数量区间 [1, 20]。
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Items { get; set; }

        /// <summary>
        /// 服务器维护状态标识： * &#x60;true&#x60; - 添加标记 * &#x60;false&#x60; - 移除标记
        /// </summary>
        [JsonProperty("maintain_status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MaintainStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchChangeMaintainServerReq {\n");
            sb.Append("  items: ").Append(Items).Append("\n");
            sb.Append("  maintainStatus: ").Append(MaintainStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchChangeMaintainServerReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchChangeMaintainServerReq input)
        {
            if (input == null) return false;
            if (this.Items != input.Items || (this.Items != null && input.Items != null && !this.Items.SequenceEqual(input.Items))) return false;
            if (this.MaintainStatus != input.MaintainStatus || (this.MaintainStatus != null && !this.MaintainStatus.Equals(input.MaintainStatus))) return false;

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
                if (this.Items != null) hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.MaintainStatus != null) hashCode = hashCode * 59 + this.MaintainStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
