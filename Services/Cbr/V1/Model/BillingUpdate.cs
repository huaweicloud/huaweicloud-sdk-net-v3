using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BillingUpdate 
    {
        /// <summary>
        /// 存储库规格
        /// </summary>
        /// <value>存储库规格</value>
        [JsonConverter(typeof(EnumClassConverter<ConsistentLevelEnum>))]
        public class ConsistentLevelEnum
        {
            /// <summary>
            /// Enum APP_CONSISTENT for value: app_consistent
            /// </summary>
            public static readonly ConsistentLevelEnum APP_CONSISTENT = new ConsistentLevelEnum("app_consistent");

            /// <summary>
            /// Enum CRASH_CONSISTENT for value: crash_consistent
            /// </summary>
            public static readonly ConsistentLevelEnum CRASH_CONSISTENT = new ConsistentLevelEnum("crash_consistent");

            private static readonly Dictionary<string, ConsistentLevelEnum> StaticFields =
            new Dictionary<string, ConsistentLevelEnum>()
            {
                { "app_consistent", APP_CONSISTENT },
                { "crash_consistent", CRASH_CONSISTENT },
            };

            private string _value;

            public ConsistentLevelEnum()
            {

            }

            public ConsistentLevelEnum(string value)
            {
                _value = value;
            }

            public static ConsistentLevelEnum FromValue(string value)
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

                if (this.Equals(obj as ConsistentLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConsistentLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ConsistentLevelEnum a, ConsistentLevelEnum b)
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

            public static bool operator !=(ConsistentLevelEnum a, ConsistentLevelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 存储库规格
        /// </summary>
        [JsonProperty("consistent_level", NullValueHandling = NullValueHandling.Ignore)]
        public ConsistentLevelEnum ConsistentLevel { get; set; }
        /// <summary>
        /// 存储库大小，单位为GB
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingUpdate {\n");
            sb.Append("  consistentLevel: ").Append(ConsistentLevel).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BillingUpdate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BillingUpdate input)
        {
            if (input == null) return false;
            if (this.ConsistentLevel != input.ConsistentLevel) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;

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
                hashCode = hashCode * 59 + this.ConsistentLevel.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                return hashCode;
            }
        }
    }
}
