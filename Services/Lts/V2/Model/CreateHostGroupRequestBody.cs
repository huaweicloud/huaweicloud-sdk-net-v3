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
    /// 创建主机组请求体
    /// </summary>
    public class CreateHostGroupRequestBody 
    {
        /// <summary>
        /// 主机组类型。windows：windows类型，linux：linux类型
        /// </summary>
        /// <value>主机组类型。windows：windows类型，linux：linux类型</value>
        [JsonConverter(typeof(EnumClassConverter<HostGroupTypeEnum>))]
        public class HostGroupTypeEnum
        {
            /// <summary>
            /// Enum LINUX for value: linux
            /// </summary>
            public static readonly HostGroupTypeEnum LINUX = new HostGroupTypeEnum("linux");

            /// <summary>
            /// Enum WINDOWS for value: windows
            /// </summary>
            public static readonly HostGroupTypeEnum WINDOWS = new HostGroupTypeEnum("windows");

            private static readonly Dictionary<string, HostGroupTypeEnum> StaticFields =
            new Dictionary<string, HostGroupTypeEnum>()
            {
                { "linux", LINUX },
                { "windows", WINDOWS },
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

            public static bool operator !=(HostGroupTypeEnum a, HostGroupTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 主机组名称
        /// </summary>
        [JsonProperty("host_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HostGroupName { get; set; }

        /// <summary>
        /// 主机组类型。windows：windows类型，linux：linux类型
        /// </summary>
        [JsonProperty("host_group_type", NullValueHandling = NullValueHandling.Ignore)]
        public HostGroupTypeEnum HostGroupType { get; set; }
        /// <summary>
        /// 主机组ID列表。主机类型必须与主机组类型一致
        /// </summary>
        [JsonProperty("host_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HostIdList { get; set; }

        /// <summary>
        /// 标签信息。KEY不能重复
        /// </summary>
        [JsonProperty("host_group_tag", NullValueHandling = NullValueHandling.Ignore)]
        public List<HostGroupTag> HostGroupTag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateHostGroupRequestBody {\n");
            sb.Append("  hostGroupName: ").Append(HostGroupName).Append("\n");
            sb.Append("  hostGroupType: ").Append(HostGroupType).Append("\n");
            sb.Append("  hostIdList: ").Append(HostIdList).Append("\n");
            sb.Append("  hostGroupTag: ").Append(HostGroupTag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateHostGroupRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateHostGroupRequestBody input)
        {
            if (input == null) return false;
            if (this.HostGroupName != input.HostGroupName || (this.HostGroupName != null && !this.HostGroupName.Equals(input.HostGroupName))) return false;
            if (this.HostGroupType != input.HostGroupType) return false;
            if (this.HostIdList != input.HostIdList || (this.HostIdList != null && input.HostIdList != null && !this.HostIdList.SequenceEqual(input.HostIdList))) return false;
            if (this.HostGroupTag != input.HostGroupTag || (this.HostGroupTag != null && input.HostGroupTag != null && !this.HostGroupTag.SequenceEqual(input.HostGroupTag))) return false;

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
                if (this.HostGroupName != null) hashCode = hashCode * 59 + this.HostGroupName.GetHashCode();
                hashCode = hashCode * 59 + this.HostGroupType.GetHashCode();
                if (this.HostIdList != null) hashCode = hashCode * 59 + this.HostIdList.GetHashCode();
                if (this.HostGroupTag != null) hashCode = hashCode * 59 + this.HostGroupTag.GetHashCode();
                return hashCode;
            }
        }
    }
}
