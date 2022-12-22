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
    /// 节点网络参数，包含了Node节点默认安群组设置
    /// </summary>
    public class ClusterInformationSpecHostNetwork 
    {

        /// <summary>
        /// 集群默认Node节点安全组需要放通部分端口来保证正常通信，[详细设置请参考[集群安全组规则配置](https://support.huaweicloud.com/cce_faq/cce_faq_00265.html)。](tag:hws)[详细设置请参考[集群安全组规则配置](https://support.huaweicloud.com/intl/zh-cn/cce_faq/cce_faq_00265.html)。](tag:hws_hk) 修改后的安全组只作用于新创建的节点和新纳管的节点，存量节点的安全组需手动修改。 
        /// </summary>
        [JsonProperty("SecurityGroup", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroup { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterInformationSpecHostNetwork {\n");
            sb.Append("  securityGroup: ").Append(SecurityGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterInformationSpecHostNetwork);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterInformationSpecHostNetwork input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SecurityGroup == input.SecurityGroup ||
                    (this.SecurityGroup != null &&
                    this.SecurityGroup.Equals(input.SecurityGroup))
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
                if (this.SecurityGroup != null)
                    hashCode = hashCode * 59 + this.SecurityGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
