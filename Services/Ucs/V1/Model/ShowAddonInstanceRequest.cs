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
    /// Request Object
    /// </summary>
    public class ShowAddonInstanceRequest 
    {

        /// <summary>
        /// 插件示例id
        /// </summary>
        [SDKProperty("id", IsPath = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 是否使用数据库存储的插件状态
        /// </summary>
        [SDKProperty("is_database_status", IsQuery = true)]
        [JsonProperty("is_database_status", NullValueHandling = NullValueHandling.Ignore)]
        public string IsDatabaseStatus { get; set; }

        /// <summary>
        /// 集群id
        /// </summary>
        [SDKProperty("cluster_id", IsQuery = true)]
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAddonInstanceRequest {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  isDatabaseStatus: ").Append(IsDatabaseStatus).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAddonInstanceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAddonInstanceRequest input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IsDatabaseStatus != input.IsDatabaseStatus || (this.IsDatabaseStatus != null && !this.IsDatabaseStatus.Equals(input.IsDatabaseStatus))) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsDatabaseStatus != null) hashCode = hashCode * 59 + this.IsDatabaseStatus.GetHashCode();
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                return hashCode;
            }
        }
    }
}
