using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// OBS桶存储。
    /// </summary>
    public class BucketStore 
    {

        /// <summary>
        /// 桶名称固定格式:wks-appcenter-{project_id}; 需先调用桶授权接口进行授权。
        /// </summary>
        [JsonProperty("bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketName { get; set; }

        /// <summary>
        /// OBS对象路径。 注: bucket_file_path是对象在obs中的完整路径,不能以/开头。 例如桶存在如下目录结构的数据。   Bucket:     ├─dir1     | ├─object1.txt     | └─object2.txt     └─object3.txt Object1的路径: dir1/object1.txt Object2的路径: dir1/object2.txt Object3的路径: object3.txt
        /// </summary>
        [JsonProperty("bucket_file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketFilePath { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BucketStore {\n");
            sb.Append("  bucketName: ").Append(BucketName).Append("\n");
            sb.Append("  bucketFilePath: ").Append(BucketFilePath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BucketStore);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BucketStore input)
        {
            if (input == null) return false;
            if (this.BucketName != input.BucketName || (this.BucketName != null && !this.BucketName.Equals(input.BucketName))) return false;
            if (this.BucketFilePath != input.BucketFilePath || (this.BucketFilePath != null && !this.BucketFilePath.Equals(input.BucketFilePath))) return false;

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
                if (this.BucketFilePath != null) hashCode = hashCode * 59 + this.BucketFilePath.GetHashCode();
                return hashCode;
            }
        }
    }
}
