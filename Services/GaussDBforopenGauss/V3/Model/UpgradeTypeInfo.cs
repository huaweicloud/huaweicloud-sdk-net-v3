using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 升级类型信息
    /// </summary>
    public class UpgradeTypeInfo 
    {
        /// <summary>
        /// 升级类型,grey&#x3D;灰度升级,inplace&#x3D;就地升级,hotfix&#x3D;热补丁升级
        /// </summary>
        /// <value>升级类型,grey&#x3D;灰度升级,inplace&#x3D;就地升级,hotfix&#x3D;热补丁升级</value>
        [JsonConverter(typeof(EnumClassConverter<UpgradeTypeEnum>))]
        public class UpgradeTypeEnum
        {
            /// <summary>
            /// Enum GREY for value: grey
            /// </summary>
            public static readonly UpgradeTypeEnum GREY = new UpgradeTypeEnum("grey");

            /// <summary>
            /// Enum INPLACE for value: inplace
            /// </summary>
            public static readonly UpgradeTypeEnum INPLACE = new UpgradeTypeEnum("inplace");

            /// <summary>
            /// Enum HOTFIX for value: hotfix
            /// </summary>
            public static readonly UpgradeTypeEnum HOTFIX = new UpgradeTypeEnum("hotfix");

            private static readonly Dictionary<string, UpgradeTypeEnum> StaticFields =
            new Dictionary<string, UpgradeTypeEnum>()
            {
                { "grey", GREY },
                { "inplace", INPLACE },
                { "hotfix", HOTFIX },
            };

            private string _value;

            public UpgradeTypeEnum()
            {

            }

            public UpgradeTypeEnum(string value)
            {
                _value = value;
            }

            public static UpgradeTypeEnum FromValue(string value)
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

                if (this.Equals(obj as UpgradeTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UpgradeTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(UpgradeTypeEnum a, UpgradeTypeEnum b)
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

            public static bool operator !=(UpgradeTypeEnum a, UpgradeTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 升级类型,grey&#x3D;灰度升级,inplace&#x3D;就地升级,hotfix&#x3D;热补丁升级
        /// </summary>
        [JsonProperty("upgrade_type", NullValueHandling = NullValueHandling.Ignore)]
        public UpgradeTypeEnum UpgradeType { get; set; }
        /// <summary>
        /// 可用，不可用
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 升级操作列表
        /// </summary>
        [JsonProperty("upgrade_action_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpgradeActionInfo> UpgradeActionList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeTypeInfo {\n");
            sb.Append("  upgradeType: ").Append(UpgradeType).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  upgradeActionList: ").Append(UpgradeActionList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeTypeInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeTypeInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UpgradeType == input.UpgradeType ||
                    (this.UpgradeType != null &&
                    this.UpgradeType.Equals(input.UpgradeType))
                ) && 
                (
                    this.Enable == input.Enable ||
                    (this.Enable != null &&
                    this.Enable.Equals(input.Enable))
                ) && 
                (
                    this.UpgradeActionList == input.UpgradeActionList ||
                    this.UpgradeActionList != null &&
                    input.UpgradeActionList != null &&
                    this.UpgradeActionList.SequenceEqual(input.UpgradeActionList)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.UpgradeType != null)
                    hashCode = hashCode * 59 + this.UpgradeType.GetHashCode();
                if (this.Enable != null)
                    hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.UpgradeActionList != null)
                    hashCode = hashCode * 59 + this.UpgradeActionList.GetHashCode();
                return hashCode;
            }
        }
    }
}
