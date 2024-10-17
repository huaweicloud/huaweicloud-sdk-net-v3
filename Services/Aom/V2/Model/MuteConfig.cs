using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 静默规则的生效时间配置
    /// </summary>
    public class MuteConfig 
    {
        /// <summary>
        /// 静默规则生效时间种类。FIXED：固定方式统计，DAILY：按日合计，WEEKLY：按周统计，MONTHLY：按月统计
        /// </summary>
        /// <value>静默规则生效时间种类。FIXED：固定方式统计，DAILY：按日合计，WEEKLY：按周统计，MONTHLY：按月统计</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum FIXED for value: FIXED
            /// </summary>
            public static readonly TypeEnum FIXED = new TypeEnum("FIXED");

            /// <summary>
            /// Enum DAILY for value: DAILY
            /// </summary>
            public static readonly TypeEnum DAILY = new TypeEnum("DAILY");

            /// <summary>
            /// Enum WEEKLY for value: WEEKLY
            /// </summary>
            public static readonly TypeEnum WEEKLY = new TypeEnum("WEEKLY");

            /// <summary>
            /// Enum MONTHLY for value: MONTHLY
            /// </summary>
            public static readonly TypeEnum MONTHLY = new TypeEnum("MONTHLY");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "FIXED", FIXED },
                { "DAILY", DAILY },
                { "WEEKLY", WEEKLY },
                { "MONTHLY", MONTHLY },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 静默规则结束时间
        /// </summary>
        [JsonProperty("ends_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndsAt { get; set; }

        /// <summary>
        /// 当type为每周或者每月时，scope不能为空
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Scope { get; set; }

        /// <summary>
        /// 静默规则开始时间
        /// </summary>
        [JsonProperty("starts_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartsAt { get; set; }

        /// <summary>
        /// 静默规则生效时间种类。FIXED：固定方式统计，DAILY：按日合计，WEEKLY：按周统计，MONTHLY：按月统计
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MuteConfig {\n");
            sb.Append("  endsAt: ").Append(EndsAt).Append("\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("  startsAt: ").Append(StartsAt).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MuteConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MuteConfig input)
        {
            if (input == null) return false;
            if (this.EndsAt != input.EndsAt || (this.EndsAt != null && !this.EndsAt.Equals(input.EndsAt))) return false;
            if (this.Scope != input.Scope || (this.Scope != null && input.Scope != null && !this.Scope.SequenceEqual(input.Scope))) return false;
            if (this.StartsAt != input.StartsAt || (this.StartsAt != null && !this.StartsAt.Equals(input.StartsAt))) return false;
            if (this.Type != input.Type) return false;

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
                if (this.EndsAt != null) hashCode = hashCode * 59 + this.EndsAt.GetHashCode();
                if (this.Scope != null) hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.StartsAt != null) hashCode = hashCode * 59 + this.StartsAt.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
