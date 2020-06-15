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

            public static readonly Dictionary<string, FileSourceEnum> StaticFields =
            new Dictionary<string, FileSourceEnum>()
            {
                {"self_build_obs", SELF_BUILD_OBS},
            };

            private string Value;

            public FileSourceEnum(string Value)
            {
                this.Value = Value;
            }

            public static FileSourceEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
            {
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupFilesBody {\n");
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
            return this.Equals(input as BackupFilesBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupFilesBody input)
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
