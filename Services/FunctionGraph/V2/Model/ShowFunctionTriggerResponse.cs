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
    /// Response Object
    /// </summary>
    public class ShowFunctionTriggerResponse : SdkResponse
    {
        /// <summary>
        /// 触发器类型。  - TIMER: \&quot;定时触发器。\&quot; - APIG: \&quot;APIG触发器。\&quot; - CTS: \&quot;云审计服务触发器。\&quot; - DDS: \&quot;文档数据库服务触发器。\&quot; - DMS: \&quot;分布式服务触发器。\&quot; - DIS: \&quot;数据接入服务触发器。\&quot; - LTS: \&quot;云日志服务触发器。\&quot; - OBS: \&quot;对象存储触发器。\&quot; - SMN: \&quot;消息通知服务触发器。\&quot; - KAFKA: \&quot;专享版消息通知服务触发器。\&quot;
        /// </summary>
        /// <value>触发器类型。  - TIMER: \&quot;定时触发器。\&quot; - APIG: \&quot;APIG触发器。\&quot; - CTS: \&quot;云审计服务触发器。\&quot; - DDS: \&quot;文档数据库服务触发器。\&quot; - DMS: \&quot;分布式服务触发器。\&quot; - DIS: \&quot;数据接入服务触发器。\&quot; - LTS: \&quot;云日志服务触发器。\&quot; - OBS: \&quot;对象存储触发器。\&quot; - SMN: \&quot;消息通知服务触发器。\&quot; - KAFKA: \&quot;专享版消息通知服务触发器。\&quot;</value>
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
        /// \&quot;触发器状态\&quot;  - ACTIVE: 启用状态。 - DISABLED: 禁用状态。
        /// </summary>
        /// <value>\&quot;触发器状态\&quot;  - ACTIVE: 启用状态。 - DISABLED: 禁用状态。</value>
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
        /// 触发器ID。
        /// </summary>
        [JsonProperty("trigger_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerId { get; set; }

        /// <summary>
        /// 触发器类型。  - TIMER: \&quot;定时触发器。\&quot; - APIG: \&quot;APIG触发器。\&quot; - CTS: \&quot;云审计服务触发器。\&quot; - DDS: \&quot;文档数据库服务触发器。\&quot; - DMS: \&quot;分布式服务触发器。\&quot; - DIS: \&quot;数据接入服务触发器。\&quot; - LTS: \&quot;云日志服务触发器。\&quot; - OBS: \&quot;对象存储触发器。\&quot; - SMN: \&quot;消息通知服务触发器。\&quot; - KAFKA: \&quot;专享版消息通知服务触发器。\&quot;
        /// </summary>
        [JsonProperty("trigger_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public TriggerTypeCodeEnum TriggerTypeCode { get; set; }
        /// <summary>
        /// \&quot;触发器状态\&quot;  - ACTIVE: 启用状态。 - DISABLED: 禁用状态。
        /// </summary>
        [JsonProperty("trigger_status", NullValueHandling = NullValueHandling.Ignore)]
        public TriggerStatusEnum TriggerStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("event_data", NullValueHandling = NullValueHandling.Ignore)]
        public TriggerEventDataResponseBody EventData { get; set; }

        /// <summary>
        /// 最后更新时间。
        /// </summary>
        [JsonProperty("last_updated_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// 触发器创建时间。
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowFunctionTriggerResponse {\n");
            sb.Append("  triggerId: ").Append(TriggerId).Append("\n");
            sb.Append("  triggerTypeCode: ").Append(TriggerTypeCode).Append("\n");
            sb.Append("  triggerStatus: ").Append(TriggerStatus).Append("\n");
            sb.Append("  eventData: ").Append(EventData).Append("\n");
            sb.Append("  lastUpdatedTime: ").Append(LastUpdatedTime).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowFunctionTriggerResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowFunctionTriggerResponse input)
        {
            if (input == null) return false;
            if (this.TriggerId != input.TriggerId || (this.TriggerId != null && !this.TriggerId.Equals(input.TriggerId))) return false;
            if (this.TriggerTypeCode != input.TriggerTypeCode) return false;
            if (this.TriggerStatus != input.TriggerStatus) return false;
            if (this.EventData != input.EventData || (this.EventData != null && !this.EventData.Equals(input.EventData))) return false;
            if (this.LastUpdatedTime != input.LastUpdatedTime || (this.LastUpdatedTime != null && !this.LastUpdatedTime.Equals(input.LastUpdatedTime))) return false;
            if (this.CreatedTime != input.CreatedTime || (this.CreatedTime != null && !this.CreatedTime.Equals(input.CreatedTime))) return false;

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
                if (this.TriggerId != null) hashCode = hashCode * 59 + this.TriggerId.GetHashCode();
                hashCode = hashCode * 59 + this.TriggerTypeCode.GetHashCode();
                hashCode = hashCode * 59 + this.TriggerStatus.GetHashCode();
                if (this.EventData != null) hashCode = hashCode * 59 + this.EventData.GetHashCode();
                if (this.LastUpdatedTime != null) hashCode = hashCode * 59 + this.LastUpdatedTime.GetHashCode();
                if (this.CreatedTime != null) hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
