using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 桶名称
    /// </summary>
    public class BucketNameReq 
    {

        /// <summary>
        /// 桶名称,名称需满足如下规则: 3～63个字符，数字或字母开头，支持小写字母、数字、“-”、“.”。 禁止使用IP地址。 禁止以“-”或“.”开头及结尾。 禁止两个“.”相邻（如：“my..bucket”）。 禁止“.”和“-”相邻（如：“my-.bucket”和“my.-bucket”）
        /// </summary>
        [JsonProperty("bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BucketNameReq {\n");
            sb.Append("  bucketName: ").Append(BucketName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BucketNameReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BucketNameReq input)
        {
            if (input == null) return false;
            if (this.BucketName != input.BucketName || (this.BucketName != null && !this.BucketName.Equals(input.BucketName))) return false;

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
                if (this.BucketName != null) hashCode = hashCode * 59 + this.BucketName.GetHashCode();
                return hashCode;
            }
        }
    }
}
