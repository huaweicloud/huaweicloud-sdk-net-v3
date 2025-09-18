using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateFunctionTriggerRequestBody 
    {
        /// <summary>
        /// 触发器类型。  - TIMER: 定时触发器。 - APIG: APIGW触发器。 - CTS: 云审计触发器，需要先开通云审计服务。 - DDS: 文档数据库触发器，需要开启函数vpc。 - DMS: 分布式消息服务触发器，需要配置dms委托。 - DIS: 数据接入服务触发器，需要配置dis委托。 - LTS: 云审计日志服务触发器，需要配置lts委托。 - OBS: 对象存储服务触发器。 - KAFKA: 专享版本kafka触发器。
        /// </summary>
        /// <value>触发器类型。  - TIMER: 定时触发器。 - APIG: APIGW触发器。 - CTS: 云审计触发器，需要先开通云审计服务。 - DDS: 文档数据库触发器，需要开启函数vpc。 - DMS: 分布式消息服务触发器，需要配置dms委托。 - DIS: 数据接入服务触发器，需要配置dis委托。 - LTS: 云审计日志服务触发器，需要配置lts委托。 - OBS: 对象存储服务触发器。 - KAFKA: 专享版本kafka触发器。</value>
        [JsonConverter(typeof(EnumClassConverter<TriggerTypeCodeEnum>))]
        public class TriggerTypeCodeEnum
        {
            /// <summary>
            /// Enum TIMER for value: TIMER
            /// </summary>
            public static readonly TriggerTypeCodeEnum TIMER = new TriggerTypeCodeEnum("TIMER");

            /// <summary>
            /// Enum APIG for value: APIG
            /// </summary>
            public static readonly TriggerTypeCodeEnum APIG = new TriggerTypeCodeEnum("APIG");

            /// <summary>
            /// Enum CTS for value: CTS
            /// </summary>
            public static readonly TriggerTypeCodeEnum CTS = new TriggerTypeCodeEnum("CTS");

            /// <summary>
            /// Enum DDS for value: DDS
            /// </summary>
            public static readonly TriggerTypeCodeEnum DDS = new TriggerTypeCodeEnum("DDS");

            /// <summary>
            /// Enum DMS for value: DMS
            /// </summary>
            public static readonly TriggerTypeCodeEnum DMS = new TriggerTypeCodeEnum("DMS");

            /// <summary>
            /// Enum DIS for value: DIS
            /// </summary>
            public static readonly TriggerTypeCodeEnum DIS = new TriggerTypeCodeEnum("DIS");

            /// <summary>
            /// Enum LTS for value: LTS
            /// </summary>
            public static readonly TriggerTypeCodeEnum LTS = new TriggerTypeCodeEnum("LTS");

            /// <summary>
            /// Enum OBS for value: OBS
            /// </summary>
            public static readonly TriggerTypeCodeEnum OBS = new TriggerTypeCodeEnum("OBS");

            /// <summary>
            /// Enum SMN for value: SMN
            /// </summary>
            public static readonly TriggerTypeCodeEnum SMN = new TriggerTypeCodeEnum("SMN");

            /// <summary>
            /// Enum KAFKA for value: KAFKA
            /// </summary>
            public static readonly TriggerTypeCodeEnum KAFKA = new TriggerTypeCodeEnum("KAFKA");

            /// <summary>
            /// Enum RABBITMQ for value: RABBITMQ
            /// </summary>
            public static readonly TriggerTypeCodeEnum RABBITMQ = new TriggerTypeCodeEnum("RABBITMQ");

            /// <summary>
            /// Enum DEDICATEDGATEWAY for value: DEDICATEDGATEWAY
            /// </summary>
            public static readonly TriggerTypeCodeEnum DEDICATEDGATEWAY = new TriggerTypeCodeEnum("DEDICATEDGATEWAY");

            /// <summary>
            /// Enum OPENSOURCEKAFKA for value: OPENSOURCEKAFKA
            /// </summary>
            public static readonly TriggerTypeCodeEnum OPENSOURCEKAFKA = new TriggerTypeCodeEnum("OPENSOURCEKAFKA");

            /// <summary>
            /// Enum APIC for value: APIC
            /// </summary>
            public static readonly TriggerTypeCodeEnum APIC = new TriggerTypeCodeEnum("APIC");

            /// <summary>
            /// Enum GAUSSMONGO for value: GAUSSMONGO
            /// </summary>
            public static readonly TriggerTypeCodeEnum GAUSSMONGO = new TriggerTypeCodeEnum("GAUSSMONGO");

            /// <summary>
            /// Enum EVENTGRID for value: EVENTGRID
            /// </summary>
            public static readonly TriggerTypeCodeEnum EVENTGRID = new TriggerTypeCodeEnum("EVENTGRID");

            private static readonly Dictionary<string, TriggerTypeCodeEnum> StaticFields =
            new Dictionary<string, TriggerTypeCodeEnum>()
            {
                { "TIMER", TIMER },
                { "APIG", APIG },
                { "CTS", CTS },
                { "DDS", DDS },
                { "DMS", DMS },
                { "DIS", DIS },
                { "LTS", LTS },
                { "OBS", OBS },
                { "SMN", SMN },
                { "KAFKA", KAFKA },
                { "RABBITMQ", RABBITMQ },
                { "DEDICATEDGATEWAY", DEDICATEDGATEWAY },
                { "OPENSOURCEKAFKA", OPENSOURCEKAFKA },
                { "APIC", APIC },
                { "GAUSSMONGO", GAUSSMONGO },
                { "EVENTGRID", EVENTGRID },
            };

            private string _value;

            public TriggerTypeCodeEnum()
            {

            }

            public TriggerTypeCodeEnum(string value)
            {
                _value = value;
            }

            public static TriggerTypeCodeEnum FromValue(string value)
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

                if (this.Equals(obj as TriggerTypeCodeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TriggerTypeCodeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TriggerTypeCodeEnum a, TriggerTypeCodeEnum b)
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

            public static bool operator !=(TriggerTypeCodeEnum a, TriggerTypeCodeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 触发器状态，取值为ACTIVE,DISABLED。
        /// </summary>
        /// <value>触发器状态，取值为ACTIVE,DISABLED。</value>
        [JsonConverter(typeof(EnumClassConverter<TriggerStatusEnum>))]
        public class TriggerStatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly TriggerStatusEnum ACTIVE = new TriggerStatusEnum("ACTIVE");

            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            public static readonly TriggerStatusEnum DISABLED = new TriggerStatusEnum("DISABLED");

            private static readonly Dictionary<string, TriggerStatusEnum> StaticFields =
            new Dictionary<string, TriggerStatusEnum>()
            {
                { "ACTIVE", ACTIVE },
                { "DISABLED", DISABLED },
            };

            private string _value;

            public TriggerStatusEnum()
            {

            }

            public TriggerStatusEnum(string value)
            {
                _value = value;
            }

            public static TriggerStatusEnum FromValue(string value)
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

                if (this.Equals(obj as TriggerStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TriggerStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TriggerStatusEnum a, TriggerStatusEnum b)
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

            public static bool operator !=(TriggerStatusEnum a, TriggerStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 触发器类型。  - TIMER: 定时触发器。 - APIG: APIGW触发器。 - CTS: 云审计触发器，需要先开通云审计服务。 - DDS: 文档数据库触发器，需要开启函数vpc。 - DMS: 分布式消息服务触发器，需要配置dms委托。 - DIS: 数据接入服务触发器，需要配置dis委托。 - LTS: 云审计日志服务触发器，需要配置lts委托。 - OBS: 对象存储服务触发器。 - KAFKA: 专享版本kafka触发器。
        /// </summary>
        [JsonProperty("trigger_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public TriggerTypeCodeEnum TriggerTypeCode { get; set; }
        /// <summary>
        /// 触发器状态，取值为ACTIVE,DISABLED。
        /// </summary>
        [JsonProperty("trigger_status", NullValueHandling = NullValueHandling.Ignore)]
        public TriggerStatusEnum TriggerStatus { get; set; }
        /// <summary>
        /// 消息代码。
        /// </summary>
        [JsonProperty("event_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string EventTypeCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("event_data", NullValueHandling = NullValueHandling.Ignore)]
        public TriggerEventDataRequestBody EventData { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFunctionTriggerRequestBody {\n");
            sb.Append("  triggerTypeCode: ").Append(TriggerTypeCode).Append("\n");
            sb.Append("  triggerStatus: ").Append(TriggerStatus).Append("\n");
            sb.Append("  eventTypeCode: ").Append(EventTypeCode).Append("\n");
            sb.Append("  eventData: ").Append(EventData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateFunctionTriggerRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateFunctionTriggerRequestBody input)
        {
            if (input == null) return false;
            if (this.TriggerTypeCode != input.TriggerTypeCode) return false;
            if (this.TriggerStatus != input.TriggerStatus) return false;
            if (this.EventTypeCode != input.EventTypeCode || (this.EventTypeCode != null && !this.EventTypeCode.Equals(input.EventTypeCode))) return false;
            if (this.EventData != input.EventData || (this.EventData != null && !this.EventData.Equals(input.EventData))) return false;

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
                hashCode = hashCode * 59 + this.TriggerTypeCode.GetHashCode();
                hashCode = hashCode * 59 + this.TriggerStatus.GetHashCode();
                if (this.EventTypeCode != null) hashCode = hashCode * 59 + this.EventTypeCode.GetHashCode();
                if (this.EventData != null) hashCode = hashCode * 59 + this.EventData.GetHashCode();
                return hashCode;
            }
        }
    }
}
