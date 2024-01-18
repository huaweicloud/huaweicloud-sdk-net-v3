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
    public class RecycleInstsanceV3 
    {

        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 实例名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 实例主备模式，取值：Ha（主备），不区分大小写。
        /// </summary>
        [JsonProperty("ha_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string HaMode { get; set; }

        /// <summary>
        /// 引擎名
        /// </summary>
        [JsonProperty("engine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineName { get; set; }

        /// <summary>
        /// 数据库引擎版本
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// 计费方式
        /// </summary>
        [JsonProperty("pay_model", NullValueHandling = NullValueHandling.Ignore)]
        public string PayModel { get; set; }

        /// <summary>
        /// 创建时间，格式为“yyyy-mm-ddThh:mm:ssZ”。  其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 删除时间，格式为“yyyy-mm-ddThh:mm:ssZ”。  其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。
        /// </summary>
        [JsonProperty("deleted_at", NullValueHandling = NullValueHandling.Ignore)]
        public string DeletedAt { get; set; }

        /// <summary>
        /// 磁盘类型。 取值范围如下，区分大小写： - COMMON，表示SATA。 - HIGH，表示SAS。 - ULTRAHIGH，表示SSD。 - ULTRAHIGHPRO，表示SSD尊享版，仅支持超高性能型尊享版（需申请权限）。 - CLOUDSSD，表示SSD云盘，仅支持通用型和独享型规格实例。 - LOCALSSD，表示本地SSD。
        /// </summary>
        [JsonProperty("volume_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeType { get; set; }

        /// <summary>
        /// 磁盘大小，单位为GB。 取值范围：40GB~4000GB，必须为10的整数倍。  部分用户支持40GB~6000GB，如果您想创建存储空间最大为6000GB的数据库实例，或提高扩容上限到10000GB，请联系客服开通。  说明：对于只读实例，该参数无效，磁盘大小，默认和主实例相同。
        /// </summary>
        [JsonProperty("volume_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? VolumeSize { get; set; }

        /// <summary>
        /// 内网地址
        /// </summary>
        [JsonProperty("data_vip", NullValueHandling = NullValueHandling.Ignore)]
        public string DataVip { get; set; }

        /// <summary>
        /// ipv6内网地址
        /// </summary>
        [JsonProperty("data_vip_v6", NullValueHandling = NullValueHandling.Ignore)]
        public string DataVipV6 { get; set; }

        /// <summary>
        /// 企业项目ID
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 保留时间，格式为“yyyy-mm-ddThh:mm:ssZ”。  其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。
        /// </summary>
        [JsonProperty("retained_until", NullValueHandling = NullValueHandling.Ignore)]
        public string RetainedUntil { get; set; }

        /// <summary>
        /// 备份id
        /// </summary>
        [JsonProperty("recycle_backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RecycleBackupId { get; set; }

        /// <summary>
        /// 备份状态 取值范围如下，区分大小写: - BUILDING 备份中，不能进行重建 - COMPLETED，标识备份完成，可以重建
        /// </summary>
        [JsonProperty("recycle_status", NullValueHandling = NullValueHandling.Ignore)]
        public string RecycleStatus { get; set; }

        /// <summary>
        /// 是否为serverless实例 - false 不是serverless实例 - true 是serverless实例
        /// </summary>
        [JsonProperty("is_serverless", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsServerless { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecycleInstsanceV3 {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  haMode: ").Append(HaMode).Append("\n");
            sb.Append("  engineName: ").Append(EngineName).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  payModel: ").Append(PayModel).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  deletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  volumeType: ").Append(VolumeType).Append("\n");
            sb.Append("  volumeSize: ").Append(VolumeSize).Append("\n");
            sb.Append("  dataVip: ").Append(DataVip).Append("\n");
            sb.Append("  dataVipV6: ").Append(DataVipV6).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  retainedUntil: ").Append(RetainedUntil).Append("\n");
            sb.Append("  recycleBackupId: ").Append(RecycleBackupId).Append("\n");
            sb.Append("  recycleStatus: ").Append(RecycleStatus).Append("\n");
            sb.Append("  isServerless: ").Append(IsServerless).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecycleInstsanceV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecycleInstsanceV3 input)
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
                    this.HaMode == input.HaMode ||
                    (this.HaMode != null &&
                    this.HaMode.Equals(input.HaMode))
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
                    this.PayModel == input.PayModel ||
                    (this.PayModel != null &&
                    this.PayModel.Equals(input.PayModel))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.DeletedAt == input.DeletedAt ||
                    (this.DeletedAt != null &&
                    this.DeletedAt.Equals(input.DeletedAt))
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
                    this.DataVip == input.DataVip ||
                    (this.DataVip != null &&
                    this.DataVip.Equals(input.DataVip))
                ) && 
                (
                    this.DataVipV6 == input.DataVipV6 ||
                    (this.DataVipV6 != null &&
                    this.DataVipV6.Equals(input.DataVipV6))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.RetainedUntil == input.RetainedUntil ||
                    (this.RetainedUntil != null &&
                    this.RetainedUntil.Equals(input.RetainedUntil))
                ) && 
                (
                    this.RecycleBackupId == input.RecycleBackupId ||
                    (this.RecycleBackupId != null &&
                    this.RecycleBackupId.Equals(input.RecycleBackupId))
                ) && 
                (
                    this.RecycleStatus == input.RecycleStatus ||
                    (this.RecycleStatus != null &&
                    this.RecycleStatus.Equals(input.RecycleStatus))
                ) && 
                (
                    this.IsServerless == input.IsServerless ||
                    (this.IsServerless != null &&
                    this.IsServerless.Equals(input.IsServerless))
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
                if (this.HaMode != null)
                    hashCode = hashCode * 59 + this.HaMode.GetHashCode();
                if (this.EngineName != null)
                    hashCode = hashCode * 59 + this.EngineName.GetHashCode();
                if (this.EngineVersion != null)
                    hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.PayModel != null)
                    hashCode = hashCode * 59 + this.PayModel.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.DeletedAt != null)
                    hashCode = hashCode * 59 + this.DeletedAt.GetHashCode();
                if (this.VolumeType != null)
                    hashCode = hashCode * 59 + this.VolumeType.GetHashCode();
                if (this.VolumeSize != null)
                    hashCode = hashCode * 59 + this.VolumeSize.GetHashCode();
                if (this.DataVip != null)
                    hashCode = hashCode * 59 + this.DataVip.GetHashCode();
                if (this.DataVipV6 != null)
                    hashCode = hashCode * 59 + this.DataVipV6.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.RetainedUntil != null)
                    hashCode = hashCode * 59 + this.RetainedUntil.GetHashCode();
                if (this.RecycleBackupId != null)
                    hashCode = hashCode * 59 + this.RecycleBackupId.GetHashCode();
                if (this.RecycleStatus != null)
                    hashCode = hashCode * 59 + this.RecycleStatus.GetHashCode();
                if (this.IsServerless != null)
                    hashCode = hashCode * 59 + this.IsServerless.GetHashCode();
                return hashCode;
            }
        }
    }
}
