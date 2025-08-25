using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowClusterAccessKeyListResponseBodyResult 
    {

        /// <summary>
        /// 访问密钥ID
        /// </summary>
        [JsonProperty("access_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// 访问密钥状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 访问密钥所属的应用名称
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 访问密钥AK
        /// </summary>
        [JsonProperty("access_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKey { get; set; }

        /// <summary>
        /// 访问密钥名称
        /// </summary>
        [JsonProperty("key_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyName { get; set; }

        /// <summary>
        /// 应用的创建时间，UNIX时间戳，单位毫秒
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowClusterAccessKeyListResponseBodyResult {\n");
            sb.Append("  accessKeyId: ").Append(AccessKeyId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  accessKey: ").Append(AccessKey).Append("\n");
            sb.Append("  keyName: ").Append(KeyName).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowClusterAccessKeyListResponseBodyResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowClusterAccessKeyListResponseBodyResult input)
        {
            if (input == null) return false;
            if (this.AccessKeyId != input.AccessKeyId || (this.AccessKeyId != null && !this.AccessKeyId.Equals(input.AccessKeyId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.AccessKey != input.AccessKey || (this.AccessKey != null && !this.AccessKey.Equals(input.AccessKey))) return false;
            if (this.KeyName != input.KeyName || (this.KeyName != null && !this.KeyName.Equals(input.KeyName))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;

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
                if (this.AccessKeyId != null) hashCode = hashCode * 59 + this.AccessKeyId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.AccessKey != null) hashCode = hashCode * 59 + this.AccessKey.GetHashCode();
                if (this.KeyName != null) hashCode = hashCode * 59 + this.KeyName.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
