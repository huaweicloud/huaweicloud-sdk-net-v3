using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 备份实例请求体
    /// </summary>
    public class BackupInstanceBody 
    {
        /// <summary>
        /// 备份缓存实例的格式。
        /// </summary>
        /// <value>备份缓存实例的格式。</value>
        [JsonConverter(typeof(EnumClassConverter<BackupFormatEnum>))]
        public class BackupFormatEnum
        {
            /// <summary>
            /// Enum AOF for value: aof
            /// </summary>
            public static readonly BackupFormatEnum AOF = new BackupFormatEnum("aof");

            /// <summary>
            /// Enum RDB for value: rdb
            /// </summary>
            public static readonly BackupFormatEnum RDB = new BackupFormatEnum("rdb");

            private static readonly Dictionary<string, BackupFormatEnum> StaticFields =
            new Dictionary<string, BackupFormatEnum>()
            {
                { "aof", AOF },
                { "rdb", RDB },
            };

            private string _value;

            public BackupFormatEnum()
            {

            }

            public BackupFormatEnum(string value)
            {
                _value = value;
            }

            public static BackupFormatEnum FromValue(string value)
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

                if (this.Equals(obj as BackupFormatEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BackupFormatEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BackupFormatEnum a, BackupFormatEnum b)
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

            public static bool operator !=(BackupFormatEnum a, BackupFormatEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 备份缓存实例的备注信息。
        /// </summary>
        [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
        public string Remark { get; set; }

        /// <summary>
        /// 备份缓存实例的格式。
        /// </summary>
        [JsonProperty("backup_format", NullValueHandling = NullValueHandling.Ignore)]
        public BackupFormatEnum BackupFormat { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupInstanceBody {\n");
            sb.Append("  remark: ").Append(Remark).Append("\n");
            sb.Append("  backupFormat: ").Append(BackupFormat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupInstanceBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupInstanceBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Remark == input.Remark ||
                    (this.Remark != null &&
                    this.Remark.Equals(input.Remark))
                ) && 
                (
                    this.BackupFormat == input.BackupFormat ||
                    (this.BackupFormat != null &&
                    this.BackupFormat.Equals(input.BackupFormat))
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
                if (this.Remark != null)
                    hashCode = hashCode * 59 + this.Remark.GetHashCode();
                if (this.BackupFormat != null)
                    hashCode = hashCode * 59 + this.BackupFormat.GetHashCode();
                return hashCode;
            }
        }
    }
}
