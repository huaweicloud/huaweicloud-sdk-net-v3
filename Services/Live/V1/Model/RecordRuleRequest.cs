using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RecordRuleRequest 
    {
        /// <summary>
        /// 录制类型，包括：CONTINUOUS_RECORD，COMMAND_RECORD，PLAN_RECORD，ON_DEMAND_RECORD。默认CONTINUOUS_RECORD。 - CONTINUOUS_RECORD：持续录制，在该规则类型配置后，只要有流到推送到录制系统，就触发录制。 - COMMAND_RECORD：命令录制，在该规则类型配置后，在流推送到录制系统后，租户需要通过命令控制该流的录制开始和结束。 - PLAN_RECORD：计划录制，在该规则类型配置后，推的流如果在计划录制的时间区间则触发录制。 - ON_DEMAND_RECORD：按需录制，在该规则类型配置后，录制系统收到推流后，需要调用租户提供的接口查询录制规则，并根据规则录制。 
        /// </summary>
        /// <value>录制类型，包括：CONTINUOUS_RECORD，COMMAND_RECORD，PLAN_RECORD，ON_DEMAND_RECORD。默认CONTINUOUS_RECORD。 - CONTINUOUS_RECORD：持续录制，在该规则类型配置后，只要有流到推送到录制系统，就触发录制。 - COMMAND_RECORD：命令录制，在该规则类型配置后，在流推送到录制系统后，租户需要通过命令控制该流的录制开始和结束。 - PLAN_RECORD：计划录制，在该规则类型配置后，推的流如果在计划录制的时间区间则触发录制。 - ON_DEMAND_RECORD：按需录制，在该规则类型配置后，录制系统收到推流后，需要调用租户提供的接口查询录制规则，并根据规则录制。 </value>
        [JsonConverter(typeof(EnumClassConverter<RecordTypeEnum>))]
        public class RecordTypeEnum
        {
            /// <summary>
            /// Enum CONTINUOUS_RECORD for value: CONTINUOUS_RECORD
            /// </summary>
            public static readonly RecordTypeEnum CONTINUOUS_RECORD = new RecordTypeEnum("CONTINUOUS_RECORD");

            /// <summary>
            /// Enum COMMAND_RECORD for value: COMMAND_RECORD
            /// </summary>
            public static readonly RecordTypeEnum COMMAND_RECORD = new RecordTypeEnum("COMMAND_RECORD");

            /// <summary>
            /// Enum PLAN_RECORD for value: PLAN_RECORD
            /// </summary>
            public static readonly RecordTypeEnum PLAN_RECORD = new RecordTypeEnum("PLAN_RECORD");

            /// <summary>
            /// Enum ON_DEMAND_RECORD for value: ON_DEMAND_RECORD
            /// </summary>
            public static readonly RecordTypeEnum ON_DEMAND_RECORD = new RecordTypeEnum("ON_DEMAND_RECORD");

            private static readonly Dictionary<string, RecordTypeEnum> StaticFields =
            new Dictionary<string, RecordTypeEnum>()
            {
                { "CONTINUOUS_RECORD", CONTINUOUS_RECORD },
                { "COMMAND_RECORD", COMMAND_RECORD },
                { "PLAN_RECORD", PLAN_RECORD },
                { "ON_DEMAND_RECORD", ON_DEMAND_RECORD },
            };

            private string _value;

            public RecordTypeEnum()
            {

            }

            public RecordTypeEnum(string value)
            {
                _value = value;
            }

            public static RecordTypeEnum FromValue(string value)
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

                if (this.Equals(obj as RecordTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RecordTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RecordTypeEnum a, RecordTypeEnum b)
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

            public static bool operator !=(RecordTypeEnum a, RecordTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 直播推流域名
        /// </summary>
        [JsonProperty("publish_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishDomain { get; set; }

        /// <summary>
        /// 应用名，如需匹配任意应用则填写*。录制规则匹配的时候，优先精确app匹配，如果匹配不到，则匹配*
        /// </summary>
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// 录制的流名，如需匹配任流名则填写*。录制规则匹配的时候，优先精确stream匹配，如果匹配不到，则匹配*
        /// </summary>
        [JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
        public string Stream { get; set; }

        /// <summary>
        /// 录制类型，包括：CONTINUOUS_RECORD，COMMAND_RECORD，PLAN_RECORD，ON_DEMAND_RECORD。默认CONTINUOUS_RECORD。 - CONTINUOUS_RECORD：持续录制，在该规则类型配置后，只要有流到推送到录制系统，就触发录制。 - COMMAND_RECORD：命令录制，在该规则类型配置后，在流推送到录制系统后，租户需要通过命令控制该流的录制开始和结束。 - PLAN_RECORD：计划录制，在该规则类型配置后，推的流如果在计划录制的时间区间则触发录制。 - ON_DEMAND_RECORD：按需录制，在该规则类型配置后，录制系统收到推流后，需要调用租户提供的接口查询录制规则，并根据规则录制。 
        /// </summary>
        [JsonProperty("record_type", NullValueHandling = NullValueHandling.Ignore)]
        public RecordTypeEnum RecordType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("default_record_config", NullValueHandling = NullValueHandling.Ignore)]
        public DefaultRecordConfig DefaultRecordConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordRuleRequest {\n");
            sb.Append("  publishDomain: ").Append(PublishDomain).Append("\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  stream: ").Append(Stream).Append("\n");
            sb.Append("  recordType: ").Append(RecordType).Append("\n");
            sb.Append("  defaultRecordConfig: ").Append(DefaultRecordConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecordRuleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecordRuleRequest input)
        {
            if (input == null) return false;
            if (this.PublishDomain != input.PublishDomain || (this.PublishDomain != null && !this.PublishDomain.Equals(input.PublishDomain))) return false;
            if (this.App != input.App || (this.App != null && !this.App.Equals(input.App))) return false;
            if (this.Stream != input.Stream || (this.Stream != null && !this.Stream.Equals(input.Stream))) return false;
            if (this.RecordType != input.RecordType) return false;
            if (this.DefaultRecordConfig != input.DefaultRecordConfig || (this.DefaultRecordConfig != null && !this.DefaultRecordConfig.Equals(input.DefaultRecordConfig))) return false;

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
                if (this.PublishDomain != null) hashCode = hashCode * 59 + this.PublishDomain.GetHashCode();
                if (this.App != null) hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.Stream != null) hashCode = hashCode * 59 + this.Stream.GetHashCode();
                hashCode = hashCode * 59 + this.RecordType.GetHashCode();
                if (this.DefaultRecordConfig != null) hashCode = hashCode * 59 + this.DefaultRecordConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
