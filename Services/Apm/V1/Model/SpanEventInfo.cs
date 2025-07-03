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
    /// event信息的简要信息。
    /// </summary>
    public class SpanEventInfo 
    {

        /// <summary>
        /// 环境名称。
        /// </summary>
        [JsonProperty("env_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvName { get; set; }

        /// <summary>
        /// 组件名称。
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 缩进。
        /// </summary>
        [JsonProperty("indent", NullValueHandling = NullValueHandling.Ignore)]
        public int? Indent { get; set; }

        /// <summary>
        /// 区域。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 主机名称。
        /// </summary>
        [JsonProperty("host_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HostName { get; set; }

        /// <summary>
        /// ip地址。
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// event的ID，在一个具体的span下面event的编号，一般是1-1-2这种格式。
        /// </summary>
        [JsonProperty("event_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EventId { get; set; }

        /// <summary>
        /// 产生下一个span的源的eventId。
        /// </summary>
        [JsonProperty("next_spanId", NullValueHandling = NullValueHandling.Ignore)]
        public string NextSpanId { get; set; }

        /// <summary>
        /// 调用方的eventid。
        /// </summary>
        [JsonProperty("source_event_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceEventId { get; set; }

        /// <summary>
        /// 方法名。
        /// </summary>
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public string Method { get; set; }

        /// <summary>
        /// 子event的个数。
        /// </summary>
        [JsonProperty("children_event_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChildrenEventCount { get; set; }

        /// <summary>
        /// 丢弃的子event个数，key是类型。
        /// </summary>
        [JsonProperty("discard", NullValueHandling = NullValueHandling.Ignore)]
        public List<DiscardInfo> Discard { get; set; }

        /// <summary>
        /// 界面展示的参数，每个类型的event自己来实现。
        /// </summary>
        [JsonProperty("argument", NullValueHandling = NullValueHandling.Ignore)]
        public string Argument { get; set; }

        /// <summary>
        /// 注册信息里面的attachment。
        /// </summary>
        [JsonProperty("attachment", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Attachment { get; set; }

        /// <summary>
        /// vTraceId，虚拟traceId。
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
        /// 环境id。
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
        /// 根event的时候存在，实际调用的url。
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
        /// 是否异步的event。
        /// </summary>
        [JsonProperty("is_async", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAsync { get; set; }

        /// <summary>
        /// 包含用户自定义参数，header或body体里的内容，httpMethod, bizCode，以及后续可能新增参数。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// 是否有错误，主要用在span的场景。
        /// </summary>
        [JsonProperty("has_error", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasError { get; set; }

        /// <summary>
        /// 错误原因。
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
        /// spanId。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpanEventInfo {\n");
            sb.Append("  envName: ").Append(EnvName).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  indent: ").Append(Indent).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  hostName: ").Append(HostName).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  eventId: ").Append(EventId).Append("\n");
            sb.Append("  nextSpanId: ").Append(NextSpanId).Append("\n");
            sb.Append("  sourceEventId: ").Append(SourceEventId).Append("\n");
            sb.Append("  method: ").Append(Method).Append("\n");
            sb.Append("  childrenEventCount: ").Append(ChildrenEventCount).Append("\n");
            sb.Append("  discard: ").Append(Discard).Append("\n");
            sb.Append("  argument: ").Append(Argument).Append("\n");
            sb.Append("  attachment: ").Append(Attachment).Append("\n");
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
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SpanEventInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SpanEventInfo input)
        {
            if (input == null) return false;
            if (this.EnvName != input.EnvName || (this.EnvName != null && !this.EnvName.Equals(input.EnvName))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.Indent != input.Indent || (this.Indent != null && !this.Indent.Equals(input.Indent))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.HostName != input.HostName || (this.HostName != null && !this.HostName.Equals(input.HostName))) return false;
            if (this.IpAddress != input.IpAddress || (this.IpAddress != null && !this.IpAddress.Equals(input.IpAddress))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.EventId != input.EventId || (this.EventId != null && !this.EventId.Equals(input.EventId))) return false;
            if (this.NextSpanId != input.NextSpanId || (this.NextSpanId != null && !this.NextSpanId.Equals(input.NextSpanId))) return false;
            if (this.SourceEventId != input.SourceEventId || (this.SourceEventId != null && !this.SourceEventId.Equals(input.SourceEventId))) return false;
            if (this.Method != input.Method || (this.Method != null && !this.Method.Equals(input.Method))) return false;
            if (this.ChildrenEventCount != input.ChildrenEventCount || (this.ChildrenEventCount != null && !this.ChildrenEventCount.Equals(input.ChildrenEventCount))) return false;
            if (this.Discard != input.Discard || (this.Discard != null && input.Discard != null && !this.Discard.SequenceEqual(input.Discard))) return false;
            if (this.Argument != input.Argument || (this.Argument != null && !this.Argument.Equals(input.Argument))) return false;
            if (this.Attachment != input.Attachment || (this.Attachment != null && input.Attachment != null && !this.Attachment.SequenceEqual(input.Attachment))) return false;
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
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;

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
                if (this.EnvName != null) hashCode = hashCode * 59 + this.EnvName.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.Indent != null) hashCode = hashCode * 59 + this.Indent.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.HostName != null) hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.IpAddress != null) hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.EventId != null) hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.NextSpanId != null) hashCode = hashCode * 59 + this.NextSpanId.GetHashCode();
                if (this.SourceEventId != null) hashCode = hashCode * 59 + this.SourceEventId.GetHashCode();
                if (this.Method != null) hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.ChildrenEventCount != null) hashCode = hashCode * 59 + this.ChildrenEventCount.GetHashCode();
                if (this.Discard != null) hashCode = hashCode * 59 + this.Discard.GetHashCode();
                if (this.Argument != null) hashCode = hashCode * 59 + this.Argument.GetHashCode();
                if (this.Attachment != null) hashCode = hashCode * 59 + this.Attachment.GetHashCode();
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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }
    }
}
