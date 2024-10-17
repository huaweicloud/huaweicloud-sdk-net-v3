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
    /// Request Object
    /// </summary>
    public class ListFlowLogsRequest 
    {
        /// <summary>
        /// 日志类型包括：internet，vpc，nat
        /// </summary>
        /// <value>日志类型包括：internet，vpc，nat</value>
        [JsonConverter(typeof(EnumClassConverter<LogTypeEnum>))]
        public class LogTypeEnum
        {
            /// <summary>
            /// Enum INTERNET for value: internet
            /// </summary>
            public static readonly LogTypeEnum INTERNET = new LogTypeEnum("internet");

            /// <summary>
            /// Enum VPC for value: vpc
            /// </summary>
            public static readonly LogTypeEnum VPC = new LogTypeEnum("vpc");

            /// <summary>
            /// Enum NAT for value: nat
            /// </summary>
            public static readonly LogTypeEnum NAT = new LogTypeEnum("nat");

            private static readonly Dictionary<string, LogTypeEnum> StaticFields =
            new Dictionary<string, LogTypeEnum>()
            {
                { "internet", INTERNET },
                { "vpc", VPC },
                { "nat", NAT },
            };

            private string _value;

            public LogTypeEnum()
            {

            }

            public LogTypeEnum(string value)
            {
                _value = value;
            }

            public static LogTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as LogTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LogTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LogTypeEnum a, LogTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(LogTypeEnum a, LogTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 防火墙实例id，创建云防火墙后用于标志防火墙由系统自动生成的标志id，可通过调用[查询防火墙实例接口](ListFirewallDetail.xml)。
        /// </summary>
        [SDKProperty("fw_instance_id", IsQuery = true)]
        [JsonProperty("fw_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceId { get; set; }

        /// <summary>
        /// 方向，包含in2out，out2in
        /// </summary>
        [SDKProperty("direction", IsQuery = true)]
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// 日志类型包括：internet，vpc，nat
        /// </summary>
        [SDKProperty("log_type", IsQuery = true)]
        [JsonProperty("log_type", NullValueHandling = NullValueHandling.Ignore)]
        public LogTypeEnum LogType { get; set; }
        /// <summary>
        /// 开始时间，以毫秒为单位的时间戳，如1718936272648
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 结束时间，以毫秒为单位的时间戳，如1718936272648
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 源IP
        /// </summary>
        [SDKProperty("src_ip", IsQuery = true)]
        [JsonProperty("src_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcIp { get; set; }

        /// <summary>
        /// 源端口
        /// </summary>
        [SDKProperty("src_port", IsQuery = true)]
        [JsonProperty("src_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? SrcPort { get; set; }

        /// <summary>
        /// 目的IP
        /// </summary>
        [SDKProperty("dst_ip", IsQuery = true)]
        [JsonProperty("dst_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DstIp { get; set; }

        /// <summary>
        /// 目的端口
        /// </summary>
        [SDKProperty("dst_port", IsQuery = true)]
        [JsonProperty("dst_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? DstPort { get; set; }

        /// <summary>
        /// 协议类型，包含TCP, UDP,ICMP,ICMPV6等。
        /// </summary>
        [SDKProperty("protocol", IsQuery = true)]
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// 应用协议
        /// </summary>
        [SDKProperty("app", IsQuery = true)]
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// 文档ID,第一页为空，其他页不为空，其他页可取上一次查询最后一条数据的log_id
        /// </summary>
        [SDKProperty("log_id", IsQuery = true)]
        [JsonProperty("log_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogId { get; set; }

        /// <summary>
        /// 下个日期，当是第一页时为空，不是第一页时不为空，其他页可取上一次查询最后一条数据的start_time
        /// </summary>
        [SDKProperty("next_date", IsQuery = true)]
        [JsonProperty("next_date", NullValueHandling = NullValueHandling.Ignore)]
        public long? NextDate { get; set; }

        /// <summary>
        /// 偏移量：指定返回记录的开始位置，必须为数字，取值范围为大于0，首页时为空，非首页时不为空
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页显示个数，范围为1-1024
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 企业项目id，用户支持企业项目后，由企业项目生成的id。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 目的主机
        /// </summary>
        [SDKProperty("dst_host", IsQuery = true)]
        [JsonProperty("dst_host", NullValueHandling = NullValueHandling.Ignore)]
        public string DstHost { get; set; }

        /// <summary>
        /// 源region名称
        /// </summary>
        [SDKProperty("src_region_name", IsQuery = true)]
        [JsonProperty("src_region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcRegionName { get; set; }

        /// <summary>
        /// 目的region名称
        /// </summary>
        [SDKProperty("dst_region_name", IsQuery = true)]
        [JsonProperty("dst_region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DstRegionName { get; set; }

        /// <summary>
        /// 源省份名称
        /// </summary>
        [SDKProperty("src_province_name", IsQuery = true)]
        [JsonProperty("src_province_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcProvinceName { get; set; }

        /// <summary>
        /// 目的省份名称
        /// </summary>
        [SDKProperty("dst_province_name", IsQuery = true)]
        [JsonProperty("dst_province_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DstProvinceName { get; set; }

        /// <summary>
        /// 源城市名称
        /// </summary>
        [SDKProperty("src_city_name", IsQuery = true)]
        [JsonProperty("src_city_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcCityName { get; set; }

        /// <summary>
        /// 目的城市名称
        /// </summary>
        [SDKProperty("dst_city_name", IsQuery = true)]
        [JsonProperty("dst_city_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DstCityName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFlowLogsRequest {\n");
            sb.Append("  fwInstanceId: ").Append(FwInstanceId).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  logType: ").Append(LogType).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  srcIp: ").Append(SrcIp).Append("\n");
            sb.Append("  srcPort: ").Append(SrcPort).Append("\n");
            sb.Append("  dstIp: ").Append(DstIp).Append("\n");
            sb.Append("  dstPort: ").Append(DstPort).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  logId: ").Append(LogId).Append("\n");
            sb.Append("  nextDate: ").Append(NextDate).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  dstHost: ").Append(DstHost).Append("\n");
            sb.Append("  srcRegionName: ").Append(SrcRegionName).Append("\n");
            sb.Append("  dstRegionName: ").Append(DstRegionName).Append("\n");
            sb.Append("  srcProvinceName: ").Append(SrcProvinceName).Append("\n");
            sb.Append("  dstProvinceName: ").Append(DstProvinceName).Append("\n");
            sb.Append("  srcCityName: ").Append(SrcCityName).Append("\n");
            sb.Append("  dstCityName: ").Append(DstCityName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFlowLogsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFlowLogsRequest input)
        {
            if (input == null) return false;
            if (this.FwInstanceId != input.FwInstanceId || (this.FwInstanceId != null && !this.FwInstanceId.Equals(input.FwInstanceId))) return false;
            if (this.Direction != input.Direction || (this.Direction != null && !this.Direction.Equals(input.Direction))) return false;
            if (this.LogType != input.LogType) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.SrcIp != input.SrcIp || (this.SrcIp != null && !this.SrcIp.Equals(input.SrcIp))) return false;
            if (this.SrcPort != input.SrcPort || (this.SrcPort != null && !this.SrcPort.Equals(input.SrcPort))) return false;
            if (this.DstIp != input.DstIp || (this.DstIp != null && !this.DstIp.Equals(input.DstIp))) return false;
            if (this.DstPort != input.DstPort || (this.DstPort != null && !this.DstPort.Equals(input.DstPort))) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;
            if (this.App != input.App || (this.App != null && !this.App.Equals(input.App))) return false;
            if (this.LogId != input.LogId || (this.LogId != null && !this.LogId.Equals(input.LogId))) return false;
            if (this.NextDate != input.NextDate || (this.NextDate != null && !this.NextDate.Equals(input.NextDate))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.DstHost != input.DstHost || (this.DstHost != null && !this.DstHost.Equals(input.DstHost))) return false;
            if (this.SrcRegionName != input.SrcRegionName || (this.SrcRegionName != null && !this.SrcRegionName.Equals(input.SrcRegionName))) return false;
            if (this.DstRegionName != input.DstRegionName || (this.DstRegionName != null && !this.DstRegionName.Equals(input.DstRegionName))) return false;
            if (this.SrcProvinceName != input.SrcProvinceName || (this.SrcProvinceName != null && !this.SrcProvinceName.Equals(input.SrcProvinceName))) return false;
            if (this.DstProvinceName != input.DstProvinceName || (this.DstProvinceName != null && !this.DstProvinceName.Equals(input.DstProvinceName))) return false;
            if (this.SrcCityName != input.SrcCityName || (this.SrcCityName != null && !this.SrcCityName.Equals(input.SrcCityName))) return false;
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
                if (this.FwInstanceId != null) hashCode = hashCode * 59 + this.FwInstanceId.GetHashCode();
                if (this.Direction != null) hashCode = hashCode * 59 + this.Direction.GetHashCode();
                hashCode = hashCode * 59 + this.LogType.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.SrcIp != null) hashCode = hashCode * 59 + this.SrcIp.GetHashCode();
                if (this.SrcPort != null) hashCode = hashCode * 59 + this.SrcPort.GetHashCode();
                if (this.DstIp != null) hashCode = hashCode * 59 + this.DstIp.GetHashCode();
                if (this.DstPort != null) hashCode = hashCode * 59 + this.DstPort.GetHashCode();
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.App != null) hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.LogId != null) hashCode = hashCode * 59 + this.LogId.GetHashCode();
                if (this.NextDate != null) hashCode = hashCode * 59 + this.NextDate.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.DstHost != null) hashCode = hashCode * 59 + this.DstHost.GetHashCode();
                if (this.SrcRegionName != null) hashCode = hashCode * 59 + this.SrcRegionName.GetHashCode();
                if (this.DstRegionName != null) hashCode = hashCode * 59 + this.DstRegionName.GetHashCode();
                if (this.SrcProvinceName != null) hashCode = hashCode * 59 + this.SrcProvinceName.GetHashCode();
                if (this.DstProvinceName != null) hashCode = hashCode * 59 + this.DstProvinceName.GetHashCode();
                if (this.SrcCityName != null) hashCode = hashCode * 59 + this.SrcCityName.GetHashCode();
                if (this.DstCityName != null) hashCode = hashCode * 59 + this.DstCityName.GetHashCode();
                return hashCode;
            }
        }
    }
}
