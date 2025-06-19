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
    public class ProgressVo 
    {

        /// <summary>
        /// 进度uri
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// 异步进度名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 资源总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 异步操作是否完成
        /// </summary>
        [JsonProperty("completed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Completed { get; set; }

        /// <summary>
        /// 异步操作是否取消
        /// </summary>
        [JsonProperty("cancelled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cancelled { get; set; }

        /// <summary>
        /// 提示信息列表
        /// </summary>
        [JsonProperty("informations", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Informations { get; set; }

        /// <summary>
        /// 错误编码
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// 提交时间
        /// </summary>
        [JsonProperty("submitted_time", NullValueHandling = NullValueHandling.Ignore)]
        public string SubmittedTime { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 服务ip
        /// </summary>
        [JsonProperty("server_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerIp { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [JsonProperty("last_modified_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastModifiedTime { get; set; }

        /// <summary>
        /// 执行完成总数
        /// </summary>
        [JsonProperty("finished_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FinishedCount { get; set; }

        /// <summary>
        /// 异步操作返回值
        /// </summary>
        [JsonProperty("return_value", NullValueHandling = NullValueHandling.Ignore)]
        public Object ReturnValue { get; set; }

        /// <summary>
        /// 异常信息
        /// </summary>
        [JsonProperty("exception_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ExceptionMessage { get; set; }

        /// <summary>
        /// 行编号
        /// </summary>
        [JsonProperty("line_up_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? LineUpNum { get; set; }

        /// <summary>
        /// 异步操作的key
        /// </summary>
        [JsonProperty("asyn_operation_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AsynOperationKey { get; set; }

        /// <summary>
        /// 是否结束
        /// </summary>
        [JsonProperty("is_ended", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEnded { get; set; }

        /// <summary>
        /// 异步操作完成进度
        /// </summary>
        [JsonProperty("finished_percent", NullValueHandling = NullValueHandling.Ignore)]
        public int? FinishedPercent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgressVo {\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  completed: ").Append(Completed).Append("\n");
            sb.Append("  cancelled: ").Append(Cancelled).Append("\n");
            sb.Append("  informations: ").Append(Informations).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("  submittedTime: ").Append(SubmittedTime).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  serverIp: ").Append(ServerIp).Append("\n");
            sb.Append("  lastModifiedTime: ").Append(LastModifiedTime).Append("\n");
            sb.Append("  finishedCount: ").Append(FinishedCount).Append("\n");
            sb.Append("  returnValue: ").Append(ReturnValue).Append("\n");
            sb.Append("  exceptionMessage: ").Append(ExceptionMessage).Append("\n");
            sb.Append("  lineUpNum: ").Append(LineUpNum).Append("\n");
            sb.Append("  asynOperationKey: ").Append(AsynOperationKey).Append("\n");
            sb.Append("  isEnded: ").Append(IsEnded).Append("\n");
            sb.Append("  finishedPercent: ").Append(FinishedPercent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProgressVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProgressVo input)
        {
            if (input == null) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.Completed != input.Completed || (this.Completed != null && !this.Completed.Equals(input.Completed))) return false;
            if (this.Cancelled != input.Cancelled || (this.Cancelled != null && !this.Cancelled.Equals(input.Cancelled))) return false;
            if (this.Informations != input.Informations || (this.Informations != null && input.Informations != null && !this.Informations.SequenceEqual(input.Informations))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.Reason != input.Reason || (this.Reason != null && !this.Reason.Equals(input.Reason))) return false;
            if (this.SubmittedTime != input.SubmittedTime || (this.SubmittedTime != null && !this.SubmittedTime.Equals(input.SubmittedTime))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.ServerIp != input.ServerIp || (this.ServerIp != null && !this.ServerIp.Equals(input.ServerIp))) return false;
            if (this.LastModifiedTime != input.LastModifiedTime || (this.LastModifiedTime != null && !this.LastModifiedTime.Equals(input.LastModifiedTime))) return false;
            if (this.FinishedCount != input.FinishedCount || (this.FinishedCount != null && !this.FinishedCount.Equals(input.FinishedCount))) return false;
            if (this.ReturnValue != input.ReturnValue || (this.ReturnValue != null && !this.ReturnValue.Equals(input.ReturnValue))) return false;
            if (this.ExceptionMessage != input.ExceptionMessage || (this.ExceptionMessage != null && !this.ExceptionMessage.Equals(input.ExceptionMessage))) return false;
            if (this.LineUpNum != input.LineUpNum || (this.LineUpNum != null && !this.LineUpNum.Equals(input.LineUpNum))) return false;
            if (this.AsynOperationKey != input.AsynOperationKey || (this.AsynOperationKey != null && !this.AsynOperationKey.Equals(input.AsynOperationKey))) return false;
            if (this.IsEnded != input.IsEnded || (this.IsEnded != null && !this.IsEnded.Equals(input.IsEnded))) return false;
            if (this.FinishedPercent != input.FinishedPercent || (this.FinishedPercent != null && !this.FinishedPercent.Equals(input.FinishedPercent))) return false;

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
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Completed != null) hashCode = hashCode * 59 + this.Completed.GetHashCode();
                if (this.Cancelled != null) hashCode = hashCode * 59 + this.Cancelled.GetHashCode();
                if (this.Informations != null) hashCode = hashCode * 59 + this.Informations.GetHashCode();
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Reason != null) hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.SubmittedTime != null) hashCode = hashCode * 59 + this.SubmittedTime.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ServerIp != null) hashCode = hashCode * 59 + this.ServerIp.GetHashCode();
                if (this.LastModifiedTime != null) hashCode = hashCode * 59 + this.LastModifiedTime.GetHashCode();
                if (this.FinishedCount != null) hashCode = hashCode * 59 + this.FinishedCount.GetHashCode();
                if (this.ReturnValue != null) hashCode = hashCode * 59 + this.ReturnValue.GetHashCode();
                if (this.ExceptionMessage != null) hashCode = hashCode * 59 + this.ExceptionMessage.GetHashCode();
                if (this.LineUpNum != null) hashCode = hashCode * 59 + this.LineUpNum.GetHashCode();
                if (this.AsynOperationKey != null) hashCode = hashCode * 59 + this.AsynOperationKey.GetHashCode();
                if (this.IsEnded != null) hashCode = hashCode * 59 + this.IsEnded.GetHashCode();
                if (this.FinishedPercent != null) hashCode = hashCode * 59 + this.FinishedPercent.GetHashCode();
                return hashCode;
            }
        }
    }
}
