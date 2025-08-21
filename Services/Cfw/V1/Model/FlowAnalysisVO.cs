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
    public class FlowAnalysisVO 
    {

        /// <summary>
        /// **参数解释**： 应用统计 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("app_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? AppCount { get; set; }

        /// <summary>
        /// **参数解释**： 字节数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("bytes", NullValueHandling = NullValueHandling.Ignore)]
        public double? Bytes { get; set; }

        /// <summary>
        /// **参数解释**： 目的IP计数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_ip_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? DstIpCount { get; set; }

        /// <summary>
        /// **参数**： 目的端口计数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_port_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? DstPortCount { get; set; }

        /// <summary>
        /// **参数解释**： 结束时间 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// **参数解释**： TOP会话详情 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("records", NullValueHandling = NullValueHandling.Ignore)]
        public List<SessionVO> Records { get; set; }

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
        /// **参数解释**： 会话次数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("sessions", NullValueHandling = NullValueHandling.Ignore)]
        public long? Sessions { get; set; }

        /// <summary>
        /// **参数解释**： 源IP计数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_ip_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? SrcIpCount { get; set; }

        /// <summary>
        /// **参数解释**： 开始时间 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowAnalysisVO {\n");
            sb.Append("  appCount: ").Append(AppCount).Append("\n");
            sb.Append("  bytes: ").Append(Bytes).Append("\n");
            sb.Append("  dstIpCount: ").Append(DstIpCount).Append("\n");
            sb.Append("  dstPortCount: ").Append(DstPortCount).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  records: ").Append(Records).Append("\n");
            sb.Append("  requestByte: ").Append(RequestByte).Append("\n");
            sb.Append("  responseByte: ").Append(ResponseByte).Append("\n");
            sb.Append("  sessions: ").Append(Sessions).Append("\n");
            sb.Append("  srcIpCount: ").Append(SrcIpCount).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlowAnalysisVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlowAnalysisVO input)
        {
            if (input == null) return false;
            if (this.AppCount != input.AppCount || (this.AppCount != null && !this.AppCount.Equals(input.AppCount))) return false;
            if (this.Bytes != input.Bytes || (this.Bytes != null && !this.Bytes.Equals(input.Bytes))) return false;
            if (this.DstIpCount != input.DstIpCount || (this.DstIpCount != null && !this.DstIpCount.Equals(input.DstIpCount))) return false;
            if (this.DstPortCount != input.DstPortCount || (this.DstPortCount != null && !this.DstPortCount.Equals(input.DstPortCount))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Records != input.Records || (this.Records != null && input.Records != null && !this.Records.SequenceEqual(input.Records))) return false;
            if (this.RequestByte != input.RequestByte || (this.RequestByte != null && !this.RequestByte.Equals(input.RequestByte))) return false;
            if (this.ResponseByte != input.ResponseByte || (this.ResponseByte != null && !this.ResponseByte.Equals(input.ResponseByte))) return false;
            if (this.Sessions != input.Sessions || (this.Sessions != null && !this.Sessions.Equals(input.Sessions))) return false;
            if (this.SrcIpCount != input.SrcIpCount || (this.SrcIpCount != null && !this.SrcIpCount.Equals(input.SrcIpCount))) return false;
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
                if (this.AppCount != null) hashCode = hashCode * 59 + this.AppCount.GetHashCode();
                if (this.Bytes != null) hashCode = hashCode * 59 + this.Bytes.GetHashCode();
                if (this.DstIpCount != null) hashCode = hashCode * 59 + this.DstIpCount.GetHashCode();
                if (this.DstPortCount != null) hashCode = hashCode * 59 + this.DstPortCount.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Records != null) hashCode = hashCode * 59 + this.Records.GetHashCode();
                if (this.RequestByte != null) hashCode = hashCode * 59 + this.RequestByte.GetHashCode();
                if (this.ResponseByte != null) hashCode = hashCode * 59 + this.ResponseByte.GetHashCode();
                if (this.Sessions != null) hashCode = hashCode * 59 + this.Sessions.GetHashCode();
                if (this.SrcIpCount != null) hashCode = hashCode * 59 + this.SrcIpCount.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
