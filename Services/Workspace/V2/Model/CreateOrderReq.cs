using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 包周期订单请求体。
    /// </summary>
    public class CreateOrderReq 
    {

        /// <summary>
        /// 订单类型，createDesktops：创建桌面，addVolumes：添加磁盘，rebuildDesktops：重建系统盘，createDesktopPool 创建桌面池，expandDesktopPool 扩容桌面池，applyDesktopsInternet：开通桌面EIP上网，createExclusiveHosts：创建专享主机，subscribeUserSharer：订购用户协同资源，ApplySubnetBandwidth：开通云办公带宽。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 企业项目ID，默认\&quot;0。\&quot;
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 包周期资源。
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<Resource> Resources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extend_param", NullValueHandling = NullValueHandling.Ignore)]
        public OrderExtendParam ExtendParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOrderReq {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateOrderReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateOrderReq input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Resources != input.Resources || (this.Resources != null && input.Resources != null && !this.Resources.SequenceEqual(input.Resources))) return false;
            if (this.ExtendParam != input.ExtendParam || (this.ExtendParam != null && !this.ExtendParam.Equals(input.ExtendParam))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.ExtendParam != null) hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
