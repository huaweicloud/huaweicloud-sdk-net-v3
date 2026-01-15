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
    public class ExportUserConnectionNewRequest 
    {

        /// <summary>
        /// 查询的起始时间。指定该参数后，返回的结果为此时间之后的所有登录记录。时间格式如：“2016-08-20T21:11:11Z”。终止时间不为空时，起始时间为非必填项。开始时间要在最近30天内。
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 查询的终止时间。指定该参数后，返回的结果为此时间之前的所有登录记录。时间格式如：“2016-08-20T21:11:11Z”。起始时间不为空时，起始时间为非必填项。结束时间要在最近30天内。
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
        /// 登录桌面的终端系统类型，该字段支持模糊查询，例如：Windows 10。
        /// </summary>
        [SDKProperty("terminal_type", IsQuery = true)]
        [JsonProperty("terminal_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TerminalType { get; set; }

        /// <summary>
        /// 导出语言，默认英文。 - zh_CN：中文 - en_US：英文
        /// </summary>
        [SDKProperty("language", IsQuery = true)]
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// 查询端到端时延的最小值。
        /// </summary>
        [SDKProperty("min_e2e_rtt", IsQuery = true)]
        [JsonProperty("min_e2e_rtt", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinE2eRtt { get; set; }

        /// <summary>
        /// 查询端到端时延的最大值。
        /// </summary>
        [SDKProperty("max_e2e_rtt", IsQuery = true)]
        [JsonProperty("max_e2e_rtt", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxE2eRtt { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 客户端出口IP。
        /// </summary>
        [SDKProperty("public_ip", IsQuery = true)]
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportUserConnectionNewRequest {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  computerName: ").Append(ComputerName).Append("\n");
            sb.Append("  terminalType: ").Append(TerminalType).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  minE2eRtt: ").Append(MinE2eRtt).Append("\n");
            sb.Append("  maxE2eRtt: ").Append(MaxE2eRtt).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExportUserConnectionNewRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExportUserConnectionNewRequest input)
        {
            if (input == null) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.ComputerName != input.ComputerName || (this.ComputerName != null && !this.ComputerName.Equals(input.ComputerName))) return false;
            if (this.TerminalType != input.TerminalType || (this.TerminalType != null && !this.TerminalType.Equals(input.TerminalType))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.MinE2eRtt != input.MinE2eRtt || (this.MinE2eRtt != null && !this.MinE2eRtt.Equals(input.MinE2eRtt))) return false;
            if (this.MaxE2eRtt != input.MaxE2eRtt || (this.MaxE2eRtt != null && !this.MaxE2eRtt.Equals(input.MaxE2eRtt))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.PublicIp != input.PublicIp || (this.PublicIp != null && !this.PublicIp.Equals(input.PublicIp))) return false;

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
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.MinE2eRtt != null) hashCode = hashCode * 59 + this.MinE2eRtt.GetHashCode();
                if (this.MaxE2eRtt != null) hashCode = hashCode * 59 + this.MaxE2eRtt.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.PublicIp != null) hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
