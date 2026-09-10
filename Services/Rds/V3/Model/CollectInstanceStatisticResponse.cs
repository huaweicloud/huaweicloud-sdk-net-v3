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
    /// Response Object
    /// </summary>
    public class CollectInstanceStatisticResponse : SdkResponse
    {

        /// <summary>
        /// 实例总数
        /// </summary>
        [JsonProperty("total_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalNum { get; set; }

        /// <summary>
        /// 异常实例数
        /// </summary>
        [JsonProperty("abnormal_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? AbnormalNum { get; set; }

        /// <summary>
        /// 磁盘不足实例数
        /// </summary>
        [JsonProperty("disk_full_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? DiskFullNum { get; set; }

        /// <summary>
        /// 冻结实例数
        /// </summary>
        [JsonProperty("frozen_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrozenNum { get; set; }

        /// <summary>
        /// 运行中实例数
        /// </summary>
        [JsonProperty("normal_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NormalNum { get; set; }

        /// <summary>
        /// 等待重启实例数
        /// </summary>
        [JsonProperty("wait_reboot_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? WaitRebootNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollectInstanceStatisticResponse {\n");
            sb.Append("  totalNum: ").Append(TotalNum).Append("\n");
            sb.Append("  abnormalNum: ").Append(AbnormalNum).Append("\n");
            sb.Append("  diskFullNum: ").Append(DiskFullNum).Append("\n");
            sb.Append("  frozenNum: ").Append(FrozenNum).Append("\n");
            sb.Append("  normalNum: ").Append(NormalNum).Append("\n");
            sb.Append("  waitRebootNum: ").Append(WaitRebootNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CollectInstanceStatisticResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CollectInstanceStatisticResponse input)
        {
            if (input == null) return false;
            if (this.TotalNum != input.TotalNum || (this.TotalNum != null && !this.TotalNum.Equals(input.TotalNum))) return false;
            if (this.AbnormalNum != input.AbnormalNum || (this.AbnormalNum != null && !this.AbnormalNum.Equals(input.AbnormalNum))) return false;
            if (this.DiskFullNum != input.DiskFullNum || (this.DiskFullNum != null && !this.DiskFullNum.Equals(input.DiskFullNum))) return false;
            if (this.FrozenNum != input.FrozenNum || (this.FrozenNum != null && !this.FrozenNum.Equals(input.FrozenNum))) return false;
            if (this.NormalNum != input.NormalNum || (this.NormalNum != null && !this.NormalNum.Equals(input.NormalNum))) return false;
            if (this.WaitRebootNum != input.WaitRebootNum || (this.WaitRebootNum != null && !this.WaitRebootNum.Equals(input.WaitRebootNum))) return false;

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
                if (this.TotalNum != null) hashCode = hashCode * 59 + this.TotalNum.GetHashCode();
                if (this.AbnormalNum != null) hashCode = hashCode * 59 + this.AbnormalNum.GetHashCode();
                if (this.DiskFullNum != null) hashCode = hashCode * 59 + this.DiskFullNum.GetHashCode();
                if (this.FrozenNum != null) hashCode = hashCode * 59 + this.FrozenNum.GetHashCode();
                if (this.NormalNum != null) hashCode = hashCode * 59 + this.NormalNum.GetHashCode();
                if (this.WaitRebootNum != null) hashCode = hashCode * 59 + this.WaitRebootNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
