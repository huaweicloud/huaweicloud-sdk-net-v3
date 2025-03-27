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
    /// 
    /// </summary>
    public class EventResponseExecuteOptions 
    {

        /// <summary>
        /// 本地盘设备名
        /// </summary>
        [JsonProperty("device", NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }

        /// <summary>
        /// 本地盘挂载唯一标识
        /// </summary>
        [JsonProperty("wwn", NullValueHandling = NullValueHandling.Ignore)]
        public string Wwn { get; set; }

        /// <summary>
        /// 本地盘序列号
        /// </summary>
        [JsonProperty("serial_number", NullValueHandling = NullValueHandling.Ignore)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// flavorID
        /// </summary>
        [JsonProperty("resize_target_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResizeTargetFlavorId { get; set; }

        /// <summary>
        /// 实例迁移策略
        /// </summary>
        [JsonProperty("migrate_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string MigratePolicy { get; set; }

        /// <summary>
        /// 执行器
        /// </summary>
        [JsonProperty("executor", NullValueHandling = NullValueHandling.Ignore)]
        public string Executor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventResponseExecuteOptions {\n");
            sb.Append("  device: ").Append(Device).Append("\n");
            sb.Append("  wwn: ").Append(Wwn).Append("\n");
            sb.Append("  serialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  resizeTargetFlavorId: ").Append(ResizeTargetFlavorId).Append("\n");
            sb.Append("  migratePolicy: ").Append(MigratePolicy).Append("\n");
            sb.Append("  executor: ").Append(Executor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EventResponseExecuteOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EventResponseExecuteOptions input)
        {
            if (input == null) return false;
            if (this.Device != input.Device || (this.Device != null && !this.Device.Equals(input.Device))) return false;
            if (this.Wwn != input.Wwn || (this.Wwn != null && !this.Wwn.Equals(input.Wwn))) return false;
            if (this.SerialNumber != input.SerialNumber || (this.SerialNumber != null && !this.SerialNumber.Equals(input.SerialNumber))) return false;
            if (this.ResizeTargetFlavorId != input.ResizeTargetFlavorId || (this.ResizeTargetFlavorId != null && !this.ResizeTargetFlavorId.Equals(input.ResizeTargetFlavorId))) return false;
            if (this.MigratePolicy != input.MigratePolicy || (this.MigratePolicy != null && !this.MigratePolicy.Equals(input.MigratePolicy))) return false;
            if (this.Executor != input.Executor || (this.Executor != null && !this.Executor.Equals(input.Executor))) return false;

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
                if (this.Device != null) hashCode = hashCode * 59 + this.Device.GetHashCode();
                if (this.Wwn != null) hashCode = hashCode * 59 + this.Wwn.GetHashCode();
                if (this.SerialNumber != null) hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.ResizeTargetFlavorId != null) hashCode = hashCode * 59 + this.ResizeTargetFlavorId.GetHashCode();
                if (this.MigratePolicy != null) hashCode = hashCode * 59 + this.MigratePolicy.GetHashCode();
                if (this.Executor != null) hashCode = hashCode * 59 + this.Executor.GetHashCode();
                return hashCode;
            }
        }
    }
}
