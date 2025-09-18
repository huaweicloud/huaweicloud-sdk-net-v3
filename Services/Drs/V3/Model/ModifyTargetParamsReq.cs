using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 修改数据库参数请求体
    /// </summary>
    public class ModifyTargetParamsReq 
    {
        /// <summary>
        /// 参数分组
        /// </summary>
        /// <value>参数分组</value>
        [JsonConverter(typeof(EnumClassConverter<GroupEnum>))]
        public class GroupEnum
        {
            /// <summary>
            /// Enum COMMON for value: common
            /// </summary>
            public static readonly GroupEnum COMMON = new GroupEnum("common");

            /// <summary>
            /// Enum PERFORMANCE for value: performance
            /// </summary>
            public static readonly GroupEnum PERFORMANCE = new GroupEnum("performance");

            private static readonly Dictionary<string, GroupEnum> StaticFields =
            new Dictionary<string, GroupEnum>()
            {
                { "common", COMMON },
                { "performance", PERFORMANCE },
            };

            private string _value;

            public GroupEnum()
            {

            }

            public GroupEnum(string value)
            {
                _value = value;
            }

            public static GroupEnum FromValue(string value)
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

                if (this.Equals(obj as GroupEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(GroupEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(GroupEnum a, GroupEnum b)
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

            public static bool operator !=(GroupEnum a, GroupEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 参数分组
        /// </summary>
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public GroupEnum Group { get; set; }
        /// <summary>
        /// 修改的参数信息
        /// </summary>
        [JsonProperty("params", NullValueHandling = NullValueHandling.Ignore)]
        public List<ParamsReqBean> Params { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyTargetParamsReq {\n");
            sb.Append("  group: ").Append(Group).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyTargetParamsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyTargetParamsReq input)
        {
            if (input == null) return false;
            if (this.Group != input.Group) return false;
            if (this.Params != input.Params || (this.Params != null && input.Params != null && !this.Params.SequenceEqual(input.Params))) return false;

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
                hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Params != null) hashCode = hashCode * 59 + this.Params.GetHashCode();
                return hashCode;
            }
        }
    }
}
