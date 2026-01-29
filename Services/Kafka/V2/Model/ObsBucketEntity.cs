using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ObsBucketEntity 
    {

        /// <summary>
        /// **参数解释**： 响应头。
        /// </summary>
        [JsonProperty("responseHeaders", NullValueHandling = NullValueHandling.Ignore)]
        public Object ResponseHeaders { get; set; }

        /// <summary>
        /// **参数解释**： 原始响应头。
        /// </summary>
        [JsonProperty("originalHeaders", NullValueHandling = NullValueHandling.Ignore)]
        public Object OriginalHeaders { get; set; }

        /// <summary>
        /// **参数解释**： 状态码。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("statusCode", NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// **参数解释**： 桶名。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("bucketName", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketName { get; set; }

        /// <summary>
        /// **参数解释**： 桶拥有者信息。
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public Object Owner { get; set; }

        /// <summary>
        /// **参数解释**： 桶的创建时间。 **取值范围**： 长度为24的字符串。
        /// </summary>
        [JsonProperty("creationDate", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreationDate { get; set; }

        /// <summary>
        /// **参数解释**： 桶所在的区域。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// **参数解释**： 集群类型。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("clustertype", NullValueHandling = NullValueHandling.Ignore)]
        public string Clustertype { get; set; }

        /// <summary>
        /// **参数解释**： 存储类型。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("storageClass", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageClass { get; set; }

        /// <summary>
        /// **参数解释**： 元数据。
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Object Metadata { get; set; }

        /// <summary>
        /// **参数解释**： 桶ACL策略。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("acl", NullValueHandling = NullValueHandling.Ignore)]
        public string Acl { get; set; }

        /// <summary>
        /// **参数解释**： 桶的存储类型。 **取值范围**： - STANDARD：标准存储。 - WARM：低频访问存储。 - COLD：归档存储。 - DEEP_ARCHIVE：深度归档存储（受限公测）。
        /// </summary>
        [JsonProperty("bucketStorageClass", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketStorageClass { get; set; }

        /// <summary>
        /// **参数解释**： 桶类型。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("bucketType", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketType { get; set; }

        /// <summary>
        /// **参数解释**： 请求ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("requestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObsBucketEntity {\n");
            sb.Append("  responseHeaders: ").Append(ResponseHeaders).Append("\n");
            sb.Append("  originalHeaders: ").Append(OriginalHeaders).Append("\n");
            sb.Append("  statusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  bucketName: ").Append(BucketName).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  creationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  clustertype: ").Append(Clustertype).Append("\n");
            sb.Append("  storageClass: ").Append(StorageClass).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  acl: ").Append(Acl).Append("\n");
            sb.Append("  bucketStorageClass: ").Append(BucketStorageClass).Append("\n");
            sb.Append("  bucketType: ").Append(BucketType).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObsBucketEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObsBucketEntity input)
        {
            if (input == null) return false;
            if (this.ResponseHeaders != input.ResponseHeaders || (this.ResponseHeaders != null && !this.ResponseHeaders.Equals(input.ResponseHeaders))) return false;
            if (this.OriginalHeaders != input.OriginalHeaders || (this.OriginalHeaders != null && !this.OriginalHeaders.Equals(input.OriginalHeaders))) return false;
            if (this.StatusCode != input.StatusCode || (this.StatusCode != null && !this.StatusCode.Equals(input.StatusCode))) return false;
            if (this.BucketName != input.BucketName || (this.BucketName != null && !this.BucketName.Equals(input.BucketName))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.CreationDate != input.CreationDate || (this.CreationDate != null && !this.CreationDate.Equals(input.CreationDate))) return false;
            if (this.Location != input.Location || (this.Location != null && !this.Location.Equals(input.Location))) return false;
            if (this.Clustertype != input.Clustertype || (this.Clustertype != null && !this.Clustertype.Equals(input.Clustertype))) return false;
            if (this.StorageClass != input.StorageClass || (this.StorageClass != null && !this.StorageClass.Equals(input.StorageClass))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && !this.Metadata.Equals(input.Metadata))) return false;
            if (this.Acl != input.Acl || (this.Acl != null && !this.Acl.Equals(input.Acl))) return false;
            if (this.BucketStorageClass != input.BucketStorageClass || (this.BucketStorageClass != null && !this.BucketStorageClass.Equals(input.BucketStorageClass))) return false;
            if (this.BucketType != input.BucketType || (this.BucketType != null && !this.BucketType.Equals(input.BucketType))) return false;
            if (this.RequestId != input.RequestId || (this.RequestId != null && !this.RequestId.Equals(input.RequestId))) return false;

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
                if (this.ResponseHeaders != null) hashCode = hashCode * 59 + this.ResponseHeaders.GetHashCode();
                if (this.OriginalHeaders != null) hashCode = hashCode * 59 + this.OriginalHeaders.GetHashCode();
                if (this.StatusCode != null) hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.BucketName != null) hashCode = hashCode * 59 + this.BucketName.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.CreationDate != null) hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.Location != null) hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Clustertype != null) hashCode = hashCode * 59 + this.Clustertype.GetHashCode();
                if (this.StorageClass != null) hashCode = hashCode * 59 + this.StorageClass.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Acl != null) hashCode = hashCode * 59 + this.Acl.GetHashCode();
                if (this.BucketStorageClass != null) hashCode = hashCode * 59 + this.BucketStorageClass.GetHashCode();
                if (this.BucketType != null) hashCode = hashCode * 59 + this.BucketType.GetHashCode();
                if (this.RequestId != null) hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
