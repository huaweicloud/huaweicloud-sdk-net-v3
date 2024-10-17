using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V2.Model
{
    /// <summary>
    /// app详细信息
    /// </summary>
    public class App 
    {
        /// <summary>
        /// RTC覆盖范围。  取值如下：    - DOMESTIC：国内范围。   - OVERSEA：海外范围。   - GLOBAL：全球范围。 
        /// </summary>
        /// <value>RTC覆盖范围。  取值如下：    - DOMESTIC：国内范围。   - OVERSEA：海外范围。   - GLOBAL：全球范围。 </value>
        [JsonConverter(typeof(EnumClassConverter<ScopeEnum>))]
        public class ScopeEnum
        {
            /// <summary>
            /// Enum DOMESTIC for value: DOMESTIC
            /// </summary>
            public static readonly ScopeEnum DOMESTIC = new ScopeEnum("DOMESTIC");

            /// <summary>
            /// Enum OVERSEA for value: OVERSEA
            /// </summary>
            public static readonly ScopeEnum OVERSEA = new ScopeEnum("OVERSEA");

            /// <summary>
            /// Enum GLOBAL for value: GLOBAL
            /// </summary>
            public static readonly ScopeEnum GLOBAL = new ScopeEnum("GLOBAL");

            private static readonly Dictionary<string, ScopeEnum> StaticFields =
            new Dictionary<string, ScopeEnum>()
            {
                { "DOMESTIC", DOMESTIC },
                { "OVERSEA", OVERSEA },
                { "GLOBAL", GLOBAL },
            };

            private string _value;

            public ScopeEnum()
            {

            }

            public ScopeEnum(string value)
            {
                _value = value;
            }

            public static ScopeEnum FromValue(string value)
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

                if (this.Equals(obj as ScopeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ScopeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ScopeEnum a, ScopeEnum b)
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

            public static bool operator !=(ScopeEnum a, ScopeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// app名称
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public AppState State { get; set; }

        /// <summary>
        /// RTC覆盖范围。  取值如下：    - DOMESTIC：国内范围。   - OVERSEA：海外范围。   - GLOBAL：全球范围。 
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public ScopeEnum Scope { get; set; }
        /// <summary>
        /// 账号名
        /// </summary>
        [JsonProperty("tenant_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantName { get; set; }

        /// <summary>
        /// 域名，App对应域名
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 创建时间，形如“2006-01-02T15:04:05.075Z”，时区为：UTC
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("authentication", NullValueHandling = NullValueHandling.Ignore)]
        public AppAuth Authentication { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("callbacks", NullValueHandling = NullValueHandling.Ignore)]
        public AppCallbacks Callbacks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("auto_record_mode", NullValueHandling = NullValueHandling.Ignore)]
        public AppAutoRecordMode AutoRecordMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class App {\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("  tenantName: ").Append(TenantName).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  authentication: ").Append(Authentication).Append("\n");
            sb.Append("  callbacks: ").Append(Callbacks).Append("\n");
            sb.Append("  autoRecordMode: ").Append(AutoRecordMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as App);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(App input)
        {
            if (input == null) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.Scope != input.Scope) return false;
            if (this.TenantName != input.TenantName || (this.TenantName != null && !this.TenantName.Equals(input.TenantName))) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.Authentication != input.Authentication || (this.Authentication != null && !this.Authentication.Equals(input.Authentication))) return false;
            if (this.Callbacks != input.Callbacks || (this.Callbacks != null && !this.Callbacks.Equals(input.Callbacks))) return false;
            if (this.AutoRecordMode != input.AutoRecordMode || (this.AutoRecordMode != null && !this.AutoRecordMode.Equals(input.AutoRecordMode))) return false;

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
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.TenantName != null) hashCode = hashCode * 59 + this.TenantName.GetHashCode();
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Authentication != null) hashCode = hashCode * 59 + this.Authentication.GetHashCode();
                if (this.Callbacks != null) hashCode = hashCode * 59 + this.Callbacks.GetHashCode();
                if (this.AutoRecordMode != null) hashCode = hashCode * 59 + this.AutoRecordMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
