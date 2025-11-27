using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAccessControlTaskResponse : SdkResponse
    {

        /// <summary>
        /// 查询结果总数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 封禁或解禁URL任务信息。
        /// </summary>
        [JsonProperty("access_control_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessControlTask> AccessControlTasks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAccessControlTaskResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  accessControlTasks: ").Append(AccessControlTasks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAccessControlTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAccessControlTaskResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.AccessControlTasks != input.AccessControlTasks || (this.AccessControlTasks != null && input.AccessControlTasks != null && !this.AccessControlTasks.SequenceEqual(input.AccessControlTasks))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.AccessControlTasks != null) hashCode = hashCode * 59 + this.AccessControlTasks.GetHashCode();
                return hashCode;
            }
        }
    }
}
