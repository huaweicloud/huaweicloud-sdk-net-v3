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
    /// 接入配置信息。
    /// </summary>
    public class AccessConfigInfo 
    {
        /// <summary>
        /// 备份模式是否开启。 - ON:开启。 - OFF:关闭。
        /// </summary>
        /// <value>备份模式是否开启。 - ON:开启。 - OFF:关闭。</value>
        [JsonConverter(typeof(EnumClassConverter<BackupModeEnum>))]
        public class BackupModeEnum
        {
            /// <summary>
            /// Enum ON for value: ON
            /// </summary>
            public static readonly BackupModeEnum ON = new BackupModeEnum("ON");

            /// <summary>
            /// Enum OFF for value: OFF
            /// </summary>
            public static readonly BackupModeEnum OFF = new BackupModeEnum("OFF");

            private static readonly Dictionary<string, BackupModeEnum> StaticFields =
            new Dictionary<string, BackupModeEnum>()
            {
                { "ON", ON },
                { "OFF", OFF },
            };

            private string _value;

            public BackupModeEnum()
            {

            }

            public BackupModeEnum(string value)
            {
                _value = value;
            }

            public static BackupModeEnum FromValue(string value)
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

                if (this.Equals(obj as BackupModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BackupModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BackupModeEnum a, BackupModeEnum b)
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

            public static bool operator !=(BackupModeEnum a, BackupModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 站点Id。
        /// </summary>
        [JsonProperty("site_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteId { get; set; }

        /// <summary>
        /// 备份模式是否开启。 - ON:开启。 - OFF:关闭。
        /// </summary>
        [JsonProperty("backup_mode", NullValueHandling = NullValueHandling.Ignore)]
        public BackupModeEnum BackupMode { get; set; }
        /// <summary>
        /// 备份信息。
        /// </summary>
        [JsonProperty("backup_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<BackupInfo> BackupInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessConfigInfo {\n");
            sb.Append("  siteId: ").Append(SiteId).Append("\n");
            sb.Append("  backupMode: ").Append(BackupMode).Append("\n");
            sb.Append("  backupInfo: ").Append(BackupInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessConfigInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessConfigInfo input)
        {
            if (input == null) return false;
            if (this.SiteId != input.SiteId || (this.SiteId != null && !this.SiteId.Equals(input.SiteId))) return false;
            if (this.BackupMode != input.BackupMode) return false;
            if (this.BackupInfo != input.BackupInfo || (this.BackupInfo != null && input.BackupInfo != null && !this.BackupInfo.SequenceEqual(input.BackupInfo))) return false;

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
                if (this.SiteId != null) hashCode = hashCode * 59 + this.SiteId.GetHashCode();
                hashCode = hashCode * 59 + this.BackupMode.GetHashCode();
                if (this.BackupInfo != null) hashCode = hashCode * 59 + this.BackupInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
