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
    /// 
    /// </summary>
    public class Resources 
    {
        /// <summary>
        /// 资源类型。 fgs_func_scale_down_timeout：v1版本函数的实例闲置释放时间 fgs_func_occurs：v1版本函数为实例数配额, v2版本函数为预留实例配额 fgs_func_pat_idle_time：vpc函数的pat闲置释放时间 fgs_func_num：用户函数数量配额 fgs_func_code_size：用户函数总代码大小配额 fgs_workflow_num：用户函数流数量配额 fgs_on_demand_instance_limit：v2版本函数单函数最大实例数配额 fgs_func_qos_limit 用户函数实例数配额
        /// </summary>
        /// <value>资源类型。 fgs_func_scale_down_timeout：v1版本函数的实例闲置释放时间 fgs_func_occurs：v1版本函数为实例数配额, v2版本函数为预留实例配额 fgs_func_pat_idle_time：vpc函数的pat闲置释放时间 fgs_func_num：用户函数数量配额 fgs_func_code_size：用户函数总代码大小配额 fgs_workflow_num：用户函数流数量配额 fgs_on_demand_instance_limit：v2版本函数单函数最大实例数配额 fgs_func_qos_limit 用户函数实例数配额</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum FGS_FUNC_SCALE_DOWN_TIMEOUT for value: fgs_func_scale_down_timeout
            /// </summary>
            public static readonly TypeEnum FGS_FUNC_SCALE_DOWN_TIMEOUT = new TypeEnum("fgs_func_scale_down_timeout");

            /// <summary>
            /// Enum FGS_FUNC_OCCURS for value: fgs_func_occurs
            /// </summary>
            public static readonly TypeEnum FGS_FUNC_OCCURS = new TypeEnum("fgs_func_occurs");

            /// <summary>
            /// Enum FGS_FUNC_PAT_IDLE_TIME for value: fgs_func_pat_idle_time
            /// </summary>
            public static readonly TypeEnum FGS_FUNC_PAT_IDLE_TIME = new TypeEnum("fgs_func_pat_idle_time");

            /// <summary>
            /// Enum FGS_FUNC_NUM for value: fgs_func_num
            /// </summary>
            public static readonly TypeEnum FGS_FUNC_NUM = new TypeEnum("fgs_func_num");

            /// <summary>
            /// Enum FGS_FUNC_CODE_SIZE for value: fgs_func_code_size
            /// </summary>
            public static readonly TypeEnum FGS_FUNC_CODE_SIZE = new TypeEnum("fgs_func_code_size");

            /// <summary>
            /// Enum FGS_WORKFLOW_NUM for value: fgs_workflow_num
            /// </summary>
            public static readonly TypeEnum FGS_WORKFLOW_NUM = new TypeEnum("fgs_workflow_num");

            /// <summary>
            /// Enum FGS_ON_DEMAND_INSTANCE_LIMIT for value: fgs_on_demand_instance_limit
            /// </summary>
            public static readonly TypeEnum FGS_ON_DEMAND_INSTANCE_LIMIT = new TypeEnum("fgs_on_demand_instance_limit");

            /// <summary>
            /// Enum FGS_FUNC_QOS_LIMIT for value: fgs_func_qos_limit
            /// </summary>
            public static readonly TypeEnum FGS_FUNC_QOS_LIMIT = new TypeEnum("fgs_func_qos_limit");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "fgs_func_scale_down_timeout", FGS_FUNC_SCALE_DOWN_TIMEOUT },
                { "fgs_func_occurs", FGS_FUNC_OCCURS },
                { "fgs_func_pat_idle_time", FGS_FUNC_PAT_IDLE_TIME },
                { "fgs_func_num", FGS_FUNC_NUM },
                { "fgs_func_code_size", FGS_FUNC_CODE_SIZE },
                { "fgs_workflow_num", FGS_WORKFLOW_NUM },
                { "fgs_on_demand_instance_limit", FGS_ON_DEMAND_INSTANCE_LIMIT },
                { "fgs_func_qos_limit", FGS_FUNC_QOS_LIMIT },
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 函数配额限制。
        /// </summary>
        [JsonProperty("quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quota { get; set; }

        /// <summary>
        /// 已使用的配额。
        /// </summary>
        [JsonProperty("used", NullValueHandling = NullValueHandling.Ignore)]
        public int? Used { get; set; }

        /// <summary>
        /// 资源类型。 fgs_func_scale_down_timeout：v1版本函数的实例闲置释放时间 fgs_func_occurs：v1版本函数为实例数配额, v2版本函数为预留实例配额 fgs_func_pat_idle_time：vpc函数的pat闲置释放时间 fgs_func_num：用户函数数量配额 fgs_func_code_size：用户函数总代码大小配额 fgs_workflow_num：用户函数流数量配额 fgs_on_demand_instance_limit：v2版本函数单函数最大实例数配额 fgs_func_qos_limit 用户函数实例数配额
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 资源的计数单位。fgs_func_code_size,单位为MB,其他场景无单位
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Resources {\n");
            sb.Append("  quota: ").Append(Quota).Append("\n");
            sb.Append("  used: ").Append(Used).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Resources);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Resources input)
        {
            if (input == null) return false;
            if (this.Quota != input.Quota || (this.Quota != null && !this.Quota.Equals(input.Quota))) return false;
            if (this.Used != input.Used || (this.Used != null && !this.Used.Equals(input.Used))) return false;
            if (this.Type != input.Type) return false;
            if (this.Unit != input.Unit || (this.Unit != null && !this.Unit.Equals(input.Unit))) return false;

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
                if (this.Quota != null) hashCode = hashCode * 59 + this.Quota.GetHashCode();
                if (this.Used != null) hashCode = hashCode * 59 + this.Used.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Unit != null) hashCode = hashCode * 59 + this.Unit.GetHashCode();
                return hashCode;
            }
        }
    }
}
