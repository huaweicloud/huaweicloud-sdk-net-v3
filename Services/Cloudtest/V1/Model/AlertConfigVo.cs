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
    public class AlertConfigVo 
    {

        /// <summary>
        /// 告警表达式
        /// </summary>
        [JsonProperty("alert_expression", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlertExpression> AlertExpression { get; set; }

        /// <summary>
        /// 告警区间，开始时间
        /// </summary>
        [JsonProperty("alertPeriodBegin", NullValueHandling = NullValueHandling.Ignore)]
        public string AlertPeriodBegin { get; set; }

        /// <summary>
        /// 告警区间，开始时间
        /// </summary>
        [JsonProperty("alertPeriodEnd", NullValueHandling = NullValueHandling.Ignore)]
        public string AlertPeriodEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("blockAlert", NullValueHandling = NullValueHandling.Ignore)]
        public BlockAlert BlockAlert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("defaultAlertTemplate", NullValueHandling = NullValueHandling.Ignore)]
        public AlertTemplate DefaultAlertTemplate { get; set; }

        /// <summary>
        /// 告警开启 0关闭 1开启
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public string Enable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("errorAlert", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorAlert ErrorAlert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("failedAlert", NullValueHandling = NullValueHandling.Ignore)]
        public FailedAlert FailedAlert { get; set; }

        /// <summary>
        /// 告警恢复通知开关 0关闭 1开启
        /// </summary>
        [JsonProperty("recoverNoticeEnable", NullValueHandling = NullValueHandling.Ignore)]
        public string RecoverNoticeEnable { get; set; }

        /// <summary>
        /// 告警收敛开关 0关闭 1开启
        /// </summary>
        [JsonProperty("restrainAlertEnable", NullValueHandling = NullValueHandling.Ignore)]
        public string RestrainAlertEnable { get; set; }

        /// <summary>
        /// 智能告警 成功多少次后发送恢复告警
        /// </summary>
        [JsonProperty("resume_alert_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResumeAlertNum { get; set; }

        /// <summary>
        /// 智能告警 指定时间后发送恢复告警
        /// </summary>
        [JsonProperty("resumeAlertTime", NullValueHandling = NullValueHandling.Ignore)]
        public string ResumeAlertTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("timeoutAlert", NullValueHandling = NullValueHandling.Ignore)]
        public TimeoutAlert TimeoutAlert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("timeoutAlertV4", NullValueHandling = NullValueHandling.Ignore)]
        public TimeoutAlert TimeoutAlertV4 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlertConfigVo {\n");
            sb.Append("  alertExpression: ").Append(AlertExpression).Append("\n");
            sb.Append("  alertPeriodBegin: ").Append(AlertPeriodBegin).Append("\n");
            sb.Append("  alertPeriodEnd: ").Append(AlertPeriodEnd).Append("\n");
            sb.Append("  blockAlert: ").Append(BlockAlert).Append("\n");
            sb.Append("  defaultAlertTemplate: ").Append(DefaultAlertTemplate).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  errorAlert: ").Append(ErrorAlert).Append("\n");
            sb.Append("  failedAlert: ").Append(FailedAlert).Append("\n");
            sb.Append("  recoverNoticeEnable: ").Append(RecoverNoticeEnable).Append("\n");
            sb.Append("  restrainAlertEnable: ").Append(RestrainAlertEnable).Append("\n");
            sb.Append("  resumeAlertNum: ").Append(ResumeAlertNum).Append("\n");
            sb.Append("  resumeAlertTime: ").Append(ResumeAlertTime).Append("\n");
            sb.Append("  timeoutAlert: ").Append(TimeoutAlert).Append("\n");
            sb.Append("  timeoutAlertV4: ").Append(TimeoutAlertV4).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlertConfigVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlertConfigVo input)
        {
            if (input == null) return false;
            if (this.AlertExpression != input.AlertExpression || (this.AlertExpression != null && input.AlertExpression != null && !this.AlertExpression.SequenceEqual(input.AlertExpression))) return false;
            if (this.AlertPeriodBegin != input.AlertPeriodBegin || (this.AlertPeriodBegin != null && !this.AlertPeriodBegin.Equals(input.AlertPeriodBegin))) return false;
            if (this.AlertPeriodEnd != input.AlertPeriodEnd || (this.AlertPeriodEnd != null && !this.AlertPeriodEnd.Equals(input.AlertPeriodEnd))) return false;
            if (this.BlockAlert != input.BlockAlert || (this.BlockAlert != null && !this.BlockAlert.Equals(input.BlockAlert))) return false;
            if (this.DefaultAlertTemplate != input.DefaultAlertTemplate || (this.DefaultAlertTemplate != null && !this.DefaultAlertTemplate.Equals(input.DefaultAlertTemplate))) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.ErrorAlert != input.ErrorAlert || (this.ErrorAlert != null && !this.ErrorAlert.Equals(input.ErrorAlert))) return false;
            if (this.FailedAlert != input.FailedAlert || (this.FailedAlert != null && !this.FailedAlert.Equals(input.FailedAlert))) return false;
            if (this.RecoverNoticeEnable != input.RecoverNoticeEnable || (this.RecoverNoticeEnable != null && !this.RecoverNoticeEnable.Equals(input.RecoverNoticeEnable))) return false;
            if (this.RestrainAlertEnable != input.RestrainAlertEnable || (this.RestrainAlertEnable != null && !this.RestrainAlertEnable.Equals(input.RestrainAlertEnable))) return false;
            if (this.ResumeAlertNum != input.ResumeAlertNum || (this.ResumeAlertNum != null && !this.ResumeAlertNum.Equals(input.ResumeAlertNum))) return false;
            if (this.ResumeAlertTime != input.ResumeAlertTime || (this.ResumeAlertTime != null && !this.ResumeAlertTime.Equals(input.ResumeAlertTime))) return false;
            if (this.TimeoutAlert != input.TimeoutAlert || (this.TimeoutAlert != null && !this.TimeoutAlert.Equals(input.TimeoutAlert))) return false;
            if (this.TimeoutAlertV4 != input.TimeoutAlertV4 || (this.TimeoutAlertV4 != null && !this.TimeoutAlertV4.Equals(input.TimeoutAlertV4))) return false;

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
                if (this.AlertExpression != null) hashCode = hashCode * 59 + this.AlertExpression.GetHashCode();
                if (this.AlertPeriodBegin != null) hashCode = hashCode * 59 + this.AlertPeriodBegin.GetHashCode();
                if (this.AlertPeriodEnd != null) hashCode = hashCode * 59 + this.AlertPeriodEnd.GetHashCode();
                if (this.BlockAlert != null) hashCode = hashCode * 59 + this.BlockAlert.GetHashCode();
                if (this.DefaultAlertTemplate != null) hashCode = hashCode * 59 + this.DefaultAlertTemplate.GetHashCode();
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.ErrorAlert != null) hashCode = hashCode * 59 + this.ErrorAlert.GetHashCode();
                if (this.FailedAlert != null) hashCode = hashCode * 59 + this.FailedAlert.GetHashCode();
                if (this.RecoverNoticeEnable != null) hashCode = hashCode * 59 + this.RecoverNoticeEnable.GetHashCode();
                if (this.RestrainAlertEnable != null) hashCode = hashCode * 59 + this.RestrainAlertEnable.GetHashCode();
                if (this.ResumeAlertNum != null) hashCode = hashCode * 59 + this.ResumeAlertNum.GetHashCode();
                if (this.ResumeAlertTime != null) hashCode = hashCode * 59 + this.ResumeAlertTime.GetHashCode();
                if (this.TimeoutAlert != null) hashCode = hashCode * 59 + this.TimeoutAlert.GetHashCode();
                if (this.TimeoutAlertV4 != null) hashCode = hashCode * 59 + this.TimeoutAlertV4.GetHashCode();
                return hashCode;
            }
        }
    }
}
