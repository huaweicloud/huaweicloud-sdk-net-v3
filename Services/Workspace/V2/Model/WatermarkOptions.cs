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
    /// 
    /// </summary>
    public class WatermarkOptions 
    {
        /// <summary>
        /// 展示方式。取值为：FIXED：固定位置。RANDOM：随机运动。
        /// </summary>
        /// <value>展示方式。取值为：FIXED：固定位置。RANDOM：随机运动。</value>
        [JsonConverter(typeof(EnumClassConverter<ShowStyleEnum>))]
        public class ShowStyleEnum
        {
            /// <summary>
            /// Enum FIXED for value: FIXED
            /// </summary>
            public static readonly ShowStyleEnum FIXED = new ShowStyleEnum("FIXED");

            /// <summary>
            /// Enum RANDOM for value: RANDOM
            /// </summary>
            public static readonly ShowStyleEnum RANDOM = new ShowStyleEnum("RANDOM");

            private static readonly Dictionary<string, ShowStyleEnum> StaticFields =
            new Dictionary<string, ShowStyleEnum>()
            {
                { "FIXED", FIXED },
                { "RANDOM", RANDOM },
            };

            private string _value;

            public ShowStyleEnum()
            {

            }

            public ShowStyleEnum(string value)
            {
                _value = value;
            }

            public static ShowStyleEnum FromValue(string value)
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

                if (this.Equals(obj as ShowStyleEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ShowStyleEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ShowStyleEnum a, ShowStyleEnum b)
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

            public static bool operator !=(ShowStyleEnum a, ShowStyleEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 展示方式。取值为：FIXED：固定位置。RANDOM：随机运动。
        /// </summary>
        [JsonProperty("show_style", NullValueHandling = NullValueHandling.Ignore)]
        public ShowStyleEnum ShowStyle { get; set; }
        /// <summary>
        /// 颜色。格式：RRGGBB。默认：2a2a2a。
        /// </summary>
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        /// <summary>
        /// 字体大小。取值范围为[1-200]。默认：30。
        /// </summary>
        [JsonProperty("font_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? FontSize { get; set; }

        /// <summary>
        /// 不透明度（%）。取值范围为[0-100]。默认：\&quot;12.5\&quot;。
        /// </summary>
        [JsonProperty("opacity_setting", NullValueHandling = NullValueHandling.Ignore)]
        public string OpacitySetting { get; set; }

        /// <summary>
        /// 条目数量。取值范围为[1-30]。默认：1。
        /// </summary>
        [JsonProperty("content_item_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ContentItemCount { get; set; }

        /// <summary>
        /// 水印内容显示格式。
        /// </summary>
        [JsonProperty("display_format", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayFormat { get; set; }

        /// <summary>
        /// 倾斜度。取值范围为[-90-90]。默认：-45。
        /// </summary>
        [JsonProperty("lean", NullValueHandling = NullValueHandling.Ignore)]
        public int? Lean { get; set; }

        /// <summary>
        /// 自定义内容。内容不得带有类似&#39;&gt;&#39;的特殊字符。
        /// </summary>
        [JsonProperty("content_customized", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentCustomized { get; set; }

        /// <summary>
        /// 内容颜色。
        /// </summary>
        [JsonProperty("content_color", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentColor { get; set; }

        /// <summary>
        /// 安全优先开关。
        /// </summary>
        [JsonProperty("watermark_security_access", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WatermarkSecurityAccess { get; set; }

        /// <summary>
        /// 用户扩展信息开关。false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("user_extend_info_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserExtendInfoSwitch { get; set; }

        /// <summary>
        /// 用户扩展信息。
        /// </summary>
        [JsonProperty("user_extend_info", NullValueHandling = NullValueHandling.Ignore)]
        public string UserExtendInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WatermarkOptions {\n");
            sb.Append("  showStyle: ").Append(ShowStyle).Append("\n");
            sb.Append("  color: ").Append(Color).Append("\n");
            sb.Append("  fontSize: ").Append(FontSize).Append("\n");
            sb.Append("  opacitySetting: ").Append(OpacitySetting).Append("\n");
            sb.Append("  contentItemCount: ").Append(ContentItemCount).Append("\n");
            sb.Append("  displayFormat: ").Append(DisplayFormat).Append("\n");
            sb.Append("  lean: ").Append(Lean).Append("\n");
            sb.Append("  contentCustomized: ").Append(ContentCustomized).Append("\n");
            sb.Append("  contentColor: ").Append(ContentColor).Append("\n");
            sb.Append("  watermarkSecurityAccess: ").Append(WatermarkSecurityAccess).Append("\n");
            sb.Append("  userExtendInfoSwitch: ").Append(UserExtendInfoSwitch).Append("\n");
            sb.Append("  userExtendInfo: ").Append(UserExtendInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WatermarkOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WatermarkOptions input)
        {
            if (input == null) return false;
            if (this.ShowStyle != input.ShowStyle) return false;
            if (this.Color != input.Color || (this.Color != null && !this.Color.Equals(input.Color))) return false;
            if (this.FontSize != input.FontSize || (this.FontSize != null && !this.FontSize.Equals(input.FontSize))) return false;
            if (this.OpacitySetting != input.OpacitySetting || (this.OpacitySetting != null && !this.OpacitySetting.Equals(input.OpacitySetting))) return false;
            if (this.ContentItemCount != input.ContentItemCount || (this.ContentItemCount != null && !this.ContentItemCount.Equals(input.ContentItemCount))) return false;
            if (this.DisplayFormat != input.DisplayFormat || (this.DisplayFormat != null && !this.DisplayFormat.Equals(input.DisplayFormat))) return false;
            if (this.Lean != input.Lean || (this.Lean != null && !this.Lean.Equals(input.Lean))) return false;
            if (this.ContentCustomized != input.ContentCustomized || (this.ContentCustomized != null && !this.ContentCustomized.Equals(input.ContentCustomized))) return false;
            if (this.ContentColor != input.ContentColor || (this.ContentColor != null && !this.ContentColor.Equals(input.ContentColor))) return false;
            if (this.WatermarkSecurityAccess != input.WatermarkSecurityAccess || (this.WatermarkSecurityAccess != null && !this.WatermarkSecurityAccess.Equals(input.WatermarkSecurityAccess))) return false;
            if (this.UserExtendInfoSwitch != input.UserExtendInfoSwitch || (this.UserExtendInfoSwitch != null && !this.UserExtendInfoSwitch.Equals(input.UserExtendInfoSwitch))) return false;
            if (this.UserExtendInfo != input.UserExtendInfo || (this.UserExtendInfo != null && !this.UserExtendInfo.Equals(input.UserExtendInfo))) return false;

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
                hashCode = hashCode * 59 + this.ShowStyle.GetHashCode();
                if (this.Color != null) hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.FontSize != null) hashCode = hashCode * 59 + this.FontSize.GetHashCode();
                if (this.OpacitySetting != null) hashCode = hashCode * 59 + this.OpacitySetting.GetHashCode();
                if (this.ContentItemCount != null) hashCode = hashCode * 59 + this.ContentItemCount.GetHashCode();
                if (this.DisplayFormat != null) hashCode = hashCode * 59 + this.DisplayFormat.GetHashCode();
                if (this.Lean != null) hashCode = hashCode * 59 + this.Lean.GetHashCode();
                if (this.ContentCustomized != null) hashCode = hashCode * 59 + this.ContentCustomized.GetHashCode();
                if (this.ContentColor != null) hashCode = hashCode * 59 + this.ContentColor.GetHashCode();
                if (this.WatermarkSecurityAccess != null) hashCode = hashCode * 59 + this.WatermarkSecurityAccess.GetHashCode();
                if (this.UserExtendInfoSwitch != null) hashCode = hashCode * 59 + this.UserExtendInfoSwitch.GetHashCode();
                if (this.UserExtendInfo != null) hashCode = hashCode * 59 + this.UserExtendInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
