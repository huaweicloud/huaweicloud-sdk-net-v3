using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V1.Model
{
    /// <summary>
    /// 场地条件
    /// </summary>
    public class Condition 
    {
        /// <summary>
        /// 整柜安装评估 取值范围：   - UNCLEAR：不清楚是否允许整柜安装，需要评估   - UNSUPPORT：不允许整柜安装，需将设备放入现有机柜   - SUPPORT：可支持整柜安装，并入现有机柜组
        /// </summary>
        /// <value>整柜安装评估 取值范围：   - UNCLEAR：不清楚是否允许整柜安装，需要评估   - UNSUPPORT：不允许整柜安装，需将设备放入现有机柜   - SUPPORT：可支持整柜安装，并入现有机柜组</value>
        [JsonConverter(typeof(EnumClassConverter<InstallationEnum>))]
        public class InstallationEnum
        {
            /// <summary>
            /// Enum UNCLEAR for value: UNCLEAR
            /// </summary>
            public static readonly InstallationEnum UNCLEAR = new InstallationEnum("UNCLEAR");

            /// <summary>
            /// Enum UNSUPPORT for value: UNSUPPORT
            /// </summary>
            public static readonly InstallationEnum UNSUPPORT = new InstallationEnum("UNSUPPORT");

            /// <summary>
            /// Enum SUPPORT for value: SUPPORT
            /// </summary>
            public static readonly InstallationEnum SUPPORT = new InstallationEnum("SUPPORT");

            private static readonly Dictionary<string, InstallationEnum> StaticFields =
            new Dictionary<string, InstallationEnum>()
            {
                { "UNCLEAR", UNCLEAR },
                { "UNSUPPORT", UNSUPPORT },
                { "SUPPORT", SUPPORT },
            };

            private string _value;

            public InstallationEnum()
            {

            }

            public InstallationEnum(string value)
            {
                _value = value;
            }

            public static InstallationEnum FromValue(string value)
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

                if (this.Equals(obj as InstallationEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InstallationEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InstallationEnum a, InstallationEnum b)
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

            public static bool operator !=(InstallationEnum a, InstallationEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 机房环境条件 取值范围：   - 0：机房条件不属于上述任何一种情况   - 1：机房使用模块化数据中心方案进行建设   - 2：机房已通过国家级或行业级标准化认证
        /// </summary>
        [JsonProperty("environment", NullValueHandling = NullValueHandling.Ignore)]
        public int? Environment { get; set; }

        /// <summary>
        /// 机柜空间条件 取值范围：   - 0：暂无扩容计划，不考虑额外余量   - 1：机柜余量相对充裕，可放置空间超过3柜   - 2：机柜余量相对紧张，可放置空间3柜以内
        /// </summary>
        [JsonProperty("space", NullValueHandling = NullValueHandling.Ignore)]
        public int? Space { get; set; }

        /// <summary>
        /// 运输条件 取值范围：   - 0：运输通道和机房门的高度或宽度不满足要求   - 1：运输通道，货梯，机房门均可满足整机柜滚轮搬运   - 2：运输通道，货梯，机房门不能支持整机柜滚轮搬运，沿途有台阶
        /// </summary>
        [JsonProperty("transport", NullValueHandling = NullValueHandling.Ignore)]
        public int? Transport { get; set; }

        /// <summary>
        /// 整柜安装评估 取值范围：   - UNCLEAR：不清楚是否允许整柜安装，需要评估   - UNSUPPORT：不允许整柜安装，需将设备放入现有机柜   - SUPPORT：可支持整柜安装，并入现有机柜组
        /// </summary>
        [JsonProperty("installation", NullValueHandling = NullValueHandling.Ignore)]
        public InstallationEnum Installation { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Condition {\n");
            sb.Append("  environment: ").Append(Environment).Append("\n");
            sb.Append("  space: ").Append(Space).Append("\n");
            sb.Append("  transport: ").Append(Transport).Append("\n");
            sb.Append("  installation: ").Append(Installation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Condition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Condition input)
        {
            if (input == null) return false;
            if (this.Environment != input.Environment || (this.Environment != null && !this.Environment.Equals(input.Environment))) return false;
            if (this.Space != input.Space || (this.Space != null && !this.Space.Equals(input.Space))) return false;
            if (this.Transport != input.Transport || (this.Transport != null && !this.Transport.Equals(input.Transport))) return false;
            if (this.Installation != input.Installation) return false;

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
                if (this.Environment != null) hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.Space != null) hashCode = hashCode * 59 + this.Space.GetHashCode();
                if (this.Transport != null) hashCode = hashCode * 59 + this.Transport.GetHashCode();
                hashCode = hashCode * 59 + this.Installation.GetHashCode();
                return hashCode;
            }
        }
    }
}
