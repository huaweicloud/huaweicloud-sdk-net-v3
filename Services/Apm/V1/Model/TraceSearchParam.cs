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
    /// 查询span数据请求参数模型。
    /// </summary>
    public class TraceSearchParam 
    {

        /// <summary>
        /// region名称。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("order_param", NullValueHandling = NullValueHandling.Ignore)]
        public OrderParam OrderParam { get; set; }

        /// <summary>
        /// 是否为精确搜索。
        /// </summary>
        [JsonProperty("real_source_full_match", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RealSourceFullMatch { get; set; }

        /// <summary>
        /// 全匹配搜索。
        /// </summary>
        [JsonProperty("source_full_match", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SourceFullMatch { get; set; }

        /// <summary>
        /// header或body体，或自定义参数，或其他tags里字段的关键词搜索。
        /// </summary>
        [JsonProperty("tags_content", NullValueHandling = NullValueHandling.Ignore)]
        public string TagsContent { get; set; }

        /// <summary>
        /// 开始时间。
        /// </summary>
        [JsonProperty("start_time_string", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTimeString { get; set; }

        /// <summary>
        /// 结束时间。
        /// </summary>
        [JsonProperty("end_time_string", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTimeString { get; set; }

        /// <summary>
        /// 最小耗时。
        /// </summary>
        [JsonProperty("time_used_min", NullValueHandling = NullValueHandling.Ignore)]
        public long? TimeUsedMin { get; set; }

        /// <summary>
        /// 最大耗时。
        /// </summary>
        [JsonProperty("time_used_max", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeUsedMax { get; set; }

        /// <summary>
        /// 搜索结果是否包含tags内容详情。
        /// </summary>
        [JsonProperty("contain_tags_content", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ContainTagsContent { get; set; }

        /// <summary>
        /// 每一页返回的行数。
        /// </summary>
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 查询第几页的数据,默认查询第一页。
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// 参数。
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public string Parameters { get; set; }

        /// <summary>
        /// 字符串格式的的状态码，用于支持多个状态码查询。
        /// </summary>
        [JsonProperty("codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Codes { get; set; }

        /// <summary>
        /// vTraceId，虚拟traceId，一个vTraceId对应多个实际的traceId， vTraceId会从开始一直往下应用传输。
        /// </summary>
        [JsonProperty("global_trace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalTraceId { get; set; }

        /// <summary>
        /// 虚拟traceId经过的path路径。
        /// </summary>
        [JsonProperty("global_path", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalPath { get; set; }

        /// <summary>
        /// 在root的span调用产生的全局id，以此往后透传。
        /// </summary>
        [JsonProperty("trace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TraceId { get; set; }

        /// <summary>
        /// 代表一次rpc的调用的id，对于root的调用，值为字符串1，对于当前span调用的下一个spanId编号为1-1,1-2等格式，以此往后类推。
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
        /// 是否有错误。
        /// </summary>
        [JsonProperty("has_error", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasError { get; set; }

        /// <summary>
        /// 错误类型。
        /// </summary>
        [JsonProperty("error_reasons", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorReasons { get; set; }

        /// <summary>
        /// 类型。
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
            sb.Append("class TraceSearchParam {\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  orderParam: ").Append(OrderParam).Append("\n");
            sb.Append("  realSourceFullMatch: ").Append(RealSourceFullMatch).Append("\n");
            sb.Append("  sourceFullMatch: ").Append(SourceFullMatch).Append("\n");
            sb.Append("  tagsContent: ").Append(TagsContent).Append("\n");
            sb.Append("  startTimeString: ").Append(StartTimeString).Append("\n");
            sb.Append("  endTimeString: ").Append(EndTimeString).Append("\n");
            sb.Append("  timeUsedMin: ").Append(TimeUsedMin).Append("\n");
            sb.Append("  timeUsedMax: ").Append(TimeUsedMax).Append("\n");
            sb.Append("  containTagsContent: ").Append(ContainTagsContent).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  codes: ").Append(Codes).Append("\n");
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
            return this.Equals(input as TraceSearchParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TraceSearchParam input)
        {
            if (input == null) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.OrderParam != input.OrderParam || (this.OrderParam != null && !this.OrderParam.Equals(input.OrderParam))) return false;
            if (this.RealSourceFullMatch != input.RealSourceFullMatch || (this.RealSourceFullMatch != null && !this.RealSourceFullMatch.Equals(input.RealSourceFullMatch))) return false;
            if (this.SourceFullMatch != input.SourceFullMatch || (this.SourceFullMatch != null && !this.SourceFullMatch.Equals(input.SourceFullMatch))) return false;
            if (this.TagsContent != input.TagsContent || (this.TagsContent != null && !this.TagsContent.Equals(input.TagsContent))) return false;
            if (this.StartTimeString != input.StartTimeString || (this.StartTimeString != null && !this.StartTimeString.Equals(input.StartTimeString))) return false;
            if (this.EndTimeString != input.EndTimeString || (this.EndTimeString != null && !this.EndTimeString.Equals(input.EndTimeString))) return false;
            if (this.TimeUsedMin != input.TimeUsedMin || (this.TimeUsedMin != null && !this.TimeUsedMin.Equals(input.TimeUsedMin))) return false;
            if (this.TimeUsedMax != input.TimeUsedMax || (this.TimeUsedMax != null && !this.TimeUsedMax.Equals(input.TimeUsedMax))) return false;
            if (this.ContainTagsContent != input.ContainTagsContent || (this.ContainTagsContent != null && !this.ContainTagsContent.Equals(input.ContainTagsContent))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.Page != input.Page || (this.Page != null && !this.Page.Equals(input.Page))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && !this.Parameters.Equals(input.Parameters))) return false;
            if (this.Codes != input.Codes || (this.Codes != null && input.Codes != null && !this.Codes.SequenceEqual(input.Codes))) return false;
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
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.OrderParam != null) hashCode = hashCode * 59 + this.OrderParam.GetHashCode();
                if (this.RealSourceFullMatch != null) hashCode = hashCode * 59 + this.RealSourceFullMatch.GetHashCode();
                if (this.SourceFullMatch != null) hashCode = hashCode * 59 + this.SourceFullMatch.GetHashCode();
                if (this.TagsContent != null) hashCode = hashCode * 59 + this.TagsContent.GetHashCode();
                if (this.StartTimeString != null) hashCode = hashCode * 59 + this.StartTimeString.GetHashCode();
                if (this.EndTimeString != null) hashCode = hashCode * 59 + this.EndTimeString.GetHashCode();
                if (this.TimeUsedMin != null) hashCode = hashCode * 59 + this.TimeUsedMin.GetHashCode();
                if (this.TimeUsedMax != null) hashCode = hashCode * 59 + this.TimeUsedMax.GetHashCode();
                if (this.ContainTagsContent != null) hashCode = hashCode * 59 + this.ContainTagsContent.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.Page != null) hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Codes != null) hashCode = hashCode * 59 + this.Codes.GetHashCode();
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
