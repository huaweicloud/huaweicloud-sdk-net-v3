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
    public class LogVO 
    {

        /// <summary>
        /// **参数解释**： 应用 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// **参数解释**： 流字节数，流量日志字段 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("bytes", NullValueHandling = NullValueHandling.Ignore)]
        public double? Bytes { get; set; }

        /// <summary>
        /// **参数解释**： 会话方向 **取值范围**： out2in 外到内访问 in2out 内到外访问
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// **参数解释**： 流字节数，访问控制日志和流量日志中存在 **取值范围**： 目的网址
        /// </summary>
        [JsonProperty("dst_host", NullValueHandling = NullValueHandling.Ignore)]
        public string DstHost { get; set; }

        /// <summary>
        /// **参数解释**： 目的IP **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DstIp { get; set; }

        /// <summary>
        /// **参数解释**： 目的端口 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? DstPort { get; set; }

        /// <summary>
        /// **参数解释**： 会话结束时间，流量日志字段 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// **参数解释**： 日志ID，用于分页查询 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("log_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogId { get; set; }

        /// <summary>
        /// **参数解释**： 流包数，流量日志字段 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("packets", NullValueHandling = NullValueHandling.Ignore)]
        public double? Packets { get; set; }

        /// <summary>
        /// **参数解释**： 协议 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// **参数解释**： 源Ip **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcIp { get; set; }

        /// <summary>
        /// **参数解释**： 源端口 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? SrcPort { get; set; }

        /// <summary>
        /// **参数解释**： 会话开始时间，流量日志字段 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// **参数解释**： 目的地区ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public Object DstRegionId { get; set; }

        /// <summary>
        /// **参数解释**： 目的地区名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DstRegionName { get; set; }

        /// <summary>
        /// **参数解释**： 目的省份ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_province_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DstProvinceId { get; set; }

        /// <summary>
        /// **参数解释**： 目的省份名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_province_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DstProvinceName { get; set; }

        /// <summary>
        /// **参数解释**： 目的城市ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_city_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DstCityId { get; set; }

        /// <summary>
        /// **参数解释**： 目的城市名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_city_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DstCityName { get; set; }

        /// <summary>
        /// **参数解释**： 源地区ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcRegionId { get; set; }

        /// <summary>
        /// **参数解释**： 源地区名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcRegionName { get; set; }

        /// <summary>
        /// **参数解释**： 源省份ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_province_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcProvinceId { get; set; }

        /// <summary>
        /// **参数解释**： 源省份名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_province_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcProvinceName { get; set; }

        /// <summary>
        /// **参数解释**： 源城市ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_city_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcCityId { get; set; }

        /// <summary>
        /// **参数解释**： 源城市名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_city_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcCityName { get; set; }

        /// <summary>
        /// **参数解释**： 虚拟网关ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("vgw_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VgwId { get; set; }

        /// <summary>
        /// **参数解释**： sctp验证标签，流量日志字段 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("sctp_verification_tag", NullValueHandling = NullValueHandling.Ignore)]
        public long? SctpVerificationTag { get; set; }

        /// <summary>
        /// **参数解释**： sctp握手流，流量日志字段 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("sctp_is_handshake_flow", NullValueHandling = NullValueHandling.Ignore)]
        public string SctpIsHandshakeFlow { get; set; }

        /// <summary>
        /// **参数解释**： qos规则ID，流量日志、访问控制日志存在 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("qos_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QosRuleId { get; set; }

        /// <summary>
        /// **参数解释**： qos规则名称，流量日志、访问控制日志存在 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("qos_rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string QosRuleName { get; set; }

        /// <summary>
        /// **参数解释**： qos通道ID，流量日志字段 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("qos_channel_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QosChannelId { get; set; }

        /// <summary>
        /// **参数解释**： qos通道名称，流量日志字段 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("qos_channel_name", NullValueHandling = NullValueHandling.Ignore)]
        public string QosChannelName { get; set; }

        /// <summary>
        /// **参数解释**： qos丢包数，流量日志字段 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("qos_drop_packets", NullValueHandling = NullValueHandling.Ignore)]
        public double? QosDropPackets { get; set; }

        /// <summary>
        /// **参数解释**： qos丢弃字节，流量日志字段 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("qos_drop_bytes", NullValueHandling = NullValueHandling.Ignore)]
        public double? QosDropBytes { get; set; }

        /// <summary>
        /// **参数解释**： qos规则类型，流量日志、访问控制日志存在 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("qos_rule_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? QosRuleType { get; set; }

        /// <summary>
        /// **参数解释**： qos通道类型，流量日志字段 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("qos_channel_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? QosChannelType { get; set; }

        /// <summary>
        /// **参数解释**： 动作，攻击日志、访问控制日志、URL日志存在 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// **参数解释**： url，URL日志字段 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// **参数解释**： 命中时间，访问控制日志、URL日志存在 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("hit_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? HitTime { get; set; }

        /// <summary>
        /// **参数解释**： 规则ID，访问控制日志、URL日志存在 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleId { get; set; }

        /// <summary>
        /// **参数解释**： 规则名称，访问控制日志、URL日志存在 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleName { get; set; }

        /// <summary>
        /// **参数解释**： 规则类型，访问控制日志和URL日志字段 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("rule_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? RuleType { get; set; }

        /// <summary>
        /// **参数解释**： 规则类型，攻击日志字段 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("attack_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string AttackRule { get; set; }

        /// <summary>
        /// **参数解释**： 攻击规则ID，攻击日志字段 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("attack_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttackRuleId { get; set; }

        /// <summary>
        /// **参数解释**： 攻击类型，攻击日志字段 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("attack_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AttackType { get; set; }

        /// <summary>
        /// **参数解释**： 事件时间，攻击日志字段 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("event_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EventTime { get; set; }

        /// <summary>
        /// **参数解释**： 攻击等级，攻击日志字段 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }

        /// <summary>
        /// **参数解释**： 规则载荷，攻击日志字段 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("packet", NullValueHandling = NullValueHandling.Ignore)]
        public string Packet { get; set; }

        /// <summary>
        /// **参数解释**： 攻击来源，攻击日志字段 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// **参数解释**： 真实IP，攻击日志字段 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("real_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string RealIp { get; set; }

        /// <summary>
        /// **参数解释**： 标签类型，攻击日志字段 **取值范围**： 1 WAF回源IP
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public int? Tag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogVO {\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  bytes: ").Append(Bytes).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  dstHost: ").Append(DstHost).Append("\n");
            sb.Append("  dstIp: ").Append(DstIp).Append("\n");
            sb.Append("  dstPort: ").Append(DstPort).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  logId: ").Append(LogId).Append("\n");
            sb.Append("  packets: ").Append(Packets).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  srcIp: ").Append(SrcIp).Append("\n");
            sb.Append("  srcPort: ").Append(SrcPort).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  dstRegionId: ").Append(DstRegionId).Append("\n");
            sb.Append("  dstRegionName: ").Append(DstRegionName).Append("\n");
            sb.Append("  dstProvinceId: ").Append(DstProvinceId).Append("\n");
            sb.Append("  dstProvinceName: ").Append(DstProvinceName).Append("\n");
            sb.Append("  dstCityId: ").Append(DstCityId).Append("\n");
            sb.Append("  dstCityName: ").Append(DstCityName).Append("\n");
            sb.Append("  srcRegionId: ").Append(SrcRegionId).Append("\n");
            sb.Append("  srcRegionName: ").Append(SrcRegionName).Append("\n");
            sb.Append("  srcProvinceId: ").Append(SrcProvinceId).Append("\n");
            sb.Append("  srcProvinceName: ").Append(SrcProvinceName).Append("\n");
            sb.Append("  srcCityId: ").Append(SrcCityId).Append("\n");
            sb.Append("  srcCityName: ").Append(SrcCityName).Append("\n");
            sb.Append("  vgwId: ").Append(VgwId).Append("\n");
            sb.Append("  sctpVerificationTag: ").Append(SctpVerificationTag).Append("\n");
            sb.Append("  sctpIsHandshakeFlow: ").Append(SctpIsHandshakeFlow).Append("\n");
            sb.Append("  qosRuleId: ").Append(QosRuleId).Append("\n");
            sb.Append("  qosRuleName: ").Append(QosRuleName).Append("\n");
            sb.Append("  qosChannelId: ").Append(QosChannelId).Append("\n");
            sb.Append("  qosChannelName: ").Append(QosChannelName).Append("\n");
            sb.Append("  qosDropPackets: ").Append(QosDropPackets).Append("\n");
            sb.Append("  qosDropBytes: ").Append(QosDropBytes).Append("\n");
            sb.Append("  qosRuleType: ").Append(QosRuleType).Append("\n");
            sb.Append("  qosChannelType: ").Append(QosChannelType).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  hitTime: ").Append(HitTime).Append("\n");
            sb.Append("  ruleId: ").Append(RuleId).Append("\n");
            sb.Append("  ruleName: ").Append(RuleName).Append("\n");
            sb.Append("  ruleType: ").Append(RuleType).Append("\n");
            sb.Append("  attackRule: ").Append(AttackRule).Append("\n");
            sb.Append("  attackRuleId: ").Append(AttackRuleId).Append("\n");
            sb.Append("  attackType: ").Append(AttackType).Append("\n");
            sb.Append("  eventTime: ").Append(EventTime).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  packet: ").Append(Packet).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  realIp: ").Append(RealIp).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LogVO input)
        {
            if (input == null) return false;
            if (this.App != input.App || (this.App != null && !this.App.Equals(input.App))) return false;
            if (this.Bytes != input.Bytes || (this.Bytes != null && !this.Bytes.Equals(input.Bytes))) return false;
            if (this.Direction != input.Direction || (this.Direction != null && !this.Direction.Equals(input.Direction))) return false;
            if (this.DstHost != input.DstHost || (this.DstHost != null && !this.DstHost.Equals(input.DstHost))) return false;
            if (this.DstIp != input.DstIp || (this.DstIp != null && !this.DstIp.Equals(input.DstIp))) return false;
            if (this.DstPort != input.DstPort || (this.DstPort != null && !this.DstPort.Equals(input.DstPort))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.LogId != input.LogId || (this.LogId != null && !this.LogId.Equals(input.LogId))) return false;
            if (this.Packets != input.Packets || (this.Packets != null && !this.Packets.Equals(input.Packets))) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;
            if (this.SrcIp != input.SrcIp || (this.SrcIp != null && !this.SrcIp.Equals(input.SrcIp))) return false;
            if (this.SrcPort != input.SrcPort || (this.SrcPort != null && !this.SrcPort.Equals(input.SrcPort))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.DstRegionId != input.DstRegionId || (this.DstRegionId != null && !this.DstRegionId.Equals(input.DstRegionId))) return false;
            if (this.DstRegionName != input.DstRegionName || (this.DstRegionName != null && !this.DstRegionName.Equals(input.DstRegionName))) return false;
            if (this.DstProvinceId != input.DstProvinceId || (this.DstProvinceId != null && !this.DstProvinceId.Equals(input.DstProvinceId))) return false;
            if (this.DstProvinceName != input.DstProvinceName || (this.DstProvinceName != null && !this.DstProvinceName.Equals(input.DstProvinceName))) return false;
            if (this.DstCityId != input.DstCityId || (this.DstCityId != null && !this.DstCityId.Equals(input.DstCityId))) return false;
            if (this.DstCityName != input.DstCityName || (this.DstCityName != null && !this.DstCityName.Equals(input.DstCityName))) return false;
            if (this.SrcRegionId != input.SrcRegionId || (this.SrcRegionId != null && !this.SrcRegionId.Equals(input.SrcRegionId))) return false;
            if (this.SrcRegionName != input.SrcRegionName || (this.SrcRegionName != null && !this.SrcRegionName.Equals(input.SrcRegionName))) return false;
            if (this.SrcProvinceId != input.SrcProvinceId || (this.SrcProvinceId != null && !this.SrcProvinceId.Equals(input.SrcProvinceId))) return false;
            if (this.SrcProvinceName != input.SrcProvinceName || (this.SrcProvinceName != null && !this.SrcProvinceName.Equals(input.SrcProvinceName))) return false;
            if (this.SrcCityId != input.SrcCityId || (this.SrcCityId != null && !this.SrcCityId.Equals(input.SrcCityId))) return false;
            if (this.SrcCityName != input.SrcCityName || (this.SrcCityName != null && !this.SrcCityName.Equals(input.SrcCityName))) return false;
            if (this.VgwId != input.VgwId || (this.VgwId != null && !this.VgwId.Equals(input.VgwId))) return false;
            if (this.SctpVerificationTag != input.SctpVerificationTag || (this.SctpVerificationTag != null && !this.SctpVerificationTag.Equals(input.SctpVerificationTag))) return false;
            if (this.SctpIsHandshakeFlow != input.SctpIsHandshakeFlow || (this.SctpIsHandshakeFlow != null && !this.SctpIsHandshakeFlow.Equals(input.SctpIsHandshakeFlow))) return false;
            if (this.QosRuleId != input.QosRuleId || (this.QosRuleId != null && !this.QosRuleId.Equals(input.QosRuleId))) return false;
            if (this.QosRuleName != input.QosRuleName || (this.QosRuleName != null && !this.QosRuleName.Equals(input.QosRuleName))) return false;
            if (this.QosChannelId != input.QosChannelId || (this.QosChannelId != null && !this.QosChannelId.Equals(input.QosChannelId))) return false;
            if (this.QosChannelName != input.QosChannelName || (this.QosChannelName != null && !this.QosChannelName.Equals(input.QosChannelName))) return false;
            if (this.QosDropPackets != input.QosDropPackets || (this.QosDropPackets != null && !this.QosDropPackets.Equals(input.QosDropPackets))) return false;
            if (this.QosDropBytes != input.QosDropBytes || (this.QosDropBytes != null && !this.QosDropBytes.Equals(input.QosDropBytes))) return false;
            if (this.QosRuleType != input.QosRuleType || (this.QosRuleType != null && !this.QosRuleType.Equals(input.QosRuleType))) return false;
            if (this.QosChannelType != input.QosChannelType || (this.QosChannelType != null && !this.QosChannelType.Equals(input.QosChannelType))) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.HitTime != input.HitTime || (this.HitTime != null && !this.HitTime.Equals(input.HitTime))) return false;
            if (this.RuleId != input.RuleId || (this.RuleId != null && !this.RuleId.Equals(input.RuleId))) return false;
            if (this.RuleName != input.RuleName || (this.RuleName != null && !this.RuleName.Equals(input.RuleName))) return false;
            if (this.RuleType != input.RuleType || (this.RuleType != null && !this.RuleType.Equals(input.RuleType))) return false;
            if (this.AttackRule != input.AttackRule || (this.AttackRule != null && !this.AttackRule.Equals(input.AttackRule))) return false;
            if (this.AttackRuleId != input.AttackRuleId || (this.AttackRuleId != null && !this.AttackRuleId.Equals(input.AttackRuleId))) return false;
            if (this.AttackType != input.AttackType || (this.AttackType != null && !this.AttackType.Equals(input.AttackType))) return false;
            if (this.EventTime != input.EventTime || (this.EventTime != null && !this.EventTime.Equals(input.EventTime))) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;
            if (this.Packet != input.Packet || (this.Packet != null && !this.Packet.Equals(input.Packet))) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.RealIp != input.RealIp || (this.RealIp != null && !this.RealIp.Equals(input.RealIp))) return false;
            if (this.Tag != input.Tag || (this.Tag != null && !this.Tag.Equals(input.Tag))) return false;

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
                if (this.Direction != null) hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.DstHost != null) hashCode = hashCode * 59 + this.DstHost.GetHashCode();
                if (this.DstIp != null) hashCode = hashCode * 59 + this.DstIp.GetHashCode();
                if (this.DstPort != null) hashCode = hashCode * 59 + this.DstPort.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.LogId != null) hashCode = hashCode * 59 + this.LogId.GetHashCode();
                if (this.Packets != null) hashCode = hashCode * 59 + this.Packets.GetHashCode();
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.SrcIp != null) hashCode = hashCode * 59 + this.SrcIp.GetHashCode();
                if (this.SrcPort != null) hashCode = hashCode * 59 + this.SrcPort.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.DstRegionId != null) hashCode = hashCode * 59 + this.DstRegionId.GetHashCode();
                if (this.DstRegionName != null) hashCode = hashCode * 59 + this.DstRegionName.GetHashCode();
                if (this.DstProvinceId != null) hashCode = hashCode * 59 + this.DstProvinceId.GetHashCode();
                if (this.DstProvinceName != null) hashCode = hashCode * 59 + this.DstProvinceName.GetHashCode();
                if (this.DstCityId != null) hashCode = hashCode * 59 + this.DstCityId.GetHashCode();
                if (this.DstCityName != null) hashCode = hashCode * 59 + this.DstCityName.GetHashCode();
                if (this.SrcRegionId != null) hashCode = hashCode * 59 + this.SrcRegionId.GetHashCode();
                if (this.SrcRegionName != null) hashCode = hashCode * 59 + this.SrcRegionName.GetHashCode();
                if (this.SrcProvinceId != null) hashCode = hashCode * 59 + this.SrcProvinceId.GetHashCode();
                if (this.SrcProvinceName != null) hashCode = hashCode * 59 + this.SrcProvinceName.GetHashCode();
                if (this.SrcCityId != null) hashCode = hashCode * 59 + this.SrcCityId.GetHashCode();
                if (this.SrcCityName != null) hashCode = hashCode * 59 + this.SrcCityName.GetHashCode();
                if (this.VgwId != null) hashCode = hashCode * 59 + this.VgwId.GetHashCode();
                if (this.SctpVerificationTag != null) hashCode = hashCode * 59 + this.SctpVerificationTag.GetHashCode();
                if (this.SctpIsHandshakeFlow != null) hashCode = hashCode * 59 + this.SctpIsHandshakeFlow.GetHashCode();
                if (this.QosRuleId != null) hashCode = hashCode * 59 + this.QosRuleId.GetHashCode();
                if (this.QosRuleName != null) hashCode = hashCode * 59 + this.QosRuleName.GetHashCode();
                if (this.QosChannelId != null) hashCode = hashCode * 59 + this.QosChannelId.GetHashCode();
                if (this.QosChannelName != null) hashCode = hashCode * 59 + this.QosChannelName.GetHashCode();
                if (this.QosDropPackets != null) hashCode = hashCode * 59 + this.QosDropPackets.GetHashCode();
                if (this.QosDropBytes != null) hashCode = hashCode * 59 + this.QosDropBytes.GetHashCode();
                if (this.QosRuleType != null) hashCode = hashCode * 59 + this.QosRuleType.GetHashCode();
                if (this.QosChannelType != null) hashCode = hashCode * 59 + this.QosChannelType.GetHashCode();
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.HitTime != null) hashCode = hashCode * 59 + this.HitTime.GetHashCode();
                if (this.RuleId != null) hashCode = hashCode * 59 + this.RuleId.GetHashCode();
                if (this.RuleName != null) hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                if (this.RuleType != null) hashCode = hashCode * 59 + this.RuleType.GetHashCode();
                if (this.AttackRule != null) hashCode = hashCode * 59 + this.AttackRule.GetHashCode();
                if (this.AttackRuleId != null) hashCode = hashCode * 59 + this.AttackRuleId.GetHashCode();
                if (this.AttackType != null) hashCode = hashCode * 59 + this.AttackType.GetHashCode();
                if (this.EventTime != null) hashCode = hashCode * 59 + this.EventTime.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Packet != null) hashCode = hashCode * 59 + this.Packet.GetHashCode();
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.RealIp != null) hashCode = hashCode * 59 + this.RealIp.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                return hashCode;
            }
        }
    }
}
