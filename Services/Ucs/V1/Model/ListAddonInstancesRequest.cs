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
    public class ListAddonInstancesRequest 
    {

        /// <summary>
        /// 集群id
        /// </summary>
        [SDKProperty("cluster_id", IsQuery = true)]
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 是否使用数据库存储的插件状态
        /// </summary>
        [SDKProperty("addon_template_name", IsQuery = true)]
        [JsonProperty("addon_template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AddonTemplateName { get; set; }

        /// <summary>
        /// 插件包名字
        /// </summary>
        [SDKProperty("is_database_status", IsQuery = true)]
        [JsonProperty("is_database_status", NullValueHandling = NullValueHandling.Ignore)]
        public string IsDatabaseStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAddonInstancesRequest {\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  addonTemplateName: ").Append(AddonTemplateName).Append("\n");
            sb.Append("  isDatabaseStatus: ").Append(IsDatabaseStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAddonInstancesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAddonInstancesRequest input)
        {
            if (input == null) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.AddonTemplateName != input.AddonTemplateName || (this.AddonTemplateName != null && !this.AddonTemplateName.Equals(input.AddonTemplateName))) return false;
            if (this.IsDatabaseStatus != input.IsDatabaseStatus || (this.IsDatabaseStatus != null && !this.IsDatabaseStatus.Equals(input.IsDatabaseStatus))) return false;

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
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.AddonTemplateName != null) hashCode = hashCode * 59 + this.AddonTemplateName.GetHashCode();
                if (this.IsDatabaseStatus != null) hashCode = hashCode * 59 + this.IsDatabaseStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
