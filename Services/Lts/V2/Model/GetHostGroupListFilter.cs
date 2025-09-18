using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 主机组过滤参数
    /// </summary>
    public class GetHostGroupListFilter 
    {
        /// <summary>
        /// 主机组类型。windows：windows类型，linux：linux类型
        /// </summary>
        /// <value>主机组类型。windows：windows类型，linux：linux类型</value>
        [JsonConverter(typeof(EnumClassConverter<HostGroupTypeEnum>))]
        public class HostGroupTypeEnum
        {
            /// <summary>
            /// Enum WINDOWS for value: windows
            /// </summary>
            public static readonly HostGroupTypeEnum WINDOWS = new HostGroupTypeEnum("windows");

            /// <summary>
            /// Enum LINUX for value: linux
            /// </summary>
            public static readonly HostGroupTypeEnum LINUX = new HostGroupTypeEnum("linux");

            private static readonly Dictionary<string, HostGroupTypeEnum> StaticFields =
            new Dictionary<string, HostGroupTypeEnum>()
            {
                { "windows", WINDOWS },
                { "linux", LINUX },
            };

            private string _value;

            public HostGroupTypeEnum()
            {

            }

            public HostGroupTypeEnum(string value)
            {
                _value = value;
            }

            public static HostGroupTypeEnum FromValue(string value)
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

                if (this.Equals(obj as HostGroupTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HostGroupTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(HostGroupTypeEnum a, HostGroupTypeEnum b)
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

            public static bool operator !=(HostGroupTypeEnum a, HostGroupTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 主机组类型。windows：windows类型，linux：linux类型
        /// </summary>
        [JsonProperty("host_group_type", NullValueHandling = NullValueHandling.Ignore)]
        public HostGroupTypeEnum HostGroupType { get; set; }
        /// <summary>
        /// 主机组名称列表。
        /// </summary>
        [JsonProperty("host_group_name_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HostGroupNameList { get; set; }

        /// <summary>
        /// 主机名称列表。
        /// </summary>
        [JsonProperty("host_name_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HostNameList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("host_group_tag", NullValueHandling = NullValueHandling.Ignore)]
        public GetHostGroupListTag HostGroupTag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetHostGroupListFilter {\n");
            sb.Append("  hostGroupType: ").Append(HostGroupType).Append("\n");
            sb.Append("  hostGroupNameList: ").Append(HostGroupNameList).Append("\n");
            sb.Append("  hostNameList: ").Append(HostNameList).Append("\n");
            sb.Append("  hostGroupTag: ").Append(HostGroupTag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetHostGroupListFilter);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetHostGroupListFilter input)
        {
            if (input == null) return false;
            if (this.HostGroupType != input.HostGroupType) return false;
            if (this.HostGroupNameList != input.HostGroupNameList || (this.HostGroupNameList != null && input.HostGroupNameList != null && !this.HostGroupNameList.SequenceEqual(input.HostGroupNameList))) return false;
            if (this.HostNameList != input.HostNameList || (this.HostNameList != null && input.HostNameList != null && !this.HostNameList.SequenceEqual(input.HostNameList))) return false;
            if (this.HostGroupTag != input.HostGroupTag || (this.HostGroupTag != null && !this.HostGroupTag.Equals(input.HostGroupTag))) return false;

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
                hashCode = hashCode * 59 + this.HostGroupType.GetHashCode();
                if (this.HostGroupNameList != null) hashCode = hashCode * 59 + this.HostGroupNameList.GetHashCode();
                if (this.HostNameList != null) hashCode = hashCode * 59 + this.HostNameList.GetHashCode();
                if (this.HostGroupTag != null) hashCode = hashCode * 59 + this.HostGroupTag.GetHashCode();
                return hashCode;
            }
        }
    }
}
