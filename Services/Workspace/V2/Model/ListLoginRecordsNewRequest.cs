using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListLoginRecordsNewRequest 
    {

        /// <summary>
        /// 查询的起始时间。指定该参数后，返回的结果为此时间之后的所有登录记录。时间格式如：“2016-08-20T21:11Z”。终止时间不为空时，起始时间为必填参数。
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 查询的终止时间。指定该参数后，返回的结果为此时间之前的所有登录记录。时间格式如：“2016-08-20T21:11Z”。起始时间不为空时，终止时间为必填参数。
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 登录桌面的用户名。
        /// </summary>
        [SDKProperty("user_name", IsQuery = true)]
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 计算机名（操作系统信息中可见）。
        /// </summary>
        [SDKProperty("computer_name", IsQuery = true)]
        [JsonProperty("computer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ComputerName { get; set; }

        /// <summary>
        /// 登录桌面的终端系统类型，当前支持：WI（云桌面客户端）。
        /// </summary>
        [SDKProperty("terminal_type", IsQuery = true)]
        [JsonProperty("terminal_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TerminalType { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 终端出口IP。
        /// </summary>
        [SDKProperty("public_ip", IsQuery = true)]
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIp { get; set; }

        /// <summary>
        /// 用于分页查询，查询的起始记录序号，从0开始。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 用于分页查询，返回登录记录数量限制,取值范围0-1000。如果不指定，默认为20。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 查询端到端时延的最小值。
        /// </summary>
        [SDKProperty("min_network_rtt", IsQuery = true)]
        [JsonProperty("min_network_rtt", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinNetworkRtt { get; set; }

        /// <summary>
        /// 查询端到端时延的最大值。
        /// </summary>
        [SDKProperty("max_network_rtt", IsQuery = true)]
        [JsonProperty("max_network_rtt", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxNetworkRtt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListLoginRecordsNewRequest {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  computerName: ").Append(ComputerName).Append("\n");
            sb.Append("  terminalType: ").Append(TerminalType).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  minNetworkRtt: ").Append(MinNetworkRtt).Append("\n");
            sb.Append("  maxNetworkRtt: ").Append(MaxNetworkRtt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListLoginRecordsNewRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListLoginRecordsNewRequest input)
        {
            if (input == null) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.ComputerName != input.ComputerName || (this.ComputerName != null && !this.ComputerName.Equals(input.ComputerName))) return false;
            if (this.TerminalType != input.TerminalType || (this.TerminalType != null && !this.TerminalType.Equals(input.TerminalType))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.PublicIp != input.PublicIp || (this.PublicIp != null && !this.PublicIp.Equals(input.PublicIp))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.MinNetworkRtt != input.MinNetworkRtt || (this.MinNetworkRtt != null && !this.MinNetworkRtt.Equals(input.MinNetworkRtt))) return false;
            if (this.MaxNetworkRtt != input.MaxNetworkRtt || (this.MaxNetworkRtt != null && !this.MaxNetworkRtt.Equals(input.MaxNetworkRtt))) return false;

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
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.ComputerName != null) hashCode = hashCode * 59 + this.ComputerName.GetHashCode();
                if (this.TerminalType != null) hashCode = hashCode * 59 + this.TerminalType.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.PublicIp != null) hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.MinNetworkRtt != null) hashCode = hashCode * 59 + this.MinNetworkRtt.GetHashCode();
                if (this.MaxNetworkRtt != null) hashCode = hashCode * 59 + this.MaxNetworkRtt.GetHashCode();
                return hashCode;
            }
        }
    }
}
