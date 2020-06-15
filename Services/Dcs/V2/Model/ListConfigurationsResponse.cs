using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListConfigurationsResponse : SdkResponse
    {
        /// <summary>
        /// 实例修改状态 - UPDATING - FAILURE - SUCCESS 
        /// </summary>
        /// <value>实例修改状态 - UPDATING - FAILURE - SUCCESS </value>
        [JsonConverter(typeof(EnumClassConverter<ConfigStatusEnum>))]
        public class ConfigStatusEnum
        {
            /// <summary>
            /// Enum UPDATING for value: UPDATING
            /// </summary>
            public static readonly ConfigStatusEnum UPDATING = new ConfigStatusEnum("UPDATING");

            /// <summary>
            /// Enum FAILURE for value: FAILURE
            /// </summary>
            public static readonly ConfigStatusEnum FAILURE = new ConfigStatusEnum("FAILURE");

            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            public static readonly ConfigStatusEnum SUCCESS = new ConfigStatusEnum("SUCCESS");

            public static readonly Dictionary<string, ConfigStatusEnum> StaticFields =
            new Dictionary<string, ConfigStatusEnum>()
            {
                {"UPDATING", UPDATING},
                {"FAILURE", FAILURE},
                {"SUCCESS", SUCCESS},
            };

            private string Value;

            public ConfigStatusEnum(string Value)
            {
                this.Value = Value;
            }

            public static ConfigStatusEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
            {
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as ConfigStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConfigStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ConfigStatusEnum a, ConfigStatusEnum b)
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

            public static bool operator !=(ConfigStatusEnum a, ConfigStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例操作时间。格式为：2017-03-31T12:24:46.297Z
        /// </summary>
        [JsonProperty("config_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigTime { get; set; }

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 实例配置项数组。
        /// </summary>
        [JsonProperty("redis_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryRedisConfig> RedisConfig { get; set; }

        /// <summary>
        /// 实例修改状态 - UPDATING - FAILURE - SUCCESS 
        /// </summary>
        [JsonProperty("config_status", NullValueHandling = NullValueHandling.Ignore)]
        public ConfigStatusEnum ConfigStatus { get; set; }
        /// <summary>
        /// 实例运行状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListConfigurationsResponse {\n");
            sb.Append("  configTime: ").Append(ConfigTime).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  redisConfig: ").Append(RedisConfig).Append("\n");
            sb.Append("  configStatus: ").Append(ConfigStatus).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListConfigurationsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListConfigurationsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfigTime == input.ConfigTime ||
                    (this.ConfigTime != null &&
                    this.ConfigTime.Equals(input.ConfigTime))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.RedisConfig == input.RedisConfig ||
                    this.RedisConfig != null &&
                    input.RedisConfig != null &&
                    this.RedisConfig.SequenceEqual(input.RedisConfig)
                ) && 
                (
                    this.ConfigStatus == input.ConfigStatus ||
                    (this.ConfigStatus != null &&
                    this.ConfigStatus.Equals(input.ConfigStatus))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.ConfigTime != null)
                    hashCode = hashCode * 59 + this.ConfigTime.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.RedisConfig != null)
                    hashCode = hashCode * 59 + this.RedisConfig.GetHashCode();
                if (this.ConfigStatus != null)
                    hashCode = hashCode * 59 + this.ConfigStatus.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
