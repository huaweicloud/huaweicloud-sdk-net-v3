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
    /// 对象的元数据信息。
    /// </summary>
    public class Content 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public Owner Owner { get; set; }

        /// <summary>
        /// **参数解释**：对象的base64编码的128位MD5摘要。ETag是对象内容的唯一标识，可以通过该值识别对象内容是否有变化。比如上传对象时ETag为A，下载对象时ETag为B，则说明对象内容发生了变化。实际的ETag是对象的哈希值。ETag只反映变化的内容，而不是其元数据。上传的对象或拷贝操作创建的对象，通过MD5加密后都有唯一的ETag。 **约束限制**：当对象是服务端加密的对象时，ETag值不是对象的MD5值，而是通过服务端加密计算出的唯一标识。 **取值范围**：长度为32的字符串。
        /// </summary>
        [JsonProperty("etag", NullValueHandling = NullValueHandling.Ignore)]
        public string Etag { get; set; }

        /// <summary>
        /// **参数解释**：对象类型。 **约束限制**：非Normal对象时返回。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**：对象名。对象名是对象在存储桶中的唯一标识。对象名是对象在桶中的完整路径，路径中不包含桶名。 **取值范围**：长度大于0且不超过1024的字符串。
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// **参数解释**：对象最近一次被修改的时间（UTC时间）。 **约束限制**：日期格式为ISO8601的格式。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("last_modified", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModified { get; set; }

        /// <summary>
        /// **参数解释**：对象的字节数。 **取值范围**：0~48.8TB，单位：字节。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }

        /// <summary>
        /// **参数解释**：对象的存储类型。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("storage_class", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageClass { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Content {\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  etag: ").Append(Etag).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  lastModified: ").Append(LastModified).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  storageClass: ").Append(StorageClass).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Content);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Content input)
        {
            if (input == null) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.Etag != input.Etag || (this.Etag != null && !this.Etag.Equals(input.Etag))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.LastModified != input.LastModified || (this.LastModified != null && !this.LastModified.Equals(input.LastModified))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.StorageClass != input.StorageClass || (this.StorageClass != null && !this.StorageClass.Equals(input.StorageClass))) return false;

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
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Etag != null) hashCode = hashCode * 59 + this.Etag.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.LastModified != null) hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.StorageClass != null) hashCode = hashCode * 59 + this.StorageClass.GetHashCode();
                return hashCode;
            }
        }
    }
}
