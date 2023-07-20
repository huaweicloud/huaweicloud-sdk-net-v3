using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SimplifiedInstanceEntry 
    {

        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 创建的实例名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 引擎名字
        /// </summary>
        [JsonProperty("engine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineName { get; set; }

        /// <summary>
        /// 引擎版本
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// 实例状态。 normal,表示正常 abnormal,表示异常 creating,表示创建中 createfail,表示创建失败 data_disk_full,表示磁盘满 deleted,表示删除 shutdown,表示关机
        /// </summary>
        [JsonProperty("instance_status", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// 是否冻结
        /// </summary>
        [JsonProperty("frozen", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Frozen { get; set; }

        /// <summary>
        /// 按照实例类型查询。取值Single、Ha、Replica、Enterprise，分别对应于单实例、主备实例和只读实例、分布式实例（企业版）。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 按需还是包周期
        /// </summary>
        [JsonProperty("pay_model", NullValueHandling = NullValueHandling.Ignore)]
        public string PayModel { get; set; }

        /// <summary>
        /// 规格码
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }

        /// <summary>
        /// 可用区集合
        /// </summary>
        [JsonProperty("availability_zone_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailabilityZoneIds { get; set; }

        /// <summary>
        /// 只读实例id集合
        /// </summary>
        [JsonProperty("read_only_instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReadOnlyInstances { get; set; }

        /// <summary>
        /// 当前实例操作动作集合
        /// </summary>
        [JsonProperty("current_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CurrentActions { get; set; }

        /// <summary>
        /// 磁盘类型。
        /// </summary>
        [JsonProperty("volume_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeType { get; set; }

        /// <summary>
        /// 磁盘大小(单位:G)。
        /// </summary>
        [JsonProperty("volume_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? VolumeSize { get; set; }

        /// <summary>
        /// 企业项目标签ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimplifiedInstanceEntry {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  engineName: ").Append(EngineName).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  instanceStatus: ").Append(InstanceStatus).Append("\n");
            sb.Append("  frozen: ").Append(Frozen).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  payModel: ").Append(PayModel).Append("\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("  availabilityZoneIds: ").Append(AvailabilityZoneIds).Append("\n");
            sb.Append("  readOnlyInstances: ").Append(ReadOnlyInstances).Append("\n");
            sb.Append("  currentActions: ").Append(CurrentActions).Append("\n");
            sb.Append("  volumeType: ").Append(VolumeType).Append("\n");
            sb.Append("  volumeSize: ").Append(VolumeSize).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SimplifiedInstanceEntry);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SimplifiedInstanceEntry input)
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
                    this.EngineName == input.EngineName ||
                    (this.EngineName != null &&
                    this.EngineName.Equals(input.EngineName))
                ) && 
                (
                    this.EngineVersion == input.EngineVersion ||
                    (this.EngineVersion != null &&
                    this.EngineVersion.Equals(input.EngineVersion))
                ) && 
                (
                    this.InstanceStatus == input.InstanceStatus ||
                    (this.InstanceStatus != null &&
                    this.InstanceStatus.Equals(input.InstanceStatus))
                ) && 
                (
                    this.Frozen == input.Frozen ||
                    (this.Frozen != null &&
                    this.Frozen.Equals(input.Frozen))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.PayModel == input.PayModel ||
                    (this.PayModel != null &&
                    this.PayModel.Equals(input.PayModel))
                ) && 
                (
                    this.SpecCode == input.SpecCode ||
                    (this.SpecCode != null &&
                    this.SpecCode.Equals(input.SpecCode))
                ) && 
                (
                    this.AvailabilityZoneIds == input.AvailabilityZoneIds ||
                    this.AvailabilityZoneIds != null &&
                    input.AvailabilityZoneIds != null &&
                    this.AvailabilityZoneIds.SequenceEqual(input.AvailabilityZoneIds)
                ) && 
                (
                    this.ReadOnlyInstances == input.ReadOnlyInstances ||
                    this.ReadOnlyInstances != null &&
                    input.ReadOnlyInstances != null &&
                    this.ReadOnlyInstances.SequenceEqual(input.ReadOnlyInstances)
                ) && 
                (
                    this.CurrentActions == input.CurrentActions ||
                    this.CurrentActions != null &&
                    input.CurrentActions != null &&
                    this.CurrentActions.SequenceEqual(input.CurrentActions)
                ) && 
                (
                    this.VolumeType == input.VolumeType ||
                    (this.VolumeType != null &&
                    this.VolumeType.Equals(input.VolumeType))
                ) && 
                (
                    this.VolumeSize == input.VolumeSize ||
                    (this.VolumeSize != null &&
                    this.VolumeSize.Equals(input.VolumeSize))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                if (this.EngineName != null)
                    hashCode = hashCode * 59 + this.EngineName.GetHashCode();
                if (this.EngineVersion != null)
                    hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.InstanceStatus != null)
                    hashCode = hashCode * 59 + this.InstanceStatus.GetHashCode();
                if (this.Frozen != null)
                    hashCode = hashCode * 59 + this.Frozen.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.PayModel != null)
                    hashCode = hashCode * 59 + this.PayModel.GetHashCode();
                if (this.SpecCode != null)
                    hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                if (this.AvailabilityZoneIds != null)
                    hashCode = hashCode * 59 + this.AvailabilityZoneIds.GetHashCode();
                if (this.ReadOnlyInstances != null)
                    hashCode = hashCode * 59 + this.ReadOnlyInstances.GetHashCode();
                if (this.CurrentActions != null)
                    hashCode = hashCode * 59 + this.CurrentActions.GetHashCode();
                if (this.VolumeType != null)
                    hashCode = hashCode * 59 + this.VolumeType.GetHashCode();
                if (this.VolumeSize != null)
                    hashCode = hashCode * 59 + this.VolumeSize.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
