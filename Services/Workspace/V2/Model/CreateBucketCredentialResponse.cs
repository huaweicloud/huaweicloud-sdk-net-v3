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
    /// Response Object
    /// </summary>
    public class CreateBucketCredentialResponse : SdkResponse
    {

        /// <summary>
        /// 访问的服务终端节点。
        /// </summary>
        [JsonProperty("server_end_point", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerEndPoint { get; set; }

        /// <summary>
        /// 存放的桶名称。
        /// </summary>
        [JsonProperty("bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketName { get; set; }

        /// <summary>
        /// OBS对象路径。 注: path是对象在obs中的完整路径。 例如桶存在如下目录结构的数据。   Bucket:     ├─dir1     | ├─object1.txt     | └─object2.txt     └─object3.txt Object1的path: dir1/object1.txt Object2的path: dir1/object2.txt Object3的path: object3.txt
        /// </summary>
        [JsonProperty("object_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy", NullValueHandling = NullValueHandling.Ignore)]
        public ObsPolicy Policy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("credential", NullValueHandling = NullValueHandling.Ignore)]
        public ObsCredential Credential { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateBucketCredentialResponse {\n");
            sb.Append("  serverEndPoint: ").Append(ServerEndPoint).Append("\n");
            sb.Append("  bucketName: ").Append(BucketName).Append("\n");
            sb.Append("  objectPath: ").Append(ObjectPath).Append("\n");
            sb.Append("  policy: ").Append(Policy).Append("\n");
            sb.Append("  credential: ").Append(Credential).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateBucketCredentialResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateBucketCredentialResponse input)
        {
            if (input == null) return false;
            if (this.ServerEndPoint != input.ServerEndPoint || (this.ServerEndPoint != null && !this.ServerEndPoint.Equals(input.ServerEndPoint))) return false;
            if (this.BucketName != input.BucketName || (this.BucketName != null && !this.BucketName.Equals(input.BucketName))) return false;
            if (this.ObjectPath != input.ObjectPath || (this.ObjectPath != null && !this.ObjectPath.Equals(input.ObjectPath))) return false;
            if (this.Policy != input.Policy || (this.Policy != null && !this.Policy.Equals(input.Policy))) return false;
            if (this.Credential != input.Credential || (this.Credential != null && !this.Credential.Equals(input.Credential))) return false;

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
                if (this.ServerEndPoint != null) hashCode = hashCode * 59 + this.ServerEndPoint.GetHashCode();
                if (this.BucketName != null) hashCode = hashCode * 59 + this.BucketName.GetHashCode();
                if (this.ObjectPath != null) hashCode = hashCode * 59 + this.ObjectPath.GetHashCode();
                if (this.Policy != null) hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.Credential != null) hashCode = hashCode * 59 + this.Credential.GetHashCode();
                return hashCode;
            }
        }
    }
}
