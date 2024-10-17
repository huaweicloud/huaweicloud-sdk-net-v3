using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListRtcHistoryQualityRequest 
    {

        /// <summary>
        /// 使用AK/SK方式认证时必选，携带的鉴权信息。 
        /// </summary>
        [SDKProperty("Authorization", IsHeader = true)]
        [JsonProperty("Authorization", NullValueHandling = NullValueHandling.Ignore)]
        public string Authorization { get; set; }

        /// <summary>
        /// 使用AK/SK方式认证时必选，请求的发生时间。 
        /// </summary>
        [SDKProperty("X-Sdk-Date", IsHeader = true)]
        [JsonProperty("X-Sdk-Date", NullValueHandling = NullValueHandling.Ignore)]
        public string XSdkDate { get; set; }

        /// <summary>
        /// 使用AK/SK方式认证时必选，携带项目ID信息，与路径参数中的项目ID相同。 
        /// </summary>
        [SDKProperty("X-Project-Id", IsHeader = true)]
        [JsonProperty("X-Project-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XProjectId { get; set; }

        /// <summary>
        /// 应用标识 
        /// </summary>
        [SDKProperty("app", IsQuery = true)]
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// 查询的数据类型 - JoinSuccessRate：加入房间成功率 - JoinSuccess5SecsRate：5秒加入成功率 - VideoFreezeRate：视频卡顿率 - AudioFreezeRate：音频卡顿率 - FirstVideoRecvTime：首帧视频接收耗时 - FirstAudioRecvTime：首帧音频接收耗时 - PullStreamSuccessRate：拉流成功率 - PushStreamSuccessRate：推流成功率 - VideoUpstreamExcellentTransRate：客户端视频上行优质传输率 - AudioUpstreamExcellentTransRate：客户端音频上行优质传输率 - VideoExcellentTransRate：端到端视频优质传输率 - AudioExcellentTransRate：端到端音频优质传输率 - VideoTransDelay：端到端视频网络时，单位为毫秒，取当天所有用户网络延迟的中位数 - AudioTransDelay：端到端音频网络时延，单位为毫秒，取当天所有用户网络延迟的中位数 
        /// </summary>
        [SDKProperty("metric", IsQuery = true)]
        [JsonProperty("metric", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Metric { get; set; }

        /// <summary>
        /// 查询起始时间。UTC时间，格式：YYYY-MM-DD，如2020-04-23，不写默认读取过去1天数据数据。 
        /// </summary>
        [SDKProperty("start_date", IsQuery = true)]
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// 查询结束时间。UTC时间，格式：YYYY-MM-DD，如2020-04-23 
        /// </summary>
        [SDKProperty("end_date", IsQuery = true)]
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRtcHistoryQualityRequest {\n");
            sb.Append("  authorization: ").Append(Authorization).Append("\n");
            sb.Append("  xSdkDate: ").Append(XSdkDate).Append("\n");
            sb.Append("  xProjectId: ").Append(XProjectId).Append("\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  metric: ").Append(Metric).Append("\n");
            sb.Append("  startDate: ").Append(StartDate).Append("\n");
            sb.Append("  endDate: ").Append(EndDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRtcHistoryQualityRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRtcHistoryQualityRequest input)
        {
            if (input == null) return false;
            if (this.Authorization != input.Authorization || (this.Authorization != null && !this.Authorization.Equals(input.Authorization))) return false;
            if (this.XSdkDate != input.XSdkDate || (this.XSdkDate != null && !this.XSdkDate.Equals(input.XSdkDate))) return false;
            if (this.XProjectId != input.XProjectId || (this.XProjectId != null && !this.XProjectId.Equals(input.XProjectId))) return false;
            if (this.App != input.App || (this.App != null && !this.App.Equals(input.App))) return false;
            if (this.Metric != input.Metric || (this.Metric != null && input.Metric != null && !this.Metric.SequenceEqual(input.Metric))) return false;
            if (this.StartDate != input.StartDate || (this.StartDate != null && !this.StartDate.Equals(input.StartDate))) return false;
            if (this.EndDate != input.EndDate || (this.EndDate != null && !this.EndDate.Equals(input.EndDate))) return false;

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
                if (this.Authorization != null) hashCode = hashCode * 59 + this.Authorization.GetHashCode();
                if (this.XSdkDate != null) hashCode = hashCode * 59 + this.XSdkDate.GetHashCode();
                if (this.XProjectId != null) hashCode = hashCode * 59 + this.XProjectId.GetHashCode();
                if (this.App != null) hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.Metric != null) hashCode = hashCode * 59 + this.Metric.GetHashCode();
                if (this.StartDate != null) hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null) hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
