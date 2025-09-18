using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpgradePlanStatus 
    {
        /// <summary>
        /// 自动升级计划状态 
        /// </summary>
        /// <value>自动升级计划状态 </value>
        [JsonConverter(typeof(EnumClassConverter<PhaseEnum>))]
        public class PhaseEnum
        {
            /// <summary>
            /// Enum PENDING for value: Pending
            /// </summary>
            public static readonly PhaseEnum PENDING = new PhaseEnum("Pending");

            /// <summary>
            /// Enum ENQUEUED for value: Enqueued
            /// </summary>
            public static readonly PhaseEnum ENQUEUED = new PhaseEnum("Enqueued");

            /// <summary>
            /// Enum UPGRADING for value: Upgrading
            /// </summary>
            public static readonly PhaseEnum UPGRADING = new PhaseEnum("Upgrading");

            /// <summary>
            /// Enum SUCCESS for value: Success
            /// </summary>
            public static readonly PhaseEnum SUCCESS = new PhaseEnum("Success");

            /// <summary>
            /// Enum FAILED for value: Failed
            /// </summary>
            public static readonly PhaseEnum FAILED = new PhaseEnum("Failed");

            /// <summary>
            /// Enum SKIPPED for value: Skipped
            /// </summary>
            public static readonly PhaseEnum SKIPPED = new PhaseEnum("Skipped");

            private static readonly Dictionary<string, PhaseEnum> StaticFields =
            new Dictionary<string, PhaseEnum>()
            {
                { "Pending", PENDING },
                { "Enqueued", ENQUEUED },
                { "Upgrading", UPGRADING },
                { "Success", SUCCESS },
                { "Failed", FAILED },
                { "Skipped", SKIPPED },
            };

            private string _value;

            public PhaseEnum()
            {

            }

            public PhaseEnum(string value)
            {
                _value = value;
            }

            public static PhaseEnum FromValue(string value)
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

                if (this.Equals(obj as PhaseEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PhaseEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PhaseEnum a, PhaseEnum b)
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

            public static bool operator !=(PhaseEnum a, PhaseEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 自动升级计划状态 
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public PhaseEnum Phase { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradePlanStatus {\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradePlanStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradePlanStatus input)
        {
            if (input == null) return false;
            if (this.Phase != input.Phase) return false;

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
                hashCode = hashCode * 59 + this.Phase.GetHashCode();
                return hashCode;
            }
        }
    }
}
