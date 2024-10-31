using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateAccessConfigResponse : SdkResponse
    {
        /// <summary>
        /// 日志接入类型。AGENT：ECS接入  K8S_CCE: CCE接入
        /// </summary>
        /// <value>日志接入类型。AGENT：ECS接入  K8S_CCE: CCE接入</value>
        [JsonConverter(typeof(EnumClassConverter<AccessConfigTypeEnum>))]
        public class AccessConfigTypeEnum
        {
            /// <summary>
            /// Enum AGENT for value: AGENT
            /// </summary>
            public static readonly AccessConfigTypeEnum AGENT = new AccessConfigTypeEnum("AGENT");

            /// <summary>
            /// Enum K8S_CCE for value: K8S_CCE
            /// </summary>
            public static readonly AccessConfigTypeEnum K8S_CCE = new AccessConfigTypeEnum("K8S_CCE");

            private static readonly Dictionary<string, AccessConfigTypeEnum> StaticFields =
            new Dictionary<string, AccessConfigTypeEnum>()
            {
                { "AGENT", AGENT },
                { "K8S_CCE", K8S_CCE },
            };

            private string _value;

            public AccessConfigTypeEnum()
            {

            }

            public AccessConfigTypeEnum(string value)
            {
                _value = value;
            }

            public static AccessConfigTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AccessConfigTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AccessConfigTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AccessConfigTypeEnum a, AccessConfigTypeEnum b)
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

            public static bool operator !=(AccessConfigTypeEnum a, AccessConfigTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 日志接入ID
        /// </summary>
        [JsonProperty("access_config_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessConfigId { get; set; }

        /// <summary>
        /// 日志接入名称
        /// </summary>
        [JsonProperty("access_config_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessConfigName { get; set; }

        /// <summary>
        /// 日志接入类型。AGENT：ECS接入  K8S_CCE: CCE接入
        /// </summary>
        [JsonProperty("access_config_type", NullValueHandling = NullValueHandling.Ignore)]
        public AccessConfigTypeEnum AccessConfigType { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("access_config_detail", NullValueHandling = NullValueHandling.Ignore)]
        public AccessConfigDeatilCreate AccessConfigDetail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("log_info", NullValueHandling = NullValueHandling.Ignore)]
        public AccessConfigQueryLogInfo LogInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("host_group_info", NullValueHandling = NullValueHandling.Ignore)]
        public AccessConfigHostGroupIdList HostGroupInfo { get; set; }

        /// <summary>
        /// 标签信息。KEY不能重复,最多20个标签
        /// </summary>
        [JsonProperty("access_config_tag", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessConfigTag> AccessConfigTag { get; set; }

        /// <summary>
        /// 二进制采集
        /// </summary>
        [JsonProperty("log_split", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LogSplit { get; set; }

        /// <summary>
        /// 日志拆分
        /// </summary>
        [JsonProperty("binary_collect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BinaryCollect { get; set; }

        /// <summary>
        /// CCE集群ID
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 编码格式，默认UTF-8
        /// </summary>
        [JsonProperty("encoding_format", NullValueHandling = NullValueHandling.Ignore)]
        public string EncodingFormat { get; set; }

        /// <summary>
        /// 采集策略：增量/全量
        /// </summary>
        [JsonProperty("incremental_collect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncrementalCollect { get; set; }

        /// <summary>
        /// IC结构化解析类型
        /// </summary>
        [JsonProperty("processor_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProcessorType { get; set; }

        /// <summary>
        /// 示例日志
        /// </summary>
        [JsonProperty("demo_log", NullValueHandling = NullValueHandling.Ignore)]
        public string DemoLog { get; set; }

        /// <summary>
        /// 示例日志解析字段
        /// </summary>
        [JsonProperty("demo_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<DemoFieldAccess> DemoFields { get; set; }

        /// <summary>
        /// IC结构化解析器
        /// </summary>
        [JsonProperty("processors", NullValueHandling = NullValueHandling.Ignore)]
        public List<Processor> Processors { get; set; }

        /// <summary>
        /// ServiceStage应用ID
        /// </summary>
        [JsonProperty("application_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// ServiceStage环境ID
        /// </summary>
        [JsonProperty("environment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// ServiceStage组件ID
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ComponentId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAccessConfigResponse {\n");
            sb.Append("  accessConfigId: ").Append(AccessConfigId).Append("\n");
            sb.Append("  accessConfigName: ").Append(AccessConfigName).Append("\n");
            sb.Append("  accessConfigType: ").Append(AccessConfigType).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  accessConfigDetail: ").Append(AccessConfigDetail).Append("\n");
            sb.Append("  logInfo: ").Append(LogInfo).Append("\n");
            sb.Append("  hostGroupInfo: ").Append(HostGroupInfo).Append("\n");
            sb.Append("  accessConfigTag: ").Append(AccessConfigTag).Append("\n");
            sb.Append("  logSplit: ").Append(LogSplit).Append("\n");
            sb.Append("  binaryCollect: ").Append(BinaryCollect).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  encodingFormat: ").Append(EncodingFormat).Append("\n");
            sb.Append("  incrementalCollect: ").Append(IncrementalCollect).Append("\n");
            sb.Append("  processorType: ").Append(ProcessorType).Append("\n");
            sb.Append("  demoLog: ").Append(DemoLog).Append("\n");
            sb.Append("  demoFields: ").Append(DemoFields).Append("\n");
            sb.Append("  processors: ").Append(Processors).Append("\n");
            sb.Append("  applicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  environmentId: ").Append(EnvironmentId).Append("\n");
            sb.Append("  componentId: ").Append(ComponentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAccessConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAccessConfigResponse input)
        {
            if (input == null) return false;
            if (this.AccessConfigId != input.AccessConfigId || (this.AccessConfigId != null && !this.AccessConfigId.Equals(input.AccessConfigId))) return false;
            if (this.AccessConfigName != input.AccessConfigName || (this.AccessConfigName != null && !this.AccessConfigName.Equals(input.AccessConfigName))) return false;
            if (this.AccessConfigType != input.AccessConfigType) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.AccessConfigDetail != input.AccessConfigDetail || (this.AccessConfigDetail != null && !this.AccessConfigDetail.Equals(input.AccessConfigDetail))) return false;
            if (this.LogInfo != input.LogInfo || (this.LogInfo != null && !this.LogInfo.Equals(input.LogInfo))) return false;
            if (this.HostGroupInfo != input.HostGroupInfo || (this.HostGroupInfo != null && !this.HostGroupInfo.Equals(input.HostGroupInfo))) return false;
            if (this.AccessConfigTag != input.AccessConfigTag || (this.AccessConfigTag != null && input.AccessConfigTag != null && !this.AccessConfigTag.SequenceEqual(input.AccessConfigTag))) return false;
            if (this.LogSplit != input.LogSplit || (this.LogSplit != null && !this.LogSplit.Equals(input.LogSplit))) return false;
            if (this.BinaryCollect != input.BinaryCollect || (this.BinaryCollect != null && !this.BinaryCollect.Equals(input.BinaryCollect))) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.EncodingFormat != input.EncodingFormat || (this.EncodingFormat != null && !this.EncodingFormat.Equals(input.EncodingFormat))) return false;
            if (this.IncrementalCollect != input.IncrementalCollect || (this.IncrementalCollect != null && !this.IncrementalCollect.Equals(input.IncrementalCollect))) return false;
            if (this.ProcessorType != input.ProcessorType || (this.ProcessorType != null && !this.ProcessorType.Equals(input.ProcessorType))) return false;
            if (this.DemoLog != input.DemoLog || (this.DemoLog != null && !this.DemoLog.Equals(input.DemoLog))) return false;
            if (this.DemoFields != input.DemoFields || (this.DemoFields != null && input.DemoFields != null && !this.DemoFields.SequenceEqual(input.DemoFields))) return false;
            if (this.Processors != input.Processors || (this.Processors != null && input.Processors != null && !this.Processors.SequenceEqual(input.Processors))) return false;
            if (this.ApplicationId != input.ApplicationId || (this.ApplicationId != null && !this.ApplicationId.Equals(input.ApplicationId))) return false;
            if (this.EnvironmentId != input.EnvironmentId || (this.EnvironmentId != null && !this.EnvironmentId.Equals(input.EnvironmentId))) return false;
            if (this.ComponentId != input.ComponentId || (this.ComponentId != null && input.ComponentId != null && !this.ComponentId.SequenceEqual(input.ComponentId))) return false;

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
                if (this.AccessConfigId != null) hashCode = hashCode * 59 + this.AccessConfigId.GetHashCode();
                if (this.AccessConfigName != null) hashCode = hashCode * 59 + this.AccessConfigName.GetHashCode();
                hashCode = hashCode * 59 + this.AccessConfigType.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.AccessConfigDetail != null) hashCode = hashCode * 59 + this.AccessConfigDetail.GetHashCode();
                if (this.LogInfo != null) hashCode = hashCode * 59 + this.LogInfo.GetHashCode();
                if (this.HostGroupInfo != null) hashCode = hashCode * 59 + this.HostGroupInfo.GetHashCode();
                if (this.AccessConfigTag != null) hashCode = hashCode * 59 + this.AccessConfigTag.GetHashCode();
                if (this.LogSplit != null) hashCode = hashCode * 59 + this.LogSplit.GetHashCode();
                if (this.BinaryCollect != null) hashCode = hashCode * 59 + this.BinaryCollect.GetHashCode();
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.EncodingFormat != null) hashCode = hashCode * 59 + this.EncodingFormat.GetHashCode();
                if (this.IncrementalCollect != null) hashCode = hashCode * 59 + this.IncrementalCollect.GetHashCode();
                if (this.ProcessorType != null) hashCode = hashCode * 59 + this.ProcessorType.GetHashCode();
                if (this.DemoLog != null) hashCode = hashCode * 59 + this.DemoLog.GetHashCode();
                if (this.DemoFields != null) hashCode = hashCode * 59 + this.DemoFields.GetHashCode();
                if (this.Processors != null) hashCode = hashCode * 59 + this.Processors.GetHashCode();
                if (this.ApplicationId != null) hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.EnvironmentId != null) hashCode = hashCode * 59 + this.EnvironmentId.GetHashCode();
                if (this.ComponentId != null) hashCode = hashCode * 59 + this.ComponentId.GetHashCode();
                return hashCode;
            }
        }
    }
}
