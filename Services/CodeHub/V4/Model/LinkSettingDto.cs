using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// **参数解释：** 可集成系统Link服务设置信息。
    /// </summary>
    public class LinkSettingDto 
    {
        /// <summary>
        /// **参数解释：** Link服务的对接鉴权类型，ak_sk代表使用ak和sk来鉴权。
        /// </summary>
        /// <value>**参数解释：** Link服务的对接鉴权类型，ak_sk代表使用ak和sk来鉴权。</value>
        [JsonConverter(typeof(EnumClassConverter<AppAuthTypeEnum>))]
        public class AppAuthTypeEnum
        {
            /// <summary>
            /// Enum AK_SK for value: ak_sk
            /// </summary>
            public static readonly AppAuthTypeEnum AK_SK = new AppAuthTypeEnum("ak_sk");

            private static readonly Dictionary<string, AppAuthTypeEnum> StaticFields =
            new Dictionary<string, AppAuthTypeEnum>()
            {
                { "ak_sk", AK_SK },
            };

            private string _value;

            public AppAuthTypeEnum()
            {

            }

            public AppAuthTypeEnum(string value)
            {
                _value = value;
            }

            public static AppAuthTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AppAuthTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AppAuthTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AppAuthTypeEnum a, AppAuthTypeEnum b)
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

            public static bool operator !=(AppAuthTypeEnum a, AppAuthTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 是否开启集成Link服务 **取值范围：** true：开启集成Link服务，false：未开启集成Link服务。
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        /// <summary>
        /// **参数解释：** Link服务的对接地址。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// **参数解释：** Link服务的对接鉴权类型，ak_sk代表使用ak和sk来鉴权。
        /// </summary>
        [JsonProperty("app_auth_type", NullValueHandling = NullValueHandling.Ignore)]
        public AppAuthTypeEnum AppAuthType { get; set; }
        /// <summary>
        /// **参数解释：** Link服务的对接鉴权ak。
        /// </summary>
        [JsonProperty("app_ak", NullValueHandling = NullValueHandling.Ignore)]
        public string AppAk { get; set; }

        /// <summary>
        /// **参数解释：** Link服务的对接鉴权sk，作为返回值时若已配置则返回掩码，掩码格式为************。
        /// </summary>
        [JsonProperty("app_sk", NullValueHandling = NullValueHandling.Ignore)]
        public string AppSk { get; set; }

        /// <summary>
        /// **参数解释：** 可关联类型列表，逗号分隔。
        /// </summary>
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public string Categories { get; set; }

        /// <summary>
        /// **参数解释：** 排除状态列表，逗号分隔。
        /// </summary>
        [JsonProperty("exclude_statuses", NullValueHandling = NullValueHandling.Ignore)]
        public string ExcludeStatuses { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinkSettingDto {\n");
            sb.Append("  active: ").Append(Active).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  appAuthType: ").Append(AppAuthType).Append("\n");
            sb.Append("  appAk: ").Append(AppAk).Append("\n");
            sb.Append("  appSk: ").Append(AppSk).Append("\n");
            sb.Append("  categories: ").Append(Categories).Append("\n");
            sb.Append("  excludeStatuses: ").Append(ExcludeStatuses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LinkSettingDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LinkSettingDto input)
        {
            if (input == null) return false;
            if (this.Active != input.Active || (this.Active != null && !this.Active.Equals(input.Active))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.AppAuthType != input.AppAuthType) return false;
            if (this.AppAk != input.AppAk || (this.AppAk != null && !this.AppAk.Equals(input.AppAk))) return false;
            if (this.AppSk != input.AppSk || (this.AppSk != null && !this.AppSk.Equals(input.AppSk))) return false;
            if (this.Categories != input.Categories || (this.Categories != null && !this.Categories.Equals(input.Categories))) return false;
            if (this.ExcludeStatuses != input.ExcludeStatuses || (this.ExcludeStatuses != null && !this.ExcludeStatuses.Equals(input.ExcludeStatuses))) return false;

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
                if (this.Active != null) hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                hashCode = hashCode * 59 + this.AppAuthType.GetHashCode();
                if (this.AppAk != null) hashCode = hashCode * 59 + this.AppAk.GetHashCode();
                if (this.AppSk != null) hashCode = hashCode * 59 + this.AppSk.GetHashCode();
                if (this.Categories != null) hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.ExcludeStatuses != null) hashCode = hashCode * 59 + this.ExcludeStatuses.GetHashCode();
                return hashCode;
            }
        }
    }
}
