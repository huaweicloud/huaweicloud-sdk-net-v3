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
    /// 备份文件列表的结构体
    /// </summary>
    public class BackupFilesBody 
    {
        /// <summary>
        /// 数据来源，当前仅支持OBS桶方式，取值为：self_build_obs。
        /// </summary>
        /// <value>数据来源，当前仅支持OBS桶方式，取值为：self_build_obs。</value>
        [JsonConverter(typeof(EnumClassConverter<FileSourceEnum>))]
        public class FileSourceEnum
        {
            /// <summary>
            /// Enum SELF_BUILD_OBS for value: self_build_obs
            /// </summary>
            public static readonly FileSourceEnum SELF_BUILD_OBS = new FileSourceEnum("self_build_obs");

            /// <summary>
            /// Enum BACKUP_RECORD for value: backup_record
            /// </summary>
            public static readonly FileSourceEnum BACKUP_RECORD = new FileSourceEnum("backup_record");

            private static readonly Dictionary<string, FileSourceEnum> StaticFields =
            new Dictionary<string, FileSourceEnum>()
            {
                { "self_build_obs", SELF_BUILD_OBS },
                { "backup_record", BACKUP_RECORD },
            };

            private string _value;

            public FileSourceEnum()
            {

            }

            public FileSourceEnum(string value)
            {
                _value = value;
            }

            public static FileSourceEnum FromValue(string value)
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

                if (this.Equals(obj as FileSourceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FileSourceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FileSourceEnum a, FileSourceEnum b)
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

            public static bool operator !=(FileSourceEnum a, FileSourceEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 数据来源，当前仅支持OBS桶方式，取值为：self_build_obs。
        /// </summary>
        [JsonProperty("file_source", NullValueHandling = NullValueHandling.Ignore)]
        public FileSourceEnum FileSource { get; set; }
        /// <summary>
        /// OBS桶名。
        /// </summary>
        [JsonProperty("bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketName { get; set; }

        /// <summary>
        /// 导入的备份文件文件列表。
        /// </summary>
        [JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
        public List<Files> Files { get; set; }

        /// <summary>
        /// 备份记录ID，数据来源为备份记录时必须填写
        /// </summary>
        [JsonProperty("backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupFilesBody {\n");
            sb.Append("  fileSource: ").Append(FileSource).Append("\n");
            sb.Append("  bucketName: ").Append(BucketName).Append("\n");
            sb.Append("  files: ").Append(Files).Append("\n");
            sb.Append("  backupId: ").Append(BackupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupFilesBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupFilesBody input)
        {
            if (input == null) return false;
            if (this.FileSource != input.FileSource) return false;
            if (this.BucketName != input.BucketName || (this.BucketName != null && !this.BucketName.Equals(input.BucketName))) return false;
            if (this.Files != input.Files || (this.Files != null && input.Files != null && !this.Files.SequenceEqual(input.Files))) return false;
            if (this.BackupId != input.BackupId || (this.BackupId != null && !this.BackupId.Equals(input.BackupId))) return false;

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
                hashCode = hashCode * 59 + this.FileSource.GetHashCode();
                if (this.BucketName != null) hashCode = hashCode * 59 + this.BucketName.GetHashCode();
                if (this.Files != null) hashCode = hashCode * 59 + this.Files.GetHashCode();
                if (this.BackupId != null) hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                return hashCode;
            }
        }
    }
}
