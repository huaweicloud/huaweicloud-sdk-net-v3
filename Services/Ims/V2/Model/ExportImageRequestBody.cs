using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ims.V2.Model
{
    /// <summary>
    /// 镜像导出请求体
    /// </summary>
    public class ExportImageRequestBody 
    {
        /// <summary>
        /// 文件格式，支持qcow2、vhd、zvhd和vmdk。
        /// </summary>
        /// <value>文件格式，支持qcow2、vhd、zvhd和vmdk。</value>
        [JsonConverter(typeof(EnumClassConverter<FileFormatEnum>))]
        public class FileFormatEnum
        {
            /// <summary>
            /// Enum QCOW2 for value: qcow2
            /// </summary>
            public static readonly FileFormatEnum QCOW2 = new FileFormatEnum("qcow2");

            /// <summary>
            /// Enum VHD for value: vhd
            /// </summary>
            public static readonly FileFormatEnum VHD = new FileFormatEnum("vhd");

            /// <summary>
            /// Enum ZVHD for value: zvhd
            /// </summary>
            public static readonly FileFormatEnum ZVHD = new FileFormatEnum("zvhd");

            /// <summary>
            /// Enum VMDK for value: vmdk
            /// </summary>
            public static readonly FileFormatEnum VMDK = new FileFormatEnum("vmdk");

            private static readonly Dictionary<string, FileFormatEnum> StaticFields =
            new Dictionary<string, FileFormatEnum>()
            {
                { "qcow2", QCOW2 },
                { "vhd", VHD },
                { "zvhd", ZVHD },
                { "vmdk", VMDK },
            };

            private string _value;

            public FileFormatEnum()
            {

            }

            public FileFormatEnum(string value)
            {
                _value = value;
            }

            public static FileFormatEnum FromValue(string value)
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

                if (this.Equals(obj as FileFormatEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FileFormatEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FileFormatEnum a, FileFormatEnum b)
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

            public static bool operator !=(FileFormatEnum a, FileFormatEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 目的文件的URL，格式：&lt;bucket&gt;:&lt;file&gt;。 说明：此处的OBS桶和镜像文件的存储类别必须是OBS标准存储。
        /// </summary>
        [JsonProperty("bucket_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketUrl { get; set; }

        /// <summary>
        /// 文件格式，支持qcow2、vhd、zvhd和vmdk。
        /// </summary>
        [JsonProperty("file_format", NullValueHandling = NullValueHandling.Ignore)]
        public FileFormatEnum FileFormat { get; set; }
        /// <summary>
        /// 是否使用快速导出，取值为true或者false。 说明：若使用快速导出，则无法指定file_format参数。
        /// </summary>
        [JsonProperty("is_quick_export", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsQuickExport { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportImageRequestBody {\n");
            sb.Append("  bucketUrl: ").Append(BucketUrl).Append("\n");
            sb.Append("  fileFormat: ").Append(FileFormat).Append("\n");
            sb.Append("  isQuickExport: ").Append(IsQuickExport).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExportImageRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExportImageRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BucketUrl == input.BucketUrl ||
                    (this.BucketUrl != null &&
                    this.BucketUrl.Equals(input.BucketUrl))
                ) && 
                (
                    this.FileFormat == input.FileFormat ||
                    (this.FileFormat != null &&
                    this.FileFormat.Equals(input.FileFormat))
                ) && 
                (
                    this.IsQuickExport == input.IsQuickExport ||
                    (this.IsQuickExport != null &&
                    this.IsQuickExport.Equals(input.IsQuickExport))
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
                if (this.BucketUrl != null)
                    hashCode = hashCode * 59 + this.BucketUrl.GetHashCode();
                if (this.FileFormat != null)
                    hashCode = hashCode * 59 + this.FileFormat.GetHashCode();
                if (this.IsQuickExport != null)
                    hashCode = hashCode * 59 + this.IsQuickExport.GetHashCode();
                return hashCode;
            }
        }
    }
}
