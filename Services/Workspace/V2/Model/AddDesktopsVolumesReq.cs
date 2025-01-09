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
    /// 增加磁盘请求。
    /// </summary>
    public class AddDesktopsVolumesReq 
    {
        /// <summary>
        /// 桌面类别  - DESKTOP：普通桌面。 - RENDER_DESKTOP：渲染桌面。
        /// </summary>
        /// <value>桌面类别  - DESKTOP：普通桌面。 - RENDER_DESKTOP：渲染桌面。</value>
        [JsonConverter(typeof(EnumClassConverter<DesktopTypeEnum>))]
        public class DesktopTypeEnum
        {
            /// <summary>
            /// Enum DESKTOP for value: DESKTOP
            /// </summary>
            public static readonly DesktopTypeEnum DESKTOP = new DesktopTypeEnum("DESKTOP");

            /// <summary>
            /// Enum RENDER_DESKTOP for value: RENDER_DESKTOP
            /// </summary>
            public static readonly DesktopTypeEnum RENDER_DESKTOP = new DesktopTypeEnum("RENDER_DESKTOP");

            private static readonly Dictionary<string, DesktopTypeEnum> StaticFields =
            new Dictionary<string, DesktopTypeEnum>()
            {
                { "DESKTOP", DESKTOP },
                { "RENDER_DESKTOP", RENDER_DESKTOP },
            };

            private string _value;

            public DesktopTypeEnum()
            {

            }

            public DesktopTypeEnum(string value)
            {
                _value = value;
            }

            public static DesktopTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DesktopTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DesktopTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DesktopTypeEnum a, DesktopTypeEnum b)
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

            public static bool operator !=(DesktopTypeEnum a, DesktopTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 桌面类别  - DESKTOP：普通桌面。 - RENDER_DESKTOP：渲染桌面。
        /// </summary>
        [JsonProperty("desktop_type", NullValueHandling = NullValueHandling.Ignore)]
        public DesktopTypeEnum DesktopType { get; set; }
        /// <summary>
        /// 新增磁盘参数。
        /// </summary>
        [JsonProperty("desktop_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddDesktopVolumesReq> DesktopVolumes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddDesktopsVolumesReq {\n");
            sb.Append("  desktopType: ").Append(DesktopType).Append("\n");
            sb.Append("  desktopVolumes: ").Append(DesktopVolumes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddDesktopsVolumesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddDesktopsVolumesReq input)
        {
            if (input == null) return false;
            if (this.DesktopType != input.DesktopType) return false;
            if (this.DesktopVolumes != input.DesktopVolumes || (this.DesktopVolumes != null && input.DesktopVolumes != null && !this.DesktopVolumes.SequenceEqual(input.DesktopVolumes))) return false;

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
                hashCode = hashCode * 59 + this.DesktopType.GetHashCode();
                if (this.DesktopVolumes != null) hashCode = hashCode * 59 + this.DesktopVolumes.GetHashCode();
                return hashCode;
            }
        }
    }
}