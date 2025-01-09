using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OperateUserReq 
    {
        /// <summary>
        /// 操作类型，可选值为： - LOCK：锁定用户。 - UNLOCK：解锁用户。 - RESET_PWD：重置用户密码。
        /// </summary>
        /// <value>操作类型，可选值为： - LOCK：锁定用户。 - UNLOCK：解锁用户。 - RESET_PWD：重置用户密码。</value>
        [JsonConverter(typeof(EnumClassConverter<OpTypeEnum>))]
        public class OpTypeEnum
        {
            /// <summary>
            /// Enum LOCK for value: LOCK
            /// </summary>
            public static readonly OpTypeEnum LOCK = new OpTypeEnum("LOCK");

            /// <summary>
            /// Enum UNLOCK for value: UNLOCK
            /// </summary>
            public static readonly OpTypeEnum UNLOCK = new OpTypeEnum("UNLOCK");

            /// <summary>
            /// Enum RESET_PWD for value: RESET_PWD
            /// </summary>
            public static readonly OpTypeEnum RESET_PWD = new OpTypeEnum("RESET_PWD");

            private static readonly Dictionary<string, OpTypeEnum> StaticFields =
            new Dictionary<string, OpTypeEnum>()
            {
                { "LOCK", LOCK },
                { "UNLOCK", UNLOCK },
                { "RESET_PWD", RESET_PWD },
            };

            private string _value;

            public OpTypeEnum()
            {

            }

            public OpTypeEnum(string value)
            {
                _value = value;
            }

            public static OpTypeEnum FromValue(string value)
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

                if (this.Equals(obj as OpTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OpTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OpTypeEnum a, OpTypeEnum b)
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

            public static bool operator !=(OpTypeEnum a, OpTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 操作类型，可选值为： - LOCK：锁定用户。 - UNLOCK：解锁用户。 - RESET_PWD：重置用户密码。
        /// </summary>
        [JsonProperty("op_type", NullValueHandling = NullValueHandling.Ignore)]
        public OpTypeEnum OpType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperateUserReq {\n");
            sb.Append("  opType: ").Append(OpType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperateUserReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperateUserReq input)
        {
            if (input == null) return false;
            if (this.OpType != input.OpType) return false;

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
                hashCode = hashCode * 59 + this.OpType.GetHashCode();
                return hashCode;
            }
        }
    }
}
