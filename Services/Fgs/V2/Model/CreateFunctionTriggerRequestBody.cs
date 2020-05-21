using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Fgs.V2.Model
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
            /// Enum KAFKA for value: KAFKA
            /// </summary>
            public static readonly TriggerTypeCodeEnum KAFKA = new TriggerTypeCodeEnum("KAFKA");

            public static readonly Dictionary<string, TriggerTypeCodeEnum> StaticFields =
            new Dictionary<string, TriggerTypeCodeEnum>()
            {
                {"TIMER", TIMER},
                {"APIG", APIG},
                {"CTS", CTS},
                {"DDS", DDS},
                {"DMS", DMS},
                {"DIS", DIS},
                {"LTS", LTS},
                {"OBS", OBS},
                {"KAFKA", KAFKA},
            };

            private string Value;

            public TriggerTypeCodeEnum(string Value)
            {
                this.Value = Value;
            }

            public static TriggerTypeCodeEnum FromValue(string Value)
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(TriggerTypeCodeEnum a, TriggerTypeCodeEnum b)
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

            public static readonly Dictionary<string, TriggerStatusEnum> StaticFields =
            new Dictionary<string, TriggerStatusEnum>()
            {
                {"ACTIVE", ACTIVE},
                {"DISABLED", DISABLED},
            };

            private string Value;

            public TriggerStatusEnum(string Value)
            {
                this.Value = Value;
            }

            public static TriggerStatusEnum FromValue(string Value)
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(TriggerStatusEnum a, TriggerStatusEnum b)
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
        /// 事件结构体。
        /// </summary>
        [JsonProperty("event_data", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> EventData { get; set; }


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
            if (input == null)
                return false;

            return 
                (
                    this.TriggerTypeCode == input.TriggerTypeCode ||
                    (this.TriggerTypeCode != null &&
                    this.TriggerTypeCode.Equals(input.TriggerTypeCode))
                ) && 
                (
                    this.TriggerStatus == input.TriggerStatus ||
                    (this.TriggerStatus != null &&
                    this.TriggerStatus.Equals(input.TriggerStatus))
                ) && 
                (
                    this.EventTypeCode == input.EventTypeCode ||
                    (this.EventTypeCode != null &&
                    this.EventTypeCode.Equals(input.EventTypeCode))
                ) && 
                (
                    this.EventData == input.EventData ||
                    this.EventData != null &&
                    input.EventData != null &&
                    this.EventData.SequenceEqual(input.EventData)
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
                if (this.TriggerTypeCode != null)
                    hashCode = hashCode * 59 + this.TriggerTypeCode.GetHashCode();
                if (this.TriggerStatus != null)
                    hashCode = hashCode * 59 + this.TriggerStatus.GetHashCode();
                if (this.EventTypeCode != null)
                    hashCode = hashCode * 59 + this.EventTypeCode.GetHashCode();
                if (this.EventData != null)
                    hashCode = hashCode * 59 + this.EventData.GetHashCode();
                return hashCode;
            }
        }
    }
}
