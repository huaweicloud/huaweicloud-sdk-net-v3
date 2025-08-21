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
    public class FlowDetailsVO 
    {

        /// <summary>
        /// **参数解释**： 应用统计 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("apps", NullValueHandling = NullValueHandling.Ignore)]
        public List<ItemVO> Apps { get; set; }

        /// <summary>
        /// **参数解释**： 关联资产类型 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("associate_instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociateInstanceType { get; set; }

        /// <summary>
        /// **参数解释**： 关联资产名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("device_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceName { get; set; }

        /// <summary>
        /// **参数解释**： 聚合项 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("item", NullValueHandling = NullValueHandling.Ignore)]
        public string Item { get; set; }

        /// <summary>
        /// **参数解释**： 最近访问时间 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("last_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastTime { get; set; }

        /// <summary>
        /// **参数解释**： 端口统计 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("ports", NullValueHandling = NullValueHandling.Ignore)]
        public List<ItemVO> Ports { get; set; }

        /// <summary>
        /// **参数解释**： 地区 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

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
        /// **参数解释**： 标签 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        /// **参数解释**： 源IP **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_ip", NullValueHandling = NullValueHandling.Ignore)]
        public List<ItemVO> SrcIp { get; set; }

        /// <summary>
        /// **参数解释**： 目的IP **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_ip", NullValueHandling = NullValueHandling.Ignore)]
        public List<ItemVO> DstIp { get; set; }

        /// <summary>
        /// **参数解释**： 协议 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowDetailsVO {\n");
            sb.Append("  apps: ").Append(Apps).Append("\n");
            sb.Append("  associateInstanceType: ").Append(AssociateInstanceType).Append("\n");
            sb.Append("  deviceName: ").Append(DeviceName).Append("\n");
            sb.Append("  item: ").Append(Item).Append("\n");
            sb.Append("  lastTime: ").Append(LastTime).Append("\n");
            sb.Append("  ports: ").Append(Ports).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  requestByte: ").Append(RequestByte).Append("\n");
            sb.Append("  responseByte: ").Append(ResponseByte).Append("\n");
            sb.Append("  sessions: ").Append(Sessions).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  srcIp: ").Append(SrcIp).Append("\n");
            sb.Append("  dstIp: ").Append(DstIp).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlowDetailsVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlowDetailsVO input)
        {
            if (input == null) return false;
            if (this.Apps != input.Apps || (this.Apps != null && input.Apps != null && !this.Apps.SequenceEqual(input.Apps))) return false;
            if (this.AssociateInstanceType != input.AssociateInstanceType || (this.AssociateInstanceType != null && !this.AssociateInstanceType.Equals(input.AssociateInstanceType))) return false;
            if (this.DeviceName != input.DeviceName || (this.DeviceName != null && !this.DeviceName.Equals(input.DeviceName))) return false;
            if (this.Item != input.Item || (this.Item != null && !this.Item.Equals(input.Item))) return false;
            if (this.LastTime != input.LastTime || (this.LastTime != null && !this.LastTime.Equals(input.LastTime))) return false;
            if (this.Ports != input.Ports || (this.Ports != null && input.Ports != null && !this.Ports.SequenceEqual(input.Ports))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.RequestByte != input.RequestByte || (this.RequestByte != null && !this.RequestByte.Equals(input.RequestByte))) return false;
            if (this.ResponseByte != input.ResponseByte || (this.ResponseByte != null && !this.ResponseByte.Equals(input.ResponseByte))) return false;
            if (this.Sessions != input.Sessions || (this.Sessions != null && !this.Sessions.Equals(input.Sessions))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && !this.Tags.Equals(input.Tags))) return false;
            if (this.SrcIp != input.SrcIp || (this.SrcIp != null && input.SrcIp != null && !this.SrcIp.SequenceEqual(input.SrcIp))) return false;
            if (this.DstIp != input.DstIp || (this.DstIp != null && input.DstIp != null && !this.DstIp.SequenceEqual(input.DstIp))) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;

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
                if (this.Apps != null) hashCode = hashCode * 59 + this.Apps.GetHashCode();
                if (this.AssociateInstanceType != null) hashCode = hashCode * 59 + this.AssociateInstanceType.GetHashCode();
                if (this.DeviceName != null) hashCode = hashCode * 59 + this.DeviceName.GetHashCode();
                if (this.Item != null) hashCode = hashCode * 59 + this.Item.GetHashCode();
                if (this.LastTime != null) hashCode = hashCode * 59 + this.LastTime.GetHashCode();
                if (this.Ports != null) hashCode = hashCode * 59 + this.Ports.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.RequestByte != null) hashCode = hashCode * 59 + this.RequestByte.GetHashCode();
                if (this.ResponseByte != null) hashCode = hashCode * 59 + this.ResponseByte.GetHashCode();
                if (this.Sessions != null) hashCode = hashCode * 59 + this.Sessions.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.SrcIp != null) hashCode = hashCode * 59 + this.SrcIp.GetHashCode();
                if (this.DstIp != null) hashCode = hashCode * 59 + this.DstIp.GetHashCode();
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                return hashCode;
            }
        }
    }
}
