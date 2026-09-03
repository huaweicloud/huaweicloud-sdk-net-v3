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
    public class ExecuteStrategiesVo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("advancedConfig", NullValueHandling = NullValueHandling.Ignore)]
        public AdvancedConfig AdvancedConfig { get; set; }

        /// <summary>
        /// 日报 0 关闭 1开启
        /// </summary>
        [JsonProperty("dailyReportEnable", NullValueHandling = NullValueHandling.Ignore)]
        public string DailyReportEnable { get; set; }

        /// <summary>
        /// 执行顺序 串行 1 并行 2 
        /// </summary>
        [JsonProperty("executeModel", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteModel { get; set; }

        /// <summary>
        /// 执行区间，开始时间
        /// </summary>
        [JsonProperty("executePeriodBegin", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutePeriodBegin { get; set; }

        /// <summary>
        /// 执行区间，开始时间
        /// </summary>
        [JsonProperty("executePeriodEnd", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutePeriodEnd { get; set; }

        /// <summary>
        /// 执行模式 立即执行 0，延后执行: 延后执行时间
        /// </summary>
        [JsonProperty("executeStartTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExecuteStartTime { get; set; }

        /// <summary>
        /// 任务执行时间段 - - 重新启用，任务采用多段时间区间执行，quartz需要用这个参数
        /// </summary>
        [JsonProperty("executionTime", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExecutionTime> ExecutionTime { get; set; }

        /// <summary>
        /// 目前无用字段
        /// </summary>
        [JsonProperty("executorOption", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> ExecutorOption { get; set; }

        /// <summary>
        /// deployTest修改properties使用，字段不固定。小网拨测使用该字段修改properties中的ip
        /// </summary>
        [JsonProperty("executorParameters", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> ExecutorParameters { get; set; }

        /// <summary>
        /// 失败重试次数
        /// </summary>
        [JsonProperty("failedRetryTimes", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailedRetryTimes { get; set; }

        /// <summary>
        /// 执行间隔
        /// </summary>
        [JsonProperty("intervalInSeconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? IntervalInSeconds { get; set; }

        /// <summary>
        /// deployTest使用
        /// </summary>
        [JsonProperty("ipKey", NullValueHandling = NullValueHandling.Ignore)]
        public string IpKey { get; set; }

        /// <summary>
        /// 执行区域
        /// </summary>
        [JsonProperty("location_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LocationIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("operateNotice", NullValueHandling = NullValueHandling.Ignore)]
        public OperateNotice OperateNotice { get; set; }

        /// <summary>
        /// deployTest使用
        /// </summary>
        [JsonProperty("pbi", NullValueHandling = NullValueHandling.Ignore)]
        public string Pbi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("protocol_test", NullValueHandling = NullValueHandling.Ignore)]
        public ProtocolTestVo ProtocolTest { get; set; }

        /// <summary>
        /// 重试次数，冒烟测试使用
        /// </summary>
        [JsonProperty("repeatTimes", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepeatTimes { get; set; }

        /// <summary>
        /// deployTest使用
        /// </summary>
        [JsonProperty("serviceNameCBG", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceNameCBG { get; set; }

        /// <summary>
        /// deployTest使用
        /// </summary>
        [JsonProperty("serviceScopeCBG", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceScopeCBG { get; set; }

        /// <summary>
        /// deployTest使用
        /// </summary>
        [JsonProperty("serviceVersionCBG", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceVersionCBG { get; set; }

        /// <summary>
        /// 不再使用
        /// </summary>
        [JsonProperty("testNodeServer", NullValueHandling = NullValueHandling.Ignore)]
        public string TestNodeServer { get; set; }

        /// <summary>
        /// 超时时间
        /// </summary>
        [JsonProperty("timeoutMilSec", NullValueHandling = NullValueHandling.Ignore)]
        public int? TimeoutMilSec { get; set; }

        /// <summary>
        /// 执行时间表达式
        /// </summary>
        [JsonProperty("timerExpression", NullValueHandling = NullValueHandling.Ignore)]
        public string TimerExpression { get; set; }

        /// <summary>
        /// deployTest使用
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteStrategiesVo {\n");
            sb.Append("  advancedConfig: ").Append(AdvancedConfig).Append("\n");
            sb.Append("  dailyReportEnable: ").Append(DailyReportEnable).Append("\n");
            sb.Append("  executeModel: ").Append(ExecuteModel).Append("\n");
            sb.Append("  executePeriodBegin: ").Append(ExecutePeriodBegin).Append("\n");
            sb.Append("  executePeriodEnd: ").Append(ExecutePeriodEnd).Append("\n");
            sb.Append("  executeStartTime: ").Append(ExecuteStartTime).Append("\n");
            sb.Append("  executionTime: ").Append(ExecutionTime).Append("\n");
            sb.Append("  executorOption: ").Append(ExecutorOption).Append("\n");
            sb.Append("  executorParameters: ").Append(ExecutorParameters).Append("\n");
            sb.Append("  failedRetryTimes: ").Append(FailedRetryTimes).Append("\n");
            sb.Append("  intervalInSeconds: ").Append(IntervalInSeconds).Append("\n");
            sb.Append("  ipKey: ").Append(IpKey).Append("\n");
            sb.Append("  locationIds: ").Append(LocationIds).Append("\n");
            sb.Append("  operateNotice: ").Append(OperateNotice).Append("\n");
            sb.Append("  pbi: ").Append(Pbi).Append("\n");
            sb.Append("  protocolTest: ").Append(ProtocolTest).Append("\n");
            sb.Append("  repeatTimes: ").Append(RepeatTimes).Append("\n");
            sb.Append("  serviceNameCBG: ").Append(ServiceNameCBG).Append("\n");
            sb.Append("  serviceScopeCBG: ").Append(ServiceScopeCBG).Append("\n");
            sb.Append("  serviceVersionCBG: ").Append(ServiceVersionCBG).Append("\n");
            sb.Append("  testNodeServer: ").Append(TestNodeServer).Append("\n");
            sb.Append("  timeoutMilSec: ").Append(TimeoutMilSec).Append("\n");
            sb.Append("  timerExpression: ").Append(TimerExpression).Append("\n");
            sb.Append("  token: ").Append(Token).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecuteStrategiesVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecuteStrategiesVo input)
        {
            if (input == null) return false;
            if (this.AdvancedConfig != input.AdvancedConfig || (this.AdvancedConfig != null && !this.AdvancedConfig.Equals(input.AdvancedConfig))) return false;
            if (this.DailyReportEnable != input.DailyReportEnable || (this.DailyReportEnable != null && !this.DailyReportEnable.Equals(input.DailyReportEnable))) return false;
            if (this.ExecuteModel != input.ExecuteModel || (this.ExecuteModel != null && !this.ExecuteModel.Equals(input.ExecuteModel))) return false;
            if (this.ExecutePeriodBegin != input.ExecutePeriodBegin || (this.ExecutePeriodBegin != null && !this.ExecutePeriodBegin.Equals(input.ExecutePeriodBegin))) return false;
            if (this.ExecutePeriodEnd != input.ExecutePeriodEnd || (this.ExecutePeriodEnd != null && !this.ExecutePeriodEnd.Equals(input.ExecutePeriodEnd))) return false;
            if (this.ExecuteStartTime != input.ExecuteStartTime || (this.ExecuteStartTime != null && !this.ExecuteStartTime.Equals(input.ExecuteStartTime))) return false;
            if (this.ExecutionTime != input.ExecutionTime || (this.ExecutionTime != null && input.ExecutionTime != null && !this.ExecutionTime.SequenceEqual(input.ExecutionTime))) return false;
            if (this.ExecutorOption != input.ExecutorOption || (this.ExecutorOption != null && input.ExecutorOption != null && !this.ExecutorOption.SequenceEqual(input.ExecutorOption))) return false;
            if (this.ExecutorParameters != input.ExecutorParameters || (this.ExecutorParameters != null && input.ExecutorParameters != null && !this.ExecutorParameters.SequenceEqual(input.ExecutorParameters))) return false;
            if (this.FailedRetryTimes != input.FailedRetryTimes || (this.FailedRetryTimes != null && !this.FailedRetryTimes.Equals(input.FailedRetryTimes))) return false;
            if (this.IntervalInSeconds != input.IntervalInSeconds || (this.IntervalInSeconds != null && !this.IntervalInSeconds.Equals(input.IntervalInSeconds))) return false;
            if (this.IpKey != input.IpKey || (this.IpKey != null && !this.IpKey.Equals(input.IpKey))) return false;
            if (this.LocationIds != input.LocationIds || (this.LocationIds != null && input.LocationIds != null && !this.LocationIds.SequenceEqual(input.LocationIds))) return false;
            if (this.OperateNotice != input.OperateNotice || (this.OperateNotice != null && !this.OperateNotice.Equals(input.OperateNotice))) return false;
            if (this.Pbi != input.Pbi || (this.Pbi != null && !this.Pbi.Equals(input.Pbi))) return false;
            if (this.ProtocolTest != input.ProtocolTest || (this.ProtocolTest != null && !this.ProtocolTest.Equals(input.ProtocolTest))) return false;
            if (this.RepeatTimes != input.RepeatTimes || (this.RepeatTimes != null && !this.RepeatTimes.Equals(input.RepeatTimes))) return false;
            if (this.ServiceNameCBG != input.ServiceNameCBG || (this.ServiceNameCBG != null && !this.ServiceNameCBG.Equals(input.ServiceNameCBG))) return false;
            if (this.ServiceScopeCBG != input.ServiceScopeCBG || (this.ServiceScopeCBG != null && !this.ServiceScopeCBG.Equals(input.ServiceScopeCBG))) return false;
            if (this.ServiceVersionCBG != input.ServiceVersionCBG || (this.ServiceVersionCBG != null && !this.ServiceVersionCBG.Equals(input.ServiceVersionCBG))) return false;
            if (this.TestNodeServer != input.TestNodeServer || (this.TestNodeServer != null && !this.TestNodeServer.Equals(input.TestNodeServer))) return false;
            if (this.TimeoutMilSec != input.TimeoutMilSec || (this.TimeoutMilSec != null && !this.TimeoutMilSec.Equals(input.TimeoutMilSec))) return false;
            if (this.TimerExpression != input.TimerExpression || (this.TimerExpression != null && !this.TimerExpression.Equals(input.TimerExpression))) return false;
            if (this.Token != input.Token || (this.Token != null && !this.Token.Equals(input.Token))) return false;

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
                if (this.AdvancedConfig != null) hashCode = hashCode * 59 + this.AdvancedConfig.GetHashCode();
                if (this.DailyReportEnable != null) hashCode = hashCode * 59 + this.DailyReportEnable.GetHashCode();
                if (this.ExecuteModel != null) hashCode = hashCode * 59 + this.ExecuteModel.GetHashCode();
                if (this.ExecutePeriodBegin != null) hashCode = hashCode * 59 + this.ExecutePeriodBegin.GetHashCode();
                if (this.ExecutePeriodEnd != null) hashCode = hashCode * 59 + this.ExecutePeriodEnd.GetHashCode();
                if (this.ExecuteStartTime != null) hashCode = hashCode * 59 + this.ExecuteStartTime.GetHashCode();
                if (this.ExecutionTime != null) hashCode = hashCode * 59 + this.ExecutionTime.GetHashCode();
                if (this.ExecutorOption != null) hashCode = hashCode * 59 + this.ExecutorOption.GetHashCode();
                if (this.ExecutorParameters != null) hashCode = hashCode * 59 + this.ExecutorParameters.GetHashCode();
                if (this.FailedRetryTimes != null) hashCode = hashCode * 59 + this.FailedRetryTimes.GetHashCode();
                if (this.IntervalInSeconds != null) hashCode = hashCode * 59 + this.IntervalInSeconds.GetHashCode();
                if (this.IpKey != null) hashCode = hashCode * 59 + this.IpKey.GetHashCode();
                if (this.LocationIds != null) hashCode = hashCode * 59 + this.LocationIds.GetHashCode();
                if (this.OperateNotice != null) hashCode = hashCode * 59 + this.OperateNotice.GetHashCode();
                if (this.Pbi != null) hashCode = hashCode * 59 + this.Pbi.GetHashCode();
                if (this.ProtocolTest != null) hashCode = hashCode * 59 + this.ProtocolTest.GetHashCode();
                if (this.RepeatTimes != null) hashCode = hashCode * 59 + this.RepeatTimes.GetHashCode();
                if (this.ServiceNameCBG != null) hashCode = hashCode * 59 + this.ServiceNameCBG.GetHashCode();
                if (this.ServiceScopeCBG != null) hashCode = hashCode * 59 + this.ServiceScopeCBG.GetHashCode();
                if (this.ServiceVersionCBG != null) hashCode = hashCode * 59 + this.ServiceVersionCBG.GetHashCode();
                if (this.TestNodeServer != null) hashCode = hashCode * 59 + this.TestNodeServer.GetHashCode();
                if (this.TimeoutMilSec != null) hashCode = hashCode * 59 + this.TimeoutMilSec.GetHashCode();
                if (this.TimerExpression != null) hashCode = hashCode * 59 + this.TimerExpression.GetHashCode();
                if (this.Token != null) hashCode = hashCode * 59 + this.Token.GetHashCode();
                return hashCode;
            }
        }
    }
}
