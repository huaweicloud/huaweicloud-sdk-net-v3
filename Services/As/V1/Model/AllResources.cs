using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 配额资源
    /// </summary>
    public class AllResources 
    {
        /// <summary>
        /// 查询配额的类型。scaling_Group：伸缩组配额。scaling_Config：伸缩配置配额。scaling_Policy：伸缩策略配额。scaling_Instance：伸缩实例配额。bandwidth_scaling_policy：伸缩带宽策略配额。
        /// </summary>
        /// <value>查询配额的类型。scaling_Group：伸缩组配额。scaling_Config：伸缩配置配额。scaling_Policy：伸缩策略配额。scaling_Instance：伸缩实例配额。bandwidth_scaling_policy：伸缩带宽策略配额。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum SCALING_GROUP for value: scaling_group
            /// </summary>
            public static readonly TypeEnum SCALING_GROUP = new TypeEnum("scaling_group");

            /// <summary>
            /// Enum SCALING_CONFIG for value: scaling_config
            /// </summary>
            public static readonly TypeEnum SCALING_CONFIG = new TypeEnum("scaling_config");

            /// <summary>
            /// Enum SCALING_POLICY for value: scaling_Policy
            /// </summary>
            public static readonly TypeEnum SCALING_POLICY = new TypeEnum("scaling_Policy");

            /// <summary>
            /// Enum SCALING_INSTANCE for value: scaling_Instance
            /// </summary>
            public static readonly TypeEnum SCALING_INSTANCE = new TypeEnum("scaling_Instance");

            /// <summary>
            /// Enum BANDWIDTH_SCALING_POLICY for value: bandwidth_scaling_policy
            /// </summary>
            public static readonly TypeEnum BANDWIDTH_SCALING_POLICY = new TypeEnum("bandwidth_scaling_policy");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "scaling_group", SCALING_GROUP },
                { "scaling_config", SCALING_CONFIG },
                { "scaling_Policy", SCALING_POLICY },
                { "scaling_Instance", SCALING_INSTANCE },
                { "bandwidth_scaling_policy", BANDWIDTH_SCALING_POLICY },
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
        /// 查询配额的类型。scaling_Group：伸缩组配额。scaling_Config：伸缩配置配额。scaling_Policy：伸缩策略配额。scaling_Instance：伸缩实例配额。bandwidth_scaling_policy：伸缩带宽策略配额。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 已使用的配额数量。当type为scaling_Policy和scaling_Instance时，该字段为保留字段，返回-1。可通过查询弹性伸缩策略和伸缩实例配额查询指定弹性伸缩组下的弹性伸缩策略和伸缩实例已使用的配额数量。
        /// </summary>
        [JsonProperty("used", NullValueHandling = NullValueHandling.Ignore)]
        public int? Used { get; set; }

        /// <summary>
        /// 配额总数量。
        /// </summary>
        [JsonProperty("quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quota { get; set; }

        /// <summary>
        /// 配额上限。
        /// </summary>
        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public int? Max { get; set; }

        /// <summary>
        /// 配额下限。
        /// </summary>
        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public int? Min { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllResources {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  used: ").Append(Used).Append("\n");
            sb.Append("  quota: ").Append(Quota).Append("\n");
            sb.Append("  max: ").Append(Max).Append("\n");
            sb.Append("  min: ").Append(Min).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AllResources);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AllResources input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.Used != input.Used || (this.Used != null && !this.Used.Equals(input.Used))) return false;
            if (this.Quota != input.Quota || (this.Quota != null && !this.Quota.Equals(input.Quota))) return false;
            if (this.Max != input.Max || (this.Max != null && !this.Max.Equals(input.Max))) return false;
            if (this.Min != input.Min || (this.Min != null && !this.Min.Equals(input.Min))) return false;

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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Used != null) hashCode = hashCode * 59 + this.Used.GetHashCode();
                if (this.Quota != null) hashCode = hashCode * 59 + this.Quota.GetHashCode();
                if (this.Max != null) hashCode = hashCode * 59 + this.Max.GetHashCode();
                if (this.Min != null) hashCode = hashCode * 59 + this.Min.GetHashCode();
                return hashCode;
            }
        }
    }
}
