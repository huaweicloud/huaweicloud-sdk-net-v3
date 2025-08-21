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
    public class SessionVO 
    {

        /// <summary>
        /// **参数解释**： 应用 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// **参数解释**： 字节数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("bytes", NullValueHandling = NullValueHandling.Ignore)]
        public double? Bytes { get; set; }

        /// <summary>
        /// **参数解释**： 目的IP关联资产类型 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_associate_instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DstAssociateInstanceType { get; set; }

        /// <summary>
        /// **参数解释**： 目的IP关联资产名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_device_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DstDeviceName { get; set; }

        /// <summary>
        /// **参数解释**： 目的IP **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DstIp { get; set; }

        /// <summary>
        /// **参数解释**： 目的端口 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_port", NullValueHandling = NullValueHandling.Ignore)]
        public string DstPort { get; set; }

        /// <summary>
        /// **参数解释**： 目的域名 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_host", NullValueHandling = NullValueHandling.Ignore)]
        public string DstHost { get; set; }

        /// <summary>
        /// **参数解释**： 目的regionID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DstRegionId { get; set; }

        /// <summary>
        /// **参数解释**： 目的地区 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DstRegionName { get; set; }

        /// <summary>
        /// **参数解释**： 结束时间 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// **参数解释**： 协议 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// **参数解释**： 请求字节数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("request_byte", NullValueHandling = NullValueHandling.Ignore)]
        public double? RequestByte { get; set; }

        /// <summary>
        /// **参数解释**： 响应字节数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("response_byte", NullValueHandling = NullValueHandling.Ignore)]
        public double? ResponseByte { get; set; }

        /// <summary>
        /// **参数解释**： 会话数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("sessions", NullValueHandling = NullValueHandling.Ignore)]
        public long? Sessions { get; set; }

        /// <summary>
        /// **参数解释**： 源IP关联资产类型 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_associate_instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcAssociateInstanceType { get; set; }

        /// <summary>
        /// **参数解释**： 源IP关联资产名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_device_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcDeviceName { get; set; }

        /// <summary>
        /// **参数解释**： 源IP **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcIp { get; set; }

        /// <summary>
        /// **参数解释**： 源地区 ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcRegionId { get; set; }

        /// <summary>
        /// **参数解释**： 源地区 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcRegionName { get; set; }

        /// <summary>
        /// **参数解释**： 会话开始时间 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionVO {\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  bytes: ").Append(Bytes).Append("\n");
            sb.Append("  dstAssociateInstanceType: ").Append(DstAssociateInstanceType).Append("\n");
            sb.Append("  dstDeviceName: ").Append(DstDeviceName).Append("\n");
            sb.Append("  dstIp: ").Append(DstIp).Append("\n");
            sb.Append("  dstPort: ").Append(DstPort).Append("\n");
            sb.Append("  dstHost: ").Append(DstHost).Append("\n");
            sb.Append("  dstRegionId: ").Append(DstRegionId).Append("\n");
            sb.Append("  dstRegionName: ").Append(DstRegionName).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  requestByte: ").Append(RequestByte).Append("\n");
            sb.Append("  responseByte: ").Append(ResponseByte).Append("\n");
            sb.Append("  sessions: ").Append(Sessions).Append("\n");
            sb.Append("  srcAssociateInstanceType: ").Append(SrcAssociateInstanceType).Append("\n");
            sb.Append("  srcDeviceName: ").Append(SrcDeviceName).Append("\n");
            sb.Append("  srcIp: ").Append(SrcIp).Append("\n");
            sb.Append("  srcRegionId: ").Append(SrcRegionId).Append("\n");
            sb.Append("  srcRegionName: ").Append(SrcRegionName).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SessionVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SessionVO input)
        {
            if (input == null) return false;
            if (this.App != input.App || (this.App != null && !this.App.Equals(input.App))) return false;
            if (this.Bytes != input.Bytes || (this.Bytes != null && !this.Bytes.Equals(input.Bytes))) return false;
            if (this.DstAssociateInstanceType != input.DstAssociateInstanceType || (this.DstAssociateInstanceType != null && !this.DstAssociateInstanceType.Equals(input.DstAssociateInstanceType))) return false;
            if (this.DstDeviceName != input.DstDeviceName || (this.DstDeviceName != null && !this.DstDeviceName.Equals(input.DstDeviceName))) return false;
            if (this.DstIp != input.DstIp || (this.DstIp != null && !this.DstIp.Equals(input.DstIp))) return false;
            if (this.DstPort != input.DstPort || (this.DstPort != null && !this.DstPort.Equals(input.DstPort))) return false;
            if (this.DstHost != input.DstHost || (this.DstHost != null && !this.DstHost.Equals(input.DstHost))) return false;
            if (this.DstRegionId != input.DstRegionId || (this.DstRegionId != null && !this.DstRegionId.Equals(input.DstRegionId))) return false;
            if (this.DstRegionName != input.DstRegionName || (this.DstRegionName != null && !this.DstRegionName.Equals(input.DstRegionName))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;
            if (this.RequestByte != input.RequestByte || (this.RequestByte != null && !this.RequestByte.Equals(input.RequestByte))) return false;
            if (this.ResponseByte != input.ResponseByte || (this.ResponseByte != null && !this.ResponseByte.Equals(input.ResponseByte))) return false;
            if (this.Sessions != input.Sessions || (this.Sessions != null && !this.Sessions.Equals(input.Sessions))) return false;
            if (this.SrcAssociateInstanceType != input.SrcAssociateInstanceType || (this.SrcAssociateInstanceType != null && !this.SrcAssociateInstanceType.Equals(input.SrcAssociateInstanceType))) return false;
            if (this.SrcDeviceName != input.SrcDeviceName || (this.SrcDeviceName != null && !this.SrcDeviceName.Equals(input.SrcDeviceName))) return false;
            if (this.SrcIp != input.SrcIp || (this.SrcIp != null && !this.SrcIp.Equals(input.SrcIp))) return false;
            if (this.SrcRegionId != input.SrcRegionId || (this.SrcRegionId != null && !this.SrcRegionId.Equals(input.SrcRegionId))) return false;
            if (this.SrcRegionName != input.SrcRegionName || (this.SrcRegionName != null && !this.SrcRegionName.Equals(input.SrcRegionName))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;

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
                if (this.App != null) hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.Bytes != null) hashCode = hashCode * 59 + this.Bytes.GetHashCode();
                if (this.DstAssociateInstanceType != null) hashCode = hashCode * 59 + this.DstAssociateInstanceType.GetHashCode();
                if (this.DstDeviceName != null) hashCode = hashCode * 59 + this.DstDeviceName.GetHashCode();
                if (this.DstIp != null) hashCode = hashCode * 59 + this.DstIp.GetHashCode();
                if (this.DstPort != null) hashCode = hashCode * 59 + this.DstPort.GetHashCode();
                if (this.DstHost != null) hashCode = hashCode * 59 + this.DstHost.GetHashCode();
                if (this.DstRegionId != null) hashCode = hashCode * 59 + this.DstRegionId.GetHashCode();
                if (this.DstRegionName != null) hashCode = hashCode * 59 + this.DstRegionName.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.RequestByte != null) hashCode = hashCode * 59 + this.RequestByte.GetHashCode();
                if (this.ResponseByte != null) hashCode = hashCode * 59 + this.ResponseByte.GetHashCode();
                if (this.Sessions != null) hashCode = hashCode * 59 + this.Sessions.GetHashCode();
                if (this.SrcAssociateInstanceType != null) hashCode = hashCode * 59 + this.SrcAssociateInstanceType.GetHashCode();
                if (this.SrcDeviceName != null) hashCode = hashCode * 59 + this.SrcDeviceName.GetHashCode();
                if (this.SrcIp != null) hashCode = hashCode * 59 + this.SrcIp.GetHashCode();
                if (this.SrcRegionId != null) hashCode = hashCode * 59 + this.SrcRegionId.GetHashCode();
                if (this.SrcRegionName != null) hashCode = hashCode * 59 + this.SrcRegionName.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
