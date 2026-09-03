using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AdvancedConfig 
    {

        /// <summary>
        /// 分块开关 1:打开 0：关闭，默认：打开
        /// </summary>
        [JsonProperty("blockEnable", NullValueHandling = NullValueHandling.Ignore)]
        public string BlockEnable { get; set; }

        /// <summary>
        /// 用例超时时间
        /// </summary>
        [JsonProperty("caseTimeout", NullValueHandling = NullValueHandling.Ignore)]
        public long? CaseTimeout { get; set; }

        /// <summary>
        /// httpClient报存cookie配置：1 保存 0 不保存
        /// </summary>
        [JsonProperty("enableCookie", NullValueHandling = NullValueHandling.Ignore)]
        public string EnableCookie { get; set; }

        /// <summary>
        /// 关闭默认添加content-type和accept请求头配置：1 打开 0 关闭
        /// </summary>
        [JsonProperty("headerDefault", NullValueHandling = NullValueHandling.Ignore)]
        public string HeaderDefault { get; set; }

        /// <summary>
        /// http请求超时时间
        /// </summary>
        [JsonProperty("httpTimeout", NullValueHandling = NullValueHandling.Ignore)]
        public long? HttpTimeout { get; set; }

        /// <summary>
        /// 八爪鱼镜像地址
        /// </summary>
        [JsonProperty("octopusImage", NullValueHandling = NullValueHandling.Ignore)]
        public string OctopusImage { get; set; }

        /// <summary>
        /// 并行用例个数
        /// </summary>
        [JsonProperty("parallelNumber", NullValueHandling = NullValueHandling.Ignore)]
        public int? ParallelNumber { get; set; }

        /// <summary>
        /// 代理用户名
        /// </summary>
        [JsonProperty("proxyAuthName", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyAuthName { get; set; }

        /// <summary>
        /// 代理密码
        /// </summary>
        [JsonProperty("proxyAuthPassword", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyAuthPassword { get; set; }

        /// <summary>
        /// 代理服务配置
        /// </summary>
        [JsonProperty("proxyHostName", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyHostName { get; set; }

        /// <summary>
        /// 代理服务配置
        /// </summary>
        [JsonProperty("proxyPort", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyPort { get; set; }

        /// <summary>
        /// 串行配置
        /// </summary>
        [JsonProperty("serialRun", NullValueHandling = NullValueHandling.Ignore)]
        public string SerialRun { get; set; }

        /// <summary>
        /// 任务停止时间
        /// </summary>
        [JsonProperty("taskStopTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TaskStopTime { get; set; }

        /// <summary>
        /// 任务超时时间
        /// </summary>
        [JsonProperty("taskTimeout", NullValueHandling = NullValueHandling.Ignore)]
        public long? TaskTimeout { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvancedConfig {\n");
            sb.Append("  blockEnable: ").Append(BlockEnable).Append("\n");
            sb.Append("  caseTimeout: ").Append(CaseTimeout).Append("\n");
            sb.Append("  enableCookie: ").Append(EnableCookie).Append("\n");
            sb.Append("  headerDefault: ").Append(HeaderDefault).Append("\n");
            sb.Append("  httpTimeout: ").Append(HttpTimeout).Append("\n");
            sb.Append("  octopusImage: ").Append(OctopusImage).Append("\n");
            sb.Append("  parallelNumber: ").Append(ParallelNumber).Append("\n");
            sb.Append("  proxyAuthName: ").Append(ProxyAuthName).Append("\n");
            sb.Append("  proxyAuthPassword: ").Append(ProxyAuthPassword).Append("\n");
            sb.Append("  proxyHostName: ").Append(ProxyHostName).Append("\n");
            sb.Append("  proxyPort: ").Append(ProxyPort).Append("\n");
            sb.Append("  serialRun: ").Append(SerialRun).Append("\n");
            sb.Append("  taskStopTime: ").Append(TaskStopTime).Append("\n");
            sb.Append("  taskTimeout: ").Append(TaskTimeout).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdvancedConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AdvancedConfig input)
        {
            if (input == null) return false;
            if (this.BlockEnable != input.BlockEnable || (this.BlockEnable != null && !this.BlockEnable.Equals(input.BlockEnable))) return false;
            if (this.CaseTimeout != input.CaseTimeout || (this.CaseTimeout != null && !this.CaseTimeout.Equals(input.CaseTimeout))) return false;
            if (this.EnableCookie != input.EnableCookie || (this.EnableCookie != null && !this.EnableCookie.Equals(input.EnableCookie))) return false;
            if (this.HeaderDefault != input.HeaderDefault || (this.HeaderDefault != null && !this.HeaderDefault.Equals(input.HeaderDefault))) return false;
            if (this.HttpTimeout != input.HttpTimeout || (this.HttpTimeout != null && !this.HttpTimeout.Equals(input.HttpTimeout))) return false;
            if (this.OctopusImage != input.OctopusImage || (this.OctopusImage != null && !this.OctopusImage.Equals(input.OctopusImage))) return false;
            if (this.ParallelNumber != input.ParallelNumber || (this.ParallelNumber != null && !this.ParallelNumber.Equals(input.ParallelNumber))) return false;
            if (this.ProxyAuthName != input.ProxyAuthName || (this.ProxyAuthName != null && !this.ProxyAuthName.Equals(input.ProxyAuthName))) return false;
            if (this.ProxyAuthPassword != input.ProxyAuthPassword || (this.ProxyAuthPassword != null && !this.ProxyAuthPassword.Equals(input.ProxyAuthPassword))) return false;
            if (this.ProxyHostName != input.ProxyHostName || (this.ProxyHostName != null && !this.ProxyHostName.Equals(input.ProxyHostName))) return false;
            if (this.ProxyPort != input.ProxyPort || (this.ProxyPort != null && !this.ProxyPort.Equals(input.ProxyPort))) return false;
            if (this.SerialRun != input.SerialRun || (this.SerialRun != null && !this.SerialRun.Equals(input.SerialRun))) return false;
            if (this.TaskStopTime != input.TaskStopTime || (this.TaskStopTime != null && !this.TaskStopTime.Equals(input.TaskStopTime))) return false;
            if (this.TaskTimeout != input.TaskTimeout || (this.TaskTimeout != null && !this.TaskTimeout.Equals(input.TaskTimeout))) return false;

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
                if (this.BlockEnable != null) hashCode = hashCode * 59 + this.BlockEnable.GetHashCode();
                if (this.CaseTimeout != null) hashCode = hashCode * 59 + this.CaseTimeout.GetHashCode();
                if (this.EnableCookie != null) hashCode = hashCode * 59 + this.EnableCookie.GetHashCode();
                if (this.HeaderDefault != null) hashCode = hashCode * 59 + this.HeaderDefault.GetHashCode();
                if (this.HttpTimeout != null) hashCode = hashCode * 59 + this.HttpTimeout.GetHashCode();
                if (this.OctopusImage != null) hashCode = hashCode * 59 + this.OctopusImage.GetHashCode();
                if (this.ParallelNumber != null) hashCode = hashCode * 59 + this.ParallelNumber.GetHashCode();
                if (this.ProxyAuthName != null) hashCode = hashCode * 59 + this.ProxyAuthName.GetHashCode();
                if (this.ProxyAuthPassword != null) hashCode = hashCode * 59 + this.ProxyAuthPassword.GetHashCode();
                if (this.ProxyHostName != null) hashCode = hashCode * 59 + this.ProxyHostName.GetHashCode();
                if (this.ProxyPort != null) hashCode = hashCode * 59 + this.ProxyPort.GetHashCode();
                if (this.SerialRun != null) hashCode = hashCode * 59 + this.SerialRun.GetHashCode();
                if (this.TaskStopTime != null) hashCode = hashCode * 59 + this.TaskStopTime.GetHashCode();
                if (this.TaskTimeout != null) hashCode = hashCode * 59 + this.TaskTimeout.GetHashCode();
                return hashCode;
            }
        }
    }
}
