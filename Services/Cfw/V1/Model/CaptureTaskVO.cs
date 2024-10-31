using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CaptureTaskVO 
    {

        /// <summary>
        /// 抓包大小,如500kb,500mb
        /// </summary>
        [JsonProperty("capture_size", NullValueHandling = NullValueHandling.Ignore)]
        public string CaptureSize { get; set; }

        /// <summary>
        /// 抓包创建时间,如2024/08/31 10:17:30
        /// </summary>
        [JsonProperty("created_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// 目的地址
        /// </summary>
        [JsonProperty("dest_address", NullValueHandling = NullValueHandling.Ignore)]
        public string DestAddress { get; set; }

        /// <summary>
        /// 目的地址类型0 ipv4，1 ipv6
        /// </summary>
        [JsonProperty("dest_address_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? DestAddressType { get; set; }

        /// <summary>
        /// 目的端口
        /// </summary>
        [JsonProperty("dest_port", NullValueHandling = NullValueHandling.Ignore)]
        public string DestPort { get; set; }

        /// <summary>
        /// 抓包时长，以分钟为单位
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        /// <summary>
        /// 是否被删除，0否 1是
        /// </summary>
        [JsonProperty("is_deleted", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsDeleted { get; set; }

        /// <summary>
        /// 最大抓包数，以个为单位
        /// </summary>
        [JsonProperty("max_packets", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxPackets { get; set; }

        /// <summary>
        /// 修改日期,如2024/08/31 10:17:30
        /// </summary>
        [JsonProperty("modified_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedDate { get; set; }

        /// <summary>
        /// 抓包任务名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 协议类型:TCP为6，UDP为17，ICMP为1，ICMPV6为58，ANY为-1，手动类型不为空，自动类型为空
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public int? Protocol { get; set; }

        /// <summary>
        /// 剩余保留天数
        /// </summary>
        [JsonProperty("remaining_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? RemainingDays { get; set; }

        /// <summary>
        /// 源地址
        /// </summary>
        [JsonProperty("source_address", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceAddress { get; set; }

        /// <summary>
        /// 源地址类型0 ipv4，1 ipv6
        /// </summary>
        [JsonProperty("source_address_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourceAddressType { get; set; }

        /// <summary>
        /// 源端口
        /// </summary>
        [JsonProperty("source_port", NullValueHandling = NullValueHandling.Ignore)]
        public string SourcePort { get; set; }

        /// <summary>
        /// 抓包任务状态，如成功（1），运行中（2），已截止（4），截止中（5）
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 抓包任务id
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaptureTaskVO {\n");
            sb.Append("  captureSize: ").Append(CaptureSize).Append("\n");
            sb.Append("  createdDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  destAddress: ").Append(DestAddress).Append("\n");
            sb.Append("  destAddressType: ").Append(DestAddressType).Append("\n");
            sb.Append("  destPort: ").Append(DestPort).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  isDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  maxPackets: ").Append(MaxPackets).Append("\n");
            sb.Append("  modifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  remainingDays: ").Append(RemainingDays).Append("\n");
            sb.Append("  sourceAddress: ").Append(SourceAddress).Append("\n");
            sb.Append("  sourceAddressType: ").Append(SourceAddressType).Append("\n");
            sb.Append("  sourcePort: ").Append(SourcePort).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CaptureTaskVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CaptureTaskVO input)
        {
            if (input == null) return false;
            if (this.CaptureSize != input.CaptureSize || (this.CaptureSize != null && !this.CaptureSize.Equals(input.CaptureSize))) return false;
            if (this.CreatedDate != input.CreatedDate || (this.CreatedDate != null && !this.CreatedDate.Equals(input.CreatedDate))) return false;
            if (this.DestAddress != input.DestAddress || (this.DestAddress != null && !this.DestAddress.Equals(input.DestAddress))) return false;
            if (this.DestAddressType != input.DestAddressType || (this.DestAddressType != null && !this.DestAddressType.Equals(input.DestAddressType))) return false;
            if (this.DestPort != input.DestPort || (this.DestPort != null && !this.DestPort.Equals(input.DestPort))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.IsDeleted != input.IsDeleted || (this.IsDeleted != null && !this.IsDeleted.Equals(input.IsDeleted))) return false;
            if (this.MaxPackets != input.MaxPackets || (this.MaxPackets != null && !this.MaxPackets.Equals(input.MaxPackets))) return false;
            if (this.ModifiedDate != input.ModifiedDate || (this.ModifiedDate != null && !this.ModifiedDate.Equals(input.ModifiedDate))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;
            if (this.RemainingDays != input.RemainingDays || (this.RemainingDays != null && !this.RemainingDays.Equals(input.RemainingDays))) return false;
            if (this.SourceAddress != input.SourceAddress || (this.SourceAddress != null && !this.SourceAddress.Equals(input.SourceAddress))) return false;
            if (this.SourceAddressType != input.SourceAddressType || (this.SourceAddressType != null && !this.SourceAddressType.Equals(input.SourceAddressType))) return false;
            if (this.SourcePort != input.SourcePort || (this.SourcePort != null && !this.SourcePort.Equals(input.SourcePort))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;

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
                if (this.CaptureSize != null) hashCode = hashCode * 59 + this.CaptureSize.GetHashCode();
                if (this.CreatedDate != null) hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.DestAddress != null) hashCode = hashCode * 59 + this.DestAddress.GetHashCode();
                if (this.DestAddressType != null) hashCode = hashCode * 59 + this.DestAddressType.GetHashCode();
                if (this.DestPort != null) hashCode = hashCode * 59 + this.DestPort.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.IsDeleted != null) hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
                if (this.MaxPackets != null) hashCode = hashCode * 59 + this.MaxPackets.GetHashCode();
                if (this.ModifiedDate != null) hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.RemainingDays != null) hashCode = hashCode * 59 + this.RemainingDays.GetHashCode();
                if (this.SourceAddress != null) hashCode = hashCode * 59 + this.SourceAddress.GetHashCode();
                if (this.SourceAddressType != null) hashCode = hashCode * 59 + this.SourceAddressType.GetHashCode();
                if (this.SourcePort != null) hashCode = hashCode * 59 + this.SourcePort.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                return hashCode;
            }
        }
    }
}
