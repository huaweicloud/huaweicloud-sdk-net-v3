using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 备份文件信息。
    /// </summary>
    public class BackupInfo 
    {
        /// <summary>
        /// 备份文件来源：（全部大写） - OBS：存放在OBS中的备份文件。 - RDS：RDS实例的备份文件。
        /// </summary>
        /// <value>备份文件来源：（全部大写） - OBS：存放在OBS中的备份文件。 - RDS：RDS实例的备份文件。</value>
        [JsonConverter(typeof(EnumClassConverter<FileSourceEnum>))]
        public class FileSourceEnum
        {
            /// <summary>
            /// Enum OBS for value: OBS
            /// </summary>
            public static readonly FileSourceEnum OBS = new FileSourceEnum("OBS");

            /// <summary>
            /// Enum RDS for value: RDS
            /// </summary>
            public static readonly FileSourceEnum RDS = new FileSourceEnum("RDS");

            private static readonly Dictionary<string, FileSourceEnum> StaticFields =
            new Dictionary<string, FileSourceEnum>()
            {
                { "OBS", OBS },
                { "RDS", RDS },
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
        /// 备份文件来源：（全部大写） - OBS：存放在OBS中的备份文件。 - RDS：RDS实例的备份文件。
        /// </summary>
        [JsonProperty("file_source", NullValueHandling = NullValueHandling.Ignore)]
        public FileSourceEnum FileSource { get; set; }
        /// <summary>
        /// OBS桶名称，使用OBS桶备份文件恢复时必填。 约束：长度范围为3～63个字符，仅支持小写字母、数字、中划线（-）、点（.），且只能以字母或数字开头和结尾，禁止使用IP地址。 如果选择从OBS桶获取备份文件必填，参考登录[客户端登录](https://support.huaweicloud.com/clientogw-obs/zh-cn_topic_0045829058.html)OBS Browser客户端，首页为OBS桶列表，可以获取到备份文件所在桶的名称。
        /// </summary>
        [JsonProperty("bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketName { get; set; }

        /// <summary>
        /// 备份文件信息列表。
        /// </summary>
        [JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
        public List<BackupFileInfo> Files { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupInfo {\n");
            sb.Append("  fileSource: ").Append(FileSource).Append("\n");
            sb.Append("  bucketName: ").Append(BucketName).Append("\n");
            sb.Append("  files: ").Append(Files).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileSource == input.FileSource ||
                    (this.FileSource != null &&
                    this.FileSource.Equals(input.FileSource))
                ) && 
                (
                    this.BucketName == input.BucketName ||
                    (this.BucketName != null &&
                    this.BucketName.Equals(input.BucketName))
                ) && 
                (
                    this.Files == input.Files ||
                    this.Files != null &&
                    input.Files != null &&
                    this.Files.SequenceEqual(input.Files)
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
                if (this.FileSource != null)
                    hashCode = hashCode * 59 + this.FileSource.GetHashCode();
                if (this.BucketName != null)
                    hashCode = hashCode * 59 + this.BucketName.GetHashCode();
                if (this.Files != null)
                    hashCode = hashCode * 59 + this.Files.GetHashCode();
                return hashCode;
            }
        }
    }
}
