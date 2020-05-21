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
    /// Request Object
    /// </summary>
    public class ShowFunctionTriggerRequest 
    {
        /// <summary>
        /// Defines triggerTypeCode
        /// </summary>
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
        /// 
        /// </summary>
        [SDKProperty("function_urn", IsPath = true)]
        public string FunctionUrn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("trigger_type_code", IsPath = true)]
        public TriggerTypeCodeEnum TriggerTypeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("triggerId", IsPath = true)]
        public string TriggerId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowFunctionTriggerRequest {\n");
            sb.Append("  functionUrn: ").Append(FunctionUrn).Append("\n");
            sb.Append("  triggerTypeCode: ").Append(TriggerTypeCode).Append("\n");
            sb.Append("  triggerId: ").Append(TriggerId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowFunctionTriggerRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowFunctionTriggerRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FunctionUrn == input.FunctionUrn ||
                    (this.FunctionUrn != null &&
                    this.FunctionUrn.Equals(input.FunctionUrn))
                ) && 
                (
                    this.TriggerTypeCode == input.TriggerTypeCode ||
                    (this.TriggerTypeCode != null &&
                    this.TriggerTypeCode.Equals(input.TriggerTypeCode))
                ) && 
                (
                    this.TriggerId == input.TriggerId ||
                    (this.TriggerId != null &&
                    this.TriggerId.Equals(input.TriggerId))
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
                if (this.FunctionUrn != null)
                    hashCode = hashCode * 59 + this.FunctionUrn.GetHashCode();
                if (this.TriggerTypeCode != null)
                    hashCode = hashCode * 59 + this.TriggerTypeCode.GetHashCode();
                if (this.TriggerId != null)
                    hashCode = hashCode * 59 + this.TriggerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
