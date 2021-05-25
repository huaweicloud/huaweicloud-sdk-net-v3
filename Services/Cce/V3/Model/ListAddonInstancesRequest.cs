using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListAddonInstancesRequest 
    {

        /// <summary>
        /// 含义：想要筛选的插件名称  属性：隐藏参数
        /// </summary>
        [SDKProperty("addon_template_name", IsQuery = true)]
        [JsonProperty("addon_template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AddonTemplateName { get; set; }

        /// <summary>
        /// 集群 ID，获取方式请参见[[如何获取接口URI中参数](https://support.huaweicloud.com/api-cce/cce_02_0271.html)](tag:hws)[[如何获取接口URI中参数](https://support.huaweicloud.com/intl/zh-cn/api-cce/cce_02_0271.html)](tag:hws_hk)
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
            sb.Append("class ListAddonInstancesRequest {\n");
            sb.Append("  addonTemplateName: ").Append(AddonTemplateName).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.AddonTemplateName == input.AddonTemplateName ||
                    (this.AddonTemplateName != null &&
                    this.AddonTemplateName.Equals(input.AddonTemplateName))
                ) && 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AddonTemplateName != null)
                    hashCode = hashCode * 59 + this.AddonTemplateName.GetHashCode();
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                return hashCode;
            }
        }
    }
}
