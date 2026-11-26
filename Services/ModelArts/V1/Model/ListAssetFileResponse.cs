using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAssetFileResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：列举的对象内容。
        /// </summary>
        [JsonProperty("contents", NullValueHandling = NullValueHandling.Ignore)]
        public List<Content> Contents { get; set; }

        /// <summary>
        /// **参数解释**：表明本次返回的结果列表是否被截断。“true”表示本次没有返回全部结果；“false”表示本次已经返回了全部结果。 **取值范围**：true,false。
        /// </summary>
        [JsonProperty("is_truncated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// **参数解释**：列举桶内对象列表时，指定一个标识符，作为列举时的起始位置，从该标识符以后按对象名的字典顺序返回对象列表。 **取值范围**：长度大于0且不超过1024的字符串。
        /// </summary>
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// **参数解释**：如果本次没有返回全部结果，响应请求中将包含此字段，用于标明本次请求列举到的最后一个对象。后续请求可以指定Marker等于该值来列举剩余的对象。 **取值范围**：长度大于0且不超过1024的字符串。
        /// </summary>
        [JsonProperty("next_marker", NullValueHandling = NullValueHandling.Ignore)]
        public string NextMarker { get; set; }

        /// <summary>
        /// **参数解释**：列举对象的最大数目，返回的对象列表将是按照字典顺序的最多前max_keys个对象。 **取值范围**：1-1000。
        /// </summary>
        [JsonProperty("max_keys", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxKeys { get; set; }

        /// <summary>
        /// **参数解释**：本次请求的桶名。 **约束限制**：桶的名字需全局唯一，不能与已有的任何桶名称重复，包括其他用户创建的桶。   桶命名规则如下：   - 3～63个字符，数字或字母开头，支持小写字母、数字、“-”、“.”。   - 禁止使用IP地址。   - 禁止以“-”或“.”开头及结尾。   - 禁止两个“.”相邻（如：“my..bucket”）。   - 禁止“.”和“-”相邻（如：“my-.bucket”和“my.-bucket”）。   - 同一用户在同一个区域多次创建同名桶不会报错，创建的桶属性以第一次请求为准。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketName { get; set; }

        /// <summary>
        /// **参数解释**：列举桶内对象列表时，指定一个前缀，限定返回的对象名必须带有prefix前缀。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string Prefix { get; set; }

        /// <summary>
        /// **参数解释**：列举桶内对象列表时，指定前缀列表，限定返回的对象名必须带有prefix前缀。
        /// </summary>
        [JsonProperty("common_prefixes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CommonPrefixes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAssetFileResponse {\n");
            sb.Append("  contents: ").Append(Contents).Append("\n");
            sb.Append("  isTruncated: ").Append(IsTruncated).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  nextMarker: ").Append(NextMarker).Append("\n");
            sb.Append("  maxKeys: ").Append(MaxKeys).Append("\n");
            sb.Append("  bucketName: ").Append(BucketName).Append("\n");
            sb.Append("  prefix: ").Append(Prefix).Append("\n");
            sb.Append("  commonPrefixes: ").Append(CommonPrefixes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAssetFileResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAssetFileResponse input)
        {
            if (input == null) return false;
            if (this.Contents != input.Contents || (this.Contents != null && input.Contents != null && !this.Contents.SequenceEqual(input.Contents))) return false;
            if (this.IsTruncated != input.IsTruncated || (this.IsTruncated != null && !this.IsTruncated.Equals(input.IsTruncated))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.NextMarker != input.NextMarker || (this.NextMarker != null && !this.NextMarker.Equals(input.NextMarker))) return false;
            if (this.MaxKeys != input.MaxKeys || (this.MaxKeys != null && !this.MaxKeys.Equals(input.MaxKeys))) return false;
            if (this.BucketName != input.BucketName || (this.BucketName != null && !this.BucketName.Equals(input.BucketName))) return false;
            if (this.Prefix != input.Prefix || (this.Prefix != null && !this.Prefix.Equals(input.Prefix))) return false;
            if (this.CommonPrefixes != input.CommonPrefixes || (this.CommonPrefixes != null && input.CommonPrefixes != null && !this.CommonPrefixes.SequenceEqual(input.CommonPrefixes))) return false;

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
                if (this.Contents != null) hashCode = hashCode * 59 + this.Contents.GetHashCode();
                if (this.IsTruncated != null) hashCode = hashCode * 59 + this.IsTruncated.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.NextMarker != null) hashCode = hashCode * 59 + this.NextMarker.GetHashCode();
                if (this.MaxKeys != null) hashCode = hashCode * 59 + this.MaxKeys.GetHashCode();
                if (this.BucketName != null) hashCode = hashCode * 59 + this.BucketName.GetHashCode();
                if (this.Prefix != null) hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                if (this.CommonPrefixes != null) hashCode = hashCode * 59 + this.CommonPrefixes.GetHashCode();
                return hashCode;
            }
        }
    }
}
