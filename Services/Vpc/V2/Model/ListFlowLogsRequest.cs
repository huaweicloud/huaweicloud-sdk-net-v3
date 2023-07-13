using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListFlowLogsRequest 
    {
        /// <summary>
        /// 功能说明：流日志所属资源类型 取值范围：支持port、network、vpc 3种类型。
        /// </summary>
        /// <value>功能说明：流日志所属资源类型 取值范围：支持port、network、vpc 3种类型。</value>
        [JsonConverter(typeof(EnumClassConverter<ResourceTypeEnum>))]
        public class ResourceTypeEnum
        {
            /// <summary>
            /// Enum PORT for value: port
            /// </summary>
            public static readonly ResourceTypeEnum PORT = new ResourceTypeEnum("port");

            /// <summary>
            /// Enum NETWORK for value: network
            /// </summary>
            public static readonly ResourceTypeEnum NETWORK = new ResourceTypeEnum("network");

            /// <summary>
            /// Enum VPC for value: vpc
            /// </summary>
            public static readonly ResourceTypeEnum VPC = new ResourceTypeEnum("vpc");

            private static readonly Dictionary<string, ResourceTypeEnum> StaticFields =
            new Dictionary<string, ResourceTypeEnum>()
            {
                { "port", PORT },
                { "network", NETWORK },
                { "vpc", VPC },
            };

            private string _value;

            public ResourceTypeEnum()
            {

            }

            public ResourceTypeEnum(string value)
            {
                _value = value;
            }

            public static ResourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ResourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResourceTypeEnum a, ResourceTypeEnum b)
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

            public static bool operator !=(ResourceTypeEnum a, ResourceTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 功能说明：流日志采集类型 取值范围：     1）all：采集指定资源的全部流量。     2）accept：采集指定资源允许传入、传出的流量。     3）reject：采集指定资源拒绝传入、传出的流量。
        /// </summary>
        /// <value>功能说明：流日志采集类型 取值范围：     1）all：采集指定资源的全部流量。     2）accept：采集指定资源允许传入、传出的流量。     3）reject：采集指定资源拒绝传入、传出的流量。</value>
        [JsonConverter(typeof(EnumClassConverter<TrafficTypeEnum>))]
        public class TrafficTypeEnum
        {
            /// <summary>
            /// Enum ALL for value: all
            /// </summary>
            public static readonly TrafficTypeEnum ALL = new TrafficTypeEnum("all");

            /// <summary>
            /// Enum REJECT for value: reject
            /// </summary>
            public static readonly TrafficTypeEnum REJECT = new TrafficTypeEnum("reject");

            /// <summary>
            /// Enum ACCEPT for value: accept
            /// </summary>
            public static readonly TrafficTypeEnum ACCEPT = new TrafficTypeEnum("accept");

            private static readonly Dictionary<string, TrafficTypeEnum> StaticFields =
            new Dictionary<string, TrafficTypeEnum>()
            {
                { "all", ALL },
                { "reject", REJECT },
                { "accept", ACCEPT },
            };

            private string _value;

            public TrafficTypeEnum()
            {

            }

            public TrafficTypeEnum(string value)
            {
                _value = value;
            }

            public static TrafficTypeEnum FromValue(string value)
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

                if (this.Equals(obj as TrafficTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TrafficTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TrafficTypeEnum a, TrafficTypeEnum b)
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

            public static bool operator !=(TrafficTypeEnum a, TrafficTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 功能说明：流日志存储类型 取值范围：     lts：存储类型为云日志服务（LTS）。
        /// </summary>
        /// <value>功能说明：流日志存储类型 取值范围：     lts：存储类型为云日志服务（LTS）。</value>
        [JsonConverter(typeof(EnumClassConverter<LogStoreTypeEnum>))]
        public class LogStoreTypeEnum
        {
            /// <summary>
            /// Enum LTS for value: lts
            /// </summary>
            public static readonly LogStoreTypeEnum LTS = new LogStoreTypeEnum("lts");

            private static readonly Dictionary<string, LogStoreTypeEnum> StaticFields =
            new Dictionary<string, LogStoreTypeEnum>()
            {
                { "lts", LTS },
            };

            private string _value;

            public LogStoreTypeEnum()
            {

            }

            public LogStoreTypeEnum(string value)
            {
                _value = value;
            }

            public static LogStoreTypeEnum FromValue(string value)
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

                if (this.Equals(obj as LogStoreTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LogStoreTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LogStoreTypeEnum a, LogStoreTypeEnum b)
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

            public static bool operator !=(LogStoreTypeEnum a, LogStoreTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 功能说明：流日志状态 取值范围：     ACTIVE：开启     DOWN：关闭     ERROR：异常故障
        /// </summary>
        /// <value>功能说明：流日志状态 取值范围：     ACTIVE：开启     DOWN：关闭     ERROR：异常故障</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("ACTIVE");

            /// <summary>
            /// Enum DOWN for value: DOWN
            /// </summary>
            public static readonly StatusEnum DOWN = new StatusEnum("DOWN");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly StatusEnum ERROR = new StatusEnum("ERROR");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "ACTIVE", ACTIVE },
                { "DOWN", DOWN },
                { "ERROR", ERROR },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 流日志资源唯一标识
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 功能说明：流日志名称 取值范围：0-64个字符，支持数字、字母、中文、_（下划线）、-（中划线）、.（点）
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [SDKProperty("tenant_id", IsQuery = true)]
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 功能说明：流日志描述 取值范围：0-255个字符，不能包含“&lt;”和“&gt;”
        /// </summary>
        [SDKProperty("description", IsQuery = true)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 功能说明：流日志所属资源类型 取值范围：支持port、network、vpc 3种类型。
        /// </summary>
        [SDKProperty("resource_type", IsQuery = true)]
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceTypeEnum ResourceType { get; set; }
        /// <summary>
        /// resource_type对应资源的唯一ID
        /// </summary>
        [SDKProperty("resource_id", IsQuery = true)]
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 功能说明：流日志采集类型 取值范围：     1）all：采集指定资源的全部流量。     2）accept：采集指定资源允许传入、传出的流量。     3）reject：采集指定资源拒绝传入、传出的流量。
        /// </summary>
        [SDKProperty("traffic_type", IsQuery = true)]
        [JsonProperty("traffic_type", NullValueHandling = NullValueHandling.Ignore)]
        public TrafficTypeEnum TrafficType { get; set; }
        /// <summary>
        /// 日志组ID 请在云日志服务中获取，详情请参见《云日志服务用户指南》。
        /// </summary>
        [SDKProperty("log_group_id", IsQuery = true)]
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }

        /// <summary>
        /// 日志主题ID 请在云日志服务中获取，详情请参见《云日志服务用户指南》。
        /// </summary>
        [SDKProperty("log_topic_id", IsQuery = true)]
        [JsonProperty("log_topic_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogTopicId { get; set; }

        /// <summary>
        /// 功能说明：流日志存储类型 取值范围：     lts：存储类型为云日志服务（LTS）。
        /// </summary>
        [SDKProperty("log_store_type", IsQuery = true)]
        [JsonProperty("log_store_type", NullValueHandling = NullValueHandling.Ignore)]
        public LogStoreTypeEnum LogStoreType { get; set; }
        /// <summary>
        /// 功能说明：流日志状态 取值范围：     ACTIVE：开启     DOWN：关闭     ERROR：异常故障
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 功能说明：每页返回的个数 取值范围：0 ~ intmax
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// 分页查询起始的资源ID，为空时为查询第一页
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFlowLogsRequest {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  trafficType: ").Append(TrafficType).Append("\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("  logTopicId: ").Append(LogTopicId).Append("\n");
            sb.Append("  logStoreType: ").Append(LogStoreType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFlowLogsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFlowLogsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.TrafficType == input.TrafficType ||
                    (this.TrafficType != null &&
                    this.TrafficType.Equals(input.TrafficType))
                ) && 
                (
                    this.LogGroupId == input.LogGroupId ||
                    (this.LogGroupId != null &&
                    this.LogGroupId.Equals(input.LogGroupId))
                ) && 
                (
                    this.LogTopicId == input.LogTopicId ||
                    (this.LogTopicId != null &&
                    this.LogTopicId.Equals(input.LogTopicId))
                ) && 
                (
                    this.LogStoreType == input.LogStoreType ||
                    (this.LogStoreType != null &&
                    this.LogStoreType.Equals(input.LogStoreType))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.TrafficType != null)
                    hashCode = hashCode * 59 + this.TrafficType.GetHashCode();
                if (this.LogGroupId != null)
                    hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.LogTopicId != null)
                    hashCode = hashCode * 59 + this.LogTopicId.GetHashCode();
                if (this.LogStoreType != null)
                    hashCode = hashCode * 59 + this.LogStoreType.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                return hashCode;
            }
        }
    }
}
