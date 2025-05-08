using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// obs桶取回请求消息
    /// </summary>
    public class CreateRealTimeClipRequestBody 
    {

        /// <summary>
        /// 时移域名 
        /// </summary>
        [JsonProperty("timeshift_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeshiftDomain { get; set; }

        /// <summary>
        /// live的应用名，默认可填写live 
        /// </summary>
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// 截取的流名 
        /// </summary>
        [JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
        public string Stream { get; set; }

        /// <summary>
        /// 直播时移的转码模板，空表示截取源流 
        /// </summary>
        [JsonProperty("trans_template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TransTemplateName { get; set; }

        /// <summary>
        /// 截取流的开始时间，格式为：YYYY-MM-DDTHH:mm:ssZ（UTC时间）,开始时间与结束时间的间隔最大为12小时 
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 截取流的开始时间，格式为：YYYY-MM-DDTHH:mm:ssZ（UTC时间）,开始时间与结束时间的间隔最大为12小时 
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 0 非固化，1 固化。默认非固化 
        /// </summary>
        [JsonProperty("is_persistence", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsPersistence { get; set; }

        /// <summary>
        /// 非固化场景为空，固化场景必填，复制到该桶中。 
        /// </summary>
        [JsonProperty("output_bucket", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputBucket { get; set; }

        /// <summary>
        /// 截取指定的m3u8文件路径名，仅支持HLS 
        /// </summary>
        [JsonProperty("output_object", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputObject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("media_process_task", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalObjectProcessReq MediaProcessTask { get; set; }

        /// <summary>
        /// 回调地址，为空则不回调 
        /// </summary>
        [JsonProperty("callback_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 自定义上下文，回调时会回调给用户，透传信息 
        /// </summary>
        [JsonProperty("session_context", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionContext { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRealTimeClipRequestBody {\n");
            sb.Append("  timeshiftDomain: ").Append(TimeshiftDomain).Append("\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  stream: ").Append(Stream).Append("\n");
            sb.Append("  transTemplateName: ").Append(TransTemplateName).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  isPersistence: ").Append(IsPersistence).Append("\n");
            sb.Append("  outputBucket: ").Append(OutputBucket).Append("\n");
            sb.Append("  outputObject: ").Append(OutputObject).Append("\n");
            sb.Append("  mediaProcessTask: ").Append(MediaProcessTask).Append("\n");
            sb.Append("  callbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  sessionContext: ").Append(SessionContext).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRealTimeClipRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRealTimeClipRequestBody input)
        {
            if (input == null) return false;
            if (this.TimeshiftDomain != input.TimeshiftDomain || (this.TimeshiftDomain != null && !this.TimeshiftDomain.Equals(input.TimeshiftDomain))) return false;
            if (this.App != input.App || (this.App != null && !this.App.Equals(input.App))) return false;
            if (this.Stream != input.Stream || (this.Stream != null && !this.Stream.Equals(input.Stream))) return false;
            if (this.TransTemplateName != input.TransTemplateName || (this.TransTemplateName != null && !this.TransTemplateName.Equals(input.TransTemplateName))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.IsPersistence != input.IsPersistence || (this.IsPersistence != null && !this.IsPersistence.Equals(input.IsPersistence))) return false;
            if (this.OutputBucket != input.OutputBucket || (this.OutputBucket != null && !this.OutputBucket.Equals(input.OutputBucket))) return false;
            if (this.OutputObject != input.OutputObject || (this.OutputObject != null && !this.OutputObject.Equals(input.OutputObject))) return false;
            if (this.MediaProcessTask != input.MediaProcessTask || (this.MediaProcessTask != null && !this.MediaProcessTask.Equals(input.MediaProcessTask))) return false;
            if (this.CallbackUrl != input.CallbackUrl || (this.CallbackUrl != null && !this.CallbackUrl.Equals(input.CallbackUrl))) return false;
            if (this.SessionContext != input.SessionContext || (this.SessionContext != null && !this.SessionContext.Equals(input.SessionContext))) return false;

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
                if (this.TimeshiftDomain != null) hashCode = hashCode * 59 + this.TimeshiftDomain.GetHashCode();
                if (this.App != null) hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.Stream != null) hashCode = hashCode * 59 + this.Stream.GetHashCode();
                if (this.TransTemplateName != null) hashCode = hashCode * 59 + this.TransTemplateName.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.IsPersistence != null) hashCode = hashCode * 59 + this.IsPersistence.GetHashCode();
                if (this.OutputBucket != null) hashCode = hashCode * 59 + this.OutputBucket.GetHashCode();
                if (this.OutputObject != null) hashCode = hashCode * 59 + this.OutputObject.GetHashCode();
                if (this.MediaProcessTask != null) hashCode = hashCode * 59 + this.MediaProcessTask.GetHashCode();
                if (this.CallbackUrl != null) hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
                if (this.SessionContext != null) hashCode = hashCode * 59 + this.SessionContext.GetHashCode();
                return hashCode;
            }
        }
    }
}
