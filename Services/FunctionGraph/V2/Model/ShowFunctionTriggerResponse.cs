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
                {"SMN", SMN},
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
        /// \&quot;触发器状态\&quot;  - ACTIVE: 启用状态。 - DISABLE: 禁用状态。
        /// </summary>
        /// <value>\&quot;触发器状态\&quot;  - ACTIVE: 启用状态。 - DISABLE: 禁用状态。</value>
        [JsonConverter(typeof(EnumClassConverter<TriggerStatusEnum>))]
        public class TriggerStatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly TriggerStatusEnum ACTIVE = new TriggerStatusEnum("ACTIVE");

            /// <summary>
            /// Enum DISABLE for value: DISABLE
            /// </summary>
            public static readonly TriggerStatusEnum DISABLE = new TriggerStatusEnum("DISABLE");

            public static readonly Dictionary<string, TriggerStatusEnum> StaticFields =
            new Dictionary<string, TriggerStatusEnum>()
            {
                {"ACTIVE", ACTIVE},
                {"DISABLE", DISABLE},
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
        /// \&quot;触发器状态\&quot;  - ACTIVE: 启用状态。 - DISABLE: 禁用状态。
        /// </summary>
        [JsonProperty("trigger_status", NullValueHandling = NullValueHandling.Ignore)]
        public TriggerStatusEnum TriggerStatus { get; set; }
        /// <summary>
        /// 触发器源事件。
        /// </summary>
        [JsonProperty("event_data", NullValueHandling = NullValueHandling.Ignore)]
        public Object EventData { get; set; }

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
            if (input == null)
                return false;

            return 
                (
                    this.TriggerId == input.TriggerId ||
                    (this.TriggerId != null &&
                    this.TriggerId.Equals(input.TriggerId))
                ) && 
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
                    this.EventData == input.EventData ||
                    (this.EventData != null &&
                    this.EventData.Equals(input.EventData))
                ) && 
                (
                    this.LastUpdatedTime == input.LastUpdatedTime ||
                    (this.LastUpdatedTime != null &&
                    this.LastUpdatedTime.Equals(input.LastUpdatedTime))
                ) && 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
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
                if (this.TriggerId != null)
                    hashCode = hashCode * 59 + this.TriggerId.GetHashCode();
                if (this.TriggerTypeCode != null)
                    hashCode = hashCode * 59 + this.TriggerTypeCode.GetHashCode();
                if (this.TriggerStatus != null)
                    hashCode = hashCode * 59 + this.TriggerStatus.GetHashCode();
                if (this.EventData != null)
                    hashCode = hashCode * 59 + this.EventData.GetHashCode();
                if (this.LastUpdatedTime != null)
                    hashCode = hashCode * 59 + this.LastUpdatedTime.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
