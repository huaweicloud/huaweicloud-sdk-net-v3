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
    /// Request Object
    /// </summary>
    public class ListCloudServersRequest 
    {

        /// <summary>
        /// 云服务器ID，格式为UUID，匹配规则为精确匹配。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 云服务器名称，匹配规则为模糊匹配。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 云服务器状态。  取值范围：  ACTIVE， BUILD，DELETED，ERROR，HARD_REBOOT，MIGRATING，REBOOT，RESIZE，REVERT_RESIZE，SHELVED，SHELVED_OFFLOADED，SHUTOFF，UNKNOWN，VERIFY_RESIZE  弹性云服务器状态说明请参考[云服务器状态](https://support.huaweicloud.com/api-ecs/ecs_08_0002.html)
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 云服务器是否处于回收站中
        /// </summary>
        [SDKProperty("in_recycle_bin", IsQuery = true)]
        [JsonProperty("in_recycle_bin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InRecycleBin { get; set; }

        /// <summary>
        /// 共池裸机按整机柜发放的同一批次的批创id。
        /// </summary>
        [SDKProperty("spod_id", IsQuery = true)]
        [JsonProperty("spod_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SpodId { get; set; }

        /// <summary>
        /// 云服务器规格名称。
        /// </summary>
        [SDKProperty("flavor_name", IsQuery = true)]
        [JsonProperty("flavor_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorName { get; set; }

        /// <summary>
        /// 镜像ID。
        /// </summary>
        [SDKProperty("image_id", IsQuery = true)]
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// 元数据过滤，支持key&#x3D;value过滤。
        /// </summary>
        [SDKProperty("metadata", IsQuery = true)]
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public string Metadata { get; set; }

        /// <summary>
        /// 元数据key过滤。
        /// </summary>
        [SDKProperty("metadata-key", IsQuery = true)]
        [JsonProperty("metadata-key", NullValueHandling = NullValueHandling.Ignore)]
        public string MetadataKey { get; set; }

        /// <summary>
        /// 查询tag字段中包含该值的云服务器。
        /// </summary>
        [SDKProperty("tags", IsQuery = true)]
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        ///  查询tag字段中不包含该值的云服务器
        /// </summary>
        [SDKProperty("not-tags", IsQuery = true)]
        [JsonProperty("not-tags", NullValueHandling = NullValueHandling.Ignore)]
        public string NotTags { get; set; }

        /// <summary>
        /// 云服务器所在的AZ，匹配规则为模糊匹配。
        /// </summary>
        [SDKProperty("availability_zone", IsQuery = true)]
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 云服务器所在的AZ，匹配规则为精确匹配。
        /// </summary>
        [SDKProperty("availability_zone_eq", IsQuery = true)]
        [JsonProperty("availability_zone_eq", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZoneEq { get; set; }

        /// <summary>
        /// 云服务器的计费类型。
        /// </summary>
        [SDKProperty("charging_mode", IsQuery = true)]
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargingMode { get; set; }

        /// <summary>
        /// 云服务器使用的密钥对名称。
        /// </summary>
        [SDKProperty("key_name", IsQuery = true)]
        [JsonProperty("key_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyName { get; set; }

        /// <summary>
        /// 过滤在launched_since时间之后启动的云服务器。格式为ISO8601时间格式，例如：2013-06-09T06:42:18Z。
        /// </summary>
        [SDKProperty("launched_since", IsQuery = true)]
        [JsonProperty("launched_since", NullValueHandling = NullValueHandling.Ignore)]
        public string LaunchedSince { get; set; }

        /// <summary>
        /// 过滤绑定某个企业项目的云服务器。 若需要查询当前用户所有企业项目绑定的云服务，请传参all_granted_eps。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 控制查询输出的字段。在默认字段的基础上选择是否查询，有管理员字段。
        /// </summary>
        [SDKProperty("expect-fields", IsQuery = true)]
        [JsonProperty("expect-fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExpectFields { get; set; }

        /// <summary>
        /// 查询返回VM数量限制。 limit 默认为10，最大为100。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCloudServersRequest {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  inRecycleBin: ").Append(InRecycleBin).Append("\n");
            sb.Append("  spodId: ").Append(SpodId).Append("\n");
            sb.Append("  flavorName: ").Append(FlavorName).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  metadataKey: ").Append(MetadataKey).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  notTags: ").Append(NotTags).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  availabilityZoneEq: ").Append(AvailabilityZoneEq).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  keyName: ").Append(KeyName).Append("\n");
            sb.Append("  launchedSince: ").Append(LaunchedSince).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  expectFields: ").Append(ExpectFields).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCloudServersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCloudServersRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.InRecycleBin == input.InRecycleBin ||
                    (this.InRecycleBin != null &&
                    this.InRecycleBin.Equals(input.InRecycleBin))
                ) && 
                (
                    this.SpodId == input.SpodId ||
                    (this.SpodId != null &&
                    this.SpodId.Equals(input.SpodId))
                ) && 
                (
                    this.FlavorName == input.FlavorName ||
                    (this.FlavorName != null &&
                    this.FlavorName.Equals(input.FlavorName))
                ) && 
                (
                    this.ImageId == input.ImageId ||
                    (this.ImageId != null &&
                    this.ImageId.Equals(input.ImageId))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.MetadataKey == input.MetadataKey ||
                    (this.MetadataKey != null &&
                    this.MetadataKey.Equals(input.MetadataKey))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.NotTags == input.NotTags ||
                    (this.NotTags != null &&
                    this.NotTags.Equals(input.NotTags))
                ) && 
                (
                    this.AvailabilityZone == input.AvailabilityZone ||
                    (this.AvailabilityZone != null &&
                    this.AvailabilityZone.Equals(input.AvailabilityZone))
                ) && 
                (
                    this.AvailabilityZoneEq == input.AvailabilityZoneEq ||
                    (this.AvailabilityZoneEq != null &&
                    this.AvailabilityZoneEq.Equals(input.AvailabilityZoneEq))
                ) && 
                (
                    this.ChargingMode == input.ChargingMode ||
                    (this.ChargingMode != null &&
                    this.ChargingMode.Equals(input.ChargingMode))
                ) && 
                (
                    this.KeyName == input.KeyName ||
                    (this.KeyName != null &&
                    this.KeyName.Equals(input.KeyName))
                ) && 
                (
                    this.LaunchedSince == input.LaunchedSince ||
                    (this.LaunchedSince != null &&
                    this.LaunchedSince.Equals(input.LaunchedSince))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.ExpectFields == input.ExpectFields ||
                    this.ExpectFields != null &&
                    input.ExpectFields != null &&
                    this.ExpectFields.SequenceEqual(input.ExpectFields)
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.InRecycleBin != null)
                    hashCode = hashCode * 59 + this.InRecycleBin.GetHashCode();
                if (this.SpodId != null)
                    hashCode = hashCode * 59 + this.SpodId.GetHashCode();
                if (this.FlavorName != null)
                    hashCode = hashCode * 59 + this.FlavorName.GetHashCode();
                if (this.ImageId != null)
                    hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.MetadataKey != null)
                    hashCode = hashCode * 59 + this.MetadataKey.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.NotTags != null)
                    hashCode = hashCode * 59 + this.NotTags.GetHashCode();
                if (this.AvailabilityZone != null)
                    hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.AvailabilityZoneEq != null)
                    hashCode = hashCode * 59 + this.AvailabilityZoneEq.GetHashCode();
                if (this.ChargingMode != null)
                    hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.KeyName != null)
                    hashCode = hashCode * 59 + this.KeyName.GetHashCode();
                if (this.LaunchedSince != null)
                    hashCode = hashCode * 59 + this.LaunchedSince.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ExpectFields != null)
                    hashCode = hashCode * 59 + this.ExpectFields.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
