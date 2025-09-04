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
    /// 服务器网络信息。
    /// </summary>
    public class EcsNetWork 
    {

        /// <summary>
        /// IP地址信息
        /// </summary>
        [JsonProperty("addr", NullValueHandling = NullValueHandling.Ignore)]
        public string Addr { get; set; }

        /// <summary>
        /// IP地址类型： &#x60;4&#x60; - IPV4 &#x60;6&#x60; - IPV6
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public int? Version { get; set; }

        /// <summary>
        /// MAC地址。
        /// </summary>
        [JsonProperty("OS-EXT-IPS-MAC:mac_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTIPSMACmacAddr { get; set; }

        /// <summary>
        /// IP地址分配方式，字符串是大小写不敏感格式。 * &#x60;fixed&#x60; - 代表私有IP地址。 * &#x60;floating&#x60; - 代表浮动IP地址。
        /// </summary>
        [JsonProperty("OS-EXT-IPS:type", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTIPStype { get; set; }

        /// <summary>
        /// IP地址对应的端口ID。
        /// </summary>
        [JsonProperty("OS-EXT-IPS:port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTIPSportId { get; set; }

        /// <summary>
        /// 虚拟私有云ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 子网id。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 租户类别: - tenant: 租户 - resource_tenant: 资源租户
        /// </summary>
        [JsonProperty("tenant_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EcsNetWork {\n");
            sb.Append("  addr: ").Append(Addr).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  oSEXTIPSMACmacAddr: ").Append(OSEXTIPSMACmacAddr).Append("\n");
            sb.Append("  oSEXTIPStype: ").Append(OSEXTIPStype).Append("\n");
            sb.Append("  oSEXTIPSportId: ").Append(OSEXTIPSportId).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  tenantType: ").Append(TenantType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EcsNetWork);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EcsNetWork input)
        {
            if (input == null) return false;
            if (this.Addr != input.Addr || (this.Addr != null && !this.Addr.Equals(input.Addr))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.OSEXTIPSMACmacAddr != input.OSEXTIPSMACmacAddr || (this.OSEXTIPSMACmacAddr != null && !this.OSEXTIPSMACmacAddr.Equals(input.OSEXTIPSMACmacAddr))) return false;
            if (this.OSEXTIPStype != input.OSEXTIPStype || (this.OSEXTIPStype != null && !this.OSEXTIPStype.Equals(input.OSEXTIPStype))) return false;
            if (this.OSEXTIPSportId != input.OSEXTIPSportId || (this.OSEXTIPSportId != null && !this.OSEXTIPSportId.Equals(input.OSEXTIPSportId))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.TenantType != input.TenantType || (this.TenantType != null && !this.TenantType.Equals(input.TenantType))) return false;

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
                if (this.Addr != null) hashCode = hashCode * 59 + this.Addr.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.OSEXTIPSMACmacAddr != null) hashCode = hashCode * 59 + this.OSEXTIPSMACmacAddr.GetHashCode();
                if (this.OSEXTIPStype != null) hashCode = hashCode * 59 + this.OSEXTIPStype.GetHashCode();
                if (this.OSEXTIPSportId != null) hashCode = hashCode * 59 + this.OSEXTIPSportId.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.TenantType != null) hashCode = hashCode * 59 + this.TenantType.GetHashCode();
                return hashCode;
            }
        }
    }
}
