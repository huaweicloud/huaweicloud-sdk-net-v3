using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 创建中心网络ER附件的请求体。
    /// </summary>
    public class CreateCentralNetworkErRouteTableAttachment 
    {
        /// <summary>
        /// - HWCloud (华为云) - Ireland (爱尔兰)
        /// </summary>
        /// <value>- HWCloud (华为云) - Ireland (爱尔兰)</value>
        [JsonConverter(typeof(EnumClassConverter<HostedCloudEnum>))]
        public class HostedCloudEnum
        {
            /// <summary>
            /// Enum HWCLOUD for value: HWCloud
            /// </summary>
            public static readonly HostedCloudEnum HWCLOUD = new HostedCloudEnum("HWCloud");

            /// <summary>
            /// Enum IRELAND for value: Ireland
            /// </summary>
            public static readonly HostedCloudEnum IRELAND = new HostedCloudEnum("Ireland");

            private static readonly Dictionary<string, HostedCloudEnum> StaticFields =
            new Dictionary<string, HostedCloudEnum>()
            {
                { "HWCloud", HWCLOUD },
                { "Ireland", IRELAND },
            };

            private string _value;

            public HostedCloudEnum()
            {

            }

            public HostedCloudEnum(string value)
            {
                _value = value;
            }

            public static HostedCloudEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as HostedCloudEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HostedCloudEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(HostedCloudEnum a, HostedCloudEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(HostedCloudEnum a, HostedCloudEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 实例描述。不支持 &lt;&gt;。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 企业路由器的ID。
        /// </summary>
        [JsonProperty("enterprise_router_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseRouterId { get; set; }

        /// <summary>
        /// 企业路由器的项目ID。
        /// </summary>
        [JsonProperty("enterprise_router_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseRouterProjectId { get; set; }

        /// <summary>
        /// ER路由器的regionID。
        /// </summary>
        [JsonProperty("enterprise_router_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseRouterRegionId { get; set; }

        /// <summary>
        /// 中心网络平面ID。
        /// </summary>
        [JsonProperty("central_network_plane_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CentralNetworkPlaneId { get; set; }

        /// <summary>
        /// 中心网络附件对端实例的连接ID，企业路由器的连接ID或者GDGW的连接ID。
        /// </summary>
        [JsonProperty("attachment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachmentId { get; set; }

        /// <summary>
        /// 企业路由器的路由表ID。
        /// </summary>
        [JsonProperty("enterprise_router_table_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseRouterTableId { get; set; }

        /// <summary>
        /// 被挂载的企业路由器的项目ID。
        /// </summary>
        [JsonProperty("attached_er_table_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachedErTableProjectId { get; set; }

        /// <summary>
        /// ER路由器的regionID。
        /// </summary>
        [JsonProperty("attached_er_table_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachedErTableRegionId { get; set; }

        /// <summary>
        /// 被挂载的企业路由器ID。
        /// </summary>
        [JsonProperty("attached_er_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachedErId { get; set; }

        /// <summary>
        /// 被挂载的企业路由器的路由表ID。
        /// </summary>
        [JsonProperty("attached_er_table_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachedErTableId { get; set; }

        /// <summary>
        /// - HWCloud (华为云) - Ireland (爱尔兰)
        /// </summary>
        [JsonProperty("hosted_cloud", NullValueHandling = NullValueHandling.Ignore)]
        public HostedCloudEnum HostedCloud { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCentralNetworkErRouteTableAttachment {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  enterpriseRouterId: ").Append(EnterpriseRouterId).Append("\n");
            sb.Append("  enterpriseRouterProjectId: ").Append(EnterpriseRouterProjectId).Append("\n");
            sb.Append("  enterpriseRouterRegionId: ").Append(EnterpriseRouterRegionId).Append("\n");
            sb.Append("  centralNetworkPlaneId: ").Append(CentralNetworkPlaneId).Append("\n");
            sb.Append("  attachmentId: ").Append(AttachmentId).Append("\n");
            sb.Append("  enterpriseRouterTableId: ").Append(EnterpriseRouterTableId).Append("\n");
            sb.Append("  attachedErTableProjectId: ").Append(AttachedErTableProjectId).Append("\n");
            sb.Append("  attachedErTableRegionId: ").Append(AttachedErTableRegionId).Append("\n");
            sb.Append("  attachedErId: ").Append(AttachedErId).Append("\n");
            sb.Append("  attachedErTableId: ").Append(AttachedErTableId).Append("\n");
            sb.Append("  hostedCloud: ").Append(HostedCloud).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateCentralNetworkErRouteTableAttachment);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateCentralNetworkErRouteTableAttachment input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.EnterpriseRouterId != input.EnterpriseRouterId || (this.EnterpriseRouterId != null && !this.EnterpriseRouterId.Equals(input.EnterpriseRouterId))) return false;
            if (this.EnterpriseRouterProjectId != input.EnterpriseRouterProjectId || (this.EnterpriseRouterProjectId != null && !this.EnterpriseRouterProjectId.Equals(input.EnterpriseRouterProjectId))) return false;
            if (this.EnterpriseRouterRegionId != input.EnterpriseRouterRegionId || (this.EnterpriseRouterRegionId != null && !this.EnterpriseRouterRegionId.Equals(input.EnterpriseRouterRegionId))) return false;
            if (this.CentralNetworkPlaneId != input.CentralNetworkPlaneId || (this.CentralNetworkPlaneId != null && !this.CentralNetworkPlaneId.Equals(input.CentralNetworkPlaneId))) return false;
            if (this.AttachmentId != input.AttachmentId || (this.AttachmentId != null && !this.AttachmentId.Equals(input.AttachmentId))) return false;
            if (this.EnterpriseRouterTableId != input.EnterpriseRouterTableId || (this.EnterpriseRouterTableId != null && !this.EnterpriseRouterTableId.Equals(input.EnterpriseRouterTableId))) return false;
            if (this.AttachedErTableProjectId != input.AttachedErTableProjectId || (this.AttachedErTableProjectId != null && !this.AttachedErTableProjectId.Equals(input.AttachedErTableProjectId))) return false;
            if (this.AttachedErTableRegionId != input.AttachedErTableRegionId || (this.AttachedErTableRegionId != null && !this.AttachedErTableRegionId.Equals(input.AttachedErTableRegionId))) return false;
            if (this.AttachedErId != input.AttachedErId || (this.AttachedErId != null && !this.AttachedErId.Equals(input.AttachedErId))) return false;
            if (this.AttachedErTableId != input.AttachedErTableId || (this.AttachedErTableId != null && !this.AttachedErTableId.Equals(input.AttachedErTableId))) return false;
            if (this.HostedCloud != input.HostedCloud) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EnterpriseRouterId != null) hashCode = hashCode * 59 + this.EnterpriseRouterId.GetHashCode();
                if (this.EnterpriseRouterProjectId != null) hashCode = hashCode * 59 + this.EnterpriseRouterProjectId.GetHashCode();
                if (this.EnterpriseRouterRegionId != null) hashCode = hashCode * 59 + this.EnterpriseRouterRegionId.GetHashCode();
                if (this.CentralNetworkPlaneId != null) hashCode = hashCode * 59 + this.CentralNetworkPlaneId.GetHashCode();
                if (this.AttachmentId != null) hashCode = hashCode * 59 + this.AttachmentId.GetHashCode();
                if (this.EnterpriseRouterTableId != null) hashCode = hashCode * 59 + this.EnterpriseRouterTableId.GetHashCode();
                if (this.AttachedErTableProjectId != null) hashCode = hashCode * 59 + this.AttachedErTableProjectId.GetHashCode();
                if (this.AttachedErTableRegionId != null) hashCode = hashCode * 59 + this.AttachedErTableRegionId.GetHashCode();
                if (this.AttachedErId != null) hashCode = hashCode * 59 + this.AttachedErId.GetHashCode();
                if (this.AttachedErTableId != null) hashCode = hashCode * 59 + this.AttachedErTableId.GetHashCode();
                hashCode = hashCode * 59 + this.HostedCloud.GetHashCode();
                return hashCode;
            }
        }
    }
}
