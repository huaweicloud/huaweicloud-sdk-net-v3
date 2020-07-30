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
    /// 云服务器详情。
    /// </summary>
    public class UpdateServerResult 
    {

        /// <summary>
        /// 项目ID。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 镜像ID。
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// 预留属性。
        /// </summary>
        [JsonProperty("accessIPv4", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessIPv4 { get; set; }

        /// <summary>
        /// 预留属性。
        /// </summary>
        [JsonProperty("accessIPv6", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessIPv6 { get; set; }

        /// <summary>
        /// 云服务器元数据。
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// 弹性云服务器的网络属性。
        /// </summary>
        [JsonProperty("addresses", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<ServerAddress>> Addresses { get; set; }

        /// <summary>
        /// 弹性云服务器创建时间。  时间格式例如：2019-05-22T03:19:19Z
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 弹性云服务器所在主机的主机ID。
        /// </summary>
        [JsonProperty("hostId", NullValueHandling = NullValueHandling.Ignore)]
        public string HostId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public SimpleFlavor Flavor { get; set; }

        /// <summary>
        /// 扩展属性， diskConfig的类型。  - MANUAL，镜像空间不会扩展。 - AUTO，系统盘镜像空间会自动扩展为与flavor大小一致。
        /// </summary>
        [JsonProperty("OS-DCF:diskConfig", NullValueHandling = NullValueHandling.Ignore)]
        public string OSDCFdiskConfig { get; set; }

        /// <summary>
        /// 创建弹性云服务器的用户ID，格式为UUID。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 弹性云服务器名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 弹性云服务器进度。
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public int? Progress { get; set; }

        /// <summary>
        /// 云服务器相关标记快捷链接信息。
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// 弹性云服务器ID，格式为UUID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 弹性云服务器更新时间。  时间格式例如：2019-05-22T03:30:52Z
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// 弹性云服务器是否为锁定状态。  - true：锁定 - false：未锁定
        /// </summary>
        [JsonProperty("locked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Locked { get; set; }

        /// <summary>
        /// 弹性云服务器的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 云服务器的标签列表。  微版本2.26后支持，如果不使用微版本查询，响应中无tags字段。  系统近期对标签功能进行了升级，升级后，返回的tag值遵循如下规则：  - key与value使用“&#x3D;”连接，如“key&#x3D;value”。 - 如果value为空字符串，则仅返回key。 - key与value使用“&#x3D;”连接，如“key&#x3D;value”。 - 如果value为空字符串，则仅返回key。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 弹性云服务器状态。  取值范围：  ACTIVE、BUILD、DELETED、ERROR、HARD_REBOOT、MIGRATING、PAUSED、REBOOT、REBUILD、RESIZE、REVERT_RESIZE、SHUTOFF、SHELVED、SHELVED_OFFLOADED、SOFT_DELETED、SUSPENDED、VERIFY_RESIZE
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 弹性云服务器的主机名。
        /// </summary>
        [JsonProperty("OS-EXT-SRV-ATTR:hostname", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRhostname { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateServerResult {\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  accessIPv4: ").Append(AccessIPv4).Append("\n");
            sb.Append("  accessIPv6: ").Append(AccessIPv6).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  addresses: ").Append(Addresses).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  hostId: ").Append(HostId).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  oSDCFdiskConfig: ").Append(OSDCFdiskConfig).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  locked: ").Append(Locked).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  oSEXTSRVATTRhostname: ").Append(OSEXTSRVATTRhostname).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateServerResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateServerResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.AccessIPv4 == input.AccessIPv4 ||
                    (this.AccessIPv4 != null &&
                    this.AccessIPv4.Equals(input.AccessIPv4))
                ) && 
                (
                    this.AccessIPv6 == input.AccessIPv6 ||
                    (this.AccessIPv6 != null &&
                    this.AccessIPv6.Equals(input.AccessIPv6))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.HostId == input.HostId ||
                    (this.HostId != null &&
                    this.HostId.Equals(input.HostId))
                ) && 
                (
                    this.Flavor == input.Flavor ||
                    (this.Flavor != null &&
                    this.Flavor.Equals(input.Flavor))
                ) && 
                (
                    this.OSDCFdiskConfig == input.OSDCFdiskConfig ||
                    (this.OSDCFdiskConfig != null &&
                    this.OSDCFdiskConfig.Equals(input.OSDCFdiskConfig))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                ) && 
                (
                    this.Locked == input.Locked ||
                    (this.Locked != null &&
                    this.Locked.Equals(input.Locked))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.OSEXTSRVATTRhostname == input.OSEXTSRVATTRhostname ||
                    (this.OSEXTSRVATTRhostname != null &&
                    this.OSEXTSRVATTRhostname.Equals(input.OSEXTSRVATTRhostname))
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
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.AccessIPv4 != null)
                    hashCode = hashCode * 59 + this.AccessIPv4.GetHashCode();
                if (this.AccessIPv6 != null)
                    hashCode = hashCode * 59 + this.AccessIPv6.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.HostId != null)
                    hashCode = hashCode * 59 + this.HostId.GetHashCode();
                if (this.Flavor != null)
                    hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.OSDCFdiskConfig != null)
                    hashCode = hashCode * 59 + this.OSDCFdiskConfig.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Progress != null)
                    hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.Locked != null)
                    hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.OSEXTSRVATTRhostname != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRhostname.GetHashCode();
                return hashCode;
            }
        }
    }
}
