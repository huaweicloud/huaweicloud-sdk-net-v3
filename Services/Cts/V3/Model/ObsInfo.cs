using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cts.V3.Model
{
    /// <summary>
    /// 转储桶信息。
    /// </summary>
    public class ObsInfo 
    {
        /// <summary>
        /// 压缩类型。包括不压缩（json），压缩（gzip）两种状态。默认为gzip格式。
        /// </summary>
        /// <value>压缩类型。包括不压缩（json），压缩（gzip）两种状态。默认为gzip格式。</value>
        [JsonConverter(typeof(EnumClassConverter<CompressTypeEnum>))]
        public class CompressTypeEnum
        {
            /// <summary>
            /// Enum GZIP for value: gzip
            /// </summary>
            public static readonly CompressTypeEnum GZIP = new CompressTypeEnum("gzip");

            /// <summary>
            /// Enum JSON for value: json
            /// </summary>
            public static readonly CompressTypeEnum JSON = new CompressTypeEnum("json");

            private static readonly Dictionary<string, CompressTypeEnum> StaticFields =
            new Dictionary<string, CompressTypeEnum>()
            {
                { "gzip", GZIP },
                { "json", JSON },
            };

            private string _value;

            public CompressTypeEnum()
            {

            }

            public CompressTypeEnum(string value)
            {
                _value = value;
            }

            public static CompressTypeEnum FromValue(string value)
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

                if (this.Equals(obj as CompressTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CompressTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CompressTypeEnum a, CompressTypeEnum b)
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

            public static bool operator !=(CompressTypeEnum a, CompressTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 标识OBS桶名称。由数字或字母开头，支持小写字母、数字、“-”、“.”，长度为3～63个字符。
        /// </summary>
        [JsonProperty("bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketName { get; set; }

        /// <summary>
        /// 标识需要存储于OBS的日志文件前缀，0-9，a-z，A-Z，&#39;-&#39;，&#39;.&#39;，&#39;_&#39;长度为0～64字符。
        /// </summary>
        [JsonProperty("file_prefix_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePrefixName { get; set; }

        /// <summary>
        /// 标识配置桶是否由追踪器自动创建。
        /// </summary>
        [JsonProperty("is_obs_created", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsObsCreated { get; set; }

        /// <summary>
        /// 标识配置桶是否已经授权给CTS服务账号。
        /// </summary>
        [JsonProperty("is_authorized_bucket", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAuthorizedBucket { get; set; }

        /// <summary>
        /// 标识配置桶内对象存储周期。 当\&quot;tracker_type\&quot;参数值为\&quot;data\&quot;时该参数值有效。
        /// </summary>
        [JsonProperty("bucket_lifecycle", NullValueHandling = NullValueHandling.Ignore)]
        public long? BucketLifecycle { get; set; }

        /// <summary>
        /// 压缩类型。包括不压缩（json），压缩（gzip）两种状态。默认为gzip格式。
        /// </summary>
        [JsonProperty("compress_type", NullValueHandling = NullValueHandling.Ignore)]
        public CompressTypeEnum CompressType { get; set; }
        /// <summary>
        /// 路径按云服务划分，打开后转储文件路径中将增加云服务名。默认为true。
        /// </summary>
        [JsonProperty("is_sort_by_service", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSortByService { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObsInfo {\n");
            sb.Append("  bucketName: ").Append(BucketName).Append("\n");
            sb.Append("  filePrefixName: ").Append(FilePrefixName).Append("\n");
            sb.Append("  isObsCreated: ").Append(IsObsCreated).Append("\n");
            sb.Append("  isAuthorizedBucket: ").Append(IsAuthorizedBucket).Append("\n");
            sb.Append("  bucketLifecycle: ").Append(BucketLifecycle).Append("\n");
            sb.Append("  compressType: ").Append(CompressType).Append("\n");
            sb.Append("  isSortByService: ").Append(IsSortByService).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObsInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObsInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BucketName == input.BucketName ||
                    (this.BucketName != null &&
                    this.BucketName.Equals(input.BucketName))
                ) && 
                (
                    this.FilePrefixName == input.FilePrefixName ||
                    (this.FilePrefixName != null &&
                    this.FilePrefixName.Equals(input.FilePrefixName))
                ) && 
                (
                    this.IsObsCreated == input.IsObsCreated ||
                    (this.IsObsCreated != null &&
                    this.IsObsCreated.Equals(input.IsObsCreated))
                ) && 
                (
                    this.IsAuthorizedBucket == input.IsAuthorizedBucket ||
                    (this.IsAuthorizedBucket != null &&
                    this.IsAuthorizedBucket.Equals(input.IsAuthorizedBucket))
                ) && 
                (
                    this.BucketLifecycle == input.BucketLifecycle ||
                    (this.BucketLifecycle != null &&
                    this.BucketLifecycle.Equals(input.BucketLifecycle))
                ) && 
                (
                    this.CompressType == input.CompressType ||
                    (this.CompressType != null &&
                    this.CompressType.Equals(input.CompressType))
                ) && 
                (
                    this.IsSortByService == input.IsSortByService ||
                    (this.IsSortByService != null &&
                    this.IsSortByService.Equals(input.IsSortByService))
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
                if (this.BucketName != null)
                    hashCode = hashCode * 59 + this.BucketName.GetHashCode();
                if (this.FilePrefixName != null)
                    hashCode = hashCode * 59 + this.FilePrefixName.GetHashCode();
                if (this.IsObsCreated != null)
                    hashCode = hashCode * 59 + this.IsObsCreated.GetHashCode();
                if (this.IsAuthorizedBucket != null)
                    hashCode = hashCode * 59 + this.IsAuthorizedBucket.GetHashCode();
                if (this.BucketLifecycle != null)
                    hashCode = hashCode * 59 + this.BucketLifecycle.GetHashCode();
                if (this.CompressType != null)
                    hashCode = hashCode * 59 + this.CompressType.GetHashCode();
                if (this.IsSortByService != null)
                    hashCode = hashCode * 59 + this.IsSortByService.GetHashCode();
                return hashCode;
            }
        }
    }
}
