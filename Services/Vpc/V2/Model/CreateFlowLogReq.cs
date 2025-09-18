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
    /// 
    /// </summary>
    public class CreateFlowLogReq 
    {
        /// <summary>
        /// 功能说明：流日志所属资源类型 取值范围：支持port、network、vpc 类型。
        /// </summary>
        /// <value>功能说明：流日志所属资源类型 取值范围：支持port、network、vpc 类型。</value>
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
                if (ReferenceEquals(a, b))
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
            /// Enum ACCEPT for value: accept
            /// </summary>
            public static readonly TrafficTypeEnum ACCEPT = new TrafficTypeEnum("accept");

            /// <summary>
            /// Enum REJECT for value: reject
            /// </summary>
            public static readonly TrafficTypeEnum REJECT = new TrafficTypeEnum("reject");

            private static readonly Dictionary<string, TrafficTypeEnum> StaticFields =
            new Dictionary<string, TrafficTypeEnum>()
            {
                { "all", ALL },
                { "accept", ACCEPT },
                { "reject", REJECT },
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
                if (ReferenceEquals(a, b))
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
        /// 功能说明：流日志名称 取值范围：0-64个字符，支持数字、字母、中文、_（下划线）、-（中划线）、.（点）
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 功能说明：流日志描述 取值范围：0-255个字符，不能包含“&lt;”和“&gt;”
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 功能说明：流日志所属资源类型 取值范围：支持port、network、vpc 类型。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceTypeEnum ResourceType { get; set; }
        /// <summary>
        /// resource_type对应资源的唯一ID
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 功能说明：流日志采集类型 取值范围：     1）all：采集指定资源的全部流量。     2）accept：采集指定资源允许传入、传出的流量。     3）reject：采集指定资源拒绝传入、传出的流量。
        /// </summary>
        [JsonProperty("traffic_type", NullValueHandling = NullValueHandling.Ignore)]
        public TrafficTypeEnum TrafficType { get; set; }
        /// <summary>
        /// 日志组ID 请在云日志服务中获取，详情请参见《云日志服务用户指南》。
        /// </summary>
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }

        /// <summary>
        /// 日志主题ID 请在云日志服务中获取，详情请参见《云日志服务用户指南》。
        /// </summary>
        [JsonProperty("log_topic_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogTopicId { get; set; }

        /// <summary>
        /// 功能说明：是否开启日志索引 取值范围：true，false
        /// </summary>
        [JsonProperty("index_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IndexEnabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFlowLogReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  trafficType: ").Append(TrafficType).Append("\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("  logTopicId: ").Append(LogTopicId).Append("\n");
            sb.Append("  indexEnabled: ").Append(IndexEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateFlowLogReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateFlowLogReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ResourceType != input.ResourceType) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.TrafficType != input.TrafficType) return false;
            if (this.LogGroupId != input.LogGroupId || (this.LogGroupId != null && !this.LogGroupId.Equals(input.LogGroupId))) return false;
            if (this.LogTopicId != input.LogTopicId || (this.LogTopicId != null && !this.LogTopicId.Equals(input.LogTopicId))) return false;
            if (this.IndexEnabled != input.IndexEnabled || (this.IndexEnabled != null && !this.IndexEnabled.Equals(input.IndexEnabled))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                hashCode = hashCode * 59 + this.TrafficType.GetHashCode();
                if (this.LogGroupId != null) hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.LogTopicId != null) hashCode = hashCode * 59 + this.LogTopicId.GetHashCode();
                if (this.IndexEnabled != null) hashCode = hashCode * 59 + this.IndexEnabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
