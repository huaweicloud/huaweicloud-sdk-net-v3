using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cts.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListTracesRequest 
    {
        /// <summary>
        /// 标识审计事件类型。 目前支持管理类事件（system）和数据类事件（data）。 默认值为\&quot;system\&quot;。
        /// </summary>
        /// <value>标识审计事件类型。 目前支持管理类事件（system）和数据类事件（data）。 默认值为\&quot;system\&quot;。</value>
        [JsonConverter(typeof(EnumClassConverter<TraceTypeEnum>))]
        public class TraceTypeEnum
        {
            /// <summary>
            /// Enum SYSTEM for value: system
            /// </summary>
            public static readonly TraceTypeEnum SYSTEM = new TraceTypeEnum("system");

            /// <summary>
            /// Enum DATA for value: data
            /// </summary>
            public static readonly TraceTypeEnum DATA = new TraceTypeEnum("data");

            private static readonly Dictionary<string, TraceTypeEnum> StaticFields =
            new Dictionary<string, TraceTypeEnum>()
            {
                { "system", SYSTEM },
                { "data", DATA },
            };

            private string _value;

            public TraceTypeEnum()
            {

            }

            public TraceTypeEnum(string value)
            {
                _value = value;
            }

            public static TraceTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as TraceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TraceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TraceTypeEnum a, TraceTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(TraceTypeEnum a, TraceTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 标示查询事件列表对应的事件等级目前有三种：正常(normal), 警告(warning),事故(incident)。 当\&quot;trace_type\&quot;字段值为\&quot;system\&quot;时，该字段筛选有效\&quot;。
        /// </summary>
        /// <value>标示查询事件列表对应的事件等级目前有三种：正常(normal), 警告(warning),事故(incident)。 当\&quot;trace_type\&quot;字段值为\&quot;system\&quot;时，该字段筛选有效\&quot;。</value>
        [JsonConverter(typeof(EnumClassConverter<TraceRatingEnum>))]
        public class TraceRatingEnum
        {
            /// <summary>
            /// Enum NORMAL for value: normal
            /// </summary>
            public static readonly TraceRatingEnum NORMAL = new TraceRatingEnum("normal");

            /// <summary>
            /// Enum WARNING for value: warning
            /// </summary>
            public static readonly TraceRatingEnum WARNING = new TraceRatingEnum("warning");

            /// <summary>
            /// Enum INCIDENT for value: incident
            /// </summary>
            public static readonly TraceRatingEnum INCIDENT = new TraceRatingEnum("incident");

            private static readonly Dictionary<string, TraceRatingEnum> StaticFields =
            new Dictionary<string, TraceRatingEnum>()
            {
                { "normal", NORMAL },
                { "warning", WARNING },
                { "incident", INCIDENT },
            };

            private string _value;

            public TraceRatingEnum()
            {

            }

            public TraceRatingEnum(string value)
            {
                _value = value;
            }

            public static TraceRatingEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as TraceRatingEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TraceRatingEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TraceRatingEnum a, TraceRatingEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(TraceRatingEnum a, TraceRatingEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 标识审计事件类型。 目前支持管理类事件（system）和数据类事件（data）。 默认值为\&quot;system\&quot;。
        /// </summary>
        [SDKProperty("trace_type", IsQuery = true)]
        [JsonProperty("trace_type", NullValueHandling = NullValueHandling.Ignore)]
        public TraceTypeEnum TraceType { get; set; }
        /// <summary>
        /// 标示查询事件列表中限定返回的事件条数。不传时默认10条，最大值200条。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 标识查询事件列表的起始时间戳（timestamp，为标准UTC时间，毫秒级，13位数字，不包括传入时间）默认为上一小时的时间戳。查询条件from与to配套使用。
        /// </summary>
        [SDKProperty("from", IsQuery = true)]
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public long? From { get; set; }

        /// <summary>
        /// 取值为响应中中marker的值，用于标识查询事件的起始时间（自此条事件的记录时间起，向更早时间查询）。 可以与“from”、“to”结合使用。 最终的查询条件取两组时间条件的交集。
        /// </summary>
        [SDKProperty("next", IsQuery = true)]
        [JsonProperty("next", NullValueHandling = NullValueHandling.Ignore)]
        public string Next { get; set; }

        /// <summary>
        /// 标识查询事件列表的结束时间戳（timestamp，为标准UTC时间，毫秒级，13位数字，不包括传入时间）默认为当前时间戳。查询条件to与from配套使用。
        /// </summary>
        [SDKProperty("to", IsQuery = true)]
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public long? To { get; set; }

        /// <summary>
        /// 当\&quot;trace_type\&quot;字段值为\&quot;system\&quot;时，该字段值默认为\&quot;system\&quot;。 当\&quot;trace_type\&quot;字段值为\&quot;data\&quot;时，该字段值可以传入数据类追踪器名称，达到筛选某个数据类追踪器下的数据事件目的。
        /// </summary>
        [SDKProperty("tracker_name", IsQuery = true)]
        [JsonProperty("tracker_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TrackerName { get; set; }

        /// <summary>
        /// 标识查询事件列表对应的云服务类型。必须为已对接CTS的云服务的英文缩写，且服务类型一般为大写字母。 当\&quot;trace_type\&quot;字段值为\&quot;system\&quot;时，该字段筛选有效\&quot;。 已对接的云服务列表参见《云审计服务用户指南》“支持的服务”章节。
        /// </summary>
        [SDKProperty("service_type", IsQuery = true)]
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        /// <summary>
        /// 标识特定用户名称，用以查询该用户下的所有事件。 当\&quot;trace_type\&quot;字段值为\&quot;system\&quot;时，该字段筛选有效\&quot;。
        /// </summary>
        [SDKProperty("user", IsQuery = true)]
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public string User { get; set; }

        /// <summary>
        /// 标示查询事件列表对应的云服务资源ID。 当\&quot;trace_type\&quot;字段值为\&quot;system\&quot;时，该字段筛选有效\&quot;。
        /// </summary>
        [SDKProperty("resource_id", IsQuery = true)]
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 标示查询事件列表对应的的资源名称。 当\&quot;trace_type\&quot;字段值为\&quot;system\&quot;时，该字段筛选有效\&quot;。 说明：该字段可能包含大写字母。
        /// </summary>
        [SDKProperty("resource_name", IsQuery = true)]
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 标示查询事件列表对应的资源类型。 当\&quot;trace_type\&quot;字段值为\&quot;system\&quot;时，该字段筛选有效\&quot;。
        /// </summary>
        [SDKProperty("resource_type", IsQuery = true)]
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 标示某一条事件的事件ID。当传入这个查询条件时，其他查询条件自动不生效。 当\&quot;trace_type\&quot;字段值为\&quot;system\&quot;时，该字段筛选有效\&quot;。
        /// </summary>
        [SDKProperty("trace_id", IsQuery = true)]
        [JsonProperty("trace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TraceId { get; set; }

        /// <summary>
        /// 标示查询事件列表对应的事件名称。 当\&quot;trace_type\&quot;字段值为\&quot;system\&quot;时，该字段筛选有效\&quot;。 说明：该字段可能包含大写字母。
        /// </summary>
        [SDKProperty("trace_name", IsQuery = true)]
        [JsonProperty("trace_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TraceName { get; set; }

        /// <summary>
        /// 标示查询事件列表对应的事件等级目前有三种：正常(normal), 警告(warning),事故(incident)。 当\&quot;trace_type\&quot;字段值为\&quot;system\&quot;时，该字段筛选有效\&quot;。
        /// </summary>
        [SDKProperty("trace_rating", IsQuery = true)]
        [JsonProperty("trace_rating", NullValueHandling = NullValueHandling.Ignore)]
        public TraceRatingEnum TraceRating { get; set; }
        /// <summary>
        /// 标示查询事件列表对应的访问密钥ID。包含临时访问凭证和永久访问密钥。
        /// </summary>
        [SDKProperty("access_key_id", IsQuery = true)]
        [JsonProperty("access_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// 标示查询事件列表对应的企业项目ID。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTracesRequest {\n");
            sb.Append("  traceType: ").Append(TraceType).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  from: ").Append(From).Append("\n");
            sb.Append("  next: ").Append(Next).Append("\n");
            sb.Append("  to: ").Append(To).Append("\n");
            sb.Append("  trackerName: ").Append(TrackerName).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  traceId: ").Append(TraceId).Append("\n");
            sb.Append("  traceName: ").Append(TraceName).Append("\n");
            sb.Append("  traceRating: ").Append(TraceRating).Append("\n");
            sb.Append("  accessKeyId: ").Append(AccessKeyId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTracesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTracesRequest input)
        {
            if (input == null) return false;
            if (this.TraceType != input.TraceType) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.From != input.From || (this.From != null && !this.From.Equals(input.From))) return false;
            if (this.Next != input.Next || (this.Next != null && !this.Next.Equals(input.Next))) return false;
            if (this.To != input.To || (this.To != null && !this.To.Equals(input.To))) return false;
            if (this.TrackerName != input.TrackerName || (this.TrackerName != null && !this.TrackerName.Equals(input.TrackerName))) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;
            if (this.User != input.User || (this.User != null && !this.User.Equals(input.User))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.TraceId != input.TraceId || (this.TraceId != null && !this.TraceId.Equals(input.TraceId))) return false;
            if (this.TraceName != input.TraceName || (this.TraceName != null && !this.TraceName.Equals(input.TraceName))) return false;
            if (this.TraceRating != input.TraceRating) return false;
            if (this.AccessKeyId != input.AccessKeyId || (this.AccessKeyId != null && !this.AccessKeyId.Equals(input.AccessKeyId))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;

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
                hashCode = hashCode * 59 + this.TraceType.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.From != null) hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Next != null) hashCode = hashCode * 59 + this.Next.GetHashCode();
                if (this.To != null) hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.TrackerName != null) hashCode = hashCode * 59 + this.TrackerName.GetHashCode();
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.User != null) hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.TraceId != null) hashCode = hashCode * 59 + this.TraceId.GetHashCode();
                if (this.TraceName != null) hashCode = hashCode * 59 + this.TraceName.GetHashCode();
                hashCode = hashCode * 59 + this.TraceRating.GetHashCode();
                if (this.AccessKeyId != null) hashCode = hashCode * 59 + this.AccessKeyId.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
