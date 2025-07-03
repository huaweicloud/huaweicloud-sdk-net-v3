using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// span信息。
    /// </summary>
    public class ClientSpanInfo 
    {

        /// <summary>
        /// vTraceId，虚拟traceI。
        /// </summary>
        [JsonProperty("global_trace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalTraceId { get; set; }

        /// <summary>
        /// 虚拟traceId经过的path路径。
        /// </summary>
        [JsonProperty("global_path", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalPath { get; set; }

        /// <summary>
        /// traceId。
        /// </summary>
        [JsonProperty("trace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TraceId { get; set; }

        /// <summary>
        /// span id。
        /// </summary>
        [JsonProperty("span_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SpanId { get; set; }

        /// <summary>
        /// 环境Iid。
        /// </summary>
        [JsonProperty("env_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnvId { get; set; }

        /// <summary>
        /// 实例id。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// 组件id。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? AppId { get; set; }

        /// <summary>
        /// 应用id。
        /// </summary>
        [JsonProperty("biz_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? BizId { get; set; }

        /// <summary>
        /// 租户id。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? DomainId { get; set; }

        /// <summary>
        /// 只有是根event也就是span的时候有值。
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// 根event 的时候存在，实际调用的url。
        /// </summary>
        [JsonProperty("real_source", NullValueHandling = NullValueHandling.Ignore)]
        public string RealSource { get; set; }

        /// <summary>
        /// 开始时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 耗时。
        /// </summary>
        [JsonProperty("time_used", NullValueHandling = NullValueHandling.Ignore)]
        public long? TimeUsed { get; set; }

        /// <summary>
        /// 状态码，针对http的调用有效。
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int? Code { get; set; }

        /// <summary>
        /// 类名。
        /// </summary>
        [JsonProperty("class_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ClassName { get; set; }

        /// <summary>
        /// 是否异步。
        /// </summary>
        [JsonProperty("is_async", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAsync { get; set; }

        /// <summary>
        /// 包含用户自定义参数，header或body体里的内容，httpMethod, bizCode，以及后续可能新增参数。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// 是否报错。
        /// </summary>
        [JsonProperty("has_error", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasError { get; set; }

        /// <summary>
        /// 报错原因。
        /// </summary>
        [JsonProperty("error_reasons", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorReasons { get; set; }

        /// <summary>
        /// 类型，mysql，kafka等。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 这里的method实际上是tags里面的http_method，只有url监控项才有。
        /// </summary>
        [JsonProperty("http_method", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpMethod { get; set; }

        /// <summary>
        /// 业务状态码的采集。
        /// </summary>
        [JsonProperty("biz_code", NullValueHandling = NullValueHandling.Ignore)]
        public string BizCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientSpanInfo {\n");
            sb.Append("  globalTraceId: ").Append(GlobalTraceId).Append("\n");
            sb.Append("  globalPath: ").Append(GlobalPath).Append("\n");
            sb.Append("  traceId: ").Append(TraceId).Append("\n");
            sb.Append("  spanId: ").Append(SpanId).Append("\n");
            sb.Append("  envId: ").Append(EnvId).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  bizId: ").Append(BizId).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  realSource: ").Append(RealSource).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  timeUsed: ").Append(TimeUsed).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  className: ").Append(ClassName).Append("\n");
            sb.Append("  isAsync: ").Append(IsAsync).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  hasError: ").Append(HasError).Append("\n");
            sb.Append("  errorReasons: ").Append(ErrorReasons).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  httpMethod: ").Append(HttpMethod).Append("\n");
            sb.Append("  bizCode: ").Append(BizCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientSpanInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClientSpanInfo input)
        {
            if (input == null) return false;
            if (this.GlobalTraceId != input.GlobalTraceId || (this.GlobalTraceId != null && !this.GlobalTraceId.Equals(input.GlobalTraceId))) return false;
            if (this.GlobalPath != input.GlobalPath || (this.GlobalPath != null && !this.GlobalPath.Equals(input.GlobalPath))) return false;
            if (this.TraceId != input.TraceId || (this.TraceId != null && !this.TraceId.Equals(input.TraceId))) return false;
            if (this.SpanId != input.SpanId || (this.SpanId != null && !this.SpanId.Equals(input.SpanId))) return false;
            if (this.EnvId != input.EnvId || (this.EnvId != null && !this.EnvId.Equals(input.EnvId))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.BizId != input.BizId || (this.BizId != null && !this.BizId.Equals(input.BizId))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.RealSource != input.RealSource || (this.RealSource != null && !this.RealSource.Equals(input.RealSource))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.TimeUsed != input.TimeUsed || (this.TimeUsed != null && !this.TimeUsed.Equals(input.TimeUsed))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.ClassName != input.ClassName || (this.ClassName != null && !this.ClassName.Equals(input.ClassName))) return false;
            if (this.IsAsync != input.IsAsync || (this.IsAsync != null && !this.IsAsync.Equals(input.IsAsync))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.HasError != input.HasError || (this.HasError != null && !this.HasError.Equals(input.HasError))) return false;
            if (this.ErrorReasons != input.ErrorReasons || (this.ErrorReasons != null && !this.ErrorReasons.Equals(input.ErrorReasons))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.HttpMethod != input.HttpMethod || (this.HttpMethod != null && !this.HttpMethod.Equals(input.HttpMethod))) return false;
            if (this.BizCode != input.BizCode || (this.BizCode != null && !this.BizCode.Equals(input.BizCode))) return false;

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
                if (this.GlobalTraceId != null) hashCode = hashCode * 59 + this.GlobalTraceId.GetHashCode();
                if (this.GlobalPath != null) hashCode = hashCode * 59 + this.GlobalPath.GetHashCode();
                if (this.TraceId != null) hashCode = hashCode * 59 + this.TraceId.GetHashCode();
                if (this.SpanId != null) hashCode = hashCode * 59 + this.SpanId.GetHashCode();
                if (this.EnvId != null) hashCode = hashCode * 59 + this.EnvId.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.BizId != null) hashCode = hashCode * 59 + this.BizId.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.RealSource != null) hashCode = hashCode * 59 + this.RealSource.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.TimeUsed != null) hashCode = hashCode * 59 + this.TimeUsed.GetHashCode();
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.ClassName != null) hashCode = hashCode * 59 + this.ClassName.GetHashCode();
                if (this.IsAsync != null) hashCode = hashCode * 59 + this.IsAsync.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.HasError != null) hashCode = hashCode * 59 + this.HasError.GetHashCode();
                if (this.ErrorReasons != null) hashCode = hashCode * 59 + this.ErrorReasons.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.HttpMethod != null) hashCode = hashCode * 59 + this.HttpMethod.GetHashCode();
                if (this.BizCode != null) hashCode = hashCode * 59 + this.BizCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
