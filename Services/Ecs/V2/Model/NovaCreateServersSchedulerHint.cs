using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    ///  弹性云服务器调度信息。  裸金属服务器场景不支持。
    /// </summary>
    public class NovaCreateServersSchedulerHint 
    {

        /// <summary>
        /// 反亲和性组信息。  UUID格式。
        /// </summary>
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public string Group { get; set; }

        /// <summary>
        /// 与指定弹性云服务器满足反亲和性。   当前不支持该功能。
        /// </summary>
        [JsonProperty("different_host", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DifferentHost { get; set; }

        /// <summary>
        /// 与指定的弹性云服务器满足亲和性。   当前不支持该功能。
        /// </summary>
        [JsonProperty("same_host", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SameHost { get; set; }

        /// <summary>
        /// 将弹性云服务器scheduler到指定网段的host上，host网段的cidr。   当前不支持该功能。
        /// </summary>
        [JsonProperty("cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string Cidr { get; set; }

        /// <summary>
        /// 将弹性云服务器scheduler到指定网段的host上，host IP地址。   当前不支持该功能。
        /// </summary>
        [JsonProperty("build_near_host_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildNearHostIp { get; set; }

        /// <summary>
        /// 在专属主机或共享池中创建弹性云服务器。默认为在共享池创建。 值为： shared 或dedicated。 shared：表示共享池。 dedicated:表示专属主机。 创建与查询此值均有效。
        /// </summary>
        [JsonProperty("tenancy", NullValueHandling = NullValueHandling.Ignore)]
        public string Tenancy { get; set; }

        /// <summary>
        /// 专属主机ID。 此属性仅在tenancy值为dedicated时有效。 不指定此属性，系统将自动分配租户可自动放置弹性云服务器的专属主机。 创建与查询此值均有效。
        /// </summary>
        [JsonProperty("dedicated_host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedHostId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaCreateServersSchedulerHint {\n");
            sb.Append("  group: ").Append(Group).Append("\n");
            sb.Append("  differentHost: ").Append(DifferentHost).Append("\n");
            sb.Append("  sameHost: ").Append(SameHost).Append("\n");
            sb.Append("  cidr: ").Append(Cidr).Append("\n");
            sb.Append("  buildNearHostIp: ").Append(BuildNearHostIp).Append("\n");
            sb.Append("  tenancy: ").Append(Tenancy).Append("\n");
            sb.Append("  dedicatedHostId: ").Append(DedicatedHostId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaCreateServersSchedulerHint);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaCreateServersSchedulerHint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.DifferentHost == input.DifferentHost ||
                    this.DifferentHost != null &&
                    input.DifferentHost != null &&
                    this.DifferentHost.SequenceEqual(input.DifferentHost)
                ) && 
                (
                    this.SameHost == input.SameHost ||
                    this.SameHost != null &&
                    input.SameHost != null &&
                    this.SameHost.SequenceEqual(input.SameHost)
                ) && 
                (
                    this.Cidr == input.Cidr ||
                    (this.Cidr != null &&
                    this.Cidr.Equals(input.Cidr))
                ) && 
                (
                    this.BuildNearHostIp == input.BuildNearHostIp ||
                    (this.BuildNearHostIp != null &&
                    this.BuildNearHostIp.Equals(input.BuildNearHostIp))
                ) && 
                (
                    this.Tenancy == input.Tenancy ||
                    (this.Tenancy != null &&
                    this.Tenancy.Equals(input.Tenancy))
                ) && 
                (
                    this.DedicatedHostId == input.DedicatedHostId ||
                    (this.DedicatedHostId != null &&
                    this.DedicatedHostId.Equals(input.DedicatedHostId))
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
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.DifferentHost != null)
                    hashCode = hashCode * 59 + this.DifferentHost.GetHashCode();
                if (this.SameHost != null)
                    hashCode = hashCode * 59 + this.SameHost.GetHashCode();
                if (this.Cidr != null)
                    hashCode = hashCode * 59 + this.Cidr.GetHashCode();
                if (this.BuildNearHostIp != null)
                    hashCode = hashCode * 59 + this.BuildNearHostIp.GetHashCode();
                if (this.Tenancy != null)
                    hashCode = hashCode * 59 + this.Tenancy.GetHashCode();
                if (this.DedicatedHostId != null)
                    hashCode = hashCode * 59 + this.DedicatedHostId.GetHashCode();
                return hashCode;
            }
        }
    }
}
