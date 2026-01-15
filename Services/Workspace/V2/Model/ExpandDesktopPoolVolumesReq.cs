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
    /// 扩容桌面池磁盘请求。
    /// </summary>
    public class ExpandDesktopPoolVolumesReq 
    {
        /// <summary>
        /// 处理类型 - ONLY_FOR_EXPAND：仅对新扩容桌面生效 - FOR_EXPAND_AND_IDLE：对新扩容桌面与空闲桌面生效 - FOR_EXPAND_AND_ALL：对新扩容桌面与已有全部桌面生效
        /// </summary>
        /// <value>处理类型 - ONLY_FOR_EXPAND：仅对新扩容桌面生效 - FOR_EXPAND_AND_IDLE：对新扩容桌面与空闲桌面生效 - FOR_EXPAND_AND_ALL：对新扩容桌面与已有全部桌面生效</value>
        [JsonConverter(typeof(EnumClassConverter<HandleTypeEnum>))]
        public class HandleTypeEnum
        {
            /// <summary>
            /// Enum ONLY_FOR_EXPAND for value: ONLY_FOR_EXPAND
            /// </summary>
            public static readonly HandleTypeEnum ONLY_FOR_EXPAND = new HandleTypeEnum("ONLY_FOR_EXPAND");

            /// <summary>
            /// Enum FOR_EXPAND_AND_IDLE for value: FOR_EXPAND_AND_IDLE
            /// </summary>
            public static readonly HandleTypeEnum FOR_EXPAND_AND_IDLE = new HandleTypeEnum("FOR_EXPAND_AND_IDLE");

            /// <summary>
            /// Enum FOR_EXPAND_AND_ALL for value: FOR_EXPAND_AND_ALL
            /// </summary>
            public static readonly HandleTypeEnum FOR_EXPAND_AND_ALL = new HandleTypeEnum("FOR_EXPAND_AND_ALL");

            private static readonly Dictionary<string, HandleTypeEnum> StaticFields =
            new Dictionary<string, HandleTypeEnum>()
            {
                { "ONLY_FOR_EXPAND", ONLY_FOR_EXPAND },
                { "FOR_EXPAND_AND_IDLE", FOR_EXPAND_AND_IDLE },
                { "FOR_EXPAND_AND_ALL", FOR_EXPAND_AND_ALL },
            };

            private string _value;

            public HandleTypeEnum()
            {

            }

            public HandleTypeEnum(string value)
            {
                _value = value;
            }

            public static HandleTypeEnum FromValue(string value)
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

                if (this.Equals(obj as HandleTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HandleTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(HandleTypeEnum a, HandleTypeEnum b)
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

            public static bool operator !=(HandleTypeEnum a, HandleTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 处理类型 - ONLY_FOR_EXPAND：仅对新扩容桌面生效 - FOR_EXPAND_AND_IDLE：对新扩容桌面与空闲桌面生效 - FOR_EXPAND_AND_ALL：对新扩容桌面与已有全部桌面生效
        /// </summary>
        [JsonProperty("handle_type", NullValueHandling = NullValueHandling.Ignore)]
        public HandleTypeEnum HandleType { get; set; }
        /// <summary>
        /// 桌面id
        /// </summary>
        [JsonProperty("desktop_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DesktopIds { get; set; }

        /// <summary>
        /// 扩容的桌面池磁盘列表。
        /// </summary>
        [JsonProperty("volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExpandDesktopPoolVolumesReqVolumes> Volumes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpandDesktopPoolVolumesReq {\n");
            sb.Append("  handleType: ").Append(HandleType).Append("\n");
            sb.Append("  desktopIds: ").Append(DesktopIds).Append("\n");
            sb.Append("  volumes: ").Append(Volumes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExpandDesktopPoolVolumesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExpandDesktopPoolVolumesReq input)
        {
            if (input == null) return false;
            if (this.HandleType != input.HandleType) return false;
            if (this.DesktopIds != input.DesktopIds || (this.DesktopIds != null && input.DesktopIds != null && !this.DesktopIds.SequenceEqual(input.DesktopIds))) return false;
            if (this.Volumes != input.Volumes || (this.Volumes != null && input.Volumes != null && !this.Volumes.SequenceEqual(input.Volumes))) return false;

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
                hashCode = hashCode * 59 + this.HandleType.GetHashCode();
                if (this.DesktopIds != null) hashCode = hashCode * 59 + this.DesktopIds.GetHashCode();
                if (this.Volumes != null) hashCode = hashCode * 59 + this.Volumes.GetHashCode();
                return hashCode;
            }
        }
    }
}
