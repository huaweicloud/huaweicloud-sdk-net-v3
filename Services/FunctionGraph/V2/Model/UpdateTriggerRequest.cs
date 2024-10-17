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
    /// Request Object
    /// </summary>
    public class UpdateTriggerRequest 
    {
        /// <summary>
        /// 触发器类型代码。
        /// </summary>
        /// <value>触发器类型代码。</value>
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

            /// <summary>
            /// Enum IOTDA for value: IOTDA
            /// </summary>
            public static readonly TriggerTypeCodeEnum IOTDA = new TriggerTypeCodeEnum("IOTDA");

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
                { "IOTDA", IOTDA },
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
        /// 函数的URN，详细解释见FunctionGraph函数模型的描述。
        /// </summary>
        [SDKProperty("function_urn", IsPath = true)]
        [JsonProperty("function_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string FunctionUrn { get; set; }

        /// <summary>
        /// 触发器类型代码。
        /// </summary>
        [SDKProperty("trigger_type_code", IsPath = true)]
        [JsonProperty("trigger_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public TriggerTypeCodeEnum TriggerTypeCode { get; set; }
        /// <summary>
        /// 触发器编码。
        /// </summary>
        [SDKProperty("trigger_id", IsPath = true)]
        [JsonProperty("trigger_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateTriggerRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTriggerRequest {\n");
            sb.Append("  functionUrn: ").Append(FunctionUrn).Append("\n");
            sb.Append("  triggerTypeCode: ").Append(TriggerTypeCode).Append("\n");
            sb.Append("  triggerId: ").Append(TriggerId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTriggerRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTriggerRequest input)
        {
            if (input == null) return false;
            if (this.FunctionUrn != input.FunctionUrn || (this.FunctionUrn != null && !this.FunctionUrn.Equals(input.FunctionUrn))) return false;
            if (this.TriggerTypeCode != input.TriggerTypeCode) return false;
            if (this.TriggerId != input.TriggerId || (this.TriggerId != null && !this.TriggerId.Equals(input.TriggerId))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.FunctionUrn != null) hashCode = hashCode * 59 + this.FunctionUrn.GetHashCode();
                hashCode = hashCode * 59 + this.TriggerTypeCode.GetHashCode();
                if (this.TriggerId != null) hashCode = hashCode * 59 + this.TriggerId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
