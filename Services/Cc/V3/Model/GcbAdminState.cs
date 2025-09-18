using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GcbAdminState 
    {
        /// <summary>
        /// 功能说明: 全域互联带宽状态。 取值范围：     NORMAL-正常     FREEZED-冻结状态
        /// </summary>
        /// <value>功能说明: 全域互联带宽状态。 取值范围：     NORMAL-正常     FREEZED-冻结状态</value>
        [JsonConverter(typeof(EnumClassConverter<AdminStateEnum>))]
        public class AdminStateEnum
        {
            /// <summary>
            /// Enum NORMAL for value: NORMAL
            /// </summary>
            public static readonly AdminStateEnum NORMAL = new AdminStateEnum("NORMAL");

            /// <summary>
            /// Enum FREEZED for value: FREEZED
            /// </summary>
            public static readonly AdminStateEnum FREEZED = new AdminStateEnum("FREEZED");

            private static readonly Dictionary<string, AdminStateEnum> StaticFields =
            new Dictionary<string, AdminStateEnum>()
            {
                { "NORMAL", NORMAL },
                { "FREEZED", FREEZED },
            };

            private string _value;

            public AdminStateEnum()
            {

            }

            public AdminStateEnum(string value)
            {
                _value = value;
            }

            public static AdminStateEnum FromValue(string value)
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

                if (this.Equals(obj as AdminStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AdminStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AdminStateEnum a, AdminStateEnum b)
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

            public static bool operator !=(AdminStateEnum a, AdminStateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 功能说明: 全域互联带宽状态。 取值范围：     NORMAL-正常     FREEZED-冻结状态
        /// </summary>
        [JsonProperty("admin_state", NullValueHandling = NullValueHandling.Ignore)]
        public AdminStateEnum AdminState { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GcbAdminState {\n");
            sb.Append("  adminState: ").Append(AdminState).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GcbAdminState);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GcbAdminState input)
        {
            if (input == null) return false;
            if (this.AdminState != input.AdminState) return false;

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
                hashCode = hashCode * 59 + this.AdminState.GetHashCode();
                return hashCode;
            }
        }
    }
}
