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
    public class ActionsOfUsersInGroupRequest 
    {
        /// <summary>
        /// 操作类型。 * ADD： 添加 * DELETE： 删除
        /// </summary>
        /// <value>操作类型。 * ADD： 添加 * DELETE： 删除</value>
        [JsonConverter(typeof(EnumClassConverter<OpTypeEnum>))]
        public class OpTypeEnum
        {
            /// <summary>
            /// Enum ADD for value: ADD
            /// </summary>
            public static readonly OpTypeEnum ADD = new OpTypeEnum("ADD");

            /// <summary>
            /// Enum DELETE for value: DELETE
            /// </summary>
            public static readonly OpTypeEnum DELETE = new OpTypeEnum("DELETE");

            private static readonly Dictionary<string, OpTypeEnum> StaticFields =
            new Dictionary<string, OpTypeEnum>()
            {
                { "ADD", ADD },
                { "DELETE", DELETE },
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

            public static bool operator !=(OpTypeEnum a, OpTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 要添加或移除的用户Id列表。
        /// </summary>
        [JsonProperty("user_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UserIds { get; set; }

        /// <summary>
        /// 操作类型。 * ADD： 添加 * DELETE： 删除
        /// </summary>
        [JsonProperty("op_type", NullValueHandling = NullValueHandling.Ignore)]
        public OpTypeEnum OpType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionsOfUsersInGroupRequest {\n");
            sb.Append("  userIds: ").Append(UserIds).Append("\n");
            sb.Append("  opType: ").Append(OpType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ActionsOfUsersInGroupRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ActionsOfUsersInGroupRequest input)
        {
            if (input == null) return false;
            if (this.UserIds != input.UserIds || (this.UserIds != null && input.UserIds != null && !this.UserIds.SequenceEqual(input.UserIds))) return false;
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
                if (this.UserIds != null) hashCode = hashCode * 59 + this.UserIds.GetHashCode();
                hashCode = hashCode * 59 + this.OpType.GetHashCode();
                return hashCode;
            }
        }
    }
}
