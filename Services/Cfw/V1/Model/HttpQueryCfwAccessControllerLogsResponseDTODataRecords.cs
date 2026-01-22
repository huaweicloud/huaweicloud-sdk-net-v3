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
    public class HttpQueryCfwAccessControllerLogsResponseDTODataRecords 
    {

        /// <summary>
        /// 动作0：permit，1：deny
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleName { get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleId { get; set; }

        /// <summary>
        /// 命中时间，以毫秒为单位的时间戳，如1718936272648
        /// </summary>
        [JsonProperty("hit_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? HitTime { get; set; }

        /// <summary>
        /// 源区域id
        /// </summary>
        [JsonProperty("src_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcRegionId { get; set; }

        /// <summary>
        /// 源区域name
        /// </summary>
        [JsonProperty("src_region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcRegionName { get; set; }

        /// <summary>
        /// 目的区域id
        /// </summary>
        [JsonProperty("dst_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DstRegionId { get; set; }

        /// <summary>
        /// 目的区域name
        /// </summary>
        [JsonProperty("dst_region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DstRegionName { get; set; }

        /// <summary>
        /// 文档ID
        /// </summary>
        [JsonProperty("log_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogId { get; set; }

        /// <summary>
        /// 源IP
        /// </summary>
        [JsonProperty("src_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcIp { get; set; }

        /// <summary>
        /// 源端口
        /// </summary>
        [JsonProperty("src_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? SrcPort { get; set; }

        /// <summary>
        /// 目的IP
        /// </summary>
        [JsonProperty("dst_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DstIp { get; set; }

        /// <summary>
        /// 目的端口
        /// </summary>
        [JsonProperty("dst_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? DstPort { get; set; }

        /// <summary>
        /// 协议类型:TCP为6,UDP为17,ICMP为1,ICMPV6为58,ANY为-1,手动类型不为空，自动类型为空
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// 规则应用类型包括：“HTTP”，“HTTPS”，“TLS1”，“DNS”，“SSH”，“MYSQL”，“SMTP”，“RDP”，“RDPS”，“VNC”，“POP3”，“IMAP4”，“SMTPS”，“POP3S”，“FTPS”，“ANY”，“BGP”等。
        /// </summary>
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// 目标主机
        /// </summary>
        [JsonProperty("dst_host", NullValueHandling = NullValueHandling.Ignore)]
        public string DstHost { get; set; }

        /// <summary>
        /// 源省份id
        /// </summary>
        [JsonProperty("src_province_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcProvinceId { get; set; }

        /// <summary>
        /// 源省份名称
        /// </summary>
        [JsonProperty("src_province_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcProvinceName { get; set; }

        /// <summary>
        /// 源城市id
        /// </summary>
        [JsonProperty("src_city_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcCityId { get; set; }

        /// <summary>
        /// 源城市名称
        /// </summary>
        [JsonProperty("src_city_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcCityName { get; set; }

        /// <summary>
        /// 目的省份id
        /// </summary>
        [JsonProperty("dst_province_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DstProvinceId { get; set; }

        /// <summary>
        /// 目的省份名称
        /// </summary>
        [JsonProperty("dst_province_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DstProvinceName { get; set; }

        /// <summary>
        /// 目的城市id
        /// </summary>
        [JsonProperty("dst_city_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DstCityId { get; set; }

        /// <summary>
        /// 目的城市名称
        /// </summary>
        [JsonProperty("dst_city_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DstCityName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpQueryCfwAccessControllerLogsResponseDTODataRecords {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  ruleName: ").Append(RuleName).Append("\n");
            sb.Append("  ruleId: ").Append(RuleId).Append("\n");
            sb.Append("  hitTime: ").Append(HitTime).Append("\n");
            sb.Append("  srcRegionId: ").Append(SrcRegionId).Append("\n");
            sb.Append("  srcRegionName: ").Append(SrcRegionName).Append("\n");
            sb.Append("  dstRegionId: ").Append(DstRegionId).Append("\n");
            sb.Append("  dstRegionName: ").Append(DstRegionName).Append("\n");
            sb.Append("  logId: ").Append(LogId).Append("\n");
            sb.Append("  srcIp: ").Append(SrcIp).Append("\n");
            sb.Append("  srcPort: ").Append(SrcPort).Append("\n");
            sb.Append("  dstIp: ").Append(DstIp).Append("\n");
            sb.Append("  dstPort: ").Append(DstPort).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  dstHost: ").Append(DstHost).Append("\n");
            sb.Append("  srcProvinceId: ").Append(SrcProvinceId).Append("\n");
            sb.Append("  srcProvinceName: ").Append(SrcProvinceName).Append("\n");
            sb.Append("  srcCityId: ").Append(SrcCityId).Append("\n");
            sb.Append("  srcCityName: ").Append(SrcCityName).Append("\n");
            sb.Append("  dstProvinceId: ").Append(DstProvinceId).Append("\n");
            sb.Append("  dstProvinceName: ").Append(DstProvinceName).Append("\n");
            sb.Append("  dstCityId: ").Append(DstCityId).Append("\n");
            sb.Append("  dstCityName: ").Append(DstCityName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HttpQueryCfwAccessControllerLogsResponseDTODataRecords);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HttpQueryCfwAccessControllerLogsResponseDTODataRecords input)
        {
            if (input == null) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.RuleName != input.RuleName || (this.RuleName != null && !this.RuleName.Equals(input.RuleName))) return false;
            if (this.RuleId != input.RuleId || (this.RuleId != null && !this.RuleId.Equals(input.RuleId))) return false;
            if (this.HitTime != input.HitTime || (this.HitTime != null && !this.HitTime.Equals(input.HitTime))) return false;
            if (this.SrcRegionId != input.SrcRegionId || (this.SrcRegionId != null && !this.SrcRegionId.Equals(input.SrcRegionId))) return false;
            if (this.SrcRegionName != input.SrcRegionName || (this.SrcRegionName != null && !this.SrcRegionName.Equals(input.SrcRegionName))) return false;
            if (this.DstRegionId != input.DstRegionId || (this.DstRegionId != null && !this.DstRegionId.Equals(input.DstRegionId))) return false;
            if (this.DstRegionName != input.DstRegionName || (this.DstRegionName != null && !this.DstRegionName.Equals(input.DstRegionName))) return false;
            if (this.LogId != input.LogId || (this.LogId != null && !this.LogId.Equals(input.LogId))) return false;
            if (this.SrcIp != input.SrcIp || (this.SrcIp != null && !this.SrcIp.Equals(input.SrcIp))) return false;
            if (this.SrcPort != input.SrcPort || (this.SrcPort != null && !this.SrcPort.Equals(input.SrcPort))) return false;
            if (this.DstIp != input.DstIp || (this.DstIp != null && !this.DstIp.Equals(input.DstIp))) return false;
            if (this.DstPort != input.DstPort || (this.DstPort != null && !this.DstPort.Equals(input.DstPort))) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;
            if (this.App != input.App || (this.App != null && !this.App.Equals(input.App))) return false;
            if (this.DstHost != input.DstHost || (this.DstHost != null && !this.DstHost.Equals(input.DstHost))) return false;
            if (this.SrcProvinceId != input.SrcProvinceId || (this.SrcProvinceId != null && !this.SrcProvinceId.Equals(input.SrcProvinceId))) return false;
            if (this.SrcProvinceName != input.SrcProvinceName || (this.SrcProvinceName != null && !this.SrcProvinceName.Equals(input.SrcProvinceName))) return false;
            if (this.SrcCityId != input.SrcCityId || (this.SrcCityId != null && !this.SrcCityId.Equals(input.SrcCityId))) return false;
            if (this.SrcCityName != input.SrcCityName || (this.SrcCityName != null && !this.SrcCityName.Equals(input.SrcCityName))) return false;
            if (this.DstProvinceId != input.DstProvinceId || (this.DstProvinceId != null && !this.DstProvinceId.Equals(input.DstProvinceId))) return false;
            if (this.DstProvinceName != input.DstProvinceName || (this.DstProvinceName != null && !this.DstProvinceName.Equals(input.DstProvinceName))) return false;
            if (this.DstCityId != input.DstCityId || (this.DstCityId != null && !this.DstCityId.Equals(input.DstCityId))) return false;
            if (this.DstCityName != input.DstCityName || (this.DstCityName != null && !this.DstCityName.Equals(input.DstCityName))) return false;

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
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.RuleName != null) hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                if (this.RuleId != null) hashCode = hashCode * 59 + this.RuleId.GetHashCode();
                if (this.HitTime != null) hashCode = hashCode * 59 + this.HitTime.GetHashCode();
                if (this.SrcRegionId != null) hashCode = hashCode * 59 + this.SrcRegionId.GetHashCode();
                if (this.SrcRegionName != null) hashCode = hashCode * 59 + this.SrcRegionName.GetHashCode();
                if (this.DstRegionId != null) hashCode = hashCode * 59 + this.DstRegionId.GetHashCode();
                if (this.DstRegionName != null) hashCode = hashCode * 59 + this.DstRegionName.GetHashCode();
                if (this.LogId != null) hashCode = hashCode * 59 + this.LogId.GetHashCode();
                if (this.SrcIp != null) hashCode = hashCode * 59 + this.SrcIp.GetHashCode();
                if (this.SrcPort != null) hashCode = hashCode * 59 + this.SrcPort.GetHashCode();
                if (this.DstIp != null) hashCode = hashCode * 59 + this.DstIp.GetHashCode();
                if (this.DstPort != null) hashCode = hashCode * 59 + this.DstPort.GetHashCode();
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.App != null) hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.DstHost != null) hashCode = hashCode * 59 + this.DstHost.GetHashCode();
                if (this.SrcProvinceId != null) hashCode = hashCode * 59 + this.SrcProvinceId.GetHashCode();
                if (this.SrcProvinceName != null) hashCode = hashCode * 59 + this.SrcProvinceName.GetHashCode();
                if (this.SrcCityId != null) hashCode = hashCode * 59 + this.SrcCityId.GetHashCode();
                if (this.SrcCityName != null) hashCode = hashCode * 59 + this.SrcCityName.GetHashCode();
                if (this.DstProvinceId != null) hashCode = hashCode * 59 + this.DstProvinceId.GetHashCode();
                if (this.DstProvinceName != null) hashCode = hashCode * 59 + this.DstProvinceName.GetHashCode();
                if (this.DstCityId != null) hashCode = hashCode * 59 + this.DstCityId.GetHashCode();
                if (this.DstCityName != null) hashCode = hashCode * 59 + this.DstCityName.GetHashCode();
                return hashCode;
            }
        }
    }
}
